using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class SachRepo : ISachRepo
    {
        private readonly AppDbContext _appDbContext;

        public SachRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Sach> GetList()
        {
            return _appDbContext.Saches.ToList();
        }

        public Sach GetById(Guid id)
        {
            return _appDbContext.Saches.FirstOrDefault(s => s.Id == id);
        }

        public string Create(Sach sach)
        {
            try
            {
                _appDbContext.Saches.Add(sach);
                _appDbContext.SaveChanges();
                return "Thêm sách thành công";
            }
            catch (Exception ex)
            {
                return "Thêm sách thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Update(Sach sach)
        {
            try
            {
                var existingSach = _appDbContext.Saches.FirstOrDefault(s => s.Id == sach.Id);
                if (existingSach != null)
                {
                    existingSach.TenSach = sach.TenSach;
                    existingSach.NamXuatBan = sach.NamXuatBan;
                    existingSach.SoLuong = sach.SoLuong;
                    existingSach.TheLoai = sach.TheLoai;
                    existingSach.MaSach = sach.MaSach;
                    existingSach.GiaTien = sach.GiaTien;
                    existingSach.TacGia = sach.TacGia;
                    existingSach.Status = sach.Status;
                    existingSach.ModifyBy = sach.ModifyBy;
                    existingSach.ModifyTime = sach.ModifyTime;
                    existingSach.DeleteBy = sach.DeleteBy;
                    existingSach.DeleteTime = sach.DeleteTime;

                    _appDbContext.Saches.Update(existingSach);
                    _appDbContext.SaveChanges();
                    return "Cập nhật sách thành công";
                }
                return "Không tìm thấy sách cần cập nhật";
            }
            catch (Exception ex)
            {
                return "Cập nhật sách thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Delete(Sach sach)
        {
            try
            {
                var existingSach = _appDbContext.Saches.FirstOrDefault(s => s.Id == sach.Id);
                if (existingSach != null)
                {
                    _appDbContext.Saches.Remove(existingSach);
                    _appDbContext.SaveChanges();
                    return "Xóa sách thành công";
                }
                return "Không tìm thấy sách cần xóa";
            }
            catch (Exception ex)
            {
                return "Xóa sách thất bại\nLỗi: " + ex.Message;
            }
        }
    }
}
