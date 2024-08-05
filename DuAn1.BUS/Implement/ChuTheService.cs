using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class ChuTheService : IChuTheService
    {
        private readonly IChuTheRepo _repo;

        public ChuTheService(IChuTheRepo repo)
        {
            _repo = repo;
        }

        public ChuTheVM GetById(Guid id)
        {
            ChuThe entity = _repo.GetById(id);
            ChuTheVM vm = ChuTheMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<ChuTheVM> GetList()
        {
            // Kiểm tra nếu _repo là null
            if (_repo == null)
            {
                throw new InvalidOperationException("Repository chưa được khởi tạo.");
            }

            // Lấy danh sách các thực thể từ repository
            List<ChuThe> entities = _repo.GetList();

            // Kiểm tra nếu entities là null
            if (entities == null)
            {
                // Trả về danh sách rỗng nếu entities là null
                return new List<ChuTheVM>();
            }

            // Ánh xạ các thực thể thành view models
            var vms = entities.Select(e => ChuTheMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(ChuTheCreateVM createVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Tạo thẻ thư viện thành công";
            }
            catch (Exception ex)
            {
                // Log exception
                return $"Lỗi: {ex.Message}";
            }
        }

        public string Update(ChuTheUpdateVM updateVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapUpdateVMToEntity(updateVM);
                bool isSuccess = _repo.Update(entity);
                return isSuccess ? "Cập nhật thẻ thư viện thành công" : "Cập nhật thẻ thư viện không thành công";
            }
            catch (Exception ex)
            {
                // Log exception
                return $"Lỗi: {ex.Message}";
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                bool isSuccess = _repo.Delete(id);
                return isSuccess ? "Xóa thẻ thư viện thành công" : "Xóa thẻ thư viện không thành công";
            }
            catch (Exception ex)
            {
                // Log exception
                return $"Lỗi: {ex.Message}";
            }
        }
    }
}
