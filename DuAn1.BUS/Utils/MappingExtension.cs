using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.BUS.ViewModel.PhieuMuons;
using DuAnOne.BUS.ViewModel.Sachs;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.DAL.Entities;

namespace DuAnOne.BUS.Utils
{
    public static class MappingExtension
    {
        public static ChuTheVM MapEntityToVM(ChuThe entity)
        {
            return new ChuTheVM
            {
                Id = entity.Id,
                Cccd = entity.Cccd,
                HoVaTen = entity.HoVaTen,
                LoaiThe = entity.LoaiThe,
                DiaChi = entity.DiaChi,
                GioiTinh = entity.GioiTinh,
                NgheNghiep = entity.NgheNghiep,
                QuocTich = entity.QuocTich,
                LoaiBanDoc = entity.LoaiBanDoc,
                Email = entity.Email,
                NoiLamViec = entity.NoiLamViec,
                Status = entity.Status
            };
        }

        public static ChuThe MapVMToEntity(ChuTheVM vm)
        {
            return new ChuThe
            {
                Id = vm.Id,
                Cccd = vm.Cccd,
                HoVaTen = vm.HoVaTen,
                LoaiThe = vm.LoaiThe,
                DiaChi = vm.DiaChi,
                GioiTinh = vm.GioiTinh,
                NgheNghiep = vm.NgheNghiep,
                QuocTich = vm.QuocTich,
                LoaiBanDoc = vm.LoaiBanDoc,
                Email = vm.Email,
                NoiLamViec = vm.NoiLamViec,
                Status = vm.Status
            };
        }

        public static SachVM MapEntityToVM(Sach entity)
        {
            return new SachVM
            {
                Id = entity.Id,
                TenSach = entity.TenSach,
                NamXuatBan = entity.NamXuatBan,
                SoLuong = entity.SoLuong,
                TheLoai = entity.TheLoai,
                MaSach = entity.MaSach,
                GiaTien = entity.GiaTien,
                TacGia = entity.TacGia,
                Status = entity.Status
            };
        }

        public static Sach MapVMToEntity(SachVM vm)
        {
            return new Sach
            {
                Id = vm.Id,
                TenSach = vm.TenSach,
                NamXuatBan = vm.NamXuatBan,
                SoLuong = vm.SoLuong,
                TheLoai = vm.TheLoai,
                MaSach = vm.MaSach,
                GiaTien = vm.GiaTien,
                TacGia = vm.TacGia,
                Status = vm.Status
            };
        }

        public static TaiKhoanVM MapEntityToVM(TaiKhoan entity)
        {
            return new TaiKhoanVM
            {
                Id = entity.Id,
                HoVaTen = entity.HoVaTen,
                NgaySinh = entity.NgaySinh,
                DiaChi = entity.DiaChi,
                Sdt = entity.Sdt,
                Email = entity.Email,
                MaNhanVien = entity.MaNhanVien,
                TenTaiKhoan = entity.TenTaiKhoan,
                MatKhau = entity.MatKhau,
                ChucVu = entity.ChucVu,
                Status = entity.Status
            };
        }

        public static TaiKhoan MapVMToEntity(TaiKhoanVM vm)
        {
            return new TaiKhoan
            {
                Id = vm.Id,
                HoVaTen = vm.HoVaTen,
                NgaySinh = vm.NgaySinh,
                DiaChi = vm.DiaChi,
                Sdt = vm.Sdt,
                Email = vm.Email,
                MaNhanVien = vm.MaNhanVien,
                TenTaiKhoan = vm.TenTaiKhoan,
                MatKhau = vm.MatKhau,
                ChucVu = vm.ChucVu,
                Status = vm.Status
            };
        }

        public static TheThuVienVM MapEntityToVM(TheThuVien entity)
        {
            return new TheThuVienVM
            {
                Id = entity.Id,
                IdChuThe = entity.IdChuThe,
                NgayCap = entity.NgayCap,
                NgayHetHan = entity.NgayHetHan,
                MaThe = entity.MaThe,
                Status = entity.Status
            };
        }

        public static TheThuVien MapVMToEntity(TheThuVienVM vm)
        {
            return new TheThuVien
            {
                Id = vm.Id,
                IdChuThe = vm.IdChuThe,
                NgayCap = vm.NgayCap,
                NgayHetHan = vm.NgayHetHan,
                MaThe = vm.MaThe,
                Status = vm.Status
            };
        }

        public static PhieuMuonVM MapEntityToVM(PhieuMuon entity)
        {
            return new PhieuMuonVM
            {
                Id = entity.Id,
                IdTaiKhoan = entity.IdTaiKhoan,
                IdThe = entity.IdThe,
                NgayMuon = entity.NgayMuon,
                NgayTra = entity.NgayTra,
                NgayTraThucTe = entity.NgayTraThucTe,
                MaPhieu = entity.MaPhieu,
                Status = entity.Status,
                CreateBy = entity.CreateBy,
                CreateTime = entity.CreateTime,
                ModifyBy = entity.ModifyBy,
                ModifyTime = entity.ModifyTime,
                DeleteBy = entity.DeleteBy,
                DeleteTime = entity.DeleteTime
            };
        }

        public static PhieuMuon MapVMToEntity(PhieuMuonVM vm)
        {
            return new PhieuMuon
            {
                Id = vm.Id,
                IdTaiKhoan = vm.IdTaiKhoan,
                IdThe = vm.IdThe,
                NgayMuon = vm.NgayMuon,
                NgayTra = vm.NgayTra,
                NgayTraThucTe = vm.NgayTraThucTe,
                MaPhieu = vm.MaPhieu,
                Status = vm.Status,
                CreateBy = vm.CreateBy,
                CreateTime = vm.CreateTime,
                ModifyBy = vm.ModifyBy,
                ModifyTime = vm.ModifyTime,
                DeleteBy = vm.DeleteBy,
                DeleteTime = vm.DeleteTime
            };
        }


    }
}
