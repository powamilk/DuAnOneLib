using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ITaiKhoanRepo
    {
        List<TaiKhoan> GetList();
        TaiKhoan GetById(Guid id);
        string Create(TaiKhoan tk);
        string Update(TaiKhoan tk);
        string Delete(TaiKhoan tk);
    }
}
