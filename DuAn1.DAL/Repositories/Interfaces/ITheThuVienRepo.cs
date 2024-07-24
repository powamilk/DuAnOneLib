using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ITheThuVienRepo
    {
        List<TheThuVien> GetList();
        TheThuVien GetById(Guid id);
        string Create(TheThuVien ttv);
        string Update(TheThuVien ttv);
        string Delete(TheThuVien ttv);
    }
}
