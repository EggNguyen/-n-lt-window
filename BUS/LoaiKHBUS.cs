using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiKHBUS
    {
        private LoaiKHDAO _loaiKHDAO = new LoaiKHDAO();

        public List<LoaiKHDTO> LayLoaiKH()
        {
            return _loaiKHDAO.LayLoaiKH();
        }
    }
}
