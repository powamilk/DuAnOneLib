using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    public class TaiKhoanRepo : ITaiKhoanRepo
    {
        private readonly AppDbContext _appDbContext;

        public TaiKhoanRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<TaiKhoan> GetList()
        {
            return _appDbContext.TaiKhoans.ToList();
        }

        public TaiKhoan GetById(Guid id)
        {
            return _appDbContext.TaiKhoans.FirstOrDefault(tk => tk.Id == id);
        }

        public bool Create(TaiKhoan entity)
        {
            try
            {
                _appDbContext.TaiKhoans.Add(entity);
                _appDbContext.SaveChanges();
                return true; // Success
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm tài khoản thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }

        public bool Update(TaiKhoan entity)
        {
            try
            {
                var existingTaiKhoan = _appDbContext.TaiKhoans.FirstOrDefault(tk => tk.Id == entity.Id);
                if (existingTaiKhoan != null)
                {
                    existingTaiKhoan.HoVaTen = entity.HoVaTen;
                    existingTaiKhoan.NgaySinh = entity.NgaySinh;
                    existingTaiKhoan.DiaChi = entity.DiaChi;
                    existingTaiKhoan.Sdt = entity.Sdt;
                    existingTaiKhoan.Email = entity.Email;
                    existingTaiKhoan.MaNhanVien = entity.MaNhanVien;
                    existingTaiKhoan.TenTaiKhoan = entity.TenTaiKhoan;
                    existingTaiKhoan.MatKhau = entity.MatKhau;
                    existingTaiKhoan.ChucVu = entity.ChucVu;
                    existingTaiKhoan.Status = entity.Status;
                    existingTaiKhoan.ModifyBy = entity.ModifyBy;
                    existingTaiKhoan.ModifyTime = entity.ModifyTime;
                    existingTaiKhoan.DeleteBy = entity.DeleteBy;
                    existingTaiKhoan.DeleteTime = entity.DeleteTime;

                    _appDbContext.TaiKhoans.Update(existingTaiKhoan);
                    _appDbContext.SaveChanges();
                    return true; // Success
                }
                Console.WriteLine("Không tìm thấy tài khoản cần cập nhật");
                return false; // Not found
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật tài khoản thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var existingTaiKhoan = _appDbContext.TaiKhoans.FirstOrDefault(tk => tk.Id == id);
                if (existingTaiKhoan != null)
                {
                    _appDbContext.TaiKhoans.Remove(existingTaiKhoan);
                    _appDbContext.SaveChanges();
                    return true; // Success
                }
                Console.WriteLine("Không tìm thấy tài khoản cần xóa");
                return false; // Not found
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa tài khoản thất bại\nLỗi: " + ex.Message);
                return false; // Failure
            }
        }
    }
}
