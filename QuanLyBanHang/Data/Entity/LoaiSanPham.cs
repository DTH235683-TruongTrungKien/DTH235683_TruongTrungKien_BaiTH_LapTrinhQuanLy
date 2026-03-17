using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data.Entity
{
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string? TenLoai { get; set; }
        public virtual ObservableCollectionListSource<SanPham> SanPhams { get; } = new();

    }
}
