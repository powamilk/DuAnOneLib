using System;
using System.Collections.Generic;

namespace DuAnOne.DAL.Entities
{
    public partial class TaiKhoan
    {
        public Guid IdNhanVien { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public int ChucVu { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual NhanVien IdNhanVienNavigation { get; set; } = null!;
    }
}
