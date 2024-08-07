using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.ViewModel.ChiTietPhieuMuon
{
    public class ChiTietPhieuMuonUpdateVM
    {
        public Guid IdPhieuMuon { get; set; }
        public Guid IdSach { get; set; }
        public int SoLuongMuon { get; set; }
        public string? GhiChu { get; set; }
        public int Status { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
