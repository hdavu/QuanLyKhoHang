using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThucTap5_QuanLyKhoHang
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void dangnhap()
        {
            try
            {
                connec.con.Open();
                string sql = "select count(*) from thukho where username=@acc and password=@pass";
                SqlCommand command = new SqlCommand(sql, connec.con);
                command.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    connec.con.Close();
                    (new FormMain(txtTenDangNhap.Text)).ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                    lblIncorrect.Text = "Sai tên tài khoản hoặc mật khẩu";
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();
                    connec.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            lblIncorrect.Text = "";
        }
    }
}
