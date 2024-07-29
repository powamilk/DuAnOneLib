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
    }
}