using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class TheThuVienService : ITheThuVienService
    {
        private readonly ITheThuVienRepo _repo;

        public TheThuVienService()
        {
            _repo = new TheThuVienRepo(new AppDbContext());
        }

        public TheThuVienVM GetById(Guid id)
        {
            TheThuVien entity = _repo.GetById(id);
            return TheThuVienMapping.MapEntityToVM(entity);
        }

        public List<TheThuVienVM> GetList()
        {
            List<TheThuVien> entities = _repo.GetList();
            return entities.Select(TheThuVienMapping.MapEntityToVM).ToList();
        }

        public string Create(TheThuVienCreateVM createVM)
        {
            try
            {
                TheThuVien entity = TheThuVienMapping.MapCreateVMToEntity(createVM);
                bool result = _repo.Create(entity);
                return result ? "Tạo thẻ thư viện thành công." : "Tạo thẻ thư viện thất bại.";
            }
            catch (Exception ex)
            {
                return $"Tạo thẻ thư viện thất bại. Lỗi: {ex.Message}";
            }
        }

        public bool Update(TheThuVienUpdateVM updateVM)
        {
            if (updateVM == null)
            {
                return false; // Dữ liệu không hợp lệ
            }

            try
            {
                TheThuVien entity = TheThuVienMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                bool result = _repo.Delete(id);
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
