using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class TheThuVien
    {
        public TheThuVien()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        public Guid Id { get; set; }
        public Guid IdChuThe { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string MaThe { get; set; } = null!;
        public int Status { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual ChuThe IdChuTheNavigation { get; set; } = null!;
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
