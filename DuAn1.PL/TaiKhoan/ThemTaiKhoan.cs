using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils.Status;
using DuAnOne.BUS.Utils.Validation;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.Extensions;
using System.Security.Cryptography;
using DuAnOne.BUS.Utils;

namespace DuAnOne.PL.TaiKhoan
{
    public partial class ThemTaiKhoan : Form
    {
        List<TaiKhoanVM> _taiKhoans;
        ITaiKhoanService _taiKhoanService;
        private readonly Action _onDataAdded;
        private Guid _idTaiKhoanDN;

        public ThemTaiKhoan(Action onDataAdded)
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
            _onDataAdded = onDataAdded;
            LoadFormData();
        }

        private void LoadFormData()
        {
            cbx_chucvu.Items.Clear();
            cbx_chucvu.Items.Add("1");
            cbx_chucvu.Items.Add("2");
            cbx_chucvu.Items.Add("3");

            cbx_status.Items.Clear();
            cbx_status.Items.Add(StatusEnum.HoatDong.GetStatusName());
            cbx_status.Items.Add(StatusEnum.KhongHoatDong.GetStatusName());
            cbx_status.Items.Add(StatusEnum.BiKhoa.GetStatusName());

        }



        public void SendCurrentUserId(Guid CurrentUserId)
        {
            _idTaiKhoanDN = CurrentUserId;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("them"))
            {
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
                if (string.IsNullOrEmpty(statusText) || !int.TryParse(statusText.Split(' ')[0], out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Status không hợp lệ.");
                    return;
                }

                var tkCreate = new TaiKhoanCreateVM
                {
                    HoVaTen = txt_hovaten.Text,
                    NgaySinh = ngaySinh,
                    DiaChi = txt_diachi.Text,
                    Sdt = txt_sodienthoai.Text,
                    Email = txt_email.Text,
                    MaNhanVien = txt_manhanvien.Text,
                    TenTaiKhoan = txt_taikhoan.Text,
                    MatKhau = txt_matkhau.Text,
                    ChucVu = chucVu,
                    Status = status,
                    CreateBy = _idTaiKhoanDN,
                };

                var validResult = TaiKhoanValidation.ValidateCreatVM(tkCreate);

                if (string.IsNullOrEmpty(validResult))
                {
                    // Kiểm tra và tạo tài khoản
                    var result = _taiKhoanService.Create(tkCreate);
                    bool isSuccess = result.Equals("Tài khoản đã được tạo thành công.", StringComparison.OrdinalIgnoreCase);
                    MessageBoxExtension.Notification("THÊM", result);

                    if (isSuccess)
                    {
                        _onDataAdded?.Invoke(); // Gọi hàm callback
                    }

                    this.Close(); // Đóng form sau khi thêm thành công
                }
                else
                {
                    MessageBoxExtension.Notification("THÊM", validResult);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}