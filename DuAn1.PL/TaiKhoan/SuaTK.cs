using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.Extensions;

namespace DuAn1.PL
{
    public partial class SuaTK : Form
    {
        List<TaiKhoanVM> _taiKhoans;
        ITaiKhoanService _taiKhoanService;
        private Guid _id;

        public event Action _onDataUpdated;

        public SuaTK(Action onDataUpdated)
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
            _onDataUpdated = onDataUpdated;
            LoadFormData();
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
            // Hiển thị hộp thoại xác nhận việc sửa dữ liệu
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn sửa tài khoản?"))
            {
                // Xác thực dữ liệu đầu vào từ các ô nhập liệu
                DateTime ngaySinh;
                if (!DateTime.TryParse(txt_ngaysinh.Text, out ngaySinh))
                {
                    MessageBoxExtension.Notification("Lỗi", "Ngày sinh không hợp lệ.");
                    return;
                }

                int chucVu;
                string chucVuText = cbx_chucvu.Text.Trim();
                if (string.IsNullOrEmpty(chucVuText) || !int.TryParse(chucVuText, out chucVu))
                {
                    MessageBoxExtension.Notification("Lỗi", "Chức vụ không hợp lệ.");
                    return;
                }

                int status;
                string statusText = cbx_status.Text.Trim();
                if (string.IsNullOrEmpty(statusText) || !int.TryParse(statusText, out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Status không hợp lệ.");
                    return;
                }

                // Tạo đối tượng cập nhật tài khoản
                var tkUpdate = new TaiKhoanUpdateVM
                {
                    Id = _id, // Biến _id chứa ID tài khoản cần cập nhật
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

                // Gọi phương thức Update của service
                var result = _taiKhoanService.Update(tkUpdate);
                bool isSuccess = result.Equals("Cập nhật tài khoản thành công.", StringComparison.OrdinalIgnoreCase);

                // Hiển thị thông báo kết quả
                MessageBoxExtension.Notification("SỬA", result);

                if (isSuccess)
                {
                    // Nếu cần, gọi phương thức để làm mới dữ liệu trong giao diện
                    _onDataUpdated?.Invoke();

                    // Đóng form sau khi sửa thành công
                    this.Close();
                }
            }
        }


        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaTK_Load(object sender, EventArgs e)
        {

        }
    }
}
