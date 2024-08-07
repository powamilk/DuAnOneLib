using DuAnOne.BUS.ViewModel.PhieuMuons;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class PhieuMuonMapping
    {
        public static PhieuMuon MapCreateVMToEntity(PhieuMuonCreateVM createVM)
        {
            return new PhieuMuon
            {
                IdTaiKhoan = createVM.IdTaiKhoan ?? Guid.Empty, // Cung cấp giá trị Guid.Empty nếu null
                IdThe = createVM.IdThe ?? Guid.Empty,           // Cung cấp giá trị Guid.Empty nếu null
                NgayMuon = createVM.NgayMuon ?? DateTime.MinValue, // Cung cấp giá trị mặc định nếu null
                NgayTra = createVM.NgayTra ?? DateTime.MinValue,   // Cung cấp giá trị mặc định nếu null
                Status = createVM.Status ?? 0, // Cung cấp giá trị mặc định nếu null
                CreateBy = createVM.CreateBy,
                CreateTime = createVM.CreateTime
            };
        }

        public static PhieuMuonVM MapEntityToVM(PhieuMuon entity)
        {
            return new PhieuMuonVM
            {
                Id = entity.Id,
                IdTaiKhoan = entity.IdTaiKhoan,
                IdThe = entity.IdThe,
                NgayMuon = entity.NgayMuon,
                NgayTra = entity.NgayTra,
                NgayTraThucTe = entity.NgayTraThucTe,
                MaPhieu = entity.MaPhieu,
                Status = entity.Status,
                CreateBy = entity.CreateBy,
                CreateTime = entity.CreateTime,
                ModifyBy = entity.ModifyBy,
                ModifyTime = entity.ModifyTime,
                DeleteBy = entity.DeleteBy,
                DeleteTime = entity.DeleteTime
            };
        }

        public static PhieuMuon MapUpdateVMToEntity(PhieuMuonUpdateVM updateVM)
        {
            return new PhieuMuon
            {
                Id = updateVM.Id,
                IdTaiKhoan = updateVM.IdTaiKhoan ?? Guid.Empty,
                IdThe = updateVM.IdThe ?? Guid.Empty,
                NgayMuon = updateVM.NgayMuon ?? default(DateTime),
                NgayTra = updateVM.NgayTra ?? default(DateTime),
                NgayTraThucTe = updateVM.NgayTraThucTe,
                MaPhieu = updateVM.MaPhieu ?? string.Empty,
                Status = updateVM.Status ?? default(int),
                ModifyBy = updateVM.ModifyBy ?? Guid.Empty,
                ModifyTime = updateVM.ModifyTime ?? default(DateTime),
                DeleteBy = updateVM.DeleteBy ?? Guid.Empty,
                DeleteTime = updateVM.DeleteTime ?? default(DateTime)
            };
        }
    }
}
