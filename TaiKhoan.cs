using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanBUS _tkbus = new TaiKhoanBUS();
        LoaiTaiKhoanBUS _ltkBUS = new LoaiTaiKhoanBUS();
        int flagBTN;
        public frmTaiKhoan()
        {
            InitializeComponent();
            cboLoaiTaiKhoanTK.SelectedIndex = 0;

            cboLoaiTaiKhoanTK.DataSource = _ltkBUS.LayDSSLTK();
            cboLoaiTaiKhoanTK.DisplayMember = "tenloai";
            cboLoaiTaiKhoanTK.ValueMember = "maloai";

            colLoaiTK.DataSource = _ltkBUS.LayDSSLTK();
            colLoaiTK.DisplayMember = "tenloai";
            colLoaiTK.ValueMember = "maloai";
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTK.AutoGenerateColumns = false;
            dgvTK.DataSource = _tkbus.LayDSTK();

            txtMaNVTK.Enabled = false;
            cboLoaiTaiKhoanTK.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void CapNhatTrangThaiNutVaConTrol()
        {
            btnTKSua.Enabled = true;
            btnLuu.Enabled = false;

            txtGhiChuTK.Text = string.Empty;
            txtMaNVTK.Text = string.Empty;
            txtMaNVTK.Text = string.Empty;
            cboLoaiTaiKhoanTK.SelectedIndex = 0;
        }
        private void frmTaiKhoan_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
            _tkbus.LayDSTK();
        }


        private void btnTKSua_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            btnLuu.Enabled = true;
            cboLoaiTaiKhoanTK.Enabled = false;
            txtMaNVTK.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (flagBTN)
            {
                case 1:
                    {
                        TaiKhoanDTO tkT = new TaiKhoanDTO()
                        {
                            tk_manv = txtMaNVTK.Text,
                            tk_ghichu = txtGhiChuTK.Text,
                        };
                        MessageBox.Show(_tkbus.SuaTK(tkT) ? HardCode.SuaThanhCong:HardCode.SuaThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvTK.DataSource = _tkbus.LayDSTK();
                        CapNhatTrangThaiNutVaConTrol();
                    }
                    break;
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvTK.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    txtMaNVTK.Text = dgvTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cboLoaiTaiKhoanTK.SelectedValue = dgvTK.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGhiChuTK.Text = null;
                }
                else
                {
                    txtMaNVTK.Text = dgvTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cboLoaiTaiKhoanTK.SelectedValue = dgvTK.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGhiChuTK.Text = dgvTK.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
                
        }

        private void txtTimTK_TextChanged(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> taikhoans = _tkbus.LayDSTK();
            taikhoans = _tkbus.TimMaTK(taikhoans, txtTimTK.Text);
            dgvTK.DataSource = taikhoans;
        }
    }
}
