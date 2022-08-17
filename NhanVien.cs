using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        int flagBTN = 0;
        public frmNhanVien()
        {
            InitializeComponent();
            cboGioiTinhNV.SelectedIndex = 0;
            cboLoaiNV.SelectedIndex = 0;
            btnLuuNV.Enabled = false;
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.AutoGenerateColumns = false;
            dgvNV.DataSource = nvBUS.LayDSNV();
            dtpNgaySinhNV.Value = DateTime.Now;
            
        }

        private void btnNVThem_Click(object sender, EventArgs e)
        {
            flagBTN = 1;

            btnLuuNV.Enabled = true;
            btnNVXoa.Enabled = false;
            btnNVSua.Enabled = false;

        }
        private void btnNVSua_Click(object sender, EventArgs e)
        {
            flagBTN = 2;

            btnLuuNV.Enabled = true;
            btnNVThem.Enabled = false;
            btnNVXoa.Enabled = false;
            cboLoaiNV.Enabled = false;
        }
        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            
            btnLuuNV.Enabled = false;
            btnNVThem.Enabled = false;
            btnNVSua.Enabled = false;
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (cboLoaiNV.Text == HardCode.QuanLy)
            {
                MessageBox.Show(HardCode.KhongXoaQuanLy, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatTrangThaiNutVaConTrol();
                return;
            }
            if (MessageBox.Show(HardCode.XacNhanXoa + txtHoVaTenDemNV.Text + txtTenNV.Text, HardCode.XoaThongTin, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nvBUS.XoaNV(txtMaNV.Text);
                dgvNV.DataSource = nvBUS.LayDSNV();

                CapNhatTrangThaiNutVaConTrol();

            }
            else
            {
                return;
            }
        }

        private void CapNhatTrangThaiNutVaConTrol()
        {
            txtMaNV.Text = string.Empty;
            txtDiaChiNV.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtHoVaTenDemNV.Text = string.Empty;
            txtSoDienThoaiNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            dtpNgaySinhNV.Value = DateTime.Now;
            cboGioiTinhNV.SelectedIndex = 0;
            cboLoaiNV.SelectedIndex = 0;

            btnLuuNV.Enabled = false;
            btnNVThem.Enabled = true;
            btnNVSua.Enabled = true;
            btnNVXoa.Enabled = true;
            cboLoaiNV.Enabled = true;
        }

        private bool KTTuoiNV()
        {
            TimeSpan timeDifference = DateTime.Now - dtpNgaySinhNV.Value;
            double Age = timeDifference.TotalDays / 365.2425;
            if (Age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool KTSDT()
        {
            for (int currentRow = 0; currentRow < dgvNV.Rows.Count - 1; currentRow++)
            {
                string sdt = dgvNV.Rows[currentRow].Cells[5].Value.ToString();
                if (sdt == txtSoDienThoaiNV.Text)
                {
                    return false;
                }
            }
            return true;
        }
        private bool KTTenNV(string tennv)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            tennv = txtTenNV.Text.Trim(); // Xóa khoảng trắng đầu và cuối chuỗi
            tennv = trimmer.Replace(tennv, " ");

            foreach (DataGridViewRow row in dgvNV.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(tennv))
                {
                    return false;
                }
            }
            return true;
        }
        //Kiểm tra có mạng hay không bằng cách ping vào google.com
        public bool KiemTraInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            switch (flagBTN)
            {
                case 1:
                    {
                        int loai = cboLoaiNV.SelectedIndex;

                        NhanVienDTO nvT = new NhanVienDTO
                        {
                            HoVaTenDem = txtHoVaTenDemNV.Text,
                            Ten = txtTenNV.Text,
                            SoDienThoai = txtSoDienThoaiNV.Text,
                            Email = txtEmail.Text,
                            DiaChi = txtDiaChiNV.Text,
                            GioiTinh = cboGioiTinhNV.Text,
                            LoaiNV = cboLoaiNV.Text,
                            NgayThangNamSinh = dtpNgaySinhNV.Value
                        };

                        if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtHoVaTenDemNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSoDienThoaiNV.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!KTTenNV(txtTenNV.Text))
                        {
                            MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!KTTuoiNV())
                        {
                            MessageBox.Show(HardCode.MuoiTamTuoi, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!KTSDT())
                        {
                            MessageBox.Show(HardCode.TrungSDT, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!nvBUS.KTEmail(txtEmail.Text))
                        {
                            MessageBox.Show(HardCode.KhongDungDinhDang, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (txtEmail.Text == HardCode.EmailGoc)
                        {
                            MessageBox.Show(HardCode.SaiEmail, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!KiemTraInternet())
                        {
                            MessageBox.Show(HardCode.KhongCoInternet, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {   
                            MessageBox.Show(nvBUS.ThemNV(nvT, loai) ? HardCode.ThemThanhCong + txtHoVaTenDemNV.Text + txtTenNV.Text : HardCode.ThemThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

                            dgvNV.DataSource = nvBUS.LayDSNV();
                            CapNhatTrangThaiNutVaConTrol();
                        }
                    }break;
                case 2:
                    {
                        NhanVienDTO nvS = new NhanVienDTO
                        {
                            MaNV = txtMaNV.Text,
                            HoVaTenDem = txtHoVaTenDemNV.Text,
                            Ten = txtTenNV.Text,
                            Email = txtEmail.Text,
                            DiaChi = txtDiaChiNV.Text,
                            SoDienThoai = txtSoDienThoaiNV.Text,
                            GioiTinh = cboGioiTinhNV.Text,
                            NgayThangNamSinh = dtpNgaySinhNV.Value
                        };
                        if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtHoVaTenDemNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSoDienThoaiNV.Text))
                        {
                            MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //if (!KTTenNV(txtTenNV.Text))
                        //{
                        //    MessageBox.Show(HardCode.TrungTen, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}
                        if (!KTTuoiNV())
                        {
                            MessageBox.Show(HardCode.MuoiTamTuoi, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!nvBUS.KTEmail(txtEmail.Text))
                        {
                            MessageBox.Show(HardCode.KhongDungDinhDang, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        
                        if (MessageBox.Show(HardCode.XacNhanSua, HardCode.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show(nvBUS.SuaNV(nvS) ? HardCode.SuaThanhCong + txtHoVaTenDemNV.Text + txtTenNV.Text : HardCode.SuaThatBai, HardCode.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvNV.DataSource = nvBUS.LayDSNV();
                            CapNhatTrangThaiNutVaConTrol();
                        }
                        else
                        {
                            return;
                        }
                    }break; 
            }

        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiNutVaConTrol();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboLoaiNV.Enabled = false;
            if (e.RowIndex != -1)
            {
                txtMaNV.Text = dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoVaTenDemNV.Text = dgvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNV.Text = dgvNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboGioiTinhNV.Text = dgvNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgaySinhNV.Value = DateTime.Parse(dgvNV.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtSoDienThoaiNV.Text = dgvNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChiNV.Text = dgvNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dgvNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                cboLoaiNV.Text = dgvNV.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }
        private void btnInSP_Click(object sender, EventArgs e)
        {
            frmChonBaoCaoNhanVien fchonbaocaonhanvien = new frmChonBaoCaoNhanVien();
            fchonbaocaonhanvien.ShowDialog();
        }

        private void txtSoDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            List<NhanVienDTO> nhanviens = nvBUS.LayDSNV();

            nhanviens = nvBUS.TimKiem(nhanviens, txtTimKiemNV.Text);

            dgvNV.DataSource = nhanviens;


        }
    }
}
