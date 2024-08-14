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
    public partial class ChiTietPhieuMuonForm : Form
    {
        List<ChiTietPhieuMuonVM> _chiTietPhieuMuons;
        private readonly IChiTietPhieuMuonService _chiTietPhieuMuonService;
        private readonly ISachService _sachService;
        private readonly Guid _idPhieuMuon;
        private readonly Guid _idTaiKhoan;
        private readonly Guid _idTheThuVien;
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly IPhieuMuonService _phieuMuonService;
        private readonly ITheThuVienService _theThuVienService;
        private readonly IChuTheService _chuTheService;

        public ChiTietPhieuMuonForm(IChiTietPhieuMuonService chiTietPhieuMuonService, ISachService sachService, Guid idPhieuMuon, Guid idTaiKhoan, Guid idTheThuVien)
        {
            InitializeComponent();
            _chiTietPhieuMuonService = chiTietPhieuMuonService;
            _phieuMuonService = new PhieuMuonService();
            _theThuVienService = new TheThuVienService();   
            _taiKhoanService = new TaiKhoanService();
            _chuTheService = new ChuTheService();   
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;
            _idTaiKhoan = idTaiKhoan;
            _idTheThuVien = idTheThuVien;
            LoadFormData();
            LoadChiTietPhieuMuon();
            LoadGridDataPhieuMuon();
        }

       

        private void LoadFormData()
        {
            dgv_chitietphieumuon.Columns.Clear();
            dgv_chitietphieumuon.Columns.Add("Column1", "STT");
            dgv_chitietphieumuon.Columns.Add("Column2", "Mã Sách");
            dgv_chitietphieumuon.Columns.Add("Column4", "Số Lượng Mượn");
            dgv_chitietphieumuon.Columns.Add("Column5", "Ghi chú");
            dgv_chitietphieumuon.Columns.Add("Column6", "Trạng Thái");
        }

        private void LoadGridDataPhieuMuon()
        {
            dgv_chitietphieumuon.Rows.Clear();
            _chiTietPhieuMuons = _chiTietPhieuMuonService.GetList(_idPhieuMuon);

            foreach (var ctpm in _chiTietPhieuMuons)
            {
                dgv_chitietphieumuon.Rows.Add(
                    (_chiTietPhieuMuons.IndexOf(ctpm) + 1),
                    _sachService.GetMaSachById(ctpm.IdSach),
                    ctpm.SoLuongMuon,
                    ctpm.GhiChu,
                    GetStatusName(ctpm.Status) // Convert status int to string
                );
            }
        }

        private void LoadChiTietPhieuMuon()
        {// Lấy thông tin phiếu mượn
            var phieuMuon = _phieuMuonService.GetById(_idPhieuMuon);
            if (phieuMuon != null)
            {
                // Gán dữ liệu vào các TextBox
                txt_maphieumuon.Text = phieuMuon.MaPhieu;
                txt_ngaymuon.Text = phieuMuon.NgayMuon.ToString("dd/MM/yyyy");
                txt_ngaytra.Text = phieuMuon.NgayTra.ToString("dd/MM/yyyy");
                txt_ngaytrathucte.Text = phieuMuon.NgayTraThucTe?.ToString("dd/MM/yyyy");
                txt_trangthai.Text = GetStatusName(phieuMuon.Status);

                // Lấy thông tin thẻ thư viện
                var theThuVien = _theThuVienService.GetById(phieuMuon.IdThe);
                if (theThuVien != null)
                {
                    txt_mathethuvien.Text = theThuVien.MaThe;

                    // Lấy thông tin từ bảng ChuThe dựa trên IdChuThe
                    var chuThe = _chuTheService.GetById(theThuVien.IdChuThe);
                    if (chuThe != null)
                    {
                        txt_hovatenchuthe.Text = chuThe.HoVaTen;
                    }
                }

                //// Lấy thông tin tài khoản (người mượn)
                //var taiKhoan = _taiKhoanService.GetById(phieuMuon.CreateBy);
                //if (taiKhoan != null)
                //{
                //    txt_hovatenchuthe.Text = taiKhoan.HoVaTen;
                //}
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetStatusName(int status)
        {
            return status switch
            {
                1 => "Đang mượn",
                2 => "Đã trả",
                3 => "Quá hạn",
                4 => "Đã trả quá hạn",
                5 => "Đang yêu cầu",
                _ => "Không xác định"
            };
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
            var themChiTietPhieuMuonForm = new ThemChiTietPhieuMuon(_chiTietPhieuMuonService, _sachService, _idPhieuMuon);

            // Đăng ký sự kiện FormClosed để làm mới dữ liệu khi form ThemChiTietPhieuMuon đóng lại
            themChiTietPhieuMuonForm.FormClosed += (s, args) =>
            {
                // Cập nhật lại DataGridView sau khi form ThemChiTietPhieuMuon đóng
                LoadChiTietPhieuMuon();
            };

            // Hiển thị form ThemChiTietPhieuMuon dưới dạng hộp thoại
            themChiTietPhieuMuonForm.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_chitietphieumuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết phiếu mượn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng được chọn
            var selectedRow = dgv_chitietphieumuon.SelectedRows[0];
            var selectedIndex = selectedRow.Index;

            if (selectedIndex < 0 || selectedIndex >= _chiTietPhieuMuons.Count)
            {
                MessageBox.Show("Chi tiết phiếu mượn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin IdPhieuMuon và IdSach từ chi tiết phiếu mượn đã chọn
            var selectedChiTiet = _chiTietPhieuMuons[selectedIndex];
            var idSach = selectedChiTiet.IdSach;

            // Hỏi người dùng xác nhận việc xóa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu mượn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Gọi service để xóa chi tiết phiếu mượn
                    _chiTietPhieuMuonService.Delete(_idPhieuMuon, idSach);
                    MessageBox.Show("Xóa chi tiết phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView sau khi xóa
                    LoadGridDataPhieuMuon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa chi tiết phiếu mượn thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_chitietphieumuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết phiếu mượn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng được chọn
            var selectedRow = dgv_chitietphieumuon.SelectedRows[0];
            var selectedIndex = selectedRow.Index;

            if (selectedIndex < 0 || selectedIndex >= _chiTietPhieuMuons.Count)
            {
                MessageBox.Show("Chi tiết phiếu mượn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin IdPhieuMuon và IdSach từ chi tiết phiếu mượn đã chọn
            var selectedChiTiet = _chiTietPhieuMuons[selectedIndex];
            var idSach = selectedChiTiet.IdSach;

            // Mở form Sửa Chi Tiết Phiếu Mượn
            var suaChiTietPhieuMuonForm = new SuaChiTietPhieuMuon(_chiTietPhieuMuonService, _sachService, _idPhieuMuon, idSach);

            // Đăng ký sự kiện FormClosed để làm mới dữ liệu khi form SuaChiTietPhieuMuon đóng lại
            suaChiTietPhieuMuonForm.FormClosed += (s, args) =>
            {
                // Cập nhật lại DataGridView sau khi form SuaChiTietPhieuMuon đóng
                LoadGridDataPhieuMuon();
            };

            // Hiển thị form SuaChiTietPhieuMuon dưới dạng hộp thoại
            suaChiTietPhieuMuonForm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
