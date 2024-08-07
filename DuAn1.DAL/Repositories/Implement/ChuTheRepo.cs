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
            return _appDbContext.ChuThes.AsQueryable().AsNoTracking().ToList(); ;
        }

        public ChuThe GetById(Guid id)
        {
            // Trả về ChuThe theo Id, hoặc null nếu không tìm thấy
            return _appDbContext.ChuThes.FirstOrDefault(c => c.Id == id);
        }

        public bool Create(ChuThe entity)
        {
            try
            {
                // Thêm đối tượng ChuThe mới vào cơ sở dữ liệu
                _appDbContext.ChuThes.Add(entity);
                _appDbContext.SaveChanges();
                return true; // Thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Thất bại
            }
        }

        public bool Update(ChuThe entity)
        {
            try
            {
                // Tìm đối tượng ChuThe hiện tại trong cơ sở dữ liệu
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == entity.Id);
                if (existingChuThe == null)
                {
                    Console.WriteLine("Không tìm thấy thẻ thư viện cần cập nhật");
                    return false; // Không tìm thấy đối tượng để cập nhật
                }

                // Cập nhật các thuộc tính của đối tượng ChuThe
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

                // Cập nhật đối tượng ChuThe trong cơ sở dữ liệu
                _appDbContext.ChuThes.Update(existingChuThe);
                _appDbContext.SaveChanges();
                return true; // Cập nhật thành công
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
                // Tìm đối tượng ChuThe trong cơ sở dữ liệu theo Id
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == id);
                if (existingChuThe == null)
                {
                    Console.WriteLine("Không tìm thấy thẻ thư viện cần xóa");
                    return false; // Không tìm thấy đối tượng để xóa
                }

                // Xóa đối tượng ChuThe khỏi cơ sở dữ liệu
                _appDbContext.ChuThes.Remove(existingChuThe);
                _appDbContext.SaveChanges();
                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa thẻ thư viện thất bại\nLỗi: " + ex.Message);
                return false; // Thất bại
            }
        }
    }
}
