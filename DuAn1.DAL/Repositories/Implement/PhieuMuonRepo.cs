using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    internal class PhieuMuonRepo : IPhieuMuonRepo
    {
        private readonly AppDbContext _appDbContext;

        public PhieuMuonRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<PhieuMuon> GetList()
        {
            return _appDbContext.PhieuMuons.ToList();
        }

        public PhieuMuon GetById(Guid id)
        {
            return _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == id);
        }

        public string Create(PhieuMuon pm)
        {
            try
            {
                _appDbContext.PhieuMuons.Add(pm);
                _appDbContext.SaveChanges();
                return "Tạo mới thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }

        public string Update(PhieuMuon pm)
        {
            try
            {
                var existingPhieuMuon = _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == pm.Id);
                if (existingPhieuMuon == null)
                {
                    return "Không tìm thấy đối tượng cần cập nhật.";
                }

                existingPhieuMuon.IdTaiKhoan = pm.IdTaiKhoan;
                existingPhieuMuon.IdThe = pm.IdThe;
                existingPhieuMuon.NgayMuon = pm.NgayMuon;
                existingPhieuMuon.NgayTra = pm.NgayTra;
                existingPhieuMuon.NgayTraThucTe = pm.NgayTraThucTe;
                existingPhieuMuon.MaPhieu = pm.MaPhieu;
                existingPhieuMuon.Status = pm.Status;
                existingPhieuMuon.CreateBy = pm.CreateBy;
                existingPhieuMuon.CreateTime = pm.CreateTime;
                existingPhieuMuon.ModifyBy = pm.ModifyBy;
                existingPhieuMuon.ModifyTime = pm.ModifyTime;
                existingPhieuMuon.DeleteBy = pm.DeleteBy;
                existingPhieuMuon.DeleteTime = pm.DeleteTime;

                _appDbContext.PhieuMuons.Update(existingPhieuMuon);
                _appDbContext.SaveChanges();

                return "Cập nhật thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }

        public string Delete(PhieuMuon pm)
        {
            try
            {
                var existingPhieuMuon = _appDbContext.PhieuMuons.FirstOrDefault(pm => pm.Id == pm.Id);
                if (existingPhieuMuon == null)
                {
                    return "Không tìm thấy đối tượng cần xóa.";
                }

                _appDbContext.PhieuMuons.Remove(existingPhieuMuon);
                _appDbContext.SaveChanges();

                return "Xóa thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }
    }
}
