using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        public Guid Id { get; set; }
        public string HoVaTen { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MaNhanVien { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual TaiKhoan? TaiKhoan { get; set; }
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
