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
        public ThemChiTietPhieuMuon(ISachService sachService, Guid idPhieuMuon)
        {
            InitializeComponent();
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;

            LoadSachToComboBox();
        }

        private void LoadSachToComboBox()
        {
            var sachList = _sachService.GetList();
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "Id";
            cb_sach.DataSource = sachList;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSachId = (Guid)cb_sach.SelectedValue;
                var soLuong = int.Parse(txt_soluong.Text);
                var ghiChu = txt_ghichu.Text;
                var status = (int)((dynamic)cb_status.SelectedItem).Value;

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
