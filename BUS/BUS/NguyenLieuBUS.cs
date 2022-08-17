using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguyenLieuBUS
    {
        NguyenLieuDAO _nldao = new NguyenLieuDAO();
        public List<NguyenLieuDTO> LayDSNL()
        {
            return _nldao.LayDSNL();
        }
        public bool ThemNL(NguyenLieuDTO nlT)
        {
            return _nldao.ThemNL(nlT);
        }
        public bool SuaNL(NguyenLieuDTO nlS)
        {
            return _nldao.SuaNL(nlS);
        }
        public bool XoaNL(string manl)
        {
            return _nldao.XoaNL(manl);
        }
        public bool KTTenNL(string tennl)
        {
            return _nldao.KTTenNL(tennl);
        }
        public bool KTMaNCC(string mancc)
        {
            return _nldao.KTMaNCC(mancc);
        }
        public bool KTMaNL(string manl)
        {
            return _nldao.KTMaNL(manl);
        }
        //public bool KTTenNLCuaNhaCungCap(string tennlvancc)
        //{
        //    return _nldao.KTTenNLCuaNhaCungCap(tennlvancc);
        //}
        public List<NguyenLieuDTO> TimTenNL(List<NguyenLieuDTO> nguyenlieus, string key)
        {
            return nguyenlieus.Where(u => u.ten.ToLower().Contains(key.ToLower())).ToList();
        }
        public List<NguyenLieuDTO> TimTenNCC(List<NguyenLieuDTO> nguyenlieus, string key)
        {
            return nguyenlieus.Where(u => u.tenncc.ToLower().Contains(key.ToLower())).ToList();
        }
        public List<NguyenLieuDTO> TimKiem(List<NguyenLieuDTO> nguyenlieus, string key)
        {
            return nguyenlieus.Where(u =>
                    u.ten.ToLower().Contains(key.ToLower()) ||
                    u.tenncc.ToLower().Contains(key.ToLower()) ||
                    u.ma.ToString().Contains(key) ||
                    u.soluong.ToString().Contains(key) ||
                    u.hansudung.ToString().Contains(key) ||
                    u.mota.ToLower().Contains(key) ||
                    u.ngaynhap.ToString().Contains(key)).ToList();
        }
    }
}
