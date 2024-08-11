using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IChuTheRepo
    {
        ChuThe GetById(Guid id);
        List<ChuThe> GetList();
        bool Create(ChuThe entity);
        bool Update(ChuThe entity);
        bool Delete(Guid id);
        List<ChuThe> GetAll();  
    }
}
