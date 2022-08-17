using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{   
   
    public partial class frmMain : Form
    {
        frmBanHang fBanHang = new frmBanHang();
        frmKhachHang fKhachHang = new frmKhachHang();

        public static int click;
        public frmMain()
        {
            InitializeComponent();
            AnMenuConBanDau();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            tmTime.Start();

            openChildForm(new frmThongKe());
            if (frmLogin.loai == 2) //nhanvien
            {
                btnNhanVien.Hide();
                btnTaiKhoan.Hide();
                btnNhaCungCap.Hide();
            }
            lblHoTen.Text = frmLogin.mainHoTen;
            lblChucVu.Text = frmLogin.mainChucVu;
        }
        

        private void AnMenuConBanDau()
        {
            pnMenuConDonHang.Visible = false;
        }
        
        private void AnMenuCon()
        {
            if (pnMenuConDonHang.Visible == true)
            {
                pnMenuConDonHang.Visible = false;
            }
        }

        private void HienMenuCon(Panel MenuCon)
        {
            if (MenuCon.Visible == false)
            {
                AnMenuCon();
                MenuCon.Visible = true;
            }
            else
            {
                MenuCon.Visible = false;
            }
        }


        //Mo form con
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnFormCon.Controls.Add(childForm);
            pnFormCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
        }


        private void btnDonHang_Click(object sender, EventArgs e)
        {
            HienMenuCon(pnMenuConDonHang);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBanHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            
            openChildForm(new frmSanPham());
            AnMenuCon();

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            openChildForm(new frmKhachHang());
            AnMenuCon();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNguyenLieu());
            AnMenuCon();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());

            AnMenuCon();

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

            openChildForm(new frmTaiKhoan());

            AnMenuCon();

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            openChildForm(new frmNhaCungCap());
            AnMenuCon();

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
            AnMenuCon();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
            }
            else
            {
                return;
            }
        }

        private void picViet_Click(object sender, EventArgs e)
        {
            btnDonHang.Text    = "Bán";
            btnBanHang.Text    = "Bán Hàng";
            btnDangXuat.Text   = "Đăng Xuất";
            btnHoaDon.Text     = "Hóa Đơn";
            btnSanPham.Text    = "Sản Phẩm";
            btnNhaCungCap.Text = "Nhà Cung Cấp";
            btnNhanVien.Text   = "Nhân Viên";
            btnTaiKhoan.Text   = "Tài Khoản";
            btnNguyenLieu.Text = "Nguyên Liệu";
            btnKhachHang.Text = "Khách Hàng";

            if (frmLogin.loai == 2) //nhanvien
            {
                lblChucVu.Text = "Nhân Viên";
            }
            if (frmLogin.loai == 1) //QuanLy
            {
                lblChucVu.Text = "Quản Lý";
            }

            fBanHang.btnBHThem.Text = "Thêm";
            fBanHang.btnBHXoa.Text = "Xóa";
            fBanHang.btnBHThanhToan.Text = "Thanh Toán";
            fBanHang.lblBanHang.Text = "Bán Hàng";
            fBanHang.lblTienNhan.Text = "Tiền Nhận";
            fBanHang.lblTongThanhTien.Text = "Tổng Thành Tiền";
            fBanHang.lblTraLai.Text = "Trả lại";
        }

        private void picUK_Click(object sender, EventArgs e)
        {

            btnNhaCungCap.TextAlign = HorizontalAlignment.Left;
            
            btnDonHang.Text = "Sell";
            btnBanHang.Text = "Sell Product";
            btnDangXuat.Text = "Log off";
            btnHoaDon.Text = "Bill";
            btnSanPham.Text = "Product";
            btnNhaCungCap.Text = "Provider";
            btnNhanVien.Text = "Employee";
            btnTaiKhoan.Text = "Accounts";
            btnNguyenLieu.Text = "Ingredients";
            btnKhachHang.Text = "Customer";

            if (frmLogin.loai == 2) //nhanvien
            {
                lblChucVu.Text = "Employee";
            }
            if (frmLogin.loai == 1) //QuanLy
            {
                lblChucVu.Text = "Manager";
            }

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                HienMenuCon(pnMenuConDonHang);
                openChildForm(new frmBanHang());
            }
            if (e.KeyCode == Keys.F2)
            {
                openChildForm(new frmSanPham());
                AnMenuCon();
            }
            if (e.KeyCode == Keys.F3)
            {
                openChildForm(new frmKhachHang());
                AnMenuCon();
            }
            if (e.KeyCode == Keys.F4)
            {
                openChildForm(new frmNguyenLieu());
                AnMenuCon();
            }
            if (e.KeyCode == Keys.F5)
            {
                openChildForm(new frmNhanVien());

                AnMenuCon();
            }
            if (e.KeyCode == Keys.F6)
            {
                openChildForm(new frmTaiKhoan());

                AnMenuCon();
            }
            if (e.KeyCode == Keys.F7)
            {
                openChildForm(new frmNhaCungCap());
                AnMenuCon();
            }
            if (e.KeyCode == Keys.F8)
            {
                openChildForm(new frmHoaDon());

                AnMenuCon();
            }
        }
    }
}
