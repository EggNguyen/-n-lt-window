using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BanHangBUS
    {
        private BanHangDAO bhdao = new BanHangDAO();
        public int tien(string ten)
        {
            return bhdao.tien(ten);
        }
    }
}
