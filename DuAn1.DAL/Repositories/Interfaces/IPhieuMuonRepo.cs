using DuAnOne.DAL.Entities;

namespace DuAnOne.DAL.Repositories.Interfaces
{
    public interface IPhieuMuonRepo
    {
        PhieuMuon GetById(Guid id);
        List<PhieuMuon> GetList();
        bool Create(PhieuMuon entity);
        bool Update(PhieuMuon entity);
        bool Delete(Guid id);
        List<TheThuVien> GetIdTheList();
        List<ChuThe> GetChuTheList();
        List<TaiKhoan> GetTaiKhoanList();
    }
}
