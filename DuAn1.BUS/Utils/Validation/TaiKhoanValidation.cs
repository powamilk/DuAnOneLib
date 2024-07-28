using DuAnOne.BUS.ViewModel.TaiKhoans;

namespace DuAnOne.BUS.Utils.Validation
{
    public class TaiKhoanValidation
    {
        public static string ValidateCreatVM(TaiKhoanCreateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin giảng viên";

            result += BaseValidation.CheckEmpty("tên", vm.HoVaTen);
            result += BaseValidation.CheckEmpty("email", vm.Email);
            result += BaseValidation.CheckEmpty("Ngày Sinh", vm.NgaySinh.ToString());
            result += BaseValidation.CheckEmpty("SDT", vm.Sdt);
            result += BaseValidation.CheckEmpty("Mã Nhân Viên", vm.MaNhanVien);
            result += BaseValidation.CheckEmpty("Tên Tài Khoản", vm.TenTaiKhoan);
            result += BaseValidation.CheckEmpty("Mật Khẩu", vm.MatKhau);
            result += BaseValidation.CheckEmpty("Chức Vụ", vm.ChucVu.ToString());
            result += BaseValidation.CheckEmpty("Địa Chỉ", vm.DiaChi);
            result += BaseValidation.CheckEmpty("Status", vm.Status.ToString());
            return result;
        }
    }
}
