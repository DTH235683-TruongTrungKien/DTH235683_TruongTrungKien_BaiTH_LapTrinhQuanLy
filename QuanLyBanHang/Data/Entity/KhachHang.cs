using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data.Entity
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string? HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
