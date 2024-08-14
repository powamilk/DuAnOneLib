using DuAnOne.BUS.ViewModel.ChiTietPhieuMuon;
using DuAnOne.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Interface
{
    public interface IChiTietPhieuMuonService
    {
        void Add(ChiTietPhieuMuonCreateVM createVM);
        void Update(ChiTietPhieuMuonUpdateVM updateVM);
        void Delete(Guid idPhieuMuon, Guid idSach);
        ChiTietPhieuMuonVM GetById(Guid idPhieuMuon, Guid idSach);
        List<ChiTietPhieuMuonVM> GetByIdPhieuMuon(Guid idPhieuMuon);

        List<ChiTietPhieuMuonVM> GetList(Guid idPhieuMuon);
    }
}
