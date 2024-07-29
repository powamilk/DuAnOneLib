using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.Sachs;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class SachService : ISachService
    {
        private readonly ISachRepo _repo;

        public SachService()
        {
            _repo = new SachRepo(new AppDbContext());
        }

        public SachVM GetById(Guid id)
        {
            Sach entity = _repo.GetById(id);
            return SachMapping.MapEntityToVM(entity);
        }

        public List<SachVM> GetList()
        {
            List<Sach> entities = _repo.GetList();
            return entities.Select(SachMapping.MapEntityToVM).ToList();
        }

        public string Create(SachCreateVM createVM)
        {
            try
            {
                Sach entity = SachMapping.MapCreateVMToEntity(createVM);
                string result = _repo.Create(entity);
                return result;
            }
            catch (Exception ex)
            {
                return $"Tạo sách thất bại. Lỗi: {ex.Message}";
            }
        }

        public bool Update(SachUpdateVM updateVM)
        {
            if (updateVM == null)
            {
                return false; // Dữ liệu không hợp lệ
            }

            try
            {
                Sach entity = SachMapping.MapUpdateVMToEntity(updateVM);
                string result = _repo.Update(entity);
                return result.Contains("Cập nhật sách thành công");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                string result = _repo.Delete(id);
                return result.Contains("Xóa sách thành công");
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
