using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    internal class ChiTietPhieuMuonRepo : IChiTietPhieuMuonRepo
    {
        private readonly AppDbContext _appDbContext;

        public ChiTietPhieuMuonRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ChiTietPhieuMuon> GetList()
        {
            return _appDbContext.ChiTietPhieuMuons.ToList();
        }

        public ChiTietPhieuMuon GetById(Guid idPhieuMuon, Guid idSach)
        {
            return _appDbContext.ChiTietPhieuMuons
                .FirstOrDefault(ctpm => ctpm.IdPhieuMuon == idPhieuMuon && ctpm.IdSach == idSach);
        }

        public string Create(ChiTietPhieuMuon entity)
        {
            try
            {
                _appDbContext.ChiTietPhieuMuons.Add(entity);
                _appDbContext.SaveChanges();
                return "Thêm chi tiết phiếu mượn thành công";
            }
            catch (Exception ex)
            {
                return "Thêm chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Update(ChiTietPhieuMuon entity)
        {
            try
            {
                var existingChiTietPhieuMuon = _appDbContext.ChiTietPhieuMuons
                    .FirstOrDefault(ctpm => ctpm.IdPhieuMuon == entity.IdPhieuMuon && ctpm.IdSach == entity.IdSach);
                if (existingChiTietPhieuMuon == null)
                {
                    return "Không tìm thấy chi tiết phiếu mượn cần cập nhật";
                }

                existingChiTietPhieuMuon.SoLuongMuon = entity.SoLuongMuon;
                existingChiTietPhieuMuon.GhiChu = entity.GhiChu;
                existingChiTietPhieuMuon.Status = entity.Status;
                existingChiTietPhieuMuon.CreateBy = entity.CreateBy;
                existingChiTietPhieuMuon.CreateTime = entity.CreateTime;
                existingChiTietPhieuMuon.ModifyBy = entity.ModifyBy;
                existingChiTietPhieuMuon.ModifyTime = entity.ModifyTime;
                existingChiTietPhieuMuon.DeleteBy = entity.DeleteBy;
                existingChiTietPhieuMuon.DeleteTime = entity.DeleteTime;

                _appDbContext.ChiTietPhieuMuons.Update(existingChiTietPhieuMuon);
                _appDbContext.SaveChanges();

                return "Cập nhật chi tiết phiếu mượn thành công";
            }
            catch (Exception ex)
            {
                return "Cập nhật chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Delete(Guid idPhieuMuon, Guid idSach)
        {
            try
            {
                var existingChiTietPhieuMuon = _appDbContext.ChiTietPhieuMuons
                    .FirstOrDefault(ctpm => ctpm.IdPhieuMuon == idPhieuMuon && ctpm.IdSach == idSach);
                if (existingChiTietPhieuMuon == null)
                {
                    return "Không tìm thấy chi tiết phiếu mượn cần xóa";
                }

                _appDbContext.ChiTietPhieuMuons.Remove(existingChiTietPhieuMuon);
                _appDbContext.SaveChanges();

                return "Xóa chi tiết phiếu mượn thành công";
            }
            catch (Exception ex)
            {
                return "Xóa chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }
    }
}
