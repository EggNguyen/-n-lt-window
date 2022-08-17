using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAO
{
    public class SanPhamDAO
    {
        QuanLyCuaHangTraSuaEntities qltsentity = new QuanLyCuaHangTraSuaEntities();

        Random randMaSP = new Random();
        string masp;
        public List<SanPhamDTO>LayDSSP()
        {
            return qltsentity.TRASUAs.Where(u => u.TRASUA_TRANGTHAI == 1).Select(u => new SanPhamDTO { TRASUA_MATS = u.TRASUA_MATS , TRASUA_TEN = u.TRASUA_TEN , TRASUA_GIA = u.TRASUA_GIA , TRASUA_NGAYTAO = (DateTime)u.TRASUA_NGAYTAO , TRASUA_MOTA = u.TRASUA_MOTA , TRASUA_TRANGTHAI = u.TRASUA_TRANGTHAI.Value}).ToList();
        }

        public bool ThemSP(SanPhamDTO spT)
        {
            do
            {

                masp = "SP" + randMaSP.Next(999, 9999).ToString();

            } while (!KtMasp(masp));

            TRASUA sp = new TRASUA()
            {
                TRASUA_MATS = masp,
                TRASUA_TEN = spT.TRASUA_TEN,
                TRASUA_GIA = spT.TRASUA_GIA,
                TRASUA_NGAYTAO = DateTime.Now,
                TRASUA_MOTA = spT.TRASUA_MOTA,
                TRASUA_TRANGTHAI = 1
            };

            qltsentity.TRASUAs.Add(sp);
            qltsentity.SaveChanges();
            return true;
        }

        public bool SuaSP(SanPhamDTO spS)
        {
            TRASUA ts = qltsentity.TRASUAs.SingleOrDefault(u => u.TRASUA_MATS == spS.TRASUA_MATS);

            if (ts == null)
            {
                return false;
            }
            else
            {
                ts.TRASUA_TEN = spS.TRASUA_TEN;
                ts.TRASUA_GIA = spS.TRASUA_GIA;
                ts.TRASUA_NGAYTAO = spS.TRASUA_NGAYTAO;
                ts.TRASUA_MOTA = spS.TRASUA_MOTA;

                qltsentity.SaveChanges();
                return true;
            }
        }

        public bool XoaSP(string masp)
        {
            TRASUA tsX = qltsentity.TRASUAs.SingleOrDefault(u => u.TRASUA_MATS == masp);
            if (tsX == null)
            {
                return false;
            }
            else
            {
                tsX.TRASUA_TRANGTHAI = 0;
                qltsentity.SaveChanges();
                return true;
            }
        }

        public bool KtTensp(string tensp)
        {
            string a = tensp.TrimEnd();
            int checkTensp = qltsentity.TRASUAs.Where(x => x.TRASUA_TRANGTHAI == 1).Count(x => x.TRASUA_TEN == a.ToString());
            
            if (checkTensp > 0)
                 return false;
            return true; 
        }

        public bool KtMasp(string masp)
        {
            int checkMasp = qltsentity.TRASUAs.Count(x => x.TRASUA_MATS == masp.ToString());

            if (checkMasp > 0)
                return false;
            return true;
        }
    }
}
