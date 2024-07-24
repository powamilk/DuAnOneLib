namespace DuAnOne.BUS.ViewModel.ChuThes
{
    public class ChuTheCreateVM
    {
        public string TenChuThe { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? GhiChu { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
