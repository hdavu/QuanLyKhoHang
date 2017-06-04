using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTap5_QuanLyKhoHang
{
    public partial class FormMain : Form
    {


        FormThemNhaCC frmTNCC = new FormThemNhaCC();
        FormSuaXoaNhaCC frmSXNCC = new FormSuaXoaNhaCC();
        FormThemNhaNH frmTNNH = new FormThemNhaNH();
        FormSuaXoaNhaNH frmSXNHH = new FormSuaXoaNhaNH();
        FormXuatHang frmXH = new FormXuatHang();
        FormNhapHang frmNH = new FormNhapHang();
        FormLichSu frmLS = new FormLichSu();
        FormThongTin frmTT = new FormThongTin();
        FormHuongDan frmHD = new FormHuongDan();
        FormNhapHangDC frmNHDC = new FormNhapHangDC();
        hanghoa frmhanghoa = new hanghoa();
        LSNhap frmLichSuNhap = new LSNhap();
        LSXuat frmLichSuXuat = new LSXuat();
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string str)
        {
            InitializeComponent();
            lblAcc.Text = str;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTNCC.ShowDialog();
        }

        private void sửaXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSXNCC.ShowDialog();
        }

        private void thêmNhàNhậnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTNNH.ShowDialog();
        }

        private void sửaXÓaNhàNhậnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSXNHH.ShowDialog();
        }

        
      

       

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTT.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHD.ShowDialog();
        }

        private void mớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNH.ShowDialog();
        }

        private void đãCóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNHDC.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXH.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhanghoa.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNHDC.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLichSuNhap.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLichSuXuat.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            connec.con.Open();
            string st = "select * from thukho where username=@acc";
            SqlCommand cmd = new SqlCommand(st, connec.con);
            cmd.Parameters.Add(new SqlParameter("@acc", lblAcc.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ta = new DataTable();
            da.Fill(ta);
            da.Dispose();
            dgvHangton.DataSource = ta;
            connec.con.Close();
            lblTennguoidung.Text = "Xin chào, " + dgvHangton.Rows[0].Cells[3].Value.ToString();
            loadHang();
        }
        private void loadHang()
        {
            connec.con.Open();
            string sql = "select ma as 'Mã',ten as 'Tên SP',donvitinh as 'Đơn vị tính',soluong as 'Số lượng',xuatxu as 'Xuất xứ' from hanghoa";
            DataTable tb = new DataTable();
            new SqlDataAdapter(new SqlCommand(sql, connec.con)).Fill(tb);
            dgvHangton.DataSource = tb;
            connec.con.Close();
        }

        private void txtTenThuKho_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connec.con.Open();
                string timkiem = "select ma as 'Mã',ten as 'Tên SP',donvitinh as 'Đơn vị tính',soluong as 'Số lượng',xuatxu as 'Xuất xứ' from hanghoa where ma like '%" + txtTenThuKho.Text + "%' or ten like N'%" + txtTenThuKho.Text + "%' or donvitinh like '%" + txtTenThuKho.Text + "%' or soluong like '%" + txtTenThuKho.Text + "%' or xuatxu like N'%" + txtTenThuKho.Text + "%'";
                DataTable tbb = new DataTable();
                new SqlDataAdapter(new SqlCommand(timkiem, connec.con)).Fill(tbb);
                dgvHangton.DataSource = tbb;
                connec.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connec.con.Close();
            }
        }
    }
}
