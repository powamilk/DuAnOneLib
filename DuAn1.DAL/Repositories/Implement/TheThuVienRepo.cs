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

        public string Create(TheThuVien ttv)
        {
            try
            {
                _appDbContext.TheThuViens.Add(ttv);
                _appDbContext.SaveChanges();
                return "Thêm thẻ thư viện thành công";
            }
            catch (Exception ex)
            {
                return "Thêm thẻ thư viện thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Update(TheThuVien ttv)
        {
            try
            {
                var existingTheThuVien = _appDbContext.TheThuViens.FirstOrDefault(ttv => ttv.Id == ttv.Id);
                if (existingTheThuVien != null)
                {
                    existingTheThuVien.IdChuThe = ttv.IdChuThe;
                    existingTheThuVien.NgayCap = ttv.NgayCap;
                    existingTheThuVien.NgayHetHan = ttv.NgayHetHan;
                    existingTheThuVien.MaThe = ttv.MaThe;
                    existingTheThuVien.Status = ttv.Status;
                    existingTheThuVien.ModifyBy = ttv.ModifyBy;
                    existingTheThuVien.ModifyTime = ttv.ModifyTime;
                    existingTheThuVien.DeleteBy = ttv.DeleteBy;
                    existingTheThuVien.DeleteTime = ttv.DeleteTime;

                    _appDbContext.TheThuViens.Update(existingTheThuVien);
                    _appDbContext.SaveChanges();
                    return "Cập nhật thẻ thư viện thành công";
                }
                return "Không tìm thấy thẻ thư viện cần cập nhật";
            }
            catch (Exception ex)
            {
                return "Cập nhật thẻ thư viện thất bại\nLỗi: " + ex.Message;
            }
        }

        public string Delete(TheThuVien ttv)
        {
            try
            {
                var existingTheThuVien = _appDbContext.TheThuViens.FirstOrDefault(ttv => ttv.Id == ttv.Id);
                if (existingTheThuVien != null)
                {
                    _appDbContext.TheThuViens.Remove(existingTheThuVien);
                    _appDbContext.SaveChanges();
                    return "Xóa thẻ thư viện thành công";
                }
                return "Không tìm thấy thẻ thư viện cần xóa";
            }
            catch (Exception ex)
            {
                return "Xóa thẻ thư viện thất bại\nLỗi: " + ex.Message;
            }
        }
    }
}
