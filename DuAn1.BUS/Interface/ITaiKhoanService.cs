using DuAnOne.BUS.ViewModel.TaiKhoans;

namespace DuAnOne.BUS.Interface
{
    public interface ITaiKhoanService
    {
        TaiKhoanVM GetById(Guid id);
        List<TaiKhoanVM> GetList();
        string Create(TaiKhoanCreateVM createVM);
        string Update(TaiKhoanUpdateVM updateVM);
        bool Delete(Guid id);
        List<TaiKhoanVM> GetAll();
    }
}
