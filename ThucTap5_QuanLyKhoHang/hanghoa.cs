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
    public partial class hanghoa : Form
    {
        public hanghoa()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");


        private void LoadData()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, soluong, donvitinh, xuatxu, dongia   FROM hanghoa  WHERE ten LIKE N'%" + texttimten.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dtghanghoa.DataSource = dt;
       
            texttenhang.DataBindings.Clear();
            textSoluong.DataBindings.Clear();
            textDongia.DataBindings.Clear();
            textDOnvitinh.DataBindings.Clear();
            textXuatxu.DataBindings.Clear();
            textMa.DataBindings.Clear();


            texttenhang.DataBindings.Add("Text", dtghanghoa.DataSource, "ten");
            textSoluong.DataBindings.Add("Text", dtghanghoa.DataSource, "soluong");
            textDongia.DataBindings.Add("Text", dtghanghoa.DataSource, "dongia");
            textDOnvitinh.DataBindings.Add("Text", dtghanghoa.DataSource, "donvitinh");
            textXuatxu.DataBindings.Add("Text", dtghanghoa.DataSource, "xuatxu");
            textMa.DataBindings.Add("Text", dtghanghoa.DataSource, "ma");

        }


        public void trangthaidau()
        {
            LoadData();
            texttenhang.ReadOnly = true;
            textSoluong.ReadOnly = true;
            textDongia.ReadOnly = true;
            textDOnvitinh.ReadOnly = true;
            textXuatxu.ReadOnly = true;
            textMa.ReadOnly = true;


            button2Xoa.Enabled = true;
            button1Sua.Enabled = true;
            button4Luu.Enabled = false;
            button3Them.Enabled = true;
            button1.Enabled = false;
            buttonCancel.Enabled = false;
        }

      

        private void hanghoa_Load(object sender, EventArgs e)
        {
            trangthaidau();

        }

        private void texttimten_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3Them_Click(object sender, EventArgs e)
        {
            button2Xoa.Enabled = false;
            button1Sua.Enabled = false;
            button4Luu.Enabled = true;
            button1.Enabled = false;
            texttenhang.ReadOnly = false;
            textSoluong.ReadOnly = false;
            textDongia.ReadOnly = false;
            textDOnvitinh.ReadOnly = false;
            textXuatxu.ReadOnly = false;
            buttonCancel.Enabled = true;

            texttenhang.Clear();
            textSoluong.Enabled = false ;
            textDongia.Clear();
            textDOnvitinh.Clear();
            textXuatxu.Clear();
            textMa.Text = "Them";

        }

        private void button1Sua_Click_1(object sender, EventArgs e)
        {
            button2Xoa.Enabled = false;
            button3Them.Enabled = false;
            button4Luu.Enabled = false;
            button1.Enabled = true;
            buttonCancel.Enabled = true;


            texttenhang.ReadOnly = false;
            textSoluong.Enabled = false; ;
            textDongia.ReadOnly = false;
            textDOnvitinh.ReadOnly = false;
            textXuatxu.ReadOnly = false;
        }

        private void button2Xoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sua = string.Format("delete from hanghoa where ma={0}", textMa.Text);
                SqlCommand cmd = new SqlCommand(sua, con);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    con.Close();
                    trangthaidau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }

        }

        private void button4Luu_Click(object sender, EventArgs e)
        {

            if (texttenhang.TextLength > 0 && textSoluong.TextLength > 0 && textXuatxu.TextLength > 0 && textDOnvitinh.TextLength > 0 && textDongia.TextLength > 0 && textMa.Text == "Them")
            {

                if ((MessageBox.Show("Bạn muốn thêm người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into hanghoa( ten, donvitinh, soluong, xuatxu, dongia) select N'{0}',N'{1}',N'{2}',N'{3}',N'{4}' ";
                    string them = string.Format(chuoisql, texttenhang.Text, textDOnvitinh.Text, Int16.Parse(textSoluong.Text), textXuatxu.Text, Int16.Parse( textDongia.Text));
                    SqlCommand cmd = new SqlCommand(them, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();
                        trangthaidau();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                    trangthaidau();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texttenhang.TextLength > 0 && textSoluong.TextLength > 0 && textXuatxu.TextLength > 0 && textDOnvitinh.TextLength > 0 && textDongia.TextLength > 0 && textMa.Text != "Them")
            {

                if ((MessageBox.Show("Bạn muốn thêm người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = string.Format("update hanghoa set ten =N'{0}', dongia =N'{1}', soluong =N'{2}', donvitinh=N'{3}' , xuatxu=N'{4}' where ma = N'{5}'", texttenhang.Text, Int16.Parse(textDongia.Text), Int16.Parse(textSoluong.Text), textDOnvitinh.Text, textXuatxu.Text,textMa.Text);
                    //string them = string.Format(chuoisql, texttenhang.Text, textDOnvitinh.Text, Int16.Parse(textSoluong.Text), textXuatxu.Text, Int16.Parse(textDongia.Text));
                    SqlCommand cmd = new SqlCommand(chuoisql, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();
                        trangthaidau();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                    trangthaidau();
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            trangthaidau();
        }
    }
}
