using DuAnOne.BUS.ViewModel.ChiTietPhieuMuon;
using DuAnOne.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils
{
    public static class ChiTietPhieuMuonMapping
    {
        public static ChiTietPhieuMuon MapCreateVMToEntity(ChiTietPhieuMuonCreateVM createVM)
        {
            return new ChiTietPhieuMuon
            {
                IdPhieuMuon = createVM.IdPhieuMuon,
                IdSach = createVM.IdSach,
                SoLuongMuon = createVM.SoLuongMuon,
                GhiChu = createVM.GhiChu,
                Status = createVM.Status,
            };
        }

        public static ChiTietPhieuMuon MapUpdateVMToEntity(ChiTietPhieuMuonUpdateVM updateVM)
        {
            return new ChiTietPhieuMuon
            {
                IdPhieuMuon = updateVM.IdPhieuMuon,
                IdSach = updateVM.IdSach,
                SoLuongMuon = updateVM.SoLuongMuon,
                GhiChu = updateVM.GhiChu,
                Status = updateVM.Status,
                ModifyBy = updateVM.ModifyBy,
                ModifyTime = updateVM.ModifyTime,
                DeleteBy = updateVM.DeleteBy,
                DeleteTime = updateVM.DeleteTime
            };
        }

        public static ChiTietPhieuMuonVM MapEntityToVM(ChiTietPhieuMuon entity)
        {
            return new ChiTietPhieuMuonVM
            {
                IdPhieuMuon = entity.IdPhieuMuon,
                IdSach = entity.IdSach,
                TenSach = entity.IdSachNavigation?.TenSach ?? "Unknown", // Lấy thông tin từ liên kết với Sach entity
                SoLuongMuon = entity.SoLuongMuon,
                GhiChu = entity.GhiChu,
                Status = entity.Status
            };
        }
    }
}
