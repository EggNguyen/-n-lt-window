using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {   HoaDonDAO hddao = new HoaDonDAO();
        public List<HoaDonDTO> LayDSHD()
        {
            return hddao.LayDSHD();
        }
        public List<ChiTietHoaDonDTO> LayDSCTHD(string mahd)
        {
            return hddao.LayDSCTHD(mahd);
        }
        public bool ThemHD(string manv, decimal khachtra, decimal thanhtien, decimal tralai)
        {
            return hddao.ThemHD(manv, khachtra, thanhtien, tralai);
        }

    }
}
