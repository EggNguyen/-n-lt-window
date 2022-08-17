using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khbus = new KhachHangBUS();
        LoaiKHBUS lkhbus = new LoaiKHBUS();
        int flagBTN = 0;
        public frmKhachHang()
        {
            InitializeComponent();
            cboGioiTinhKH.SelectedIndex = 0;
            if (frmLogin.loai == 2)
            {
                btnKHXoa.Visible = false;
            }
            cboLoaiKH.DataSource = lkhbus.LayLoaiKH();
            cboLoaiKH.DisplayMember = "TenLoai";
            cboLoaiKH.ValueMember = "MaLoai";

            colLoaiKH.DataSource = lkhbus.LayLoaiKH();
            colLoaiKH.DisplayMember = "TenLoai";
            colLoaiKH.ValueMember = "MaLoai";

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.AutoGenerateColumns = false;
            dgvKH.DataSource = khbus.LayDSKH();
            dtpNgaySinhKH.Value = DateTime.Now;
            dtpNgaySinhKH.MaxDate = DateTime.Now;
            btnLuu.Enabled = false;
        }
        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
        }
        #region KiemTraKeyPress
        private void txtSoDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtHoVaTenDemKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);

        }
        #endregion
        private void btnKHThem_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            btnLuu.Enabled = true;
            btnKHSua.Enabled = false;
            btnKHXoa.Enabled = false;
           

        }
        private void CapNhatTrangThaiNutVaConTrol()
        {
            btnLuu.Enabled = false;
            btnKHThem.Enabled = true;
            btnKHXoa.Enabled = true;
            btnKHSua.Enabled = true;
            cboLoaiKH.Enabled = true;

            txtHoVaTenDemKH.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtSoDienThoaiKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChiKH.Text = string.Empty;
            cboGioiTinhKH.SelectedIndex = 0;
            cboLoaiKH.SelectedIndex = 0;
        }
        private void btnKHSua_Click(object sender, EventArgs e)
        {
            flagBTN = 2;

            btnLuu.Enabled = true;
            btnKHThem.Enabled = false;
            btnKHXoa.Enabled = false;
            cboLoaiKH.Enabled = false;
            
        }
        private void btnKHXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnKHThem.Enabled = false;
            btnKHSua.Enabled = false;
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (cboLoaiKH.Text == HardCode.KhachThanhVien)
            {
                MessageBox.Show(HardCode.KhongXoaKhachThanhVien, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (MessageBox.Show(HardCode.XacNhanXoa + txtHoVaTenDemKH.Text + txtTenKH.Text, HardCode.XoaThongTin, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                khbus.XoaKH(txtMaKH.Text);
                dgvKH.DataSource = khbus.LayDSKH();

                btnKHSua.Enabled = true;
                btnKHThem.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaKH.Text = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboLoaiKH.SelectedValue = dgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHoVaTenDemKH.Text = dgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenKH.Text = dgvKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSoDienThoaiKH.Text = dgvKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpNgaySinhKH.Value = DateTime.Parse(dgvKH.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtDiaChiKH.Text = dgvKH.Rows[e.RowIndex].Cells[6].Value.ToString();
                cboGioiTinhKH.Text = dgvKH.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            List<KhachHangDTO> khTim = khbus.LayDSKH();

            khTim = khbus.TimKiem(khTim, txtTimKH.Text);
            
            dgvKH.DataSource = khTim;
        }
        private bool KiemTraTenKH(string tenkh)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            tenkh = txtTenKH.Text.Trim(); // Xóa khoảng trắng đầu và cuối chuỗi
            tenkh = trimmer.Replace(tenkh, " ");

            foreach (DataGridViewRow row in dgvKH.Rows)
            {
                if (row.Cells[3].Value.ToString().Equals(tenkh))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (flagBTN)
            {
                case 1:
                    {
                        if (string.IsNullOrEmpty(txtHoVaTenDemKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtSoDienThoaiKH.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnKHXoa.Enabled = true;
                            btnKHSua.Enabled = true;
                            btnLuu.Enabled = false;
                            return;
                        }
                        if (!KiemTraTenKH(txtTenKH.Text))
                        {
                            MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnKHXoa.Enabled = true;
                            btnKHSua.Enabled = true;
                            btnLuu.Enabled = false;
                            return;
                        }
                        if (!khbus.KTSDTKH(txtSoDienThoaiKH.Text))
                        {
                            MessageBox.Show(HardCode.TrungSDT, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnKHXoa.Enabled = true;
                            btnKHSua.Enabled = true;
                            btnLuu.Enabled = false;
                            return;
                        }
                        KhachHangDTO khT = new KhachHangDTO
                        {
                            MaKH = txtMaKH.Text,
                            HoTenDemKH = txtHoVaTenDemKH.Text,
                            TenKH = txtTenKH.Text,
                            SdtKH = txtSoDienThoaiKH.Text,
                            NgaySinhKH = dtpNgaySinhKH.Value,
                            DiaChiKH = txtDiaChiKH.Text,
                            GioiTinhKH = cboGioiTinhKH.Text,
                            LoaiKH = cboLoaiKH.SelectedValue.ToString()
                        };

                        if (khbus.KTSDTKH(txtSoDienThoaiKH.Text))
                        {
                            MessageBox.Show(khbus.ThemKH(khT) ? HardCode.ThemThanhCong + txtHoVaTenDemKH.Text + txtTenKH.Text : HardCode.ThemThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvKH.DataSource = khbus.LayDSKH();
                            CapNhatTrangThaiNutVaConTrol();
                        }
                        else
                        {
                            MessageBox.Show("Trùng Số Điện Thoại hoặc số điện thoại phải có 10 số", HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    break;
                case 2:
                    {
                        KhachHangDTO khS = new KhachHangDTO
                        {
                            MaKH = txtMaKH.Text,
                            HoTenDemKH = txtHoVaTenDemKH.Text,
                            TenKH = txtTenKH.Text,
                            SdtKH = txtSoDienThoaiKH.Text,
                            NgaySinhKH = dtpNgaySinhKH.Value,
                            DiaChiKH = txtDiaChiKH.Text,
                            GioiTinhKH = cboGioiTinhKH.Text,
                            LoaiKH = cboLoaiKH.SelectedValue.ToString()
                        };

                        if (txtSoDienThoaiKH.TextLength == 10)
                        {
                            if (MessageBox.Show(HardCode.XacNhanSua, HardCode.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                MessageBox.Show(khbus.SuaKH(khS) ? HardCode.SuaThanhCong + txtHoVaTenDemKH.Text + txtTenKH.Text : HardCode.SuaThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                                dgvKH.DataSource = khbus.LayDSKH();
                                CapNhatTrangThaiNutVaConTrol();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(HardCode.MuoiSDT, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    break;
            }
        }
        private void AutocompleteCollection()
        {
            AutoCompleteStringCollection autoSP = new AutoCompleteStringCollection();

            string strConnection = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string sql = "SELECT KHACHHANG_TEN from KHACHAHNG WHERE KHACHHANG_TRANGTHAI = 1 ";
            SqlCommand com = new SqlCommand();

            com.Connection = conn;
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    autoSP.Add(reader["KHACHHANG_TEN"].ToString());
                }
            }
            txtTimKH.AutoCompleteCustomSource = autoSP;
        }

        private void btnInKhachHang_Click(object sender, EventArgs e)
        {
            frmChonBaoCaoKhachHang fchon = new frmChonBaoCaoKhachHang();
            fchon.ShowDialog();

        }
    }
}
