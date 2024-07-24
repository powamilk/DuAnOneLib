namespace DuAnOne.BUS.ViewModel.TheThuViens
{
    public class TheThuVienUpdateVM
    {
        public Guid Id { get; set; }
        public Guid? IdChuThe { get; set; }
        public DateTime? NgayCap { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string? MaThe { get; set; }
        public int? Status { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
