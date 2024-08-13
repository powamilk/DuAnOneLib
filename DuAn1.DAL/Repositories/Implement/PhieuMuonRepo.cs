using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class PhieuMuonRepo : IPhieuMuonRepo
    {
        private readonly AppDbContext _appDbContext;

        public PhieuMuonRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PhieuMuon GetById(Guid id)
        {
            return _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == id);
        }

        public List<PhieuMuon> GetList()
        {
            return _appDbContext.PhieuMuons
            .Include(pm => pm.IdTheNavigation) // Nạp đối tượng TheThuVien
            .ToList();
        }

        public bool Create(PhieuMuon entity)
        {   
            entity.CreateTime = DateTime.Now;   
            try
            {
                _appDbContext.PhieuMuons.Add(entity);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception
                return false;
            }
        }

        public bool Update(PhieuMuon entity)
        {
            try
            {
                var existingPhieuMuon = _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == entity.Id);
                if (existingPhieuMuon == null)
                {
                    return false;
                }

                existingPhieuMuon.IdThe = entity.IdThe;
                existingPhieuMuon.NgayMuon = entity.NgayMuon;
                existingPhieuMuon.NgayTra = entity.NgayTra;
                existingPhieuMuon.NgayTraThucTe = entity.NgayTraThucTe;
                existingPhieuMuon.MaPhieu = entity.MaPhieu;
                existingPhieuMuon.Status = entity.Status;
                existingPhieuMuon.CreateBy = entity.CreateBy;
                existingPhieuMuon.CreateTime = entity.CreateTime;
                existingPhieuMuon.ModifyBy = entity.ModifyBy;
                existingPhieuMuon.ModifyTime = entity.ModifyTime;
                existingPhieuMuon.DeleteBy = entity.DeleteBy;
                existingPhieuMuon.DeleteTime = entity.DeleteTime;

                _appDbContext.PhieuMuons.Update(existingPhieuMuon);
                _appDbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Log the exception
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var existingPhieuMuon = _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == id);
                if (existingPhieuMuon == null)
                {
                    return false;
                }

                _appDbContext.PhieuMuons.Remove(existingPhieuMuon);
                _appDbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Log the exception
                return false;
            }
        }

        public List<TheThuVien> GetIdTheList()
        {
            return _appDbContext.TheThuViens.ToList();
        }

        public List<ChuThe> GetChuTheList()
        {
            return _appDbContext.ChuThes.ToList();
        }

        public List<TaiKhoan> GetTaiKhoanList()
        {
            return _appDbContext.TaiKhoans.ToList();
        }
    }
}
