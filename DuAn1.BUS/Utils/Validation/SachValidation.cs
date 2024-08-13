using DuAnOne.BUS.ViewModel.Sachs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils.Validation
{
    public class SachValidation
    {
        public static string ValidateCreateVM(SachCreateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin sách";

            result += BaseValidation.CheckEmpty("Tên Sách", vm.TenSach);
            result += BaseValidation.CheckNumber("Năm Xuất Bản", vm.NamXuatBan, minValue: 1000);
            result += BaseValidation.CheckNumber("Số Lượng", vm.SoLuong);
            result += BaseValidation.CheckEmpty("Mã Sách", vm.MaSach);
            result += BaseValidation.CheckNumber("Giá Tiền", vm.GiaTien);
            return result;
        }

        public static string ValidateUpdateVM(SachUpdateVM vm)
        {
            string result = string.Empty;

            if (vm == null)
                return "Yêu cầu nhập thông tin sách";

            if (!string.IsNullOrWhiteSpace(vm.TenSach))
            {
                result += BaseValidation.CheckEmpty("Tên Sách", vm.TenSach);
            }

            // Kiểm tra thuộc tính nullable với giá trị
            if (vm.NamXuatBan.HasValue)
            {
                result += BaseValidation.CheckNumber("Năm Xuất Bản", vm.NamXuatBan.Value, minValue: 1000);
            }

            if (vm.SoLuong.HasValue)
            {
                result += BaseValidation.CheckNumber("Số Lượng", vm.SoLuong.Value);
            }

            if (!string.IsNullOrWhiteSpace(vm.MaSach))
            {
                result += BaseValidation.CheckEmpty("Mã Sách", vm.MaSach);
            }

            if (vm.GiaTien.HasValue)
            {
                result += BaseValidation.CheckNumber("Giá Tiền", vm.GiaTien.Value);
            }
            return result;
        }
    }



}
