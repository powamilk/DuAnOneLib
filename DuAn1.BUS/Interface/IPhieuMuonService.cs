using DuAnOne.BUS.ViewModel;
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
        List<IdTheData> GetIdTheList();
        List<(string Status, int SoLuong)> GetPhieuMuonStatistics();

        List<(string MaThe, int SoLanMuon)> GetThongKeTheThuVien();
    }
}
