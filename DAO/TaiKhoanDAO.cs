using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class TaiKhoanDAO
    {
        QuanLyCuaHangTraSuaEntities qltkentity = new QuanLyCuaHangTraSuaEntities();
        Random randMK = new Random();
        public List<TaiKhoanDTO> LayDSTK()
        {
            return qltkentity.TAIKHOANs.Where(x => x.TAIKHOAN_TRANGTHAI == 1).Select(u => new TaiKhoanDTO { tk_manv = u.TAIKHOAN_MANHANVIEN, tk_ngaytao = (DateTime)u.TAIKHOAN_NGAYTAO, tk_maloai = u.TAIKHOAN_MALOAI , trangthai = u.TAIKHOAN_TRANGTHAI.Value , tk_ghichu = u.TAIKHOAN_GHICHU }).OrderBy(u => u.tk_maloai).ToList();
        }

        public bool SuaTK(TaiKhoanDTO tkS)
        {
            TAIKHOAN tk = qltkentity.TAIKHOANs.SingleOrDefault(u => u.TAIKHOAN_MANHANVIEN == tkS.tk_manv);

            if (tk == null)
            {
                return false;
            }
            else
            {
                tk.TAIKHOAN_MANHANVIEN = tkS.tk_manv;
                tk.TAIKHOAN_GHICHU = tkS.tk_ghichu;

                qltkentity.SaveChanges();
                return true;
            }
        }
        
        public bool KTMatKhau(string matkhau)
        {
            int KTMK = qltkentity.TAIKHOANs.Count(x => x.TAIKHOAN_MATKHAU == matkhau.ToString());

            if (KTMK > 0)
                return false;
            return true;
        }
        public bool KTTaiKhoan(string manv)
        {
            int KTTK = qltkentity.TAIKHOANs.Count(x => x.TAIKHOAN_MANHANVIEN == manv.ToString());

            if (KTTK > 0)
                return false;
            return true;
        }
    }
}
