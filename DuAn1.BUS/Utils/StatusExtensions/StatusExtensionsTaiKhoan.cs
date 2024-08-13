using DuAnOne.BUS.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils.StatusExtensions
{
    public static class StatusExtensionsTaiKhoan
    {
        public static string GetStatusName(this StatusEnum status)
        {
            return status switch
            {
                StatusEnum.HoatDong => "1 - Đang hoạt động",
                StatusEnum.KhongHoatDong => "2 - Không hoạt động",
                StatusEnum.BiKhoa => "3 - Bị khóa",
                _ => "Chưa xác định"
            };
        }
    }
}
