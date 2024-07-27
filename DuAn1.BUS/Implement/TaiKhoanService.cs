using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly ITaiKhoanRepo _repo;

        public TaiKhoanService()
        {
            _repo = new TaiKhoanRepo(new AppDbContext());
        }

        public TaiKhoanVM GetById(Guid id)
        {
            TaiKhoan entity = _repo.GetById(id);
            TaiKhoanVM vm = TaiKhoanMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<TaiKhoanVM> GetList()
        {
            List<TaiKhoan> entities = _repo.GetList();
            List<TaiKhoanVM> vms = entities.Select(e => TaiKhoanMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(TaiKhoanCreateVM createVM)
        {
            try
            {
                TaiKhoan entity = TaiKhoanMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Tài khoản đã được tạo thành công.";
            }
            catch (Exception ex)
            {
                return $"Tạo tài khoản thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Update(TaiKhoanUpdateVM updateVM)
        {
            try
            {
                TaiKhoan entity = TaiKhoanMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật tài khoản thành công." : "Cập nhật tài khoản thất bại.";
            }
            catch (Exception ex)
            {
                return $"Cập nhật tài khoản thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                bool result = _repo.Delete(id);
                return result ? "Xóa tài khoản thành công." : "Xóa tài khoản thất bại.";
            }
            catch (Exception ex)
            {
                return $"Xóa tài khoản thất bại. Lỗi: {ex.Message}";
            }
        }
    }
}
