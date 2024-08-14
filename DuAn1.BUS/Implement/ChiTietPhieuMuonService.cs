using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.ChiTietPhieuMuon;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Implement
{
    public class ChiTietPhieuMuonService : IChiTietPhieuMuonService
    {
        private readonly IChiTietPhieuMuonRepo _repo;

        public ChiTietPhieuMuonService(IChiTietPhieuMuonRepo repo)
        {
            _repo = repo;
        }

        public void Add(ChiTietPhieuMuonCreateVM createVM)
        {
            if (createVM == null)
            {
                throw new ArgumentNullException(nameof(createVM));
            }

            var chiTiet = ChiTietPhieuMuonMapping.MapCreateVMToEntity(createVM);
            _repo.Add(chiTiet);
        }

        public void Update(ChiTietPhieuMuonUpdateVM updateVM)
        {
            if (updateVM == null)
            {
                throw new ArgumentNullException(nameof(updateVM));
            }

            var existing = _repo.GetById(updateVM.IdPhieuMuon, updateVM.IdSach);
            if (existing == null)
            {
                throw new KeyNotFoundException("Chi tiết phiếu mượn không tồn tại.");
            }

            var chiTiet = ChiTietPhieuMuonMapping.MapUpdateVMToEntity(updateVM);
            _repo.Update(chiTiet);
        }

        public void Delete(Guid idPhieuMuon, Guid idSach)
        {
            var existing = _repo.GetById(idPhieuMuon, idSach);
            if (existing == null)
            {
                throw new KeyNotFoundException("Chi tiết phiếu mượn không tồn tại.");
            }

            _repo.Delete(idPhieuMuon, idSach);
        }

        public ChiTietPhieuMuonVM GetById(Guid idPhieuMuon, Guid idSach)
        {
            var chiTiet = _repo.GetById(idPhieuMuon, idSach);
            if (chiTiet == null)
            {
                throw new KeyNotFoundException("Chi tiết phiếu mượn không tồn tại.");
            }

            return ChiTietPhieuMuonMapping.MapEntityToVM(chiTiet);
        }

        public List<ChiTietPhieuMuonVM> GetByIdPhieuMuon(Guid idPhieuMuon)
        {
            var chiTietPhieuMuons = _repo.GetByIdPhieuMuon(idPhieuMuon);
            return chiTietPhieuMuons.Select(ChiTietPhieuMuonMapping.MapEntityToVM).ToList();
        }

        public List<ChiTietPhieuMuonVM> GetList(Guid idPhieuMuon)
        {
            List<ChiTietPhieuMuon> entities = _repo.GetList(idPhieuMuon);
            List<ChiTietPhieuMuonVM> vms = entities.Select(e => ChiTietPhieuMuonMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

    }
}
