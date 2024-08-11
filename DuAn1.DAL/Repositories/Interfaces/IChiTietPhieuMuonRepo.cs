using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IChiTietPhieuMuonRepo
    {
        void Add(ChiTietPhieuMuon chiTiet);
        void Update(ChiTietPhieuMuon chiTiet);
        void Delete(Guid idPhieuMuon, Guid idSach);
        ChiTietPhieuMuon GetById(Guid idPhieuMuon, Guid idSach);
        List<ChiTietPhieuMuon> GetByIdPhieuMuon(Guid idPhieuMuon);
        
    }
}
