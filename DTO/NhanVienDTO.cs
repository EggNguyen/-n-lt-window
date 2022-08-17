using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoVaTenDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayThangNamSinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public string LoaiNV { get; set; }
    }
}
