using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IPhieuMuonRepo
    {
        List<PhieuMuon> GetList();
        PhieuMuon GetById(Guid id);
        string Create(PhieuMuon pm);
        string Update(PhieuMuon pm);
        string Delete(PhieuMuon pm);
    }
}
