using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.ViewModel.ChiTietPhieuMuon
{
    public class ChiTietPhieuMuonVM
    {
        public Guid IdPhieuMuon { get; set; }
        public Guid IdSach { get; set; }
        public string TenSach { get; set; } = null!;
        public int SoLuongMuon { get; set; }
        public string? GhiChu { get; set; }
        public int Status { get; set; }
    }
}
