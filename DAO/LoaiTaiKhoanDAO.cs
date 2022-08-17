using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiTaiKhoanDAO
    { QuanLyCuaHangTraSuaEntities qlltkentity = new QuanLyCuaHangTraSuaEntities();
        public List<LoaiTaiKhoanDTO>LayDSSLTK()
        {
            return qlltkentity.LOAITAIKHOANs.Where(u => u.TrangThai == 1).Select( u => new LoaiTaiKhoanDTO {maloai = u.MALOAI , tenloai = u.TENLOAITK , trangthai = u.TrangThai.Value }).ToList();
        }
    }
}
