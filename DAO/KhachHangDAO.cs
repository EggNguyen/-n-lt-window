using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        QuanLyCuaHangTraSuaEntities qlkhentity = new QuanLyCuaHangTraSuaEntities();
        Random randMaKH = new Random();
        string makh;
        public List<KhachHangDTO> LayDSKH()
        {
            return qlkhentity.KHACHHANGs.Where(x => x.KHACHHANG_TRANGTHAI == 1).Select(u => new KhachHangDTO { MaKH = u.KHACHHANG_MAKHACH, HoTenDemKH = u.KHACHHANG_HOTENDEM, TenKH = u.KHACHHANG_TEN, SdtKH = u.KHACHANG_SODIENTHOAI, NgaySinhKH = u.KHACHANG_NGAYSINH.Value, DiaChiKH = u.KHACHHANG_DIACHI, GioiTinhKH = u.KHACHHANG_GIOITINH, TrangThaiKH = u.KHACHHANG_TRANGTHAI.Value, LoaiKH = u.KHACHHANG_LOAIKH }).OrderBy(u => u.LoaiKH).ToList();
        }
        public List<KhachHangDTO> LayDSLKH(string loai)
        {
            return qlkhentity.KHACHHANGs.Where(x => x.KHACHHANG_TRANGTHAI == 1 && x.KHACHHANG_LOAIKH == loai).Select(u => new KhachHangDTO { MaKH = u.KHACHHANG_MAKHACH, HoTenDemKH = u.KHACHHANG_HOTENDEM, TenKH = u.KHACHHANG_TEN, SdtKH = u.KHACHANG_SODIENTHOAI, NgaySinhKH = u.KHACHANG_NGAYSINH.Value, DiaChiKH = u.KHACHHANG_DIACHI, GioiTinhKH = u.KHACHHANG_GIOITINH, TrangThaiKH = u.KHACHHANG_TRANGTHAI.Value, LoaiKH = u.KHACHHANG_LOAIKH }).OrderBy(u => u.LoaiKH).ToList();
        }
        public bool KTMaKH(string makh)
        {
            int checkMasp = qlkhentity.KHACHHANGs.Count(x => x.KHACHHANG_MAKHACH == makh.ToString());

            if (checkMasp > 0)
                return false;
            return true;

        }
        public bool KTSDTKH(string sdt)
        {
            int checkMasp = qlkhentity.KHACHHANGs.Count(x => x.KHACHANG_SODIENTHOAI == sdt.ToString());

            if (checkMasp > 0 || sdt.Length < 10)
                return false;
            return true;
        }
        public bool ThemKH(KhachHangDTO khT)
        {
            do
            {
                makh = "KH" + randMaKH.Next(999, 9999).ToString();
                if (!KTMaKH(makh))
                {
                    continue;
                }
            }while (!KTMaKH(makh));

            KHACHHANG kh = new KHACHHANG()
            {
                KHACHHANG_MAKHACH = makh,
                KHACHHANG_HOTENDEM = khT.HoTenDemKH,
                KHACHHANG_TEN = khT.TenKH,
                KHACHANG_SODIENTHOAI = khT.SdtKH,
                KHACHANG_NGAYSINH = khT.NgaySinhKH,
                KHACHHANG_DIACHI = khT.DiaChiKH,
                KHACHHANG_GIOITINH = khT.GioiTinhKH,
                KHACHHANG_TRANGTHAI = 1,
                KHACHHANG_LOAIKH = khT.LoaiKH
            };

            qlkhentity.KHACHHANGs.Add(kh);
            qlkhentity.SaveChanges();
            return true;
        }

        public bool SuaKH(KhachHangDTO khS)
        {
            KHACHHANG kh = qlkhentity.KHACHHANGs.SingleOrDefault(u => u.KHACHHANG_MAKHACH == khS.MaKH);

            if (kh == null)
            {
                return false;
            }
            else
            {
                kh.KHACHHANG_HOTENDEM = khS.HoTenDemKH;
                kh.KHACHHANG_TEN = khS.TenKH;
                kh.KHACHANG_SODIENTHOAI = khS.SdtKH;
                kh.KHACHANG_NGAYSINH = khS.NgaySinhKH;
                kh.KHACHHANG_DIACHI = khS.DiaChiKH;
                kh.KHACHHANG_GIOITINH = khS.GioiTinhKH;
                kh.KHACHHANG_LOAIKH = khS.LoaiKH;

                qlkhentity.SaveChanges();
                return true;
            }
        }

        public bool XoaKH(string makh)
        {
            KHACHHANG khX = qlkhentity.KHACHHANGs.SingleOrDefault(u => u.KHACHHANG_MAKHACH == makh);
            if (khX == null)
            {
                return false;
            }
            else
            {
                khX.KHACHHANG_TRANGTHAI = 0;
                qlkhentity.SaveChanges();
                return true;
            }
        }
    }
}
