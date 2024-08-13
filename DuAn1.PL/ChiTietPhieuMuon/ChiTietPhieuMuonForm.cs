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
    public partial class ChiTietPhieuMuonForm : Form
    {
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
            switch (status)
            {
                case 1:
                    return "Đang mượn";
                case 2:
                    return "Đã trả";
                case 3:
                    return "Quá hạn";
                case 4:
                    return "Đã trả quá hạn";
                case 5:
                    return "Đang yêu cầu";
                default:
                    return "Không xác định";
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
