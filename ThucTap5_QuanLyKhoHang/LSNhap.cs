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
    public partial class LSNhap : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");

        public LSNhap()
        {
            InitializeComponent();
        }

        private void LoadDonHangNhap()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT pn.ma, pn.ten, pn.ngaynhap, ncc.ten FROM phieunhap pn INNER JOIN nhacungcap ncc ON pn.nhacungcapma = ncc.ma  WHERE pn.ten LIKE N'%" + textBox1.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ma"].Visible = false;
            textBox2.DataBindings.Clear();

            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "ma");

           

        }


        private void LoadDataChiTiet()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  hh.ten,hh.xuatxu ,ctpn.soluong, hh.dongia  FROM chitietphieunhap ctpn JOIN hanghoa hh  ON ctpn.hanghoama = hh.ma WHERE ctpn.phieunhapma = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView2.DataSource = dt;




        }



        private void tinhtien()
        {
            int thanhtien = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                int sl = Convert.ToInt32(dataGridView2.Rows[i].Cells["soluong"].Value.ToString());
                int dg = Convert.ToInt32(dataGridView2.Rows[i].Cells["dongia"].Value.ToString());

                thanhtien += sl * dg;
            }
            textBox3.Text = thanhtien.ToString();
        }

        private void LSXuat_Load(object sender, EventArgs e)
        {
            LoadDonHangNhap();
            LoadDataChiTiet();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadDataChiTiet();
            tinhtien();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDonHangNhap();
        }
    }
}
