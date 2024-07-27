using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IChiTietPhieuMuonRepo
    {
        List<ChiTietPhieuMuon> GetList();
        ChiTietPhieuMuon GetById(Guid idPhieuMuon, Guid idSach);
        string Create(ChiTietPhieuMuon entity);
        string Update(ChiTietPhieuMuon entity);
        string Delete(Guid idPhieuMuon, Guid idSach);
    }
}
