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
    public partial class FormSuaXoaNhaCC : Form
    {
        public FormSuaXoaNhaCC()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
        DataSet ds = new DataSet();



        private void trangthaidau()
        {
            LoadData();
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtTim.ReadOnly = false;
            txtMa.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtMst.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtTen.ReadOnly = true;         
        }


       





        private void LoadData() //hien hti du lieu len cac o textbox
        {

           


            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, diachi, sdt, masothue FROM nhacungcap WHERE ten LIKE N'%" + txtTim.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtg.DataSource = dt;

           
            dtg.Columns["ma"].HeaderText = "Mã";

            //xoa trang cac o textbox
            txtDiachi.DataBindings.Clear();
            txtMst.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtMa.DataBindings.Clear();

            //hine thi du lieu len
            txtDiachi.DataBindings.Add("Text", dtg.DataSource, "diachi");
            txtMst.DataBindings.Add("Text", dtg.DataSource, "masothue");
            txtSdt.DataBindings.Add("Text", dtg.DataSource, "sdt");
            txtTen.DataBindings.Add("Text", dtg.DataSource, "ten");
            txtMa.DataBindings.Add("Text", dtg.DataSource, "ma");

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormSuaXoaNhaCC_Load(object sender, EventArgs e)
        {
            trangthaidau();
        }


        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, diachi, sdt, masothue FROM nhacungcap WHERE ten LIKE N'%" + txtTim.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtg.DataSource = dt;
            LoadData();
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDiachi.ReadOnly = false;
            txtMst.ReadOnly = false;
            txtSdt.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtTim.ReadOnly = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }




        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiachi.TextLength > 0 && txtMst.TextLength > 0 && txtSdt.TextLength > 0 && txtTen.TextLength > 0)
            {
                if (MessageBox.Show("Bạn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                    con.Open();
                    string sua = string.Format("update nhacungcap set ten=N'{0}', diachi =N'{1}', sdt=N'{2}' , masothue=N'{3}' WHERE ma =N'{4}'  ", txtTen.Text, txtDiachi.Text, txtSdt.Text, txtMst.Text,txtMa.Text);
                    SqlCommand cmd = new SqlCommand(sua, con);

                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sua = string.Format("delete from nhacungcap where ma={0}", txtMa.Text);
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
    }
}
