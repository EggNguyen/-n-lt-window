using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string tk_manv { get; set; }
        public string tk_matkhau { get; set; }
        public string tk_maloai { get; set; }
        public DateTime tk_ngaytao { get; set; }
        public int trangthai { get; set; }

        public string tk_ghichu { get; set; }
    }
}
