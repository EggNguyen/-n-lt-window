using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSanPham : Form
    {   
        
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        QuanLyCuaHangTraSuaDataContext qlchts = new QuanLyCuaHangTraSuaDataContext();
        int flagBTN = 0;

        public frmSanPham()
        {
            InitializeComponent();
            cboMoTaSP.SelectedIndex = 0;
            if (frmLogin.loai == 2)
            {
                btnXoaSP.Visible = false;
            }
            btnLuuSP.Enabled = false;
            //dgvQLSP.Columns[2].DefaultCellStyle.Format = "#,####.###";
        }
        private void LayDSSP()
        {
            List<SP_LayDSSPResult> DSSP = qlchts.SP_LayDSSP().ToList();
            dgvQLSP.DataSource = DSSP;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvQLSP.AutoGenerateColumns = false;
            //dgvQLSP.DataSource = sanPhamBUS.LayDSSP();
            LayDSSP();
            AutocompleteCollection();
            dtpNgayNhapSP.Value = DateTime.Now;
        }
        private void frmSanPham_DoubleClick_1(object sender, EventArgs e)
        {
            LayDSSP();
        }
        #region KiemTraNhap

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
        private void txtGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
        #region ChucNang
        private void CapNhatTrangThaiNutVaConTrol()
        {
            btnLuuSP.Enabled = false;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = true;
            btnXoaSP.Enabled = true;

            txtMASP.Text = string.Empty;
            cboMoTaSP.SelectedIndex = 0;
            txtGiaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            dtpNgayNhapSP.Value = DateTime.Now;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            txtTenSP.Focus();
            btnLuuSP.Enabled = true;
            btnXoaSP.Enabled = false;
            btnSuaSP.Enabled = false;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            flagBTN = 2;

            btnLuuSP.Enabled = true;
            btnThemSP.Enabled = false;
            btnSuaSP.Enabled = false;
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            btnLuuSP.Enabled = false;
            btnThemSP.Enabled = false;
            btnSuaSP.Enabled = false;
            if (string.IsNullOrEmpty(txtMASP.Text))
            {
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (cboMoTaSP.SelectedIndex == 0)
            {
                MessageBox.Show("Không thể xóa sản phẩm đang bán chạy", HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            //if (MessageBox.Show("Xóa Sản Phẩm Đang BÁN CHẠY ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    sanPhamBUS.XoaSP(txtMASP.Text);
            //    LayDSSP();
            //    CapNhatTrangThaiNutVaConTrol();
            //}
            if (MessageBox.Show(HardCode.XacNhanXoa + txtTenSP.Text, "Xóa Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sanPhamBUS.XoaSP(txtMASP.Text);
                LayDSSP();
                CapNhatTrangThaiNutVaConTrol();
            }
            else
            {
                btnThemSP.Enabled = true;
                btnSuaSP.Enabled = true;
                btnLuuSP.Enabled = false;
                return;
            }
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            List<SanPhamDTO> sanPhams = sanPhamBUS.LayDSSP();

            sanPhams = sanPhamBUS.TimKiem(sanPhams, txtTimSP.Text);
            
            dgvQLSP.DataSource = sanPhams;
        }
#endregion
        private void dgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {   
                txtMASP.Text = dgvQLSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvQLSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaSP.Text = dgvQLSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayNhapSP.Value = DateTime.Parse(dgvQLSP.Rows[e.RowIndex].Cells[3].Value.ToString());
                cboMoTaSP.Text = dgvQLSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void AutocompleteCollection()
        {
            AutoCompleteStringCollection autoSP = new AutoCompleteStringCollection();
            string sql = "";
            string strConnection = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            sql = "SELECT TRASUA_TEN from TRASUA WHERE TRASUA_TRANGTHAI = 1 ";

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
                    autoSP.Add(reader["TRASUA_TEN"].ToString());
                }
            }
            
            txtTimSP.AutoCompleteCustomSource = autoSP;
        }
        private bool KiemTraTenSP(string tensp)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            tensp = txtTenSP.Text.Trim(); // Xóa khoảng trắng đầu và cuối chuỗi
            tensp = trimmer.Replace(tensp, " ");

            foreach (DataGridViewRow row in dgvQLSP.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(tensp))
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
                        
                        if (!KiemTraTenSP(txtTenSP.Text))
                        {
                            MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnXoaSP.Enabled = true;
                            btnSuaSP.Enabled = true;
                            btnLuuSP.Enabled = false;
                            return;

                        }
                        if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGiaSP.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                            btnXoaSP.Enabled = true;
                            btnSuaSP.Enabled = true;
                            btnLuuSP.Enabled = false;
                            return;
                        }

                        if (!sanPhamBUS.ktMasp(txtMASP.Text))
                        {
                            MessageBox.Show(HardCode.TrungMa, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnXoaSP.Enabled = true;
                            btnSuaSP.Enabled = true;
                            btnLuuSP.Enabled = false;
                            return;
                        }
                        else
                        {
                            SanPhamDTO spT = new SanPhamDTO
                            {
                                TRASUA_TEN = txtTenSP.Text,
                                TRASUA_GIA = Convert.ToDecimal(txtGiaSP.Text),
                                TRASUA_MOTA = cboMoTaSP.Text,
                            };
                            MessageBox.Show(sanPhamBUS.ThemSP(spT) ? HardCode.ThemThanhCong + txtTenSP.Text : HardCode.ThemThatBai,HardCode.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Information);
                            CapNhatTrangThaiNutVaConTrol();

                            LayDSSP();
                        }
                    }break;

                case 2:
                    {
                        if (string.IsNullOrEmpty(txtMASP.Text))
                        {
                            CapNhatTrangThaiNutVaConTrol();
                            return;
                        }

                        SanPhamDTO spS = new SanPhamDTO
                        {
                            TRASUA_MATS = txtMASP.Text,
                            TRASUA_TEN = txtTenSP.Text,
                            TRASUA_GIA = Convert.ToDecimal(txtGiaSP.Text),
                            TRASUA_NGAYTAO = dtpNgayNhapSP.Value,
                            TRASUA_MOTA = cboMoTaSP.Text,
                        };

                        if (MessageBox.Show(HardCode.XacNhanSua, HardCode.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sanPhamBUS.SuaSP(spS);
                            CapNhatTrangThaiNutVaConTrol();

                            LayDSSP();
                        }
                        else
                        {
                            return;
                        }
                    }break;
            }
        }

        private void frmSanPham_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
        }

        private void txtGiaSP_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
