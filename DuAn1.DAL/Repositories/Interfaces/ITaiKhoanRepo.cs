using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ITaiKhoanRepo
    {
        TaiKhoan GetById(Guid id);
        List<TaiKhoan> GetList();
        bool Create(TaiKhoan entity);
        bool Update(TaiKhoan entity);
        bool Delete(Guid id);
        List<TaiKhoan> GetAll();
    }
}
