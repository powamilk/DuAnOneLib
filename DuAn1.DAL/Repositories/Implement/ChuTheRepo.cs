using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class ChuTheRepo : IChuTheRepo
    {
        private readonly AppDbContext _appDbContext;

        public ChuTheRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ChuThe> GetList()
        {
            // Trả về danh sách tất cả các ChuThe
            return _appDbContext.ChuThes.ToList(); 
        }

        public ChuThe GetById(Guid id)
        {
            // Trả về ChuThe theo Id, hoặc null nếu không tìm thấy
            return _appDbContext.ChuThes.FirstOrDefault(c => c.Id == id);
        }

        public bool Create(ChuThe entity)
        {
            entity.CreateTime = DateTime.Now;
            try
            {
                _appDbContext.ChuThes.Add(entity);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false;
            }
        }

        public bool Update(ChuThe entity)
        {
            try
            {
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == entity.Id);
                if (existingChuThe != null)
                {
                    existingChuThe.Cccd = entity.Cccd;
                    existingChuThe.HoVaTen = entity.HoVaTen;
                    existingChuThe.LoaiThe = entity.LoaiThe;
                    existingChuThe.DiaChi = entity.DiaChi;
                    existingChuThe.GioiTinh = entity.GioiTinh;
                    existingChuThe.NgheNghiep = entity.NgheNghiep;
                    existingChuThe.QuocTich = entity.QuocTich;
                    existingChuThe.LoaiBanDoc = entity.LoaiBanDoc;
                    existingChuThe.Email = entity.Email;
                    existingChuThe.NoiLamViec = entity.NoiLamViec;
                    existingChuThe.Status = entity.Status;
                    existingChuThe.ModifyBy = entity.ModifyBy;
                    existingChuThe.ModifyTime = entity.ModifyTime;
                    existingChuThe.DeleteBy = entity.DeleteBy;
                    existingChuThe.DeleteTime = entity.DeleteTime;

                    _appDbContext.ChuThes.Update(existingChuThe);
                    _appDbContext.SaveChanges();
                    return true;
                }
                Console.WriteLine("Không tìm thấy thẻ thư viện cần cập nhật");
                return false;              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Thất bại
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == id);
                if (existingChuThe == null)
                {
                    _appDbContext.ChuThes.Remove(existingChuThe);
                    _appDbContext.SaveChanges();
                    return true;
                }
                Console.WriteLine("Không tìm thấy thẻ thư viện cần xóa");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; 
            }
        }

        public List<ChuThe> GetAll()
        {
            return _appDbContext.ChuThes.AsQueryable().AsNoTracking().ToList();
        }
    }
}
