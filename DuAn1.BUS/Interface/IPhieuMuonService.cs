using DuAnOne.BUS.ViewModel.PhieuMuons;

namespace DuAnOne.BUS.Interface
{
    public interface IPhieuMuonService
    {
        PhieuMuonVM GetById(Guid id);
        List<PhieuMuonVM> GetList();
        string Create(PhieuMuonCreateVM createVM);
        string Update(PhieuMuonUpdateVM updateVM);
        string Delete(Guid id);
    }
}
