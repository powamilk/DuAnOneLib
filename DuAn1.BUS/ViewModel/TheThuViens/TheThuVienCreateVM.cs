﻿namespace DuAnOne.BUS.ViewModel.TheThuViens
{
    public class TheThuVienCreateVM
    {
        public Guid IdChuThe { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string MaThe { get; set; } = null!;
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
