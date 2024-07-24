using DuAnOne.BUS.ViewModel.PhieuMuons;

namespace DuAnOne.BUS.Interface
{
    public interface IPhieuMuonService
    {
        PhieuMuonVM GetById(Guid id);
        List<PhieuMuonVM> GetList();
        string Create(PhieuMuonVM createVM);
        bool Update(PhieuMuonVM updateVM);
        bool Delete(Guid id);
    }
}
