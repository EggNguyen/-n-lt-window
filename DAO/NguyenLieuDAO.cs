using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguyenLieuDAO
    {
        QuanLyCuaHangTraSuaEntities qlnlentity = new QuanLyCuaHangTraSuaEntities();
        Random randMaNL = new Random();
        string manl;
        public List<NguyenLieuDTO> LayDSNL()
        {
            return qlnlentity.NGUYENLIEUx.Where(u => u.NGUYENLIEU_TRANGTHAI == 1).Select(u => new NguyenLieuDTO { ma = u.NGUYENLIEU_MANL, ten = u.NGUYENLIEU_TEN, ngaynhap = (DateTime)u.NGUYENLIEU_NGAYNHAP, hansudung = (DateTime)u.NGUYENLIEU_HANSD, soluong = u.NGUYENLIEU_SOLUONGTON.Value, mota = u.NGUYENLIEU_MOTA , tenncc = u.NGUYENLIEU_TENNCC , trangthai = u.NGUYENLIEU_TRANGTHAI.Value }).OrderBy(u => u.hansudung).ToList();
        }
        public bool ThemNL(NguyenLieuDTO nlT)
        {
            do
            {
                manl = "NL" + randMaNL.Next(999, 9999).ToString();
            } while (!KTMaNL(manl));
            NGUYENLIEU nl = new NGUYENLIEU()
            {
               NGUYENLIEU_MANL = manl,
               NGUYENLIEU_HANSD = nlT.hansudung,
               NGUYENLIEU_TENNCC = nlT.tenncc,
               NGUYENLIEU_MOTA = nlT.mota,
               NGUYENLIEU_NGAYNHAP = DateTime.Now,
               NGUYENLIEU_SOLUONGTON = nlT.soluong,
               NGUYENLIEU_TEN = nlT.ten,
               NGUYENLIEU_TRANGTHAI = 1
            };

            qlnlentity.NGUYENLIEUx.Add(nl);
            qlnlentity.SaveChanges();
            return true;
        }
        public bool SuaNL(NguyenLieuDTO nlS)
        {
            NGUYENLIEU nl = qlnlentity.NGUYENLIEUx.SingleOrDefault(u => u.NGUYENLIEU_MANL == nlS.ma);

            if (nl == null)
            {
                return false;
            }
            else
            {
                nl.NGUYENLIEU_TENNCC = nlS.tenncc;
                nl.NGUYENLIEU_HANSD = nlS.hansudung;
                nl.NGUYENLIEU_MOTA = nlS.mota;
                nl.NGUYENLIEU_SOLUONGTON = nlS.soluong;
                nl.NGUYENLIEU_TEN = nlS.ten;

                qlnlentity.SaveChanges();
                return true;
            }
        }
        public bool XoaNL(string manl)
        {
            NGUYENLIEU nlX = qlnlentity.NGUYENLIEUx.SingleOrDefault(u => u.NGUYENLIEU_MANL == manl);
            if (nlX == null)
            {
                return false;
            }
            else
            {
                nlX.NGUYENLIEU_TRANGTHAI = 0;
                qlnlentity.SaveChanges();
                return true;
            }
        }
        public bool KTMaNL(string manl)
        {
            int checkMaNL = qlnlentity.NGUYENLIEUx.Count(x => x.NGUYENLIEU_MANL == manl.ToString());

            if (checkMaNL > 0)
                return false;
            return true;
        }
        public bool KTMaNCC(string mancc)
        {
            int checkMaNCC = qlnlentity.NHACUNGCAPs.Count(x => x.NHACUNGCAP_MANCC == mancc.ToString());

            if (checkMaNCC > 0)
                return false;
            return true;
        }
        public bool KTTenNL(string tennl)
        {
            int checkTennl = qlnlentity.NGUYENLIEUx.Count(x => x.NGUYENLIEU_TEN == tennl.ToString());

            if (checkTennl > 0)
                return false;
            return true;
        }


        //public bool KTTenNLCuaNhaCungCap(string tennlvancc)
        //{
        //    int checkTennlvaNCC = qlnlentity.NHACUNGCAPs.Count(x => x.NHACUNGCAP_MATHANG.Split() == tennlvancc.ToString());

        //    if (checkTennlvaNCC > 0)
        //        return false;
        //    return true;
        //}

    }
}
