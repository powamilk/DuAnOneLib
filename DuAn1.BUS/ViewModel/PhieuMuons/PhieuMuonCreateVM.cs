namespace DuAnOne.BUS.ViewModel.PhieuMuons
{
    public class PhieuMuonCreateVM
    {
        public Guid IdTaiKhoan { get; set; }
        public Guid IdThe { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
