using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO _sanPhamDAO = new SanPhamDAO();

        public List<SanPhamDTO>LayDSSP()
        {
            return _sanPhamDAO.LayDSSP();
        }

        public bool ThemSP(SanPhamDTO spT)
        {
            return _sanPhamDAO.ThemSP(spT);
        }

        public bool SuaSP(SanPhamDTO spS)
        {
            return _sanPhamDAO.SuaSP(spS);
        }

        public bool XoaSP(string mssv)
        {
            return _sanPhamDAO.XoaSP(mssv);
        }

        public List<SanPhamDTO> TimMaSP(List<SanPhamDTO> sanPhams, string key)
        {
            return sanPhams.Where(u => u.TRASUA_MATS.ToLower().Contains(key.ToLower())).ToList();
        }

        public List<SanPhamDTO> TimTenSP(List<SanPhamDTO> sanPhams, string key)
        {
            return sanPhams.Where(u => u.TRASUA_TEN.ToLower().Contains(key.ToLower())).ToList();
        }

        public List<SanPhamDTO> TimGiaSP(List<SanPhamDTO> sanPhams, string key)
        {
            return sanPhams.Where(u => u.TRASUA_GIA.ToString().Contains(key)).ToList();
        }
        public List<SanPhamDTO> TimNgayTao(List<SanPhamDTO> sanPhams, string key)
        {
            return sanPhams.Where(u => u.TRASUA_NGAYTAO.ToString().Contains(key)).ToList();
        }
        public bool KtTensp(string tensp)
        {
            return _sanPhamDAO.KtTensp(tensp);
        }

        public bool ktMasp(string masp)
        {
            return _sanPhamDAO.KtMasp(masp);
        }
        public List<SanPhamDTO> TimKiem(List<SanPhamDTO> sanphams, string key)
        {
            return sanphams.Where(u =>
                    u.TRASUA_MATS.ToString().ToLower().Contains(key.ToLower()) ||
                    u.TRASUA_TEN.ToLower().Contains(key.ToLower()) ||
                    u.TRASUA_GIA.ToString().Contains(key) ||
                    u.TRASUA_MOTA.ToLower().Contains(key.ToLower())).ToList();
        }

    }
}
