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
    public partial class FormThemNhaCC : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");

        public FormThemNhaCC()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDiachi.TextLength > 0 && txtMst.TextLength > 0 && txtSdt.TextLength > 0 && txtTen.TextLength > 0)
            {
                if ((MessageBox.Show("Bạn muốn thêm nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into nhacungcap(phieunhapma, hanghoama,) select N'{0}',N'{1}',N'{2}',N'{3}'";
                    string them = string.Format(chuoisql, txtTen.Text, txtDiachi.Text, txtSdt.Text, txtMst.Text);
                    SqlCommand cmd = new SqlCommand(them, con);




                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {

            this.Close(); 

        }

        private void FormThemNhaCC_Load(object sender, EventArgs e)
        {
           
        }
    }
}
