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
    public partial class frmNguyenLieu : Form
    {
        NguyenLieuBUS nlbus = new NguyenLieuBUS();
        NhaCungCapBUS nccbus = new NhaCungCapBUS();
        int flagBTN;
        public frmNguyenLieu()
        {
            InitializeComponent();
            dtpHanSuDungNL.Value = DateTime.Now;

        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvNL.AutoGenerateColumns = false;
            dgvNL.DataSource = nlbus.LayDSNL();
            cboTenNCC.DataSource = nccbus.LayDSNCC();
            cboTenNCC.DisplayMember = "ten";
            cboTenNCC.ValueMember = "ma";
            cboTenNCC.SelectedIndex = 0;

        }
        private void CapNhatTrangThaiNutVaConTrol()
        {
            btnNLThem.Enabled = true;
            btnNLSua.Enabled = true;
            btnNLXoa.Enabled = true;
            btnNLLuu.Enabled = false;

            txtMaNL.Text = string.Empty;
            cboTenNCC.SelectedIndex = 0;
            txtMoTaNL.Text = string.Empty;
            txtSoLuongTonNL.Text = string.Empty;
            txtTenNL.Text = string.Empty;
        }
        private void btnNLThem_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            txtTenNL.Focus();
            btnNLLuu.Enabled = true;
            btnNLXoa.Enabled = false;
            btnNLSua.Enabled = false;
        }
        private void btnNLSua_Click(object sender, EventArgs e)
        {
            flagBTN = 2;

            btnNLLuu.Enabled = true;
            btnNLThem.Enabled = false;
            btnNLSua.Enabled = false;
            btnNLXoa.Enabled = false;
        }
        private void btnNLXoa_Click(object sender, EventArgs e)
        {
            btnNLLuu.Enabled = false;
            btnNLThem.Enabled = false;
            btnNLSua.Enabled = false;
            if (string.IsNullOrEmpty(txtMaNL.Text))
            {
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (txtSoLuongTonNL.Text == "0")
            {
                if (MessageBox.Show(HardCode.XacNhanXoa + txtTenNL.Text, HardCode.XoaThongTin, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nlbus.XoaNL(txtMaNL.Text);
                    dgvNL.DataSource = nlbus.LayDSNL();
                    CapNhatTrangThaiNutVaConTrol();
                    return;
                }
                else
                {
                    btnNLThem.Enabled = true;
                    btnNLSua.Enabled = true;
                    btnNLLuu.Enabled = false;
                    return;
                }
            }
            if (txtSoLuongTonNL.Text != "0")
            {
                MessageBox.Show("Nguyên Liệu Vẫn Còn!", HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (DateTime.Now < dtpHanSuDungNL.Value)
            {
                MessageBox.Show("Chưa Hết Hạn Sử Dụng!", HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatTrangThaiNutVaConTrol();
                return;
            }


        }
        private bool KiemTraTenNL(string tennl)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            tennl = txtTenNL.Text.Trim(); // Xóa khoảng trắng đầu và cuối chuỗi
            tennl = trimmer.Replace(tennl, " ");

            foreach (DataGridViewRow row in dgvNL.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(tennl))
                {
                    return false;
                }
            }
            return true;
        }
        private bool KiemTraHSD()
        {
            if (dtpHanSuDungNL.Value <= DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool KiemTraMatHang()
        {
            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection conn = new SqlConnection(constr);

            conn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_KiemTraMatHang";
            cmd.Parameters.AddWithValue("@tenncc", cboTenNCC.Text);
            cmd.Parameters.AddWithValue("@mathang", txtTenNL.Text);
            cmd.Connection = conn;

            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);

            if (code == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        private void btnNLLuu_Click(object sender, EventArgs e)
        {
            switch (flagBTN)
            {
                case 1:
                    {

                        
                        if (string.IsNullOrEmpty(txtSoLuongTonNL.Text) || string.IsNullOrEmpty(txtTenNL.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnNLXoa.Enabled = true;
                            btnNLSua.Enabled = true;
                            btnNLLuu.Enabled = false;
                            return;
                        }
                        if (!KiemTraTenNL(txtTenNL.Text))
                        {
                            MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnNLXoa.Enabled = true;
                            btnNLSua.Enabled = true;
                            btnNLLuu.Enabled = false;
                            return;
                        }
                        if (!KiemTraHSD())
                        {
                            MessageBox.Show(HardCode.HanSuDungBeHonNgayHienTai, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            dtpHanSuDungNL.Value = DateTime.Now;
                            btnNLXoa.Enabled = true;
                            btnNLSua.Enabled = true;
                            btnNLLuu.Enabled = false;
                            return;
                        }
                        if (!KiemTraMatHang())
                        {
                            MessageBox.Show(HardCode.SaiMatHang, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnNLXoa.Enabled = true;
                            btnNLSua.Enabled = true;
                            btnNLLuu.Enabled = false;
                            return;
                        }
                        //if (nlbus.KTTenNLCuaNhaCungCap(txtTenNL.Text))
                        //{
                        //    MessageBox.Show("Nhà Cung Cấp Không Cung Cấp Nguyên Liệu Này", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //    btnNLXoa.Enabled = true;
                        //    btnNLSua.Enabled = true;
                        //    btnNLLuu.Enabled = false;
                        //    return;
                        //}
                        else
                        {
                            NguyenLieuDTO nlT = new NguyenLieuDTO
                            {
                                ma = txtMaNL.Text,
                                tenncc = cboTenNCC.Text,
                                ten = txtTenNL.Text,
                                hansudung = dtpHanSuDungNL.Value,
                                soluong = Int32.Parse(txtSoLuongTonNL.Text),
                                mota = txtMoTaNL.Text
                            };
                            MessageBox.Show(nlbus.ThemNL(nlT) ? HardCode.ThemThanhCong + txtTenNL.Text : HardCode.ThemThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CapNhatTrangThaiNutVaConTrol();

                            dgvNL.DataSource = nlbus.LayDSNL();
                        }
                    }
                    break;
                case 2:
                    {
                        NguyenLieuDTO nlS = new NguyenLieuDTO
                        {
                            ma = txtMaNL.Text,
                            tenncc = cboTenNCC.Text,
                            ten = txtTenNL.Text,
                            hansudung = dtpHanSuDungNL.Value,
                            soluong = Int32.Parse(txtSoLuongTonNL.Text),
                            mota = txtMoTaNL.Text
                        };

                        //if (!KiemTraTenNL(txtTenNL.Text))
                        //{
                        //    MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    btnNLXoa.Enabled = true;
                        //    btnNLSua.Enabled = true;
                        //    btnNLLuu.Enabled = false;
                        //    return;
                        //}

                        if (MessageBox.Show(HardCode.XacNhanSua, HardCode.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nlbus.SuaNL(nlS);
                            CapNhatTrangThaiNutVaConTrol();

                            dgvNL.DataSource = nlbus.LayDSNL();
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;
            }
        }
        private void dgvNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvNL.Rows[e.RowIndex].Cells[6].Value == null)
                {
                    txtMaNL.Text = dgvNL.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNL.Text = dgvNL.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSoLuongTonNL.Text = dgvNL.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpHanSuDungNL.Value = DateTime.Parse(dgvNL.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cboTenNCC.Text = dgvNL.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtMoTaNL.Text = null;
                }
                else
                {
                    txtMaNL.Text = dgvNL.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNL.Text = dgvNL.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSoLuongTonNL.Text = dgvNL.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpHanSuDungNL.Value = DateTime.Parse(dgvNL.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cboTenNCC.Text = dgvNL.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtMoTaNL.Text = dgvNL.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
        }

        private void txtSoLuongTonNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtTenNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = char.IsDigit(e.KeyChar);
        }
        private void frmNguyenLieu_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
        }

        private void txtTimNL_TextChanged(object sender, EventArgs e)
        {
            List<NguyenLieuDTO> nls = nlbus.LayDSNL();

            nls = nlbus.TimKiem(nls, txtTimNL.Text);

            dgvNL.DataSource = nls;
        }

       
    }
}
