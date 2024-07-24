using DuAnOne.BUS.ViewModel.Sachs;

namespace DuAnOne.BUS.Interface
{
    public interface ISachService
    {
        SachVM GetById(Guid id);
        List<SachVM> GetList();
        string Create(SachCreateVM createVM);
        bool Update(SachUpdateVM updateVM);
        bool Delete(Guid id);
    }
}
