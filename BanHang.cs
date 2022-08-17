using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBanHang : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        BanHangBUS bhBUS = new BanHangBUS();
        HoaDonBUS hdbus = new HoaDonBUS();

        int macthd = 3;

        public frmBanHang()
        {
            InitializeComponent();
            txtTienNhan.Enabled = false;
        }

        public static int LaySoDongChiTietHoaDon()
        {
            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmdd = new SqlCommand("SELECT count(*) FROM CHITIET_HOADON", con);
            con.Open();
            int kq = (int)cmdd.ExecuteScalar();
            con.Close();

            return kq + 1;
        }
        public static int LayGiaTriDongCuoiCungMACTHD()
        {
            
            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmdd = new SqlCommand("SELECT TOP 1 MACTHD FROM CHITIET_HOADON ORDER BY MACTHD DESC", con);
            con.Open();
            int kq = (int)cmdd.ExecuteNonQuery();
            con.Close();

            return kq;
        }
        private void CapNhatControl()
        {
            cboTenSP.SelectedIndex = 0;
            numSanPham.Value = 1;
            txtTienNhan.Text = string.Empty;
            txtTienNhan.Enabled = false;
            txtTongThanhTienBH.Text = string.Empty;
            txtTraLaiBH.Text = string.Empty;
            dgvBH.Rows.Clear();
        }

        private void btnBHThanhToan_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTienNhan.Text))
            {
                MessageBox.Show(HardCode.NhapThieu, HardCode.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal khachtra = Convert.ToDecimal(txtTienNhan.Text);
            decimal thanhtien = decimal.Parse(txtTongThanhTienBH.Text);
            decimal tralai = decimal.Parse(txtTraLaiBH.Text);
            int kq = 0;

            hdbus.ThemHD(frmLogin.manhanvien, khachtra, thanhtien, tralai);
            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            for (int i = 0; i < dgvBH.Rows.Count - 1; i++)
            {

                SqlConnection conn = new SqlConnection(constr);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ThemChiTietHoaDon";
                    cmd.Parameters.AddWithValue("@mahd", "HD" + LaySoDongChiTietHoaDon());
                    cmd.Parameters.AddWithValue("@mats", dgvBH.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@tensp", dgvBH.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@soluong", dgvBH.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@dongia", dgvBH.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@macthd", macthd);

                    cmd.Connection = conn;

                    kq = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            macthd++;
            if (kq != 0)
            {
                MessageBox.Show(HardCode.ThanhToanThanhCong,HardCode.CanhBao,MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                CapNhatControl();
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cboTenSP.DataSource = sanPhamBUS.LayDSSP();
            cboTenSP.DisplayMember = "TRASUA_TEN";
            cboTenSP.ValueMember = "TRASUA_MATS";
        }


        private void btnBHThem_Click(object sender, EventArgs e)
        {
            txtTienNhan.Enabled = true;


            DataGridViewRow row = (DataGridViewRow)dgvBH.Rows[0].Clone();

            string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmdd = new SqlCommand("SELECT TRASUA_GIA as giatien , TRASUA_MATS as mats FROM TRASUA WHERE TRASUA_TEN = @tentrasua",con); //Your SQL Query here
            cmdd.Parameters.AddWithValue("@tentrasua", cboTenSP.Text);
            con.Open();
            cmdd.ExecuteNonQuery();
            SqlDataReader dr = cmdd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    row.Cells[0].Value = dr["mats"].ToString();
                    row.Cells[1].Value = cboTenSP.Text;
                    row.Cells[2].Value = numSanPham.Value;
                    row.Cells[3].Value = dr["giatien"].ToString();
                    dgvBH.Rows.Add(row);
                }
            }
            con.Close();
        }

        private void txtTongThanhTienBH_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ThanhTien()
        {
            double thanhtiendgv = 0;
            double thanhtien = 0;
            int sc = dgvBH.Rows.Count;

            for (int i = 0; i < sc - 1; i++)
            {
                thanhtiendgv = double.Parse(dgvBH.Rows[i].Cells[2].Value.ToString()) * double.Parse(dgvBH.Rows[i].Cells[3].Value.ToString());

                dgvBH.Rows[i].Cells[4].Value = thanhtiendgv;

                thanhtien += thanhtiendgv;
                txtTongThanhTienBH.Text = thanhtien.ToString();
            }
        }
        private void dgvBH_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ThanhTien();
            
        }

        private void btnBHXoa_Click(object sender, EventArgs e)
        {
            int sc = dgvBH.Rows.Count;

            foreach (DataGridViewRow item in this.dgvBH.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dgvBH.Rows.Remove(item);
                    for (int i = 0; i < sc - 1; i++)
                    {
                        ThanhTien();
                    }
                }
                else
                {
                    txtTongThanhTienBH.Text = "0";
                    dgvBH.Rows.Clear();

                }
            }
            if (dgvBH.Rows[0].Cells[0].Value == null)
            {
                txtTienNhan.Enabled = false;
            }
            else
            {
                txtTienNhan.Enabled = true;
            }
        }
        private void dgvBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvBH.Rows[e.RowIndex].Cells[1].Value == null)
                {
                   
                    return;
                }
                else
                {
                    cboTenSP.Text = dgvBH.Rows[e.RowIndex].Cells[1].Value.ToString();
                    numSanPham.Value = decimal.Parse(dgvBH.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }
        }

        private void frmBanHang_Click(object sender, EventArgs e)
        {
            CapNhatControl();
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            double tienthua = 0;
            if (!string.IsNullOrEmpty(txtTienNhan.Text))
            {
                
                double so1 = Convert.ToDouble(txtTongThanhTienBH.Text);
                double so2 = Convert.ToDouble(txtTienNhan.Text);
                if (so2 < so1)
                {
                    btnBHThanhToan.Enabled = false;
                }
                else
                {
                    tienthua = Math.Abs( so1 - so2 );
                    btnBHThanhToan.Enabled = true;
                }
            }
            else
            {
                txtTraLaiBH.Text = string.Empty;
                return;
            }

            txtTraLaiBH.Text = tienthua.ToString();
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
