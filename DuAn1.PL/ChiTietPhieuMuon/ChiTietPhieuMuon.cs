using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
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
    public partial class ChiTietPhieuMuon : Form
    {
        private IChiTietPhieuMuonService _chiTietPhieuMuonService;
        private ISachService _sachService;
        private Guid _idPhieuMuon;
        private SuaChiTietPhieuMuon _suaChiTietPhieuMuon;
        private ThemChiTietPhieuMuon _themChiTietPhieuMuon;
        private Guid _selectedIdPhieuMuon;
        private Guid _selectedIdSach;
        private int _selectedSoLuong;
        private string _selectedGhiChu;
        private int _selectedStatus;

        public ChiTietPhieuMuon(IChiTietPhieuMuonService chiTietPhieuMuonService, ISachService sachService, Guid idPhieuMuon)
        {
            InitializeComponent();
            _chiTietPhieuMuonService = chiTietPhieuMuonService;
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;
            LoadChiTietPhieuMuon();
        }

        private void LoadFormData()
        {
            dgv_chitietphieumuon.Columns.Clear();
            dgv_chitietphieumuon.Columns.Add("Column1", "STT");
            dgv_chitietphieumuon.Columns.Add("Column2", "Mã Sách");
            dgv_chitietphieumuon.Columns.Add("Column3", "Tên Sách");
            dgv_chitietphieumuon.Columns.Add("Column4", "Số Lượng Mượn");
            dgv_chitietphieumuon.Columns.Add("Column5", "Ghi chú");
            dgv_chitietphieumuon.Columns.Add("Column6", "Trạng Thái");
        }

        private void LoadChiTietPhieuMuon()
        {
            var chiTietPhieuMuons = _chiTietPhieuMuonService.GetByIdPhieuMuon(_idPhieuMuon);
            dgv_chitietphieumuon.Rows.Clear();

            foreach (var ct in chiTietPhieuMuons)
            {
                var sach = _sachService.GetById(ct.IdSach);
                if (sach != null)
                {
                    dgv_chitietphieumuon.Rows.Add(
                        sach.MaSach,
                        sach.TenSach,
                        ct.SoLuongMuon,
                        ct.GhiChu,
                        sach.Status
                    );
                }
            }
        }

        //private void ShowSuaChiTietPhieuMuon()
        //{
        //    if (_suaChiTietPhieuMuon == null)
        //    {
        //        _suaChiTietPhieuMuon = new SuaChiTietPhieuMuon();
        //        _suaChiTietPhieuMuon.FormClosed += SuaChiTietPhieuMuon_FormClosed;
        //    }
        //    _suaChiTietPhieuMuon.SendData(_selectedIdPhieuMuon, _selectedIdSach, _selectedSoLuong, _selectedGhiChu, _selectedStatus);
        //    _suaChiTietPhieuMuon.Show(); // Hiển thị form mới
        //}

        private void SuaChiTietPhieuMuon_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadChiTietPhieuMuon();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        //private void btn_xoa_Click(object sender, EventArgs e)
        //{
        //    if (_selectedIdPhieuMuon == Guid.Empty || _selectedIdSach == Guid.Empty)
        //    {
        //        MessageBox.Show("Chưa chọn chi tiết phiếu mượn để xóa.");
        //        return;
        //    }

        //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu mượn này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        var ketQua = _chiTietPhieuMuonService.Delete(_selectedIdPhieuMuon, _selectedIdSach);
        //        string thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";
        //        MessageBox.Show(thongBao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        LoadChiTietPhieuMuon();
        //    }
        //}

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
