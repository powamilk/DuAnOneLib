using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface ISachRepo
    {
        List<Sach> GetList();
        Sach GetById(Guid id);
        string Create(Sach entity);
        string Update(Sach entity);
        string Delete(Guid id);
    }
}
