using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TheThuViens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnOne.PL.TheThuVien
{
    public partial class SuaTheThuVien : Form
    {
        List<TheThuVienVM> _theThuViens;
        ITheThuVienService _theThuVienService;
        private Guid _id;

        public Action DataUpdated;

        public SuaTheThuVien()
        {
            InitializeComponent();
            LoadFormData();
            _theThuVienService = new TheThuVienService();
        }

        private void LoadFormData()
        {
            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");
        }

        public void SendData(Guid id, Guid chuThe, DateTime ngayCap, DateTime ngayHetHan, String maThe, int status)
        {
            _id = id;
            txt_idchuthe.Text = chuThe.ToString();
            txt_ngaycap.Text = ngayCap.ToString();
            txt_ngayhethan.Text = ngayHetHan.ToString();
            txt_mathe.Text = maThe;
            cb_status.Text = status.ToString();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            // Xác nhận hành động từ người dùng
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật thẻ thư viện này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Kiểm tra và chuyển đổi dữ liệu nhập vào
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
                // Tạo ViewModel từ dữ liệu nhập vào
                var theThuVienUpdateVM = new TheThuVienUpdateVM
                {
                    IdChuThe = Guid.Parse(txt_idchuthe.Text),
                    NgayCap = ngayCap,
                    NgayHetHan = ngayHetHan,
                    MaThe = txt_mathe.Text,
                    Status = status
                };

                // Gọi phương thức cập nhật của dịch vụ
                bool isSuccess = _theThuVienService.Update(theThuVienUpdateVM);

                // Thông báo kết quả cho người dùng
                if (isSuccess)
                {
                    MessageBox.Show("Cập nhật thẻ thư viện thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kích hoạt sự kiện DataUpdated nếu có
                    DataUpdated?.Invoke();

                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật thẻ thư viện không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
