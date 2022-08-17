using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO _nvDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNV()
        {
            return _nvDAO.LayDSNV();
        }
        public List<NhanVienDTO> LayDSNVDANGHI()
        {
            return _nvDAO.LayDSNVDANGHI();
        }
        public bool ThemNV(NhanVienDTO nvT , int loai)
        {
            return _nvDAO.ThemNV(nvT , loai);
        }
        public bool SuaNV(NhanVienDTO nvS)
        {
            return _nvDAO.SuaNV(nvS);
        }
        public bool XoaNV(string manv)
        {
            return _nvDAO.XoaNV(manv);
        }
        public bool KTEmail(string Email)
        {
            return _nvDAO.KTEmail(Email);
        }
        public string HoTenNhanVien(string manv)
        {
            return _nvDAO.HoTenNhanVien(manv);
        }
        public string ChucVu(string manv)
        {
            return _nvDAO.ChucVu(manv);
        }

        public List<NhanVienDTO> TimKiem(List<NhanVienDTO> nhanviens, string key)    
        {
            return nhanviens.Where(u =>
                    u.MaNV.ToString().ToLower().Contains(key.ToLower()) ||
                    u.HoVaTenDem.ToLower().Contains(key.ToLower()) ||
                    u.Ten.ToLower().Contains(key.ToLower()) ||
                    u.DiaChi.ToLower().Contains(key.ToLower()) ||
                    u.SoDienThoai.ToLower().Contains(key.ToLower()) ||
                    u.GioiTinh.ToLower().Contains(key.ToLower()) ||
                    u.Email.ToLower().Contains(key.ToLower()) ||
                    u.NgayThangNamSinh.ToString().Contains(key) ||
                    u.LoaiNV.ToLower().Contains(key.ToLower())).ToList();
        }
    }
}
