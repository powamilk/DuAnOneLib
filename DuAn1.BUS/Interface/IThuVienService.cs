using DuAnOne.BUS.ViewModel.TheThuViens;

namespace DuAnOne.BUS.Interface
{
    public interface ITheThuVienService
    {
        TheThuVienVM GetById(Guid id);
        List<TheThuVienVM> GetList();
        string Create(TheThuVienCreateVM createVM);
        bool Update(TheThuVienUpdateVM updateVM);
        bool Delete(Guid id);
    }
}
