using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class TheThuVienRepo : ITheThuVienRepo
    {
        private readonly AppDbContext _appDbContext;

        public TheThuVienRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<TheThuVien> GetList()
        {
            return _appDbContext.TheThuViens.ToList();
        }

        public TheThuVien GetById(Guid id)
        {
            return _appDbContext.TheThuViens.FirstOrDefault(ttv => ttv.Id == id);
        }

        public bool Create(TheThuVien entity)
        {
            try
            {
                _appDbContext.TheThuViens.Add(entity);
                _appDbContext.SaveChanges();
                return true; // Success
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }

        public bool Update(TheThuVien entity)
        {
            try
            {
                var existingTheThuVien = _appDbContext.TheThuViens.FirstOrDefault(ttv => ttv.Id == entity.Id);
                if (existingTheThuVien != null)
                {
                    existingTheThuVien.IdChuThe = entity.IdChuThe;
                    existingTheThuVien.NgayCap = entity.NgayCap;
                    existingTheThuVien.NgayHetHan = entity.NgayHetHan;
                    existingTheThuVien.MaThe = entity.MaThe;
                    existingTheThuVien.Status = entity.Status;
                    existingTheThuVien.ModifyBy = entity.ModifyBy;
                    existingTheThuVien.ModifyTime = entity.ModifyTime;
                    existingTheThuVien.DeleteBy = entity.DeleteBy;
                    existingTheThuVien.DeleteTime = entity.DeleteTime;

                    _appDbContext.TheThuViens.Update(existingTheThuVien);
                    _appDbContext.SaveChanges();
                    return true; // Success
                }
                Console.WriteLine("Không tìm thấy thẻ thư viện cần cập nhật");
                return false; // Not found
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var existingTheThuVien = _appDbContext.TheThuViens.FirstOrDefault(ttv => ttv.Id == id);
                if (existingTheThuVien != null)
                {
                    _appDbContext.TheThuViens.Remove(existingTheThuVien);
                    _appDbContext.SaveChanges();
                    return true; // Success
                }
                Console.WriteLine("Không tìm thấy thẻ thư viện cần xóa");
                return false; // Not found
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }
    }
}
