using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiKHDAO
    {
        QuanLyCuaHangTraSuaEntities qlLkhentity = new QuanLyCuaHangTraSuaEntities();
        public List<LoaiKHDTO> LayLoaiKH()
        {
            return qlLkhentity.LOAIKHs.Where(mkh => mkh.TRANGTHAI == 1).Select(mkh => new LoaiKHDTO { MaLoai = mkh.MALOAIKH, TenLoai = mkh.TENLOAIKH, TrangThai = mkh.TRANGTHAI.Value }).ToList();
        }
    }
}
