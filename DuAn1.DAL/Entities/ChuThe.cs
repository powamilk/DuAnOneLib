using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class ChuThe
    {
        public ChuThe()
        {
            TheThuViens = new HashSet<TheThuVien>();
        }

        public Guid Id { get; set; }
        public string Cccd { get; set; } = null!;
        public string HoVaTen { get; set; } = null!;
        public int LoaiThe { get; set; }
        public string DiaChi { get; set; } = null!;
        public int GioiTinh { get; set; }
        public string NgheNghiep { get; set; } = null!;
        public string QuocTich { get; set; } = null!;
        public int LoaiBanDoc { get; set; }
        public string Email { get; set; } = null!;
        public string NoiLamViec { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual ICollection<TheThuVien> TheThuViens { get; set; }
    }
}
