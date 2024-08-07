using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    internal class ChiTietPhieuMuonRepo : IChiTietPhieuMuonRepo
    {
        private readonly AppDbContext _context;

        public ChiTietPhieuMuonRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ChiTietPhieuMuon chiTiet)
        {
            _context.ChiTietPhieuMuons.Add(chiTiet);
            _context.SaveChanges();
        }

        public void Update(ChiTietPhieuMuon chiTiet)
        {
            // Tìm kiếm đối tượng dựa trên IdPhieuMuon và IdSach
            var existing = _context.ChiTietPhieuMuons
                .FirstOrDefault(ct => ct.IdPhieuMuon == chiTiet.IdPhieuMuon && ct.IdSach == chiTiet.IdSach);

            if (existing != null)
            {
                existing.SoLuongMuon = chiTiet.SoLuongMuon;
                existing.GhiChu = chiTiet.GhiChu;
                existing.Status = chiTiet.Status;
                existing.ModifyBy = chiTiet.ModifyBy;
                existing.ModifyTime = chiTiet.ModifyTime;
                _context.SaveChanges();
            }
        }

        public void Delete(Guid idPhieuMuon, Guid idSach)
        {
            var chiTiet = _context.ChiTietPhieuMuons
                .FirstOrDefault(ct => ct.IdPhieuMuon == idPhieuMuon && ct.IdSach == idSach);

            if (chiTiet != null)
            {
                _context.ChiTietPhieuMuons.Remove(chiTiet);
                _context.SaveChanges();
            }
        }

        public ChiTietPhieuMuon GetById(Guid idPhieuMuon, Guid idSach)
        {
            return _context.ChiTietPhieuMuons
                .FirstOrDefault(ct => ct.IdPhieuMuon == idPhieuMuon && ct.IdSach == idSach);
        }

        public List<ChiTietPhieuMuon> GetByIdPhieuMuon(Guid idPhieuMuon)
        {
            return _context.ChiTietPhieuMuons
                .Where(ct => ct.IdPhieuMuon == idPhieuMuon)
                .ToList();
        }
    }
}
