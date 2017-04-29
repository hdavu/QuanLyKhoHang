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

        public FormMain()
        {
            InitializeComponent();
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
    }
}
