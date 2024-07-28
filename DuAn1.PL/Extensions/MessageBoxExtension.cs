namespace DuAnOne.PL.Extensions
{
    public static class MessageBoxExtension
    {
        public static void Notification(string title, string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK);
        }

        public static bool Confirm(string msg)
        {
            var result = MessageBox.Show($"Bạn có muốn {msg} không ?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            return result == DialogResult.OK;
        }
    }
}
