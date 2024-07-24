using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IChuTheRepo
    {
        List<ChuThe> GetList();
        ChuThe GetById(Guid id);
        string Create(ChuThe ct);
        string Update(ChuThe ct);
        string Delete(ChuThe ct);
    }
}
