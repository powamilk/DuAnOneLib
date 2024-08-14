using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnOne.BUS.Utils.StatusExtensions
{
    public static class StatusExtensionsPhieuMuon
    {
        public static string GetStatusName(int status)
        {
            return status switch
            {
                1 => "1 - Đang mượn",
                2 => "2 - Đã trả",
                3 => "3 - Quá hạn",
                4 => "4 - Đã trả quá hạn",
                _ => "Không xác định"
            };
        }
    }
}
