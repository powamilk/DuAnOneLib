using DuAnOne.BUS.Implement;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;

namespace DuAnOne.PL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo đối tượng AppDbContext và TaiKhoanRepo
            var dbContext = new AppDbContext();
            var taiKhoanRepo = new TaiKhoanRepo(dbContext);

            // Tạo đối tượng TaiKhoanService với repo
            var taiKhoanService = new TaiKhoanService();

            // Tạo đối tượng LoginForm
            using (var loginForm = new Login(taiKhoanService))
            {
                // Hiển thị LoginForm và kiểm tra kết quả đăng nhập
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu đăng nhập thành công, mở TabForm
                    Application.Run(new TabForm());
                }
                else
                {
                    // Nếu đăng nhập thất bại hoặc người dùng hủy, đóng ứng dụng
                    Application.Exit();
                }
            }
        }
    }
}
