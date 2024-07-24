using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class ChiTietPhieuMuonRepo : IChiTietPhieuMuonRepo
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

        public ChiTietPhieuMuon GetById(Guid id)
        {
            return _appDbContext.ChiTietPhieuMuons
                .FirstOrDefault(ctpm => ctpm.IdPhieuMuon == id);
        }

        public string Create(ChiTietPhieuMuon ctpm)
        {
            try
            {
                _appDbContext.ChiTietPhieuMuons.Add(ctpm);
                _appDbContext.SaveChanges();
                return "Thêm chi tiết phiếu mượn thành công";
            }
            catch (Exception ex)
            {
                return "Thêm chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Update(ChiTietPhieuMuon ctpm)
        {
            try
            {
                var existingChiTiet = _appDbContext.ChiTietPhieuMuons
                    .FirstOrDefault(ct => ct.IdPhieuMuon == ctpm.IdPhieuMuon
                                        && ct.IdSach == ctpm.IdSach);

                if (existingChiTiet != null)
                {
                    existingChiTiet.SoLuongMuon = ctpm.SoLuongMuon;
                    existingChiTiet.GhiChu = ctpm.GhiChu;
                    existingChiTiet.Status = ctpm.Status;
                    existingChiTiet.ModifyBy = ctpm.ModifyBy;
                    existingChiTiet.ModifyTime = ctpm.ModifyTime;
                    existingChiTiet.DeleteBy = ctpm.DeleteBy;
                    existingChiTiet.DeleteTime = ctpm.DeleteTime;

                    _appDbContext.ChiTietPhieuMuons.Update(existingChiTiet);
                    _appDbContext.SaveChanges();
                    return "Cập nhật chi tiết phiếu mượn thành công";
                }
                return "Không tìm thấy chi tiết phiếu mượn để cập nhật";
            }
            catch (Exception ex)
            {
                return "Cập nhật chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Delete(ChiTietPhieuMuon ctpm)
        {
            try
            {
                var existingChiTiet = _appDbContext.ChiTietPhieuMuons
                    .FirstOrDefault(ct => ct.IdPhieuMuon == ctpm.IdPhieuMuon
                                        && ct.IdSach == ctpm.IdSach);

                if (existingChiTiet != null)
                {
                    _appDbContext.ChiTietPhieuMuons.Remove(existingChiTiet);
                    _appDbContext.SaveChanges();
                    return "Xóa chi tiết phiếu mượn thành công";
                }
                return "Không tìm thấy chi tiết phiếu mượn để xóa";
            }
            catch (Exception ex)
            {
                return "Xóa chi tiết phiếu mượn thất bại\nLỗi: " + ex.Message;
            }
        }
    }
}
