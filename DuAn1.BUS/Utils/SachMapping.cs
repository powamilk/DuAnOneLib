using DuAnOne.BUS.ViewModel.Sachs;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class SachMapping
    {
        public static Sach MapCreateVMToEntity(SachCreateVM createVM)
        {
            return new Sach
            {
                TenSach = createVM.TenSach,
                NamXuatBan = createVM.NamXuatBan,
                SoLuong = createVM.SoLuong,
                TheLoai = createVM.TheLoai,
                MaSach = createVM.MaSach,
                GiaTien = createVM.GiaTien,
                TacGia = createVM.TacGia,
                Status = createVM.Status,
                CreateBy = createVM.CreateBy,
                CreateTime = createVM.CreateTime
            };
        }

        public static SachVM MapEntityToVM(Sach entity)
        {
            return new SachVM
            {
                Id = entity.Id,
                TenSach = entity.TenSach,
                NamXuatBan = entity.NamXuatBan,
                SoLuong = entity.SoLuong,
                TheLoai = entity.TheLoai,
                MaSach = entity.MaSach,
                GiaTien = entity.GiaTien,
                TacGia = entity.TacGia,
                Status = entity.Status,
                CreateBy = entity.CreateBy,
                CreateTime = entity.CreateTime,
                ModifyBy = entity.ModifyBy,
                ModifyTime = entity.ModifyTime
            };
        }

        public static Sach MapUpdateVMToEntity(SachUpdateVM updateVM)
        {
            return new Sach
            {
                Id = updateVM.Id,
                TenSach = updateVM.TenSach,
                NamXuatBan = updateVM.NamXuatBan ?? default,
                SoLuong = updateVM.SoLuong ?? default,
                TheLoai = updateVM.TheLoai,
                MaSach = updateVM.MaSach,
                GiaTien = updateVM.GiaTien ?? default,
                TacGia = updateVM.TacGia,
                Status = updateVM.Status ?? default,
                ModifyBy = updateVM.ModifyBy,
                ModifyTime = updateVM.ModifyTime,
                DeleteBy = updateVM.DeleteBy,
                DeleteTime = updateVM.DeleteTime
            };
        }
    }
}
