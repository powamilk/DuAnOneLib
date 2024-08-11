using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils.Validation;
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
        public event Action _onDataAdded;

        public ThemSach(Action onDataAdded)
        {
           
            InitializeComponent();
            _sachService = new SachService();
            _onDataAdded = onDataAdded;
            LoadFormData();
        }

        private void LoadFormData()
        {
            cb_status.Items.Clear();
            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn thêm sách?"))
            {
                // Xác thực dữ liệu đầu vào từ các ô nhập liệu
                if (string.IsNullOrWhiteSpace(txt_tensach.Text))
                {
                    MessageBoxExtension.Notification("Lỗi", "Tên sách không được để trống.");
                    return;
                }

                if (!int.TryParse(txt_namxuatban.Text, out int namXuatBan))
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

                if (!double.TryParse(txt_giatien.Text, out double giaTien))
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

                var validResult = SachValidation.ValidateCreateVM(sachCreate);

                if (string.IsNullOrEmpty(validResult))
                {    
                    var result = _sachService.Create(sachCreate);
                    bool isSuccess = result.Equals("Thêm sách thành công.", StringComparison.OrdinalIgnoreCase);
                    MessageBoxExtension.Notification("THÊM", result);

                    if (isSuccess)
                    {
                        _onDataAdded?.Invoke();                 
                    }
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
