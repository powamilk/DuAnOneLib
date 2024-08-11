using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ITheThuVienRepo
    {
        List<TheThuVien> GetList();
        TheThuVien GetById(Guid id);
        bool Create(TheThuVien entity);
        bool Update(TheThuVien entity);
        bool Delete(Guid id);
        List<TheThuVien> GetAll();
    }
}
