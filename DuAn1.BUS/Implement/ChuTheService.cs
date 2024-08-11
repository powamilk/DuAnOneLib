using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class ChuTheService : IChuTheService
    {
        private readonly IChuTheRepo _repo;

        public ChuTheService()
        {
            _repo = new ChuTheRepo(new AppDbContext());
        }

        public ChuTheVM GetById(Guid id)
        {
            ChuThe entity = _repo.GetById(id);
            ChuTheVM vm = ChuTheMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<ChuTheVM> GetList()
        {
            List<ChuThe> entities = _repo.GetList();
            List<ChuTheVM> vms = entities.Select(e => ChuTheMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(ChuTheCreateVM createVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Chủ thẻ đã được thêm thành công";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string Update(ChuTheUpdateVM updateVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật thẻ thư viện thành công" : "Cập nhật thẻ thư viện không thành công";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public bool Delete(Guid id)
        {
            return _repo.Delete(id);
        }

        public List<ChuTheVM> GetAll()
        {
            List<ChuThe> entities = _repo.GetAll();
            return entities.Select(e => ChuTheMapping.MapEntityToVM(e)).ToList();
        }
    }
}
