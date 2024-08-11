using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public string Create(Sach entity)
        {
            entity.CreateTime = DateTime.Now;
            try
            {
                _appDbContext.Saches.Add(entity);
                _appDbContext.SaveChanges();
                return "Thêm sách thành công.";
            }
            catch (Exception ex)
            {
                return $"Thêm sách thất bại. Lỗi: {ex.Message}";
            }
        }

        public bool Update(Sach entity)
        {
            try
            {
                var existingSach = _appDbContext.Saches.FirstOrDefault(s => s.Id == entity.Id);
                if (existingSach != null)
                {
                    existingSach.TenSach = entity.TenSach;
                    existingSach.NamXuatBan = entity.NamXuatBan;
                    existingSach.SoLuong = entity.SoLuong;
                    existingSach.TheLoai = entity.TheLoai;
                    existingSach.MaSach = entity.MaSach;
                    existingSach.GiaTien = entity.GiaTien;
                    existingSach.TacGia = entity.TacGia;
                    existingSach.Status = entity.Status;
                    existingSach.ModifyBy = entity.ModifyBy;
                    existingSach.ModifyTime = entity.ModifyTime;
                    existingSach.DeleteBy = entity.DeleteBy;
                    existingSach.DeleteTime = entity.DeleteTime;

                    _appDbContext.Saches.Update(existingSach);
                    _appDbContext.SaveChanges();
                    return true;
                }
                Console.WriteLine("Không tìm thấy sách cần cập nhật");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật sách thất bại\nLỗi: " + ex.Message);
                return false;
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                var existingSach = _appDbContext.Saches.FirstOrDefault(s => s.Id == id);
                if (existingSach != null)
                {
                    _appDbContext.Saches.Remove(existingSach);
                    _appDbContext.SaveChanges();
                    return "Xóa sách thành công.";
                }
                return "Sách không tìm thấy.";
            }
            catch (Exception ex)
            {
                return $"Xóa sách thất bại. Lỗi: {ex.Message}";
            }
        }

        public List<Sach> GetAll()
        {
            return _appDbContext.Saches.AsQueryable().AsNoTracking().ToList();
        }
    }
}
