using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;

namespace DuAn1.PL
{
    public partial class SuaTK : Form
    {
        List<TaiKhoanVM> _taiKhoans;
        ITaiKhoanService _taiKhoanService;
        private Guid _id;

        public SuaTK()
        {
            InitializeComponent();
            LoadFormData();
            _taiKhoanService = new TaiKhoanService();
        }

        private void LoadFormData()
        {
            cbx_chucvu.Items.Add("Nhân Viên");
            cbx_chucvu.Items.Add("Quản Lý");
            cbx_chucvu.Items.Add("Admin");

            cbx_status.Items.Add("1");
            cbx_status.Items.Add("2");
            cbx_status.Items.Add("3");

        }



        public void SendData(Guid id, string hoVaTen, DateTime ngaySinh, string diaChi, string email, string sdt, string maNhanVien, string tenTaiKhoan, string matKhau, int chucVu, int status)
        {
            _id = id;
            txt_hovaten.Text = hoVaTen;
            txt_ngaysinh.Text = ngaySinh.ToString();
            txt_diachi.Text = diaChi;
            txt_email.Text = email;
            txt_sodienthoai.Text = sdt;
            txt_manhanvien.Text = maNhanVien;
            txt_matkhau.Text = matKhau;
            txt_taikhoan.Text = tenTaiKhoan;
            cbx_chucvu.Text = chucVu.ToString();
            cbx_status.Text = status.ToString();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh;
            if (!DateTime.TryParse(txt_ngaysinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi");
                return;
            }

            int chucVu;
            if (!int.TryParse(cbx_chucvu.Text, out chucVu))
            {
                MessageBox.Show("Chức vụ không hợp lệ.", "Lỗi");
                return;
            }

            int status;
            if (!int.TryParse(cbx_status.Text, out status))
            {
                MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi");
                return;
            }

            var tkUpdate = new TaiKhoanUpdateVM()
            {
                Id = _id, // Biến này nên chứa ID tài khoản cần cập nhật
                HoVaTen = txt_hovaten.Text,
                NgaySinh = ngaySinh,
                DiaChi = txt_diachi.Text,
                Email = txt_email.Text,
                Sdt = txt_sodienthoai.Text,
                MaNhanVien = txt_manhanvien.Text,
                TenTaiKhoan = txt_taikhoan.Text,
                MatKhau = txt_matkhau.Text,
                ChucVu = chucVu,
                Status = status
            };
            var result = _taiKhoanService.Update(tkUpdate);
            MessageBox.Show(result, "CHỈNH SỬA");
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
