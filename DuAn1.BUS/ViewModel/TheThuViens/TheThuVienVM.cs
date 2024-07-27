namespace DuAnOne.BUS.ViewModel.TheThuViens
{
    public class TheThuVienVM
    {
        public Guid Id { get; set; }
        public Guid IdChuThe { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string MaThe { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }

        // Thêm các thuộc tính sau nếu cần
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}