using BTTH02.Forms;
using System;
using QuanLyBanHang.Forms;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLoaiSanPham());
            //Application.Run(new frmHangSanXuat());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmNhanVien());
            //Application.Run(new frmSanPham());
            //Application.Run(new frmHoaDon());
            Application.Run(new frmMain());

        }
    }
}