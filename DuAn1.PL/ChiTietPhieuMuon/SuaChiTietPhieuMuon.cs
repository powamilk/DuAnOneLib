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
    public partial class SuaChiTietPhieuMuon : Form
    {
        private readonly IChiTietPhieuMuonService _chiTietPhieuMuonService;
        private readonly ISachService _sachService;
        private readonly Guid _idPhieuMuon;
        private readonly Guid _idSach;

        public SuaChiTietPhieuMuon(IChiTietPhieuMuonService chiTietPhieuMuonService, ISachService sachService, Guid idPhieuMuon, Guid idSach)
        {
            InitializeComponent();
            _chiTietPhieuMuonService = chiTietPhieuMuonService;
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;
            _idSach = idSach;

            // Load data when the form is loaded
            this.Load += SuaChiTietPhieuMuon_Load;
        }

        private void SuaChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadSachComboBox();
            LoadStatusComboBox();
            LoadChiTietPhieuMuon();
        }

        private void LoadSachComboBox()
        {
            var sachList = _sachService.GetList();
            cb_sach.DataSource = sachList;
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "Id";
        }

        private void LoadStatusComboBox()
        {
            var statuses = new[]
            {
                new { Text = "Đang mượn", Value = 1 },
                new { Text = "Đã trả", Value = 2 },
                new { Text = "Quá hạn", Value = 3 },
                new { Text = "Đã trả quá hạn", Value = 4 }
            };

            cb_status.DisplayMember = "Text";
            cb_status.ValueMember = "Value";
            cb_status.DataSource = statuses;
        }

        private void LoadChiTietPhieuMuon()
        {
            var chiTiet = _chiTietPhieuMuonService.GetById(_idPhieuMuon, _idSach);
            if (chiTiet != null)
            {
                cb_sach.SelectedValue = chiTiet.IdSach;
                txt_soluong.Text = chiTiet.SoLuongMuon.ToString();
                txt_ghichu.Text = chiTiet.GhiChu;
                cb_status.SelectedValue = chiTiet.Status; // Ensure this matches the Value of one of the items in the ComboBox
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_soluong.Text, out var soLuong))
            {
                MessageBox.Show("Số lượng mượn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ghiChu = txt_ghichu.Text;
            if (cb_status.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var status = (int)cb_status.SelectedValue; // Now the SelectedValue will be an integer
            var selectedSachId = (Guid)cb_sach.SelectedValue;

            var updateVM = new ChiTietPhieuMuonUpdateVM
            {
                IdPhieuMuon = _idPhieuMuon,
                IdSach = selectedSachId,
                SoLuongMuon = soLuong,
                GhiChu = ghiChu,
                Status = status,
                ModifyTime = DateTime.Now
            };

            try
            {
                _chiTietPhieuMuonService.Update(updateVM);
                MessageBox.Show("Cập nhật chi tiết phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật chi tiết phiếu mượn thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
