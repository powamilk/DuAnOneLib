using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.ChiTietPhieuMuon;
using DuAnOne.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnOne.PL.ChiTietPhieuMuon
{
    public partial class ThemChiTietPhieuMuon : Form
    {
        private readonly IChiTietPhieuMuonService _chiTietPhieuMuonService;
        private readonly ISachService _sachService;
        private readonly Guid _idPhieuMuon;
        public ThemChiTietPhieuMuon(IChiTietPhieuMuonService chiTietPhieuMuonService, ISachService sachService, Guid idPhieuMuon)
        {
            InitializeComponent();
            _chiTietPhieuMuonService = chiTietPhieuMuonService;
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;

            // Load danh sách sách vào ComboBox
            LoadSachToComboBox();

            // Lấy ID sách được chọn (sau khi ComboBox đã được khởi tạo)
            var selectedSachId = (Guid)cb_sach.SelectedValue;

            // Load status dựa trên sách đã chọn
            LoadStatusToComboBox(selectedSachId);
        }

        private void LoadSachToComboBox()
        {
            var sachList = _sachService.GetList();
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "Id";
            cb_sach.DataSource = sachList;

            // Gọi LoadStatusToComboBox với sách đầu tiên khi khởi tạo
            if (cb_sach.SelectedValue != null)
            {
                LoadStatusToComboBox((Guid)cb_sach.SelectedValue);
            }

            // Xử lý sự kiện khi người dùng chọn sách khác
            cb_sach.SelectedIndexChanged += (s, e) =>
            {
                if (cb_sach.SelectedValue != null)
                {
                    LoadStatusToComboBox((Guid)cb_sach.SelectedValue);
                }
            };
        }

        private void LoadStatusToComboBox(Guid selectedSachId)
        {
            var sach = _sachService.GetById(selectedSachId);
            if (sach != null)
            {
                var statuses = new[]
                {
            new { Text = "Đang Mượn", Value = "Đang Mượn" },
            new { Text = "Đã Mượn", Value = "Đã Mượn" },
            new { Text = "Đã Trả", Value = "Đã Trả" },
            new { Text = "Quá hạn", Value = "Quá hạn" },
            new { Text = "Đã Trả quá hạn", Value = "Đã Trả quá hạn" },
            new { Text = "Đang yêu cầu", Value = "Đang yêu cầu" }
        };

                cb_status.DisplayMember = "Text";
                cb_status.ValueMember = "Value";
                cb_status.DataSource = statuses;

                // Đặt trạng thái hiện tại của sách
                cb_status.SelectedValue = GetStatusName(sach.Status);
            }
        }

        private string GetStatusName(int status)
        {
            return status switch
            {
                1 => "Đang Mượn ",
                2 => "Đã Mượn",
                3 => "Đã Trả",
                4 => "Quá hạn",
                5 => "Đã Trả quá hạn",
                _ => "đang yêu cầu",
            };
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSachId = (Guid)cb_sach.SelectedValue;
                var soLuong = int.Parse(txt_soluong.Text);
                var ghiChu = txt_ghichu.Text;
                var status = (int)cb_status.SelectedValue;

                // Gọi phương thức Add từ dịch vụ
                _chiTietPhieuMuonService.Add(new ChiTietPhieuMuonCreateVM
                {
                    IdPhieuMuon = _idPhieuMuon,
                    IdSach = selectedSachId,
                    SoLuongMuon = soLuong,
                    GhiChu = ghiChu,
                    Status = status
                });

                MessageBox.Show("Thêm chi tiết phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
