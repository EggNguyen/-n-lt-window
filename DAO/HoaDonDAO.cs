using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{   
    public class HoaDonDAO
    {
        QuanLyCuaHangTraSuaEntities qlhd = new QuanLyCuaHangTraSuaEntities();
        static int mahoadon = 3;
        public static int LaySoDongHoaDon()
        {
            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmdd = new SqlCommand("SELECT count(*) FROM HOADON", con);
            con.Open();
            int kq = (int)cmdd.ExecuteScalar();
            con.Close();

            return kq;
        }
        public List<HoaDonDTO> LayDSHD()
        {
            return qlhd.HOADONs.Where(x => x.HOADON_TRANGTHAI == 1).Select(u => new HoaDonDTO { mahd = u.HOADON_MAHOADON, ngaylap = u.HOADON_NGAYLAP, khachtra = (int)u.HOADON_KHACHTRA.Value, thanhtien = (int)u.HOADON_THANHTIEN.Value, thoilai = (int)u.HOADON_THOILAI.Value, manv = u.HOADON_MANV}).OrderBy(u => u.ngaylap).ToList();
        }
        public List<ChiTietHoaDonDTO> LayDSCTHD(string mahd)
        {
            return qlhd.CHITIET_HOADON.Where(x => x.MACTHD == mahd).Select(u => new ChiTietHoaDonDTO { ct_macthd = u.MACTHD , ct_tensp = u.CHITIET_HOADON_TENSP, ct_soluong = u.CHITIET_HOADON_SOLUONG, ct_dongia = u.CHITIET_HOADON_DONGIA}).ToList();
        }

        public bool ThemHD(string manv , decimal khachtra , decimal thanhtien , decimal tralai )
        {
            HOADON hd = new HOADON()
            {
                HOADON_MAHOADON = mahoadon.ToString(),
                HOADON_NGAYLAP = DateTime.Now,
                HOADON_MANV = manv,
                HOADON_KHACHTRA = khachtra,
                HOADON_THANHTIEN = thanhtien,
                HOADON_THOILAI = tralai,
                HOADON_TRANGTHAI = 1
            };
            mahoadon++;
            qlhd.HOADONs.Add(hd);
            qlhd.SaveChanges();
            return true;
        }
    }
}
