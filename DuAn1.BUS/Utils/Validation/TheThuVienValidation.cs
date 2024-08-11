using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils.Validation
{
    public class TheThuVienValidation
    {
        public static string ValidateCreateVM(TheThuVienCreateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin thẻ thư viện.";

            result += BaseValidation.CheckEmpty("Mã Thẻ", vm.MaThe);
            result += BaseValidation.CheckDate("Ngày Cấp", vm.NgayCap);
            result += BaseValidation.CheckDate("Ngày Hết Hạn", vm.NgayHetHan);
            result += BaseValidation.CheckEmpty("Trạng Thái", vm.Status.ToString());

            return result;
        }

        public static string ValidateUpdateVM(TheThuVienUpdateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin thẻ thư viện.";

            result += BaseValidation.CheckEmpty("Mã Thẻ", vm.MaThe);
            result += BaseValidation.CheckDate("Ngày Cấp", vm.NgayCap);
            result += BaseValidation.CheckDate("Ngày Hết Hạn", vm.NgayHetHan);
            result += BaseValidation.CheckEmpty("Trạng Thái", vm.Status.ToString());

            return result;
        }

        public static string ValidateEntity(TheThuVien entity)
        {
            string result = string.Empty;

            if (entity == null)
                return "Yêu cầu nhập thông tin thẻ thư viện.";

            result += BaseValidation.CheckEmpty("Mã Thẻ", entity.MaThe);
            result += BaseValidation.CheckDate("Ngày Cấp", entity.NgayCap);
            result += BaseValidation.CheckDate("Ngày Hết Hạn", entity.NgayHetHan);
            result += BaseValidation.CheckEmpty("Trạng Thái", entity.Status.ToString());

            return result;
        }
    }
}
