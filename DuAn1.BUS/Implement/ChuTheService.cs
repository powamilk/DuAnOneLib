using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.BUS.Implement
{
    public class ChuTheService : IChuTheService
    {
        private readonly IChuTheRepo _repo;
        private readonly IChuTheRepo _chuTheRepo;
        private readonly ITheThuVienRepo _theThuVienRepo;  

        public ChuTheService()
        {
            _repo = new ChuTheRepo(new AppDbContext());
            _chuTheRepo = new ChuTheRepo(new AppDbContext());
            _theThuVienRepo = new TheThuVienRepo(new AppDbContext());  
        }

        public ChuTheVM GetById(Guid id)
        {
            ChuThe entity = _repo.GetById(id);
            ChuTheVM vm = ChuTheMapping.MapEntityToVM(entity);
            return vm;
        }

        public List<ChuTheVM> GetList()
        {
            List<ChuThe> entities = _repo.GetList();
            List<ChuTheVM> vms = entities.Select(e => ChuTheMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public string Create(ChuTheCreateVM createVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapCreateVMToEntity(createVM);
                _repo.Create(entity);
                return "Chủ thẻ đã được thêm thành công";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string Update(ChuTheUpdateVM updateVM)
        {
            try
            {
                ChuThe entity = ChuTheMapping.MapUpdateVMToEntity(updateVM);
                bool result = _repo.Update(entity);
                return result ? "Cập nhật thẻ thư viện thành công" : "Cập nhật thẻ thư viện không thành công";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public bool Delete(Guid id)
        {
            return _repo.Delete(id);
        }

        public List<ChuTheVM> GetAll()
        {
            List<ChuThe> entities = _repo.GetAll();
            return entities.Select(e => ChuTheMapping.MapEntityToVM(e)).ToList();
        }

        public List<(string CCCD, string HoVaTen, int SoLuongThe)> GetThongKeChuThe()
        {
            // Lấy danh sách tất cả Chủ Thẻ và Thẻ Thư Viện
            var chuTheList = _chuTheRepo.GetList();
            var theThuVienList = _theThuVienRepo.GetAll();

            // Tính toán số lượng thẻ cho mỗi chủ thẻ
            var result = chuTheList
                .Select(chuThe => new
                {
                    CCCD = chuThe.Cccd,
                    HoVaTen = chuThe.HoVaTen,
                    SoLuongThe = theThuVienList.Count(the => the.IdChuThe == chuThe.Id)
                })
                .Select(x => (x.CCCD, x.HoVaTen, x.SoLuongThe))
                .ToList();

            return result;
        }

    }
}
