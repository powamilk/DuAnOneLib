using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class TaiKhoanMapping
    {
        public static TaiKhoan MapCreateVMToEntity(TaiKhoanCreateVM createVM)
        {
            return new TaiKhoan
            {
                HoVaTen = createVM.HoVaTen,
                NgaySinh = createVM.NgaySinh,
                DiaChi = createVM.DiaChi,
                Sdt = createVM.Sdt,
                Email = createVM.Email,
                MaNhanVien = createVM.MaNhanVien,
                TenTaiKhoan = createVM.TenTaiKhoan,
                MatKhau = createVM.MatKhau,
                ChucVu = createVM.ChucVu,
                Status = createVM.Status,
                CreateBy = createVM.CreateBy,
                CreateTime = createVM.CreateTime
            };
        }

        public static TaiKhoanVM MapEntityToVM(TaiKhoan entity)
        {
            return new TaiKhoanVM
            {
                Id = entity.Id,
                HoVaTen = entity.HoVaTen,
                NgaySinh = entity.NgaySinh,
                DiaChi = entity.DiaChi,
                Sdt = entity.Sdt,
                Email = entity.Email,
                MaNhanVien = entity.MaNhanVien,
                TenTaiKhoan = entity.TenTaiKhoan,
                MatKhau = entity.MatKhau,
                ChucVu = entity.ChucVu,
                Status = entity.Status,
                CreateBy = entity.CreateBy,
                CreateTime = entity.CreateTime,
                ModifyBy = entity.ModifyBy,
                ModifyTime = entity.ModifyTime
            };
        }

        public static TaiKhoan MapUpdateVMToEntity(TaiKhoanUpdateVM updateVM)
        {
            return new TaiKhoan
            {
                Id = updateVM.Id,
                HoVaTen = updateVM.HoVaTen ?? string.Empty,
                NgaySinh = updateVM.NgaySinh ?? DateTime.MinValue,
                DiaChi = updateVM.DiaChi ?? string.Empty,
                Sdt = updateVM.Sdt ?? string.Empty,
                Email = updateVM.Email ?? string.Empty,
                MaNhanVien = updateVM.MaNhanVien ?? string.Empty,
                TenTaiKhoan = updateVM.TenTaiKhoan ?? string.Empty,
                MatKhau = updateVM.MatKhau ?? string.Empty,
                ChucVu = updateVM.ChucVu ?? 0,
                Status = updateVM.Status ?? 0,
                ModifyBy = updateVM.ModifyBy,
                ModifyTime = updateVM.ModifyTime,
                DeleteBy = updateVM.DeleteBy,
                DeleteTime = updateVM.DeleteTime
            };
        }
    }
}
