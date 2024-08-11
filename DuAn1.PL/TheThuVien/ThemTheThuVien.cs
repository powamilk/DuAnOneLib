using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TheThuViens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAnOne.BUS.Utils.Validation;
using DuAnOne.PL.Extensions;

namespace DuAnOne.PL.TheThuVien
{
    public partial class ThemTheThuVien : Form
    {
        List<TheThuVienVM> _theThuViens;
        ITheThuVienService _theThuVienService;

        public event Action _onDataAdded;

        public ThemTheThuVien(Action onDataAdded)
        {
            InitializeComponent();
            _theThuVienService = new TheThuVienService();
            _theThuViens = _theThuVienService.GetList();
            _onDataAdded = onDataAdded; 
            LoadFormData();
        }

        private void LoadFormData()
        {
            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm thẻ thư viện này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime ngayCap, ngayHetHan;
                if (!DateTime.TryParse(txt_ngaycap.Text, out ngayCap))
                {
                    MessageBox.Show("Ngày cấp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!DateTime.TryParse(txt_ngayhethan.Text, out ngayHetHan))
                {
                    MessageBox.Show("Ngày hết hạn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_mathe.Text))
                {
                    MessageBox.Show("Mã thẻ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int status;
                if (!int.TryParse(cb_status.Text, out status))
                {
                    MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo ViewModel từ dữ liệu nhập vào
                var ttvCreate = new TheThuVienCreateVM
                {
                    NgayCap = ngayCap,
                    NgayHetHan = ngayHetHan,
                    MaThe = txt_mathe.Text,
                    Status = status
                };

                var validResult = TheThuVienValidation.ValidateCreateVM(ttvCreate);
                if(string.IsNullOrEmpty(validResult))
                {
                    var result = _theThuVienService.Create(ttvCreate);
                    bool isSuccess = result.Equals("Tạo thẻ thư viện thành công.", StringComparison.OrdinalIgnoreCase);
                    MessageBoxExtension.Notification("THÊM", result);

                    if (isSuccess)
                    {
                        _onDataAdded?.Invoke();
                    }
                    this.Close();
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
