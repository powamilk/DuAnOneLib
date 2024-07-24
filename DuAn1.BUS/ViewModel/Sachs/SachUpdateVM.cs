namespace DuAnOne.BUS.ViewModel.Sachs
{
    public class SachUpdateVM
    {
        public Guid Id { get; set; }
        public string? TenSach { get; set; }
        public int? NamXuatBan { get; set; }
        public int? SoLuong { get; set; }
        public string? TheLoai { get; set; }
        public string? MaSach { get; set; }
        public double? GiaTien { get; set; }
        public string? TacGia { get; set; }
        public int? Status { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
