﻿namespace DuAnOne.DAL.Entities
{
    public partial class PhieuMuon
    {
        public PhieuMuon()
        {
            ChiTietPhieuMuons = new HashSet<ChiTietPhieuMuon>();
        }

        public Guid Id { get; set; }
        public Guid IdTaiKhoan { get; set; }
        public Guid IdThe { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime? NgayTraThucTe { get; set; }
        public string MaPhieu { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual TaiKhoan IdTaiKhoanNavigation { get; set; } = null!;
        public virtual TheThuVien IdTheNavigation { get; set; } = null!;
        public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}
