using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        QuanLyCuaHangTraSuaEntities qlnccentity = new QuanLyCuaHangTraSuaEntities();
        Random randMaNCC = new Random();
        string mancc;
        public List<NhaCungCapDTO> LayDSNCC()
        {
            return qlnccentity.NHACUNGCAPs.Where(u => u.NHACUNGCAP_TRANGTHAI == 1).Select(u => new NhaCungCapDTO {ma = u.NHACUNGCAP_MANCC , ten = u.NHACUNGCAP_TEN , diachi = u.NHACUNGCAP_DIACHI , sodienthoai = u.NHACUNGCAP_SDT , mathang = u.NHACUNGCAP_MATHANG , manv = u.MANHANVIEN}).ToList();
        }

        public bool ThemNCC(NhaCungCapDTO nccT,string manv)
        {
            do
            {
                mancc = "NCC" + randMaNCC.Next(99, 999).ToString();
            } while (!KtMaNCC(mancc));
            NHACUNGCAP ncc = new NHACUNGCAP()
            {
                NHACUNGCAP_MANCC = mancc,
                NHACUNGCAP_TEN = nccT.ten,
                NHACUNGCAP_DIACHI = nccT.diachi,
                NHACUNGCAP_MATHANG = nccT.mathang,
                NHACUNGCAP_SDT = nccT.sodienthoai,
                MANHANVIEN = manv,
                NHACUNGCAP_TRANGTHAI = 1
            };

            qlnccentity.NHACUNGCAPs.Add(ncc);
            qlnccentity.SaveChanges();
            return true;
        }

        public bool SuaNCC(NhaCungCapDTO nccS)
        {
            NHACUNGCAP ncc = qlnccentity.NHACUNGCAPs.SingleOrDefault(u => u.NHACUNGCAP_MANCC == nccS.ma);

            if (ncc == null)
            {
                return false;
            }
            else
            {
                ncc.NHACUNGCAP_TEN = nccS.ten;
                ncc.NHACUNGCAP_SDT = nccS.sodienthoai;
                ncc.NHACUNGCAP_MATHANG = nccS.mathang;
                ncc.NHACUNGCAP_DIACHI = nccS.diachi;

                qlnccentity.SaveChanges();
                return true;
            }
        }

        public bool XoaNCC(string mancc)
        {
            NHACUNGCAP nccX = qlnccentity.NHACUNGCAPs.SingleOrDefault(u => u.NHACUNGCAP_MANCC == mancc);
            if (nccX == null)
            {
                return false;
            }
            else
            {
                nccX.NHACUNGCAP_TRANGTHAI = 0;
                qlnccentity.SaveChanges();
                return true;
            }
        }

        public bool KtTenNCC(string tenncc)
        {
            int checkTenNCC = qlnccentity.NHACUNGCAPs.Count(x => x.NHACUNGCAP_TEN == tenncc.ToString());

            if (checkTenNCC > 0)
                return false;
            return true;
        }
        public bool KtMaNCC(string mancc)
        {
            int checkMaNCC = qlnccentity.NHACUNGCAPs.Count(x => x.NHACUNGCAP_MANCC == mancc.ToString());

            if (checkMaNCC > 0)
                return false;
            return true;
        }
    }
}
