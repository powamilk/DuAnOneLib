using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class ChuTheMapping
    {
        public static ChuThe MapCreateVMToEntity(ChuTheCreateVM createVM)
        {
            return new ChuThe
            {
                Cccd = createVM.Cccd,
                HoVaTen = createVM.HoVaTen,
                LoaiThe = createVM.LoaiThe,
                DiaChi = createVM.DiaChi,
                GioiTinh = createVM.GioiTinh,
                NgheNghiep = createVM.NgheNghiep,
                QuocTich = createVM.QuocTich,
                LoaiBanDoc = createVM.LoaiBanDoc,
                Email = createVM.Email,
                NoiLamViec = createVM.NoiLamViec,
                Status = createVM.Status,
                CreateBy = createVM.CreateBy,
                CreateTime = createVM.CreateTime
            };
        }

        public static ChuTheVM MapEntityToVM(ChuThe entity)
        {
            return new ChuTheVM
            {
                Id = entity.Id,
                Cccd = entity.Cccd,
                HoVaTen = entity.HoVaTen,
                LoaiThe = entity.LoaiThe,
                DiaChi = entity.DiaChi,
                GioiTinh = entity.GioiTinh,
                NgheNghiep = entity.NgheNghiep,
                QuocTich = entity.QuocTich,
                LoaiBanDoc = entity.LoaiBanDoc,
                Email = entity.Email,
                NoiLamViec = entity.NoiLamViec,
                Status = entity.Status
            };
        }

        public static ChuThe MapUpdateVMToEntity(ChuTheUpdateVM updateVM)
        {
            return new ChuThe
            {
                Id = updateVM.Id,
                Cccd = updateVM.Cccd,
                HoVaTen = updateVM.HoVaTen,
                LoaiThe = updateVM.LoaiThe,
                DiaChi = updateVM.DiaChi,
                GioiTinh = updateVM.GioiTinh,
                NgheNghiep = updateVM.NgheNghiep,
                QuocTich = updateVM.QuocTich,
                LoaiBanDoc = updateVM.LoaiBanDoc,
                Email = updateVM.Email,
                NoiLamViec = updateVM.NoiLamViec,
                Status = updateVM.Status,
                ModifyBy = updateVM.ModifyBy,
                ModifyTime = updateVM.ModifyTime,
                DeleteBy = updateVM.DeleteBy,
                DeleteTime = updateVM.DeleteTime
            };
        }
    }
}
