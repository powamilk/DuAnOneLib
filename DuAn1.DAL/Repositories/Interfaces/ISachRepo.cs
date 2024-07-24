using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ISachRepo
    {
        List<Sach> GetList();
        Sach GetById(Guid id);
        string Create(Sach sach);
        string Update(Sach sach);
        string Delete(Sach sach);
    }
}
