using DuAnOne.BUS.Implement;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using Microsoft.VisualBasic.ApplicationServices;

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
            var taiKhoanService = new TaiKhoanService();

            using (var loginForm = new Login(taiKhoanService))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu đăng nhập thành công, mở TabForm
                    var mainForm = new TabForm(loginForm.LoggedInUserId, loginForm.UserRole, loginForm.MaNhanVien, loginForm.LoaiTaiKhoan);
                    Application.Run(mainForm);
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
