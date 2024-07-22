using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class Sach
    {
        public Sach()
        {
            ChiTietPhieuMuons = new HashSet<ChiTietPhieuMuon>();
            TacGiaSaches = new HashSet<TacGiaSach>();
        }

        public Guid Id { get; set; }
        public string TenSach { get; set; } = null!;
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public string? TheLoai { get; set; }
        public string MaSach { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
        public int GiaTien { get; set; }

        public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        public virtual ICollection<TacGiaSach> TacGiaSaches { get; set; }
    }
}
