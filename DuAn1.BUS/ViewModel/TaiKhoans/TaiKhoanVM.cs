namespace DuAnOne.BUS.ViewModel.TaiKhoans
{
    public class TaiKhoanVM
    {
        public Guid Id { get; set; }
        public string HoVaTen { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MaNhanVien { get; set; } = null!;
        public string TenTaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public int ChucVu { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
