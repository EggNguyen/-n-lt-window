using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dtpDenNgay.Value = DateTime.Now;
            dtpTuNgay.Value = DateTime.Now;
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show(HardCode.KhongTheLonHonNgayHienTai, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDenNgay.Value = DateTime.Now;
                dtpTuNgay.Value = DateTime.Now;
                return;
            }

            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show(HardCode.KhongTheLonHonNgayHienTai, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDenNgay.Value = DateTime.Now;
                dtpTuNgay.Value = DateTime.Now;
                return;
            }

            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection conn = new SqlConnection(constr);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ThongKeDoanhThuTheoNgay";
                cmd.Parameters.AddWithValue("@ngay1", dtpTuNgay.Value);
                cmd.Parameters.AddWithValue("@ngay2", dtpDenNgay.Value);

                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvThongKe.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int sc = dgvThongKe.Rows.Count;
            double thanhtien = 0;
            int sohoadon = sc;
            //if (dgvThongKe.Rows[0].Cells[0].Value == null)
            //{
            //    lblTongTien.Text = "0 " + " VNĐ";
            //    lblSoHoaDon.Text = "0";
            //    return;
            //}
            for (int i = 0; i < sc; i++)
            {
                thanhtien += double.Parse(dgvThongKe.Rows[i].Cells[3].Value.ToString());
            }
            lblTongTien.Text = thanhtien.ToString("#,#### VNĐ");
            lblSoHoaDon.Text = sc.ToString();
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0)
            {
                MessageBox.Show(HardCode.KhongTheIn,HardCode.CanhBao,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            frmXemThongKe fxemthongke = new frmXemThongKe();
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã HĐ", Type.GetType("System.String"));
            dt.Columns.Add("Ngày Lập", Type.GetType("System.DateTime"));
            dt.Columns.Add("Tiền Nhận", Type.GetType("System.Double"));
            dt.Columns.Add("Thành Tiền", Type.GetType("System.Double"));
            dt.Columns.Add("Trả Lại", Type.GetType("System.Double"));
            dt.Columns.Add("Mã NV", Type.GetType("System.String"));

            foreach (DataGridViewRow dgv in dgvThongKe.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
            }
            rptThongKe rpt = new rptThongKe();
            rpt.SetDataSource(dt);
            rpt.SetParameterValue("paTuNgay", dtpTuNgay.Value);
            rpt.SetParameterValue("paDenNgay", dtpDenNgay.Value);
            rpt.SetParameterValue("paTongDoanhThu",lblTongTien.Text);
            rpt.SetParameterValue("paSoHoaDon", lblSoHoaDon.Text);
            rpt.SetParameterValue("paNgayLap", DateTime.Now);
            rpt.SetParameterValue("paNguoiLap",frmLogin.mainHoTen);

            fxemthongke.crvThongKe.ReportSource = rpt;
            fxemthongke.ShowDialog();
        }
    }
}
