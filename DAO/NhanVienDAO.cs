using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        QuanLyCuaHangTraSuaEntities qlnventity = new QuanLyCuaHangTraSuaEntities();

        Random randMaNV = new Random();
        string manv;

        Random randMatKhau = new Random();
        string matkhau;
        public List<NhanVienDTO> LayDSNV()
        {
            return qlnventity.NHANVIENs.Where(x => x.NHANVIEN_TRANGTHAI == 1).Select(u => new NhanVienDTO {MaNV = u.NHANVIEN_MANHANVIEN , HoVaTenDem = u.NHANVIEN_HOVATENDEM , Ten = u.NHANVIEN_TEN, GioiTinh = u.NHANVIEN_GIOITINH , NgayThangNamSinh = u.NHANVIEN_NTNS.Value , SoDienThoai = u.NHANVIEN_PHONE , DiaChi = u.NHANVIEN_DIACHI , Email = u.NHANVIEN_EMAIL, TrangThai = u.NHANVIEN_TRANGTHAI.Value , LoaiNV = u.NHANVIEN_LOAINV }).ToList();
        }

        public List<NhanVienDTO> LayDSNVDANGHI()
        {
            return qlnventity.NHANVIENs.Where(x => x.NHANVIEN_TRANGTHAI == 0).Select(u => new NhanVienDTO {MaNV = u.NHANVIEN_MANHANVIEN , HoVaTenDem = u.NHANVIEN_HOVATENDEM, Ten = u.NHANVIEN_TEN, GioiTinh = u.NHANVIEN_GIOITINH, NgayThangNamSinh = u.NHANVIEN_NTNS.Value, SoDienThoai = u.NHANVIEN_PHONE, DiaChi = u.NHANVIEN_DIACHI, Email = u.NHANVIEN_EMAIL, TrangThai = u.NHANVIEN_TRANGTHAI.Value, LoaiNV = u.NHANVIEN_LOAINV }).ToList();
        }
        public string HoTenNhanVien(string manv)
        {
            NHANVIEN nv = qlnventity.NHANVIENs.SingleOrDefault(u => u.NHANVIEN_MANHANVIEN == manv.ToString());
            string ho = nv.NHANVIEN_HOVATENDEM;
            string ten = nv.NHANVIEN_TEN;
            return ho +" "+ ten;
        }
        public string ChucVu(string manv)
        {
            NHANVIEN nv = qlnventity.NHANVIENs.SingleOrDefault(u => u.NHANVIEN_MANHANVIEN == manv.ToString());
            string chucvu = nv.NHANVIEN_LOAINV;
            return chucvu;
        }
        public bool KTEmail(string Email)
        {
            Email = Email ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Email))
                return (true);
            else
                return (false);
        }
        public bool KTMaNV(string manv)
        {
            int checkMaNV = qlnventity.NHANVIENs.Count(x => x.NHANVIEN_MANHANVIEN == manv.ToString());

            if (checkMaNV > 0)
                return false;
            return true;
        }

        public bool ThemNV(NhanVienDTO nvT , int loai)
        {
            string loainv = "";
            do
            {
                if (loai == 0)
                {
                    manv = "NV" + randMaNV.Next(999, 9999).ToString();
                    loainv = "2";
                }
                if (loai == 1)
                {
                    manv = "QL" + randMaNV.Next(999, 9999).ToString();
                    loainv = "1";
                }
            } while (!KTMaNV(manv));

            do
            {
                matkhau = randMatKhau.Next(99999, 999999).ToString();

            } while (!KTMatKhau(matkhau));


            NHANVIEN nv = new NHANVIEN()
            {
                NHANVIEN_MANHANVIEN = manv,
                NHANVIEN_HOVATENDEM = nvT.HoVaTenDem,
                NHANVIEN_TEN = nvT.Ten,
                NHANVIEN_DIACHI = nvT.DiaChi,
                NHANVIEN_EMAIL = nvT.Email,
                NHANVIEN_GIOITINH = nvT.GioiTinh,
                NHANVIEN_LOAINV = nvT.LoaiNV,
                NHANVIEN_NTNS = nvT.NgayThangNamSinh,
                NHANVIEN_PHONE = nvT.SoDienThoai,
                NHANVIEN_TRANGTHAI = 1 
            };


            TAIKHOAN tk = new TAIKHOAN()
            {
                TAIKHOAN_MANHANVIEN = manv,
                TAIKHOAN_MATKHAU = MaHoaMatKhauMD5(matkhau),
                TAIKHOAN_NGAYTAO = DateTime.Now,
                TAIKHOAN_MALOAI = loainv,
                TAIKHOAN_TRANGTHAI = 1
            };


            GuiEmail(manv ,matkhau , nvT.Email);
            qlnventity.TAIKHOANs.Add(tk);
            qlnventity.NHANVIENs.Add(nv);
            
            qlnventity.SaveChanges();
            return true;
        }
        public bool SuaNV(NhanVienDTO nvS)
        {
            NHANVIEN nv = qlnventity.NHANVIENs.SingleOrDefault(u => u.NHANVIEN_MANHANVIEN == nvS.MaNV);

            if (nv == null)
            {
                return false;
            }
            else
            {
                nv.NHANVIEN_HOVATENDEM = nvS.HoVaTenDem;
                nv.NHANVIEN_TEN = nvS.Ten;
                nv.NHANVIEN_PHONE = nvS.SoDienThoai;
                nv.NHANVIEN_NTNS = nvS.NgayThangNamSinh;
                nv.NHANVIEN_GIOITINH = nvS.GioiTinh;
                nv.NHANVIEN_DIACHI = nvS.GioiTinh;

                qlnventity.SaveChanges();
                return true;
            }
        }

        public bool XoaNV(string manv)
        {
            NHANVIEN nv = qlnventity.NHANVIENs.SingleOrDefault(u => u.NHANVIEN_MANHANVIEN == manv);
            TAIKHOAN tk = qlnventity.TAIKHOANs.SingleOrDefault(u => u.TAIKHOAN_MANHANVIEN == manv);

            if (nv == null)
            {
                return false;
            }
            else
            {
                nv.NHANVIEN_TRANGTHAI = 0;
                tk.TAIKHOAN_TRANGTHAI = 0;
                qlnventity.SaveChanges();
                return true;
            }
        }
        public bool KTMatKhau(string matkhau)
        {
            int KTMK = qlnventity.TAIKHOANs.Count(x => x.TAIKHOAN_MATKHAU == matkhau.ToString());

            if (KTMK > 0)
                return false;
            return true;
        }
        public void GuiEmail(string manv , string matkhau ,string email)
        {   
            MailAddress from = new MailAddress("tainat1202@gmail.com", "Tài Khoản");
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Thông Tin Tài Khoản";
            message.Body = manv + " " + matkhau;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Host = "smtp.gmail.com";
            client.UseDefaultCredentials = false;
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("tainat1202@gmail.com", "jtjjfphqfpwksiwv");
            client.EnableSsl = true;
            client.Send(message);
        }

        public string MaHoaMatKhauMD5(string matkhau)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matkhau);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
