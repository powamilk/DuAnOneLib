namespace DuAnOne.BUS.ViewModel.PhieuMuons
{
    public class PhieuMuonUpdateVM
    {
        public Guid Id { get; set; }
        public Guid? IdChuThe { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public int? Status { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
