using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
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

        public PhieuMuonService()
        {
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
    }
}
