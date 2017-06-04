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
    public partial class FormNhapHang : Form
    {


        SqlDataAdapter adap;
        DataSet ds;

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");

        int thanhtien = 0;

        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoHangDataSet.nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.quanLyKhoHangDataSet.nhacungcap);


            adap = new SqlDataAdapter("select ma, ten, soluong, xuatxu, dongia, donvitinh from hanghoa where ma =NULL", con);
            ds = new System.Data.DataSet();

            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["ma"].Visible = false;

            comboBox1.SelectedItem = null;          // no problem
            textBox1Thukhoma.Text = "1";

            maskedTextBox1Thoigian.Text = DateTime.Now.ToString("dd-MM-yyyy  HH:mm");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                 
                        SqlCommandBuilder cmbl = new SqlCommandBuilder(adap);
                        adap.Update(ds);


                        con.Open();
                        //trigger cho bảng  phieunhap
                        string chuoisql = "insert into phieunhap(ten,ngaynhap,nhacungcapma,thukhoma,ghichu) select N'{0}',GETDATE(),N'{1}',N'{2}',N'{3}'";
                        string them = string.Format(chuoisql, textBox1Tenphieu.Text, textBox1Ma.Text, textBox1Thukhoma.Text, textBox2Ghichu.Text);
                        SqlCommand cmd = new SqlCommand(them, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.Close();
                   
                
               
            }
            else
                MessageBox.Show("Bạn chưa nhập đủ hàng hóa hoặc nhà cung cấp");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1Ma.Text = comboBox1.SelectedValue == null ? "" : comboBox1.SelectedValue.ToString();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                thanhtien = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int sl = Convert.ToInt32(dataGridView1.Rows[i].Cells["soluong"].Value.ToString());
                    int dg = Convert.ToInt32(dataGridView1.Rows[i].Cells["dongia"].Value.ToString());

                    thanhtien += sl * dg;
                }
                textBox1Tien.Text = thanhtien.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin hoặc nhập sai định dạng");

            }
        }

        private void dataGridView1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
