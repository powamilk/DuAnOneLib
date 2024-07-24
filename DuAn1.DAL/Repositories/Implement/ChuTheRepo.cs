using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.DAL.Repositories.Implement
{
    internal class ChuTheRepo : IChuTheRepo
    {
        private readonly AppDbContext _appDbContext;

        public ChuTheRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ChuThe> GetList()
        {
            return _appDbContext.ChuThes.ToList();
        }

        public ChuThe GetById(Guid id)
        {
            return _appDbContext.ChuThes.FirstOrDefault(c => c.Id == id);
        }

        public string Create(ChuThe ct)
        {
            try
            {
                _appDbContext.ChuThes.Add(ct);
                _appDbContext.SaveChanges();
                return "Tạo mới thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }

        public string Update(ChuThe ct)
        {
            try
            {
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == ct.Id);
                if (existingChuThe == null)
                {
                    return "Không tìm thấy đối tượng cần cập nhật.";
                }

                existingChuThe.Cccd = ct.Cccd;
                existingChuThe.HoVaTen = ct.HoVaTen;
                existingChuThe.LoaiThe = ct.LoaiThe;
                existingChuThe.DiaChi = ct.DiaChi;
                existingChuThe.GioiTinh = ct.GioiTinh;
                existingChuThe.NgheNghiep = ct.NgheNghiep;
                existingChuThe.QuocTich = ct.QuocTich;
                existingChuThe.LoaiBanDoc = ct.LoaiBanDoc;
                existingChuThe.Email = ct.Email;
                existingChuThe.NoiLamViec = ct.NoiLamViec;
                existingChuThe.Status = ct.Status;
                existingChuThe.CreateBy = ct.CreateBy;
                existingChuThe.CreateTime = ct.CreateTime;
                existingChuThe.ModifyBy = ct.ModifyBy;
                existingChuThe.ModifyTime = ct.ModifyTime;
                existingChuThe.DeleteBy = ct.DeleteBy;
                existingChuThe.DeleteTime = ct.DeleteTime;

                _appDbContext.ChuThes.Update(existingChuThe);
                _appDbContext.SaveChanges();

                return "Cập nhật thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }


        public string Delete(ChuThe ct)
        {
            try
            {
                var existingChuThe = _appDbContext.ChuThes.FirstOrDefault(c => c.Id == ct.Id);
                if (existingChuThe == null)
                {
                    return "Không tìm thấy đối tượng cần xóa.";
                }

                _appDbContext.ChuThes.Remove(existingChuThe);
                _appDbContext.SaveChanges();

                return "Xóa thành công.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }
    }
}
