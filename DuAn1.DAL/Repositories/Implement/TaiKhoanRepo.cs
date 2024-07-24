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

        public string Create(TaiKhoan tk)
        {
            try
            {
                _appDbContext.TaiKhoans.Add(tk);
                _appDbContext.SaveChanges();
                return "Thêm tài khoản thành công";
            }
            catch (Exception ex)
            {
                return "Thêm tài khoản thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Update(TaiKhoan tk)
        {
            try
            {
                var existingTaiKhoan = _appDbContext.TaiKhoans.FirstOrDefault(tk => tk.Id == tk.Id);
                if (existingTaiKhoan != null)
                {
                    existingTaiKhoan.HoVaTen = tk.HoVaTen;
                    existingTaiKhoan.NgaySinh = tk.NgaySinh;
                    existingTaiKhoan.DiaChi = tk.DiaChi;
                    existingTaiKhoan.Sdt = tk.Sdt;
                    existingTaiKhoan.Email = tk.Email;
                    existingTaiKhoan.MaNhanVien = tk.MaNhanVien;
                    existingTaiKhoan.TenTaiKhoan = tk.TenTaiKhoan;
                    existingTaiKhoan.MatKhau = tk.MatKhau;
                    existingTaiKhoan.ChucVu = tk.ChucVu;
                    existingTaiKhoan.Status = tk.Status;
                    existingTaiKhoan.ModifyBy = tk.ModifyBy;
                    existingTaiKhoan.ModifyTime = tk.ModifyTime;
                    existingTaiKhoan.DeleteBy = tk.DeleteBy;
                    existingTaiKhoan.DeleteTime = tk.DeleteTime;

                    _appDbContext.TaiKhoans.Update(existingTaiKhoan);
                    _appDbContext.SaveChanges();
                    return "Cập nhật tài khoản thành công";
                }
                return "Không tìm thấy tài khoản cần cập nhật";
            }
            catch (Exception ex)
            {
                return "Cập nhật tài khoản thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Delete(TaiKhoan tk)
        {
            try
            {
                var existingTaiKhoan = _appDbContext.TaiKhoans.FirstOrDefault(tk => tk.Id == tk.Id);
                if (existingTaiKhoan != null)
                {
                    _appDbContext.TaiKhoans.Remove(existingTaiKhoan);
                    _appDbContext.SaveChanges();
                    return "Xóa tài khoản thành công";
                }
                return "Không tìm thấy tài khoản cần xóa";
            }
            catch (Exception ex)
            {
                return "Xóa tài khoản thất bại\nLỗi: " + ex.Message;
            }
        }
    }
}
