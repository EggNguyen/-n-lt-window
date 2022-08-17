using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        QuanLyCuaHangTraSuaEntities cthd = new QuanLyCuaHangTraSuaEntities();
        public List<ChiTietHoaDonDTO> LayDSCTHD(string mahd)
        {
            return cthd.CHITIET_HOADON.Where(u => u.MACTHD == mahd).Select(u => new ChiTietHoaDonDTO { ct_macthd = u.MACTHD, ct_tensp = u.CHITIET_HOADON_TENSP, ct_soluong = u.CHITIET_HOADON_SOLUONG, ct_dongia = u.CHITIET_HOADON_DONGIA }).ToList();
        }
    }
}
