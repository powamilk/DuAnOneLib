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

        public Login(ITaiKhoanService taiKhoanService)
        {
            InitializeComponent();
            _taiKhoanService = taiKhoanService;
        }
        public string Username { get; private set; }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txt_username.Text.Trim();
            string matKhau = txt_password.Text.Trim();

            // Xác thực người dùng
            var taiKhoan = _taiKhoanService.GetByUsername(tenTaiKhoan);
            if (taiKhoan != null && taiKhoan.MatKhau == matKhau)
            {
                LoggedInUserId = taiKhoan.Id;
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
