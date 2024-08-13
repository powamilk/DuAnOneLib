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
        private ComboBox cb_idThe;
        private Guid _idPhieuMuonDN;


        public event Action _onDataAdded;

        public ThemPhieuMuon(Action onDataAdded)
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            this.cb_idThe = new System.Windows.Forms.ComboBox();
            LoadFormData();
            
            _onDataAdded = onDataAdded;
        }
        private void LoadFormData()
        {
            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");

            LoadIdTheData();
        }

        public void SendCurrentUserId(Guid CurrentUserId)
        {
            _idPhieuMuonDN = CurrentUserId;
        }

        private void LoadIdTheData()
        {
            try
            {
                var idTheList = _phieuMuonService.GetIdTheList();

                if (idTheList == null || !idTheList.Any())
                {
                    MessageBox.Show("Không có dữ liệu thẻ thư viện để hiển thị.");
                    return;
                }

                cb_idThe.DataSource = null; // Đặt DataSource thành null trước khi thiết lập lại
                cb_idThe.DataSource = idTheList;
                cb_idThe.DisplayMember = "MaThe"; // Thuộc tính hiển thị
                cb_idThe.ValueMember = "Id";       // Thuộc tính giá trị
                if (idTheList.Count > 0)
                {
                    cb_idThe.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp dữ liệu vào ComboBox: {ex.Message}");
            }
        }


        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn thêm phiếu mượn?"))
            {
                DateTime ngayMuon;
                DateTime ngayTra;
                DateTime ngayTraThucTe;

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
                if (cb_idThe.SelectedValue == null)
                {
                    MessageBoxExtension.Notification("Lỗi", "Chưa chọn thẻ thư viện.");
                    return;
                }


                int status;
                string statusText = cb_status.Text.Trim();
                if (string.IsNullOrEmpty(statusText) || !int.TryParse(statusText, out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Trạng thái không hợp lệ.");
                    return;
                }

                var phieuMuonCreate = new PhieuMuonCreateVM
                {
                    IdThe = (Guid)cb_idThe.SelectedValue, // Lấy giá trị đã chọn từ ComboBox
                    NgayMuon = ngayMuon,
                    NgayTra = ngayTra,
                    NgayTraThucTe = ngayTraThucTe,
                    MaPhieu = txt_maphieu.Text,
                    Status = status,
                    CreateBy = _idPhieuMuonDN
                };

                var result = _phieuMuonService.Create(phieuMuonCreate);
                bool isSuccess = result.Equals("Thêm phiếu mượn thành công.", StringComparison.OrdinalIgnoreCase);

                MessageBoxExtension.Notification("THÊM", result);

                if (isSuccess)
                {
                    // Nếu cần, gọi phương thức để làm mới dữ liệu trong giao diện
                    _onDataAdded?.Invoke();
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
