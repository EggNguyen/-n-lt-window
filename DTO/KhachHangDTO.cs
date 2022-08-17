using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string HoTenDemKH { get; set; }
        public string TenKH { get; set; }
        public string SdtKH { get; set; }
        public DateTime NgaySinhKH { get; set; }
        public string DiaChiKH { get; set; }
        public string GioiTinhKH { get; set; }
        public int TrangThaiKH { get; set; }
        public string LoaiKH { get; set; }
    }
}
