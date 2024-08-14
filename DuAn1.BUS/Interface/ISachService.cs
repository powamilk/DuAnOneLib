using DuAnOne.BUS.ViewModel.Sachs;

namespace DuAnOne.BUS.Interface
{
    public interface ISachService
    {
        SachVM GetById(Guid id);
        List<SachVM> GetList();
        string Create(SachCreateVM createVM);
        string Update(SachUpdateVM updateVM);
        bool Delete(Guid id);
        string GetMaSachById(Guid id);
    }
}
