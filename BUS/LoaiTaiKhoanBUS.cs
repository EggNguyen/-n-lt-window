using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiTaiKhoanBUS
    {
        LoaiTaiKhoanDAO _ltkDAO = new LoaiTaiKhoanDAO();

        public List<LoaiTaiKhoanDTO>LayDSSLTK()
        {
            return _ltkDAO.LayDSSLTK();
        }
    }
}
