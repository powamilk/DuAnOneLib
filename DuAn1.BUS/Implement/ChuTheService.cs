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
            ChuTheVM vm = MappingExtension.MapEntityToVM(entity);
            return vm;
        }

        public List<ChuTheVM> GetList()
        {
            List<ChuThe> entities = _repo.GetList();
            var vms = entities.Select(e => MappingExtension.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(ChuTheCreateVM createVM)
        {
            throw new NotImplementedException();
        }

        public string Update(ChuTheUpdateVM updateVM)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }



    }
}
