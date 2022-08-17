using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO _tkDAO = new TaiKhoanDAO();

        public List<TaiKhoanDTO> LayDSTK()
        {
            return _tkDAO.LayDSTK();
        }
        public bool SuaTK(TaiKhoanDTO tkS)
        {
            return _tkDAO.SuaTK(tkS);
        }
        public bool KTTaiKhoan(string manv)
        {
            return _tkDAO.KTTaiKhoan(manv);
        }
        public List<TaiKhoanDTO> TimMaTK(List<TaiKhoanDTO> taikhoans, string key)
        {
            return taikhoans.Where(u => u.tk_manv.Contains(key)).ToList();
        }
    }
}
