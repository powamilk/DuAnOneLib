using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Interface
{
    public interface ITaiKhoanService
    {
        TaiKhoanVM GetById(Guid id);
        List<TaiKhoanVM> GetList();
        string Create(TaiKhoanCreateVM createVM);
        string Update(TaiKhoanUpdateVM updateVM);
        bool Delete(Guid id);
        string GetUserNameById(Guid userId);
        List<TaiKhoanVM> GetAll();
        bool ValidateUser(string tenTaiKhoan, string matKhau);
        TaiKhoan GetByUsername(string username);
        TaiKhoanVM Login(string tenTaiKhoan, string matKhau);
        List<(string LoaiTaiKhoan, int SoLuong)> GetTaiKhoanStatistics();
    }
}
