using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{

    public partial class frmLogin : Form
    {
        ToolTip toolTip = new ToolTip();
        NhanVienBUS nvbus = new NhanVienBUS();
        public static int loai;
        public static string mainHoTen = "";
        public static string mainChucVu = "";
        public static string manhanvien = "";

        public static bool flag = true;

        public frmLogin()
        {
            InitializeComponent();
            //cboLoaiNVLG.SelectedIndex = 0;
            txtMatKhau.MouseHover += new EventHandler(txtMatKhau_MouseHover);
            txtMatKhau.MouseLeave += new EventHandler(txtMatKhau_MouseLeave);
        }

        private void btnHienPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnAnPass.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
        private void btnAnPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btnHienPass.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void picUK_Click(object sender, EventArgs e)
        {
            lblPhanMem.Text = "TNH Milk Tea";
            lblQuanLy.Text = "Management Sofware";
            lblDangNhap.Text = "Login";
            txtID.PlaceholderText = "ID";
            txtMatKhau.PlaceholderText = "Password";
            btnDangNhap.Text = "Login";
            Text = "Login";
            //cboLoaiNVLG.Items.Clear();
            //cboLoaiNVLG.Items.AddRange(new String[] { "Staff", "Manager" });
            //cboLoaiNVLG.SelectedIndex = 0;

        }

        private void picVietNam_Click(object sender, EventArgs e)
        {
            lblPhanMem.Text = "Phần Mềm";
            lblQuanLy.Text = "Quản Lý Trà Sữa TNH";
            lblDangNhap.Text = "Đăng Nhập";
            txtID.PlaceholderText = "Mã Nhân Viên";
            txtMatKhau.PlaceholderText = "Mật Khẩu";
            btnDangNhap.Text = "Đăng Nhập";
            Text = "Đăng Nhập";
            //cboLoaiNVLG.Items.Clear();
            //cboLoaiNVLG.Items.AddRange(new String[] { "Nhân viên", "Quản lý" });
            //cboLoaiNVLG.SelectedIndex = 0;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string md5password = MaHoaMatKhauMD5(txtMatKhau.Text);
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DangNhap";
                cmd.Parameters.AddWithValue("@UserName", txtID.Text);
                cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text);
                cmd.Connection = conn;

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    loai = 2;// nhanvien
                    mainHoTen = nvbus.HoTenNhanVien(txtID.Text);
                    mainChucVu = nvbus.ChucVu(txtID.Text);
                    manhanvien = txtID.Text;

                    new frmMain().Show();

                    Hide();
                }
                else if (code == 1)
                {
                    loai = 1; //quanly
                    mainHoTen = nvbus.HoTenNhanVien(txtID.Text);
                    mainChucVu = nvbus.ChucVu(txtID.Text);
                    manhanvien = txtID.Text;

                    new frmMain().Show();

                    Hide();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtMatKhau.Text = "";
                    txtID.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtMatKhau.Text = "";
                    txtID.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtMatKhau_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(txtMatKhau);
        }

        private void txtMatKhau_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Caps Lock Is On";
            toolTip.ToolTipIcon = ToolTipIcon.Warning;
            toolTip.IsBalloon = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
