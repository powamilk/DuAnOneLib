namespace DuAnOne.BUS.Utils.Validation
{
    public static class BaseValidation
    {
        public static string CheckEmpty(string propertyName, string propertyValue)
        {
            if (string.IsNullOrWhiteSpace(propertyValue))
                return $"Không được để trống {propertyName}\n";

            return string.Empty;
        }

        public static string CheckDate(string fieldName, DateTime? date)
        {
            if (!date.HasValue || date.Value == default(DateTime))
                return $"{fieldName} không hợp lệ hoặc chưa được chọn.\n";
            return string.Empty;
        }

        public static string CheckDateRange(string fieldName, DateTime? startDate, DateTime? endDate)
        {
            if (startDate.HasValue && endDate.HasValue && startDate.Value > endDate.Value)
                return $"{fieldName} không hợp lệ: Ngày bắt đầu không thể lớn hơn ngày kết thúc.\n";
            return string.Empty;
        }

        public static string CheckNumber(string fieldName, int value, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            return value < minValue || value > maxValue ? $"{fieldName} phải nằm trong khoảng từ {minValue} đến {maxValue}.\n" : string.Empty;
        }

        public static string CheckNumber(string fieldName, double value, double minValue = double.MinValue)
        {
            return value < minValue ? $"{fieldName} không được nhỏ hơn {minValue}.\n" : string.Empty;
        }

    }
}