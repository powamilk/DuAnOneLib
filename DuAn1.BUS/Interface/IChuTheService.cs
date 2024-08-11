using DuAnOne.BUS.ViewModel.ChuThes;

namespace DuAnOne.BUS.Interface
{
    public interface IChuTheService
    {
        ChuTheVM GetById(Guid id);
        List<ChuTheVM> GetList();
        string Create(ChuTheCreateVM createVM);
        string Update(ChuTheUpdateVM updateVM);
        bool Delete(Guid id);
        List<ChuTheVM> GetAll();

    }
}
