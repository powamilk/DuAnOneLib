namespace DuAnOne.BUS.ViewModel.Sachs
{
    public class SachCreateVM
    {
        public string TenSach { get; set; } = null!;
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public string? TheLoai { get; set; }
        public string MaSach { get; set; } = null!;
        public double GiaTien { get; set; }
        public string? TacGia { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
