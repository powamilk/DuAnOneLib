using DuAnOne.BUS.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnOne.PL
{
    public partial class Login : Form
    {

        private readonly ITaiKhoanService _taiKhoanService;
        public Guid LoggedInUserId { get; private set; }
        public int UserRole { get; private set; } // Thuộc tính mới để lưu chức vụ của người dùng
        public string LoaiTaiKhoan { get; private set; }
        public string MaNhanVien {  get; private set; }

        public Login(ITaiKhoanService taiKhoanService)
        {
            InitializeComponent();
            _taiKhoanService = taiKhoanService;
            txt_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txt_username.Text.Trim();
            string matKhau = txt_password.Text.Trim();

            // Xác thực người dùng
            var taiKhoan = _taiKhoanService.GetByUsername(tenTaiKhoan);
            if (taiKhoan != null && taiKhoan.MatKhau == matKhau)
            {
                LoggedInUserId = taiKhoan.Id;
                UserRole = taiKhoan.ChucVu;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TabForm mainForm = new TabForm(LoggedInUserId, UserRole, taiKhoan.MaNhanVien, UserRole == 1 ? "Admin" : "Nhân viên");
                this.Hide(); // Ẩn form login
                mainForm.ShowDialog(); // Mở form chính

                this.Show(); // Hiển thị lại form login nếu form chính đóng
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
