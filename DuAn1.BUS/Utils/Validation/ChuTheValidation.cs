using DuAnOne.BUS.ViewModel.ChuThes;

namespace DuAnOne.BUS.Utils.Validation
{
    public class ChuTheValidation
    {
        public static string ValidateCreateVM(ChuTheCreateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin chủ thẻ";

            result += BaseValidation.CheckEmpty("CCCD", vm.Cccd);
            result += BaseValidation.CheckEmpty("Tên", vm.HoVaTen);
            result += BaseValidation.CheckEmpty("Địa Chỉ", vm.DiaChi);
            result += BaseValidation.CheckEmpty("Ngành Nghề", vm.NgheNghiep);
            result += BaseValidation.CheckEmpty("Email", vm.Email);
            result += BaseValidation.CheckEmpty("Nơi Làm Việc", vm.NoiLamViec);

            result += BaseValidation.CheckEmpty("Loại Thẻ", vm.LoaiThe.ToString());
            result += BaseValidation.CheckEmpty("Giới Tính", vm.GioiTinh.ToString());
            result += BaseValidation.CheckEmpty("Quốc Tịch", vm.QuocTich.ToString());
            result += BaseValidation.CheckEmpty("Loại Bạn Đọc", vm.LoaiBanDoc.ToString());

            return result;
        }
    }
}
