using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class ChiTietPhieuMuon
    {
        public Guid IdPhieuMuon { get; set; }
        public Guid IdSach { get; set; }
        public int SoLuongMuon { get; set; }
        public string? GhiChu { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual PhieuMuon IdPhieuMuonNavigation { get; set; } = null!;
        public virtual Sach IdSachNavigation { get; set; } = null!;
    }
}
