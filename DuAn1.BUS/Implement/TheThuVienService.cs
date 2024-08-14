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
                _repo.Create(entity);
                return "Tạo thẻ thư viện thành công.";
            }
            catch (Exception ex)
            {
                return $"Tạo thẻ thư viện thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Update(TheThuVienUpdateVM updateVM)
        {
            try
            {
                TheThuVien entity = TheThuVienMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật thẻ thư viện thành công" : "Cập nhật thẻ thư viện thất bại.";
            }
            catch (Exception ex)
            {
                return $"Cập nhật thẻ thư viện thất bại. Lỗi: {ex.Message}";
            }
        }

        public bool Delete(Guid id)
        {
           return _repo.Delete(id); 
        }

        public List<TheThuVienVM> GetAll()
        {
            List<TheThuVien> entities = _repo.GetAll();
            return entities.Select(e => TheThuVienMapping.MapEntityToVM(e)).ToList();   
        }

        public List<TheThuVien> GetIdTheList()
        {
            return _repo.GetAll(); // Lấy danh sách thẻ thư viện từ repository
        }
    }
}
