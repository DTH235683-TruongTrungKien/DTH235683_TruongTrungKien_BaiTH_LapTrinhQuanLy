using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH02.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            var hoadon = context.HoaDon.Find(id);
            if (hoadon != null)
            {
                context.HoaDon.Remove(hoadon);
            }
            context.SaveChanges();
            frmHoaDon_Load(sender, e);


        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable hdTable = new DataTable();
                    DataTable hdctTable = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet hdWorksheet = workbook.Worksheet(1);
                        IXLWorksheet hdctWorkSheet = workbook.Worksheet(2);
                        bool firstRow = true;
                        string readRange = "1:1";
                        // Sheet hóa đơn
                        foreach (IXLRow row in hdWorksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    hdTable.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                hdTable.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    hdTable.Rows[hdTable.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Sheet hóa đơn chi tiết
                        firstRow = true;
                        readRange = "1:1";
                        foreach (IXLRow row in hdctWorkSheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    hdctTable.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                hdctTable.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    hdctTable.Rows[hdctTable.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (hdTable.Rows.Count > 0)
                        {
                            foreach (DataRow r in hdTable.Rows)
                            {
                                var nv = context.NhanVien
                                    .FirstOrDefault(x => x.HoVaTen == r["NhanVien"].ToString());

                                var kh = context.KhachHang
                                    .FirstOrDefault(x => x.HoVaTen == r["KhachHang"].ToString());

                                HoaDon hd = new HoaDon();
                                hd.NhanVienID = nv.ID;
                                hd.KhachHangID = kh.ID;
                                hd.NgayLap = Convert.ToDateTime(r["NgayLap"]);

                                var hdct = hdctTable.AsEnumerable().Where(x => Convert.ToInt32(x["ID"]) == Convert.ToInt32(r["ID"]));

                                foreach (var ct in hdct)
                                {
                                    var sp = context.SanPham
                                        .FirstOrDefault(x => x.TenSanPham == ct["TenSanPham"].ToString());

                                    hd.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                                    {
                                        SanPhamID = sp.ID,
                                        SoLuongBan = Convert.ToInt32(ct["SoLuongBan"]),
                                        DonGiaBan = Convert.ToInt32(ct["DonGiaBan"])
                                    });
                                }

                                context.HoaDon.Add(hd);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + hdTable.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hóa đơn
                    DataTable hdTable = new DataTable();
                    hdTable.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVien", typeof(string)),
                        new DataColumn("KhachHang", typeof(string)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("TongTien", typeof(int)),
                    });
                    var hoaDon = context.HoaDon
                        .Include(x => x.NhanVien)
                        .Include(x => x.KhachHang)
                        .Include(x => x.HoaDon_ChiTiet)
                        .ToList();
                    if (hoaDon != null)
                    {
                        foreach (var p in hoaDon)
                            hdTable.Rows.Add(p.ID, p.NhanVien.HoVaTen, p.KhachHang.HoVaTen, p.NgayLap, Convert.ToInt32(p.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan)));
                    }

                    // Hóa đơn chi tiết
                    DataTable hdctTable = new DataTable();
                    hdctTable.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenSanPham", typeof(string)),
                        new DataColumn("SoLuongBan", typeof(int)),
                        new DataColumn("DonGiaBan", typeof(int)),
                        new DataColumn("ThanhTien", typeof(int)),
                    });
                    var hoaDonChiTiet = context.HoaDon_ChiTiet.Include(x => x.SanPham).ToList();
                    if (hoaDonChiTiet != null)
                    {
                        foreach (var p in hoaDonChiTiet)
                            hdctTable.Rows.Add(p.ID, p.SanPham.TenSanPham, p.SoLuongBan, p.DonGiaBan, Convert.ToInt32(p.SoLuongBan * p.DonGiaBan));
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(hdTable, "HoaDon");
                        var sheet2 = wb.Worksheets.Add(hdctTable, "HoaDonChiTiet");
                        sheet1.Columns().AdjustToContents();
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
