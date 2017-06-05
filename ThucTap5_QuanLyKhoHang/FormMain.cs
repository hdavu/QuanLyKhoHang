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

namespace ThucTap5_QuanLyKhoHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
        }
<<<<<<< HEAD
        SqlConnection con;
        string strSql = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa";

        private void hien(string strSql)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            hien(strSql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDonvitinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtXuatxu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void cboTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboTimkiem.Text == "Tên hàng hóa")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE ten LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Đơn vị tính")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE donvitinh LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Số lượng")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE soluong LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Xuất xứ")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE xuatxu LIKE N'%" + txtTimkiem.Text + "%'";
            else
                str = strSql;
            hien(str);
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboTimkiem.Text == "Tên hàng hóa")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE ten LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Đơn vị tính")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE donvitinh LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Số lượng")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE soluong LIKE N'%" + txtTimkiem.Text + "%'";
            else if (cboTimkiem.Text == "Xuất xứ")
                str = "select ma as [Mã], ten as [Tên hàng hóa], donvitinh as [Đơn vị tính], soluong as [Số lượng], xuatxu as [Xuất xứ] from hanghoa WHERE xuatxu LIKE N'%" + txtTimkiem.Text + "%'";
            else
                str = strSql;
            hien(str);
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

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXH.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNH.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLS.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTT.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHD.ShowDialog();
        }

=======
>>>>>>> parent of 511bf4c... bản chuẩn
    }
}
