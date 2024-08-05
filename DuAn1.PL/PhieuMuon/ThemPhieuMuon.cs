using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.PhieuMuons;
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

namespace DuAnOne.PL.PhieuMuon
{
    public partial class ThemPhieuMuon : Form
    {
        List<PhieuMuonVM> _phieuMuons;
        IPhieuMuonService _phieuMuonService;
        private Guid _id;

        public event Action DataAdded;

        public ThemPhieuMuon()
        {
            InitializeComponent();
            LoadFormData();
            _phieuMuonService = new PhieuMuonService();
        }
        private void LoadFormData()
        {
            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");
        }

        public void SendData(Guid id, Guid idTaiKhoan, Guid idThe, DateTime ngayMuon, DateTime ngayTra, DateTime? ngayTraThucTe, string maPhieu, int status)
        {
            _id = id;
            txt_idtaikhoan.Text = idTaiKhoan.ToString();
            txt_idthe.Text = idThe.ToString();
            txt_ngaymuon.Text = ngayMuon.ToString("dd/MM/yyyy");
            txt_ngaytra.Text = ngayTra.ToString("dd/MM/yyyy");
            txt_ngaytrathucte.Text = ngayTraThucTe.HasValue ? ngayTraThucTe.Value.ToString("dd/MM/yyyy") : string.Empty;
            txt_maphieu.Text = maPhieu;
            cb_status.SelectedIndex = status - 1;
        }


        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn thêm phiếu mượn?"))
            {
                DateTime ngayMuon;
                DateTime ngayTra;
                DateTime ngayTraThucTe;

                // Kiểm tra và chuyển đổi các giá trị từ TextBox sang DateTime
                if (!DateTime.TryParse(txt_ngaymuon.Text, out ngayMuon))
                {
                    MessageBoxExtension.Notification("Lỗi", "Ngày mượn không hợp lệ.");
                    return;
                }
                if (!DateTime.TryParse(txt_ngaytra.Text, out ngayTra))
                {
                    MessageBoxExtension.Notification("Lỗi", "Ngày trả không hợp lệ.");
                    return;
                }
                if (!DateTime.TryParse(txt_ngaytrathucte.Text, out ngayTraThucTe))
                {
                    MessageBoxExtension.Notification("Lỗi", "Ngày trả thực tế không hợp lệ.");
                    return;
                }

                int status;
                string statusText = cb_status.Text.Trim();
                if (string.IsNullOrEmpty(statusText) || !int.TryParse(statusText, out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Trạng thái không hợp lệ.");
                    return;
                }

                // Tạo đối tượng thêm phiếu mượn
                var phieuMuonCreate = new PhieuMuonCreateVM
                {
                    IdTaiKhoan = Guid.Parse(txt_idtaikhoan.Text),
                    IdThe = Guid.Parse(txt_idthe.Text),
                    NgayMuon = ngayMuon,
                    NgayTra = ngayTra,
                    NgayTraThucTe = ngayTraThucTe,
                    MaPhieu = txt_maphieu.Text,
                    Status = status
                };

                // Gọi phương thức Create của service
                var result = _phieuMuonService.Create(phieuMuonCreate);
                bool isSuccess = result.Equals("Thêm phiếu mượn thành công.", StringComparison.OrdinalIgnoreCase);

                // Hiển thị thông báo kết quả
                MessageBoxExtension.Notification("THÊM", result);

                if (isSuccess)
                {
                    // Nếu cần, gọi phương thức để làm mới dữ liệu trong giao diện
                    DataAdded?.Invoke();
                    this.Close(); // Đóng form sau khi thêm thành công
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
