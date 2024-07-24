using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IChiTietPhieuMuonRepo
    {
        List<ChiTietPhieuMuon> GetList();
        ChiTietPhieuMuon GetById(Guid id);
        string Create(ChiTietPhieuMuon ctpm);
        string Update(ChiTietPhieuMuon ctpm);
        string Delete(ChiTietPhieuMuon ctpm);
    }
}
