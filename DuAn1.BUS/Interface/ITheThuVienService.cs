using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Interface
{
    public interface ITheThuVienService
    {
        TheThuVienVM GetById(Guid id);
        List<TheThuVienVM> GetList();
        string Create(TheThuVienCreateVM createVM);
        string Update(TheThuVienUpdateVM updateVM);
        bool Delete(Guid id);
        List<TheThuVienVM> GetAll();

        List<TheThuVien> GetIdTheList();
    }
}
