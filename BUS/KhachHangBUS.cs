using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO _khDAO = new KhachHangDAO();

        public List<KhachHangDTO>LayDSKH()
        {
            return _khDAO.LayDSKH();
        }
        public List<KhachHangDTO> LayDSLKH(string loai)
        {
            return _khDAO.LayDSLKH(loai);
        }
        public bool KTSDTKH(string sdt)
        {
            return _khDAO.KTSDTKH(sdt);
        }
        public bool ThemKH(KhachHangDTO khT)
        {
            return _khDAO.ThemKH(khT);
        }

        public bool SuaKH(KhachHangDTO khS)
        {
            return _khDAO.SuaKH(khS);
        }

        public bool XoaKH(string makh)
        {
            return _khDAO.XoaKH(makh);
        }

        public List<KhachHangDTO> TimKiem(List<KhachHangDTO> khTim, string key)
        {
            return khTim.Where(u =>
                    u.MaKH.ToString().ToLower().Contains(key.ToLower()) ||
                    u.HoTenDemKH.ToLower().Contains(key.ToLower()) ||
                    u.TenKH.ToString().Contains(key) ||
                    u.NgaySinhKH.ToString().Contains(key) ||
                    u.DiaChiKH.Contains(key) ||
                    u.GioiTinhKH.Contains(key) ||
                    u.LoaiKH.Contains(key) ||
                    u.SdtKH.ToLower().Contains(key.ToLower())).ToList();
        }
    }
}
