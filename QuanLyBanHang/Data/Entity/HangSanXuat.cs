using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data.Entity
{
    public class HangSanXuat
    {
        public int ID { get; set; }
        public string? TenHangSanXuat {  get; set; }
        public virtual ObservableCollectionListSource<SanPham> SanPhams { get; set; } = new();
    }
}
