using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThucTap5_QuanLyKhoHang
{
    static class connec
    {
        static string CoString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True;User ID=sa;Connect Timeout=200";
        public static SqlConnection con = new SqlConnection(CoString);
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

