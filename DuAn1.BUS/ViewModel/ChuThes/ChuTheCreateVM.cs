namespace DuAnOne.BUS.ViewModel.ChuThes
{
    public class ChuTheCreateVM
    {
        public string Cccd { get; set; } = null!;
        public string HoVaTen { get; set; } = null!;
        public int LoaiThe { get; set; }
        public string DiaChi { get; set; } = null!;
        public int GioiTinh { get; set; }
        public string NgheNghiep { get; set; } = null!;
        public int QuocTich { get; set; }
        public int LoaiBanDoc { get; set; }
        public string Email { get; set; } = null!;
        public string NoiLamViec { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
