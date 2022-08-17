using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmChonBaoCaoKhachHang : Form
    {
        LoaiKHBUS lkhbus = new LoaiKHBUS();
        public frmChonBaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void btnXemBaoCaoKhachHang_Click(object sender, EventArgs e)
        {
            frmXemBaoCaoKhachHang fxembaocaokhachhang = new frmXemBaoCaoKhachHang();

            if (radTatCa.Checked)
            {
                fxembaocaokhachhang.TatCaKhachHang();
                fxembaocaokhachhang.ShowDialog();
            }
            if (radTheoLoai.Checked)
            {
                fxembaocaokhachhang.LoaiKhachHang((LoaiKHDTO)cboLoaiKhachHang.SelectedItem);
                fxembaocaokhachhang.ShowDialog();
            }
            if (radNhomTheoLoai.Checked)
            {
                fxembaocaokhachhang.NhomTheoLoai();
                fxembaocaokhachhang.ShowDialog();
            }
        }

        private void frmChonBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            cboLoaiKhachHang.DisplayMember = "TenLoai";
            cboLoaiKhachHang.ValueMember = "MaLoai";
            cboLoaiKhachHang.DataSource = lkhbus.LayLoaiKH();
        }
    }
}
