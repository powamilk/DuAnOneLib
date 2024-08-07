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
        }

        private void SuaChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadSachComboBox();
            LoadChiTietPhieuMuon();
        }

        private void LoadSachComboBox()
        {
            var sachList = _sachService.GetList();
            cb_sach.DataSource = sachList;
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "Id";
        }
        private void LoadChiTietPhieuMuon()
        {
            var chiTiet = _chiTietPhieuMuonService.GetById(_idPhieuMuon, _idSach);
            if (chiTiet != null)
            {
                cb_sach.SelectedValue = chiTiet.IdSach;
                txt_soluong.Text = chiTiet.SoLuongMuon.ToString();
                txt_ghichu.Text = chiTiet.GhiChu;
                cb_status.SelectedIndex = cb_status.Items.IndexOf(chiTiet.Status == 1 ? "Hoạt động" : "Ngừng hoạt động");
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var selectedSachId = (Guid)cb_sach.SelectedValue;
            var soLuong = int.Parse(txt_soluong.Text);
            var ghiChu = txt_ghichu.Text;
            var status = (int)((dynamic)cb_status.SelectedItem).Value;

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
