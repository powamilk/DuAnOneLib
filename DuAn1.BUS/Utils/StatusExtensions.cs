using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils
{
    public static class StatusExtensions
    {
        public static string GetStatusDescription(int status)
        {
            return status switch
            {
                1 => "Đang hoạt động",
                2 => "Tạm ngưng",
                3 => "Đã bị xóa",
                _ => "Không xác định"
            };
        }
    }
}
