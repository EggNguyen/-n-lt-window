using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanHangDAO
    {
        QuanLyCuaHangTraSuaEntities qlbhentity = new QuanLyCuaHangTraSuaEntities();

        //public bool ThemBH(SanPhamDAO bhT)
        //{

        //    NHANVIEN nv = new NHANVIEN()
        //    {
        //        NHANVIEN_MANHANVIEN = manv,
        //        NHANVIEN_HOVATENDEM = nvT.HoVaTenDem,
        //        NHANVIEN_TEN = nvT.Ten,
        //        NHANVIEN_DIACHI = nvT.DiaChi,
        //        NHANVIEN_EMAIL = nvT.Email,
        //        NHANVIEN_GIOITINH = nvT.GioiTinh,
        //        NHANVIEN_LOAINV = nvT.LoaiNV,
        //        NHANVIEN_NTNS = nvT.NgayThangNamSinh,
        //        NHANVIEN_PHONE = nvT.SoDienThoai,
        //        NHANVIEN_TRANGTHAI = 1
        //    };
        //    qlnventity.NHANVIENs.Add(nv);

        //    qlbhentity.SaveChanges();
        //    return true;
        //}
        public int tien(string a)
        {
            TRASUA TS = qlbhentity.TRASUAs.SingleOrDefault(u => u.TRASUA_TEN == a.ToString());
            int money = Convert.ToInt32(TS.TRASUA_GIA);
            return money;
        }
    }
}
