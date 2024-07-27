using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class TheThuVienMapping
    {
        public static TheThuVien MapCreateVMToEntity(TheThuVienCreateVM createVM)
        {
            return new TheThuVien
            {
                IdChuThe = createVM.IdChuThe,
                NgayCap = createVM.NgayCap,
                NgayHetHan = createVM.NgayHetHan,
                MaThe = createVM.MaThe,
                Status = createVM.Status,
                CreateBy = createVM.CreateBy,
                CreateTime = createVM.CreateTime
            };
        }

        public static TheThuVienVM MapEntityToVM(TheThuVien entity)
        {
            return new TheThuVienVM
            {
                Id = entity.Id,
                IdChuThe = entity.IdChuThe,
                NgayCap = entity.NgayCap,
                NgayHetHan = entity.NgayHetHan,
                MaThe = entity.MaThe,
                Status = entity.Status,
                CreateBy = entity.CreateBy,
                CreateTime = entity.CreateTime,
                ModifyBy = entity.ModifyBy,
                ModifyTime = entity.ModifyTime
                // Loại bỏ các thuộc tính DeleteBy và DeleteTime
            };
        }

        public static TheThuVien MapUpdateVMToEntity(TheThuVienUpdateVM updateVM)
        {
            return new TheThuVien
            {
                Id = updateVM.Id,
                IdChuThe = updateVM.IdChuThe ?? default,
                NgayCap = updateVM.NgayCap ?? default,
                NgayHetHan = updateVM.NgayHetHan ?? default,
                MaThe = updateVM.MaThe,
                Status = updateVM.Status ?? default,
                ModifyBy = updateVM.ModifyBy,
                ModifyTime = updateVM.ModifyTime,
                DeleteBy = updateVM.DeleteBy,
                DeleteTime = updateVM.DeleteTime
            };
        }
    }
}
