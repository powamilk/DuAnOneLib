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
        private IChuTheService _chuTheService;
        private IPhieuMuonService _phieuMuonService;
        private ITaiKhoanService _taiKhoanService;
        private ITheThuVienService _theThuVienService;
        private Guid _idPhieuMuon;
        private Guid _idTaiKhoan;
        private Guid _idTheThuVien;
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
            _chuTheService = new ChuTheService();
            _phieuMuonService = new PhieuMuonService();
            _taiKhoanService = new TaiKhoanService();   
            _sachService = sachService;
            _idPhieuMuon = idPhieuMuon;
            LoadChiTietPhieuMuon();
        }

        public void SetPhieuMuonId(Guid idPhieuMuon)
        {
            _idPhieuMuon = idPhieuMuon;
            LoadPhieuMuonData();
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

        private void LoadPhieuMuonData()
        {
            try
            {
                // Lấy dữ liệu phiếu mượn bằng ID phiếu mượn
                var phieuMuon = _phieuMuonService.GetById(_idPhieuMuon); // Chỉ cần ID phiếu mượn

                if (phieuMuon != null)
                {
                    // Cập nhật thông tin phiếu mượn vào các control
                    txt_maphieumuon.Text = phieuMuon.Id.ToString();
                    txt_trangthai.Text = phieuMuon.Status.ToString();
                    txt_mathethuvien.Text = phieuMuon.IdThe.ToString();

                    // Lấy thông tin thẻ thư viện
                    var theThuVien = _theThuVienService.GetById(phieuMuon.IdThe);
                    txt_hovatenchuthe.Text = theThuVien?.IdChuThe.ToString() ?? "Unknown";

                    // Cập nhật các ngày vào các control
                    txt_ngaymuon.Text = phieuMuon.NgayMuon.ToString("dd/MM/yyyy");
                    txt_ngaytra.Text = phieuMuon.NgayTra.ToString("dd/MM/yyyy");
                    txt_ngaytrathucte.Text = phieuMuon.NgayTraThucTe.HasValue ? phieuMuon.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "Chưa có";
                }
                else
                {
                    // Thông báo khi không tìm thấy phiếu mượn
                    MessageBox.Show("Phiếu mượn không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Có lỗi khi tải dữ liệu phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
