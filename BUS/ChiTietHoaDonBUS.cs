using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO cthddao = new ChiTietHoaDonDAO();
        public List<ChiTietHoaDonDTO> LayDSCTHD(string mahd)
        {
            return cthddao.LayDSCTHD(mahd);
        }

    }
}
