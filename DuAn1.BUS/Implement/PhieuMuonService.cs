using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel;
using DuAnOne.BUS.ViewModel.PhieuMuons;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly IPhieuMuonRepo _repo;
        private readonly ITheThuVienRepo _theThuVienRepo;

        public PhieuMuonService()
        {
            _theThuVienRepo = new TheThuVienRepo(new AppDbContext());
            _repo = new PhieuMuonRepo(new AppDbContext());

        }

        public PhieuMuonVM GetById(Guid id)
        {
            PhieuMuon entity = _repo.GetById(id);
            PhieuMuonVM vm = PhieuMuonMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<PhieuMuonVM> GetList()
        {
            List<PhieuMuon> entities = _repo.GetList();
            List<PhieuMuonVM> vms = entities.Select(e => PhieuMuonMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(PhieuMuonCreateVM createVM)
        {
            try
            {
                PhieuMuon entity = PhieuMuonMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Phiếu mượn đã được tạo thành công.";
            }
            catch (Exception ex)
            {
                return $"Tạo phiếu mượn thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Update(PhieuMuonUpdateVM updateVM)
        {
            if (updateVM == null)
            {
                return "Dữ liệu phiếu mượn không hợp lệ.";
            }

            try
            {
                PhieuMuon entity = PhieuMuonMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật phiếu mượn thành công." : "Cập nhật phiếu mượn thất bại.";
            }
            catch (Exception ex)
            {
                return $"Cập nhật phiếu mượn thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                bool result = _repo.Delete(id);
                return result ? "Xóa phiếu mượn thành công." : "Xóa phiếu mượn thất bại.";
            }
            catch (Exception ex)
            {
                return $"Xóa phiếu mượn thất bại. Lỗi: {ex.Message}";
            }
        }

        public List<IdTheData> GetIdTheList()
        {
            var entities = _theThuVienRepo.GetAll(); // Giả sử GetAll() trả về danh sách TheThuVien
            return entities.Select(e => new IdTheData
            {
                Id = e.Id,
                MaThe = e.MaThe
            }).ToList();
        }

        public List<(string Status, int SoLuong)> GetPhieuMuonStatistics()
        {
            // Lấy tất cả phiếu mượn
            var allPhieuMuon = _repo.GetList();

            // Nhóm theo trạng thái và đếm số lượng
            var statistics = allPhieuMuon
                .GroupBy(pm => pm.Status switch
                {
                    1 => "Đang mượn",
                    2 => "Đã trả",
                    3 => "Quá hạn",
                    4 => "Đã trả quá hạn",
                    5 => "Đang yêu cầu",
                    _ => "Khác"
                })
                .Select(group => (Status: group.Key, SoLuong: group.Count()))
                .ToList();

            return statistics;
        }

        public List<(string MaThe, int SoLanMuon)> GetThongKeTheThuVien()
        {
            var phieuMuons = _repo.GetList();

            var result = phieuMuons
                .GroupBy(pm => pm.IdThe)
                .Select(group => new
                {
                    MaThe = group.First().IdTheNavigation?.MaThe ?? "N/A", // Kiểm tra nếu MaThe null
                    SoLanMuon = group.Count()
                })
                .Select(x => (x.MaThe, x.SoLanMuon))
                .ToList();

            return result;
        }


    }
}
