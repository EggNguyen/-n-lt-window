using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO _nccDAO = new NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDSNCC()
        {
            return _nccDAO.LayDSNCC();
        }
        public bool ThemNCC(NhaCungCapDTO nccT , string manv)
        {
            return _nccDAO.ThemNCC(nccT , manv);
        }
        public bool SuaNCC(NhaCungCapDTO nccS)
        {
            return _nccDAO.SuaNCC(nccS);
        }
        public bool XoaNCC(string mancc)
        {
            return _nccDAO.XoaNCC(mancc);
        }
        public bool KtTenNCC(string tenncc)
        {
            return _nccDAO.KtTenNCC(tenncc);
        }
        public List<NhaCungCapDTO> TimKiem(List<NhaCungCapDTO> nccs, string key)
        {
            return nccs.Where(u =>
                    u.ten.ToLower().Contains(key.ToLower()) ||
                    u.ma.ToLower().Contains(key.ToLower()) ||
                    u.sodienthoai.ToString().Contains(key) ||
                    u.diachi.ToLower().Contains(key) ||
                    u.mathang.ToLower().Contains(key) ||
                    u.manv.ToLower().Contains(key)).ToList();
        }
    }
}
