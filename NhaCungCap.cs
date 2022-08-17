using System;
using System.Collections.Generic;
using BUS;
using DTO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNhaCungCap : Form
    {
        QuanLyCuaHangTraSuaDataContext qlncc = new QuanLyCuaHangTraSuaDataContext();
        NhaCungCapBUS nccbus = new NhaCungCapBUS();
        int flagBTN;
        
        public frmNhaCungCap()
        {
            InitializeComponent();
            btnNCCLuu.Enabled = false;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.AutoGenerateColumns = false;
            dgvNCC.DataSource = nccbus.LayDSNCC();
        }
        //private void LayDSNCC()
        //{
        //    List<SP_LayDSNCCResult> DSNCC = qlncc.SP_LayDSNCC().ToList();
        //    dgvNCC.DataSource = DSNCC;
        //}
        private void CapNhatTrangThaiNutVaConTrol()
        {
            btnNCCLuu.Enabled = false;
            btnNCCThem.Enabled = true;
            btnNCCSua.Enabled = true;
            btnNCCXoa.Enabled = true;

            txtDiaChiNCC.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            txtMatHangNCC.Text = string.Empty;
            txtSoDienThoaiNCC.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
        }
        private void btnNCCThem_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            btnNCCLuu.Enabled = true;
            btnNCCXoa.Enabled = false;
            btnNCCSua.Enabled = false;
        }

        private void btnNCCSua_Click(object sender, EventArgs e)
        {
            flagBTN = 2;

            btnNCCLuu.Enabled = true;
            btnNCCThem.Enabled = false;
            btnNCCXoa.Enabled = false;
        }

        private void btnNCCXoa_Click(object sender, EventArgs e)
        {
            btnNCCLuu.Enabled = false;
            btnNCCThem.Enabled = false;
            btnNCCSua.Enabled = false;

            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (MessageBox.Show(HardCode.XacNhanXoa + txtTenNCC.Text, HardCode.XoaThongTin, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nccbus.XoaNCC(txtMaNCC.Text);
                dgvNCC.DataSource = nccbus.LayDSNCC();
                CapNhatTrangThaiNutVaConTrol();
            }
            else
            {
                btnNCCThem.Enabled = true;
                btnNCCSua.Enabled = true;
                btnNCCLuu.Enabled = false;
                return;
            }

        }
        private void btnNCCLuu_Click(object sender, EventArgs e)
        {
            switch (flagBTN)
            {
                case 1:
                    {
                        NhaCungCapDTO nccT = new NhaCungCapDTO
                        {   
                            ma = txtMaNCC.Text,
                            ten = txtTenNCC.Text,
                            sodienthoai = txtSoDienThoaiNCC.Text,
                            diachi = txtDiaChiNCC.Text,
                            mathang = txtMatHangNCC.Text,
                        };

                        if (string.IsNullOrEmpty(txtDiaChiNCC.Text) || string.IsNullOrEmpty(txtMatHangNCC.Text) || string.IsNullOrEmpty(txtSoDienThoaiNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnNCCXoa.Enabled = true;
                            btnNCCSua.Enabled = true;
                            btnNCCLuu.Enabled = false;
                            return;
                        }
                        if (txtSoDienThoaiNCC.TextLength < 10)
                        {
                            MessageBox.Show(HardCode.MuoiSDT, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!nccbus.KtTenNCC(txtTenNCC.Text))
                        {
                            MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnNCCXoa.Enabled = true;
                            btnNCCSua.Enabled = true;
                            btnNCCLuu.Enabled = false;
                            return;
                        }
                        else
                        {
                            MessageBox.Show(nccbus.ThemNCC(nccT , frmLogin.manhanvien) ? HardCode.ThemThanhCong + txtTenNCC.Text : HardCode.ThemThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CapNhatTrangThaiNutVaConTrol();

                            dgvNCC.DataSource = nccbus.LayDSNCC();
                        }
                    }
                    break;

                case 2:
                    {
                        NhaCungCapDTO nccT = new NhaCungCapDTO
                        {
                            ma = txtMaNCC.Text,
                            ten = txtTenNCC.Text,
                            sodienthoai = txtSoDienThoaiNCC.Text,
                            diachi = txtDiaChiNCC.Text,
                            mathang = txtMatHangNCC.Text
                        };
                        if (string.IsNullOrEmpty(txtMaNCC.Text))
                        {
                            CapNhatTrangThaiNutVaConTrol();
                            return;
                        }
                        if (MessageBox.Show(HardCode.XacNhanSua, HardCode.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nccbus.SuaNCC(nccT);
                            CapNhatTrangThaiNutVaConTrol();

                            dgvNCC.DataSource = nccbus.LayDSNCC();
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;
            }
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoDienThoaiNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChiNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMatHangNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            List<NhaCungCapDTO> nccs = nccbus.LayDSNCC();

            nccs = nccbus.TimKiem(nccs, txtTimKiemNCC.Text);

            dgvNCC.DataSource = nccs;
        }

        private void frmNhaCungCap_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
        }

        private void txtSoDienThoaiNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
