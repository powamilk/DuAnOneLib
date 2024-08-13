using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly ITaiKhoanRepo _repo;

        public TaiKhoanService()
        {
            _repo = new TaiKhoanRepo(new AppDbContext());
        }

        public TaiKhoanVM Login(string tenTaiKhoan, string matKhau)
        {
            // Tìm tài khoản trong cơ sở dữ liệu
            var taiKhoan = _repo.GetList().FirstOrDefault(tk => tk.TenTaiKhoan == tenTaiKhoan && tk.MatKhau == matKhau);

            if (taiKhoan != null)
            {
                // Nếu tài khoản tồn tại và mật khẩu khớp, trả về thông tin tài khoản
                return new TaiKhoanVM
                {
                    Id = taiKhoan.Id,
                    TenTaiKhoan = taiKhoan.TenTaiKhoan,
                    MatKhau = taiKhoan.MatKhau,
                    ChucVu = taiKhoan.ChucVu
                    // Cập nhật các thuộc tính khác nếu cần
                };
            }

            return null; // Nếu không tìm thấy tài khoản
        }

        public TaiKhoanVM GetById(Guid id)
        {
            TaiKhoan entity = _repo.GetById(id);
            TaiKhoanVM vm = TaiKhoanMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<TaiKhoanVM> GetList()
        {
            List<TaiKhoan> entities = _repo.GetList();
            List<TaiKhoanVM> vms = entities.Select(e => TaiKhoanMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(TaiKhoanCreateVM createVM)
        {
            try
            {
                TaiKhoan entity = TaiKhoanMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Tài khoản đã được tạo thành công.";
            }
            catch (Exception ex)
            {
                return $"Tạo tài khoản thất bại. Lỗi: {ex.Message}";
            }
        }

        public string Update(TaiKhoanUpdateVM updateVM)
        {
            try
            {
                TaiKhoan entity = TaiKhoanMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật tài khoản thành công." : "Cập nhật tài khoản thất bại.";
            }
            catch (Exception ex)
            {
                return $"Cập nhật tài khoản thất bại. Lỗi: {ex.Message}";
            }
        }

        public bool Delete(Guid id)
        {
            return _repo.Delete(id);
        }

        public string GetUserNameById(Guid userId)
        {
            return _repo.GetUserNameById(userId);
        }

        public List<TaiKhoanVM> GetAll()
        {
            List<TaiKhoan> entities = _repo.GetAll(); // Giả sử có phương thức GetAll trong repo
            return entities.Select(e => TaiKhoanMapping.MapEntityToVM(e)).ToList();
        }
        public bool ValidateUser(string tenTaiKhoan, string matKhau)
        {
            var taiKhoan = _repo.GetByUsername(tenTaiKhoan);
            if (taiKhoan == null)
            {
                return false;
            }

            // Kiểm tra mật khẩu
            return taiKhoan.MatKhau == matKhau;
        }

        public TaiKhoan GetByUsername(string username)
        {
            return _repo.GetByUsername(username);
        }

        public List<(string LoaiTaiKhoan, int SoLuong)> GetTaiKhoanStatistics()
        {
            // Lấy tất cả tài khoản
            var allTaiKhoan = _repo.GetAll();

            // Nhóm theo loại tài khoản và đếm số lượng
            var statistics = allTaiKhoan
                .GroupBy(tk => tk.ChucVu == 1 ? "Admin" : "NhanVien")
                .Select(group => (LoaiTaiKhoan: group.Key, SoLuong: group.Count()))
                .ToList();

            return statistics;
        }
    }
}
