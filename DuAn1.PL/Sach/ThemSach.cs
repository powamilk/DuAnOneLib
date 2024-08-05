using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.Sachs;
using DuAnOne.PL.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnOne.PL.Sach
{
    public partial class ThemSach : Form
    {
        List<SachVM> _sachs;
        ISachService _sachService;
        private Guid _id;

        public event Action DataAdded;
        public ThemSach()
        {
            LoadFormData();
            InitializeComponent();
            _sachService = new SachService();
            _sachs = _sachService.GetList();
        }

        private void LoadFormData()
        {
            cb_status.Items.Add("Het");
            cb_status.Items.Add("Con");
            cb_status.Items.Add("Rach");
            cb_status.Items.Add("Thieu Trang");
        }

        public void SendData(Guid id, string tenSach, int namXuatBan, int soLuong, string theLoai, string maSach, double giaTien, string tacGia, int status)
        {
            _id = id;
            txt_tensach.Text = tenSach;
            nb_namxuatban.Text = namXuatBan.ToString();
            nb_soluong.Text = soLuong.ToString();
            txt_theloai.Text = theLoai;
            txt_masach.Text = maSach;
            nb_giatien.Text = giaTien.ToString();
            txt_tacgia.Text = tacGia;
            cb_status.Text = status.ToString();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận việc thêm dữ liệu
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn thêm sách?"))
            {
                // Xác thực dữ liệu đầu vào từ các ô nhập liệu
                if (string.IsNullOrWhiteSpace(txt_tensach.Text))
                {
                    MessageBoxExtension.Notification("Lỗi", "Tên sách không được để trống.");
                    return;
                }

                if (!int.TryParse(nb_namxuatban.Text, out int namXuatBan))
                {
                    MessageBoxExtension.Notification("Lỗi", "Năm xuất bản không hợp lệ.");
                    return;
                }

                if (!int.TryParse(nb_soluong.Text, out int soLuong))
                {
                    MessageBoxExtension.Notification("Lỗi", "Số lượng không hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_theloai.Text))
                {
                    MessageBoxExtension.Notification("Lỗi", "Thể loại không được để trống.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_masach.Text))
                {
                    MessageBoxExtension.Notification("Lỗi", "Mã sách không được để trống.");
                    return;
                }

                if (!double.TryParse(nb_giatien.Text, out double giaTien))
                {
                    MessageBoxExtension.Notification("Lỗi", "Giá tiền không hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_tacgia.Text))
                {
                    MessageBoxExtension.Notification("Lỗi", "Tác giả không được để trống.");
                    return;
                }

                if (!int.TryParse(cb_status.Text, out int status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Trạng thái không hợp lệ.");
                    return;
                }

                // Tạo đối tượng tạo sách
                var sachCreate = new SachCreateVM
                {
                    TenSach = txt_tensach.Text,
                    NamXuatBan = namXuatBan,
                    SoLuong = soLuong,
                    TheLoai = txt_theloai.Text,
                    MaSach = txt_masach.Text,
                    GiaTien = giaTien,
                    TacGia = txt_tacgia.Text,
                    Status = status
                };

                // Gọi phương thức Create của dịch vụ
                var result = _sachService.Create(sachCreate);
                bool isSuccess = result.Equals("Sách đã được tạo thành công.", StringComparison.OrdinalIgnoreCase);

                // Hiển thị thông báo kết quả
                MessageBoxExtension.Notification("THÊM", result);

                if (isSuccess)
                {
                    // Nếu cần, gọi phương thức để làm mới dữ liệu trong giao diện
                    DataAdded?.Invoke();

                    // Đóng form sau khi thêm thành công
                    this.Close();
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
