using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils.StatusExtensions;
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
        ITheThuVienService _theThuVienService;
        private Guid _id;
        private ComboBox cb_idThe;
        private Guid _idPhieuMuonDN;


        public event Action _onDataAdded;

        public ThemPhieuMuon(Action onDataAdded)
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            _theThuVienService = new TheThuVienService();   
            this.cb_idThe = new System.Windows.Forms.ComboBox();
            LoadFormData();
            
            _onDataAdded = onDataAdded;
        }
        private void LoadFormData()
        {
            cb_status.Items.Add(StatusExtensionsPhieuMuon.GetStatusName(1));
            cb_status.Items.Add(StatusExtensionsPhieuMuon.GetStatusName(2));
            cb_status.Items.Add(StatusExtensionsPhieuMuon.GetStatusName(3));
            cb_status.Items.Add(StatusExtensionsPhieuMuon.GetStatusName(4));

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
                var theThuViens = _phieuMuonService.GetIdTheList(); // Lấy danh sách từ service

                if (theThuViens != null && theThuViens.Any())
                {
                    cb_idthe.DataSource = theThuViens;
                    cb_idthe.DisplayMember = "MaThe"; // Hiển thị Mã thẻ
                    cb_idthe.ValueMember = "Id"; // Giá trị là Id của thẻ
                }
                else
                {
                    MessageBox.Show("Không có thẻ thư viện nào để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp dữ liệu vào ComboBox: {ex.Message}");
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm phiếu mượn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime ngayMuon;
                DateTime ngayTra;
                DateTime? ngayTraThucTe = null;

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

                if (!string.IsNullOrWhiteSpace(txt_ngaytrathucte.Text))
                {
                    DateTime tempNgayTraThucTe;
                    if (DateTime.TryParse(txt_ngaytrathucte.Text, out tempNgayTraThucTe))
                    {
                        ngayTraThucTe = tempNgayTraThucTe;
                    }
                    else
                    {
                        MessageBoxExtension.Notification("Lỗi", "Ngày trả thực tế không hợp lệ.");
                        return;
                    }
                }

                if (cb_idthe.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn thẻ thư viện hợp lệ.");
                    return;
                }

                var selectedIdThe = (Guid)cb_idthe.SelectedValue;

                int status;
                if (string.IsNullOrEmpty(cb_status.Text) || !int.TryParse(cb_status.Text.Split('-')[0].Trim(), out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Trạng thái không hợp lệ.");
                    return;
                }

                var phieuMuonCreate = new PhieuMuonCreateVM
                {
                    IdThe = selectedIdThe,
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
                    _onDataAdded?.Invoke();
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
