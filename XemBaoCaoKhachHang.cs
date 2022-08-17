using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmXemBaoCaoKhachHang : Form
    {
        KhachHangBUS khbus = new KhachHangBUS();
        LoaiKHBUS lkhbus = new LoaiKHBUS();
        public frmXemBaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void XemBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            this.rpvXemBaoCaoKhachHang.RefreshReport();
        }
        public void TatCaKhachHang()
        {
            List<KhachHangDTO> khdto = khbus.LayDSKH();
            this.rpvXemBaoCaoKhachHang.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptTatCaKhachHang.rdlc";
            this.rpvXemBaoCaoKhachHang.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSKhachHang", khdto));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paNgayLap" , DateTime.Today.ToString()));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paNhanVien", frmLogin.mainHoTen.ToString()));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paMaNhanVien", frmLogin.manhanvien.ToString()));

            this.rpvXemBaoCaoKhachHang.RefreshReport();
        }

        public void LoaiKhachHang(LoaiKHDTO loai)
        {
            List<KhachHangDTO> khdto = khbus.LayDSLKH(loai.MaLoai);
            this.rpvXemBaoCaoKhachHang.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptLoaiKhachHang.rdlc";
            this.rpvXemBaoCaoKhachHang.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSLoaiKhachHang", khdto));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Today.ToString()));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paNhanVien", frmLogin.mainHoTen.ToString()));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paMaNhanVien", frmLogin.manhanvien.ToString()));
            this.rpvXemBaoCaoKhachHang.LocalReport.SetParameters(new ReportParameter("paTenLoai", loai.TenLoai));

            this.rpvXemBaoCaoKhachHang.RefreshReport();
        }

        public void NhomTheoLoai()
        {
            List<LoaiKHDTO> lkhdto = lkhbus.LayLoaiKH();
            this.rpvXemBaoCaoKhachHang.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptKhachHangGroup.rdlc";
            this.rpvXemBaoCaoKhachHang.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.rpvXemBaoCaoKhachHang.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSLoaiKhachHang", lkhdto));


            this.rpvXemBaoCaoKhachHang.RefreshReport();
        }
        void LocalReport_SubreportProcessing(object sender , SubreportProcessingEventArgs e)
        {
            string maloai = e.Parameters["paMaLoai"].Values[0];
            e.DataSources.Add(new ReportDataSource ("DSKhachHang",khbus.LayDSLKH(maloai)));
        }
    }
}
