﻿using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.ChuThe;
using DuAnOne.PL.Extensions;
using DuAnOne.PL.TaiKhoan;
using DuAnOne.DAL.Entities;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;
using DuAnOne.DAL;
using DuAnOne.BUS.ViewModel.TheThuViens;
using DuAnOne.PL.TheThuVien;
using DuAnOne.BUS.ViewModel.Sachs;
using DuAnOne.PL.Sach;
using DuAnOne.BUS.ViewModel.PhieuMuons;
using System.Drawing.Printing;
using DuAnOne.PL.PhieuMuon;
using System;
using DuAn1.PL;
using System.Windows.Forms;
using DuAnOne.BUS.Utils;

namespace DuAnOne.PL
{
    public partial class TabForm : Form
    {
        #region Khai bao the thu vien
        List<TheThuVienVM> _theThuViens;
        ITheThuVienService _theThuVienService;
        Guid _idChuThe;
        Guid _id;
        Guid _maTTVChon;
        DateTime _ngayCapChon;
        DateTime _ngayHetHan;
        string _maTheChon;
        int _statusTheChon;

        private ThemTheThuVien _themTheThuViens;
        #endregion

        #region Khai báo Tài Khoản
        List<TaiKhoanVM> _taiKhoans;
        ITaiKhoanService _taiKhoanService;
        Guid _maTKChon;
        string _hoVaTenChon;
        DateTime _ngaySinhChon;
        string _diaChiChon;
        string _sdtChon;
        string _emailChon;
        string _maNhanVienChon;
        string _tenTaiKhoanChon;
        string _matKhauChon;
        int _chucVuChon;
        int _statusChon;
        public Guid CurrentUserId { get; private set; } = Guid.NewGuid();


        #endregion

        #region Load Data Tài Khoản
        private void LoadData()
        {
            List<TaiKhoanVM> taiKhoans = _taiKhoanService.GetList();
            dgv_taikhoan.DataSource = taiKhoans;
        }
        #endregion

        public void ShowFormSuaTK()
        {
            if (_maTKChon == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản");
                return;
            }
            var taiKhoanChon = _taiKhoans.FirstOrDefault(tk => tk.Id == _maTKChon);

            if (taiKhoanChon == null)
            {
                MessageBox.Show("Form Sửa tài khoản chưa được khởi tạo");
                return;
            }

            var form = new SuaTK(LoadGridData);
            this.Enabled = false;
            form.SendData(
                 _maTKChon,
                 taiKhoanChon.HoVaTen,
                 taiKhoanChon.NgaySinh,
                 taiKhoanChon.DiaChi,
                 taiKhoanChon.Email,
                 taiKhoanChon.Sdt,
                 taiKhoanChon.MaNhanVien,
                 taiKhoanChon.TenTaiKhoan,
                 taiKhoanChon.MatKhau,
                 taiKhoanChon.ChucVu,
                 taiKhoanChon.Status
                );
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }

        #region Show Thêm Tài Khoản
        public void ShowThemTK()
        {
            var form = new ThemTaiKhoan(LoadGridData);
            this.Enabled = false; // Vô hiệu hóa form chính
            form.SendCurrentUserId(CurrentUserId);
            form.Show(); // Hiển thị form mới
            form.FormClosed += (s, e) => this.Enabled = true;

        }
        #endregion

        public void SetUserId(Guid userId)
        {
            CurrentUserId = userId;
        }


        private void SuaTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

        }
        #region Thêm Tài Khoản Form Close
        private void ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        #endregion

        public TabForm()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
            _chuTheService = new ChuTheService();
            _theThuVienService = new TheThuVienService();
            _sachService = new SachService();

            LoadFormData();
            LoadGridData();
            LoadFormDataChuThe();
            LoadGridDataChuThe();
            LoadFormDataTheThuVien();
            LoadFormDataTheThuVien();
            LoadFormDataSach();
            LoadGridDataSach();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #region Load Form Data Tài Khoản
        private void LoadFormData()
        {
            dgv_taikhoan.Columns.Clear();
            dgv_taikhoan.Columns.Add("clm1", "STT");
            dgv_taikhoan.Columns.Add("clm7", "Mã Nhân Viên");
            dgv_taikhoan.Columns.Add("clm3", "Họ Và Tên");
            dgv_taikhoan.Columns.Add("clm4", "Ngày Sinh");
            dgv_taikhoan.Columns.Add("clm5", "Địa Chỉ");
            dgv_taikhoan.Columns.Add("clm6", "SĐT");
            dgv_taikhoan.Columns.Add("clm9", "Tên Tài Khoản");
            dgv_taikhoan.Columns.Add("clm8", "Mật Khẩu");
            dgv_taikhoan.Columns.Add("clm10", "Chức Vụ");
            dgv_taikhoan.Columns.Add("clm11", "Status");
            dgv_taikhoan.Columns.Add("clm12", "Thời gian tạo");


        }
        #endregion

        #region Load Grid Data Tài Khoản
        private void LoadGridData()
        {
            // Code để tải lại dữ liệu cho DataGridView
            dgv_taikhoan.Rows.Clear(); // Xóa các dòng hiện có
            _taiKhoans = _taiKhoanService.GetAll(); // Lấy danh sách tài khoản mới
            foreach (var tk in _taiKhoans)
            {
                dgv_taikhoan.Rows.Add(
                    (_taiKhoans.IndexOf(tk) + 1),
                    tk.MaNhanVien,
                    tk.HoVaTen,
                    tk.NgaySinh,
                    tk.DiaChi,
                    tk.Sdt,
                    tk.TenTaiKhoan,
                    tk.MatKhau,
                    tk.ChucVu,
                    StatusExtensions.GetStatusDescription(tk.Status),
                    tk.CreateTime);
            }
        }
        #endregion

        #region Xóa Form Tài Khoản
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                var ketQua = _taiKhoanService.Delete(_maTKChon);
                string thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridData();
            }
        }
        #endregion

        #region dvg_taikhoan Cell Click
        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var index = e.RowIndex;

            //if (index < 0 || index > _taiKhoans.Count - 1)
            //{
            //    _maTKChon = Guid.Empty;
            //    return;
            //}

            //var tkChon = _taiKhoans.ElementAt(index);
            //_maTKChon = tkChon.Id;
            //txt_hienthichon.Text = tkChon.Id.ToString();
        }
        #endregion

        #region btn_them Tài Khoản
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            ShowThemTK();
        }
        #endregion

        #region Khai báo chủ thẻ
        List<ChuTheVM> _chuThes;
        IChuTheService _chuTheService;
        string _cccdChon;
        Guid _chuTheIdChon;
        Guid _maChuTheChon;
        private IChuTheRepo _chuTheRepo;
        private ThemChuTHe _theChuThe;
        private SuaChuThe _suaChuThe;
        public event Action DataAdded;


        #endregion

        #region Load Data TO ChuThe
        private void LoadDataChuThe()
        {
            List<ChuTheVM> chuThes = _chuTheService.GetList();
            dgv_chuthe.DataSource = chuThes;
        }
        #endregion

        #region Show Sửa CHủ Thẻ
        public void ShowFormSuaChuThe()
        {
            if (_maChuTheChon == Guid.Empty)
            {
                MessageBox.Show("Bạn chư chọn chu the");
                return;
            }
            var chuTheChon = _chuThes.FirstOrDefault(c => c.Id == _maChuTheChon);

            if (chuTheChon == null)
            {
                MessageBox.Show("Form Sửa tài khoản chưa được khởi tạo");
                return;
            }

            var form = new SuaChuThe(LoadGridDataChuThe);
            this.Enabled = false;
            form.SendDataToChuThe(
                _maChuTheChon,
                chuTheChon.Cccd,
                chuTheChon.HoVaTen,
                chuTheChon.LoaiThe,
                chuTheChon.DiaChi,
                chuTheChon.GioiTinh,
                chuTheChon.NgheNghiep,
                chuTheChon.QuocTich,
                chuTheChon.LoaiBanDoc,
                chuTheChon.Email,
                chuTheChon.NoiLamViec,
                chuTheChon.Status
                );
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion

        #region Show Thêm CHủ THẻ
        public void ShowThemCT()
        {
            var form = new ThemChuTHe(LoadGridDataChuThe);
            this.Enabled = false;
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion

        #region SuaChuThe_FormClosed
        private void SuaChuThe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
            LoadGridDataChuThe(); // Làm mới dữ liệu trên grid
        }
        #endregion



        #region Load Form Data Chủ Thẻ
        private void LoadFormDataChuThe()
        {
            dgv_chuthe.Columns.Clear();
            dgv_chuthe.Columns.Add("Column1", "STT");
            dgv_chuthe.Columns.Add("Column2", "CCCD");
            dgv_chuthe.Columns.Add("Column3", "Họ Và Tên");
            dgv_chuthe.Columns.Add("Column4", "Loại Thẻ");
            dgv_chuthe.Columns.Add("Column5", "Địa Chỉ");
            dgv_chuthe.Columns.Add("Column6", "Giới Tính");
            dgv_chuthe.Columns.Add("Column7", "Nghề Nghiệp");
            dgv_chuthe.Columns.Add("Column8", "Quốc Tịch");
            dgv_chuthe.Columns.Add("Column9", "Loại Bạn Đọc");
            dgv_chuthe.Columns.Add("Column10", "Email");
            dgv_chuthe.Columns.Add("Column11", "Nơi Làm Việc");
            dgv_chuthe.Columns.Add("Column12", "Status");
        }
        #endregion

        #region Load Grid Data Chủ Thẻ
        private void LoadGridDataChuThe()
        {
            dgv_chuthe.Rows.Clear(); // Xóa các dòng hiện có
            _chuThes = _chuTheService.GetAll(); // Lấy danh sách chủ thẻ mới

            foreach (var ct in _chuThes)
            {
                dgv_chuthe.Rows.Add(
                    (_chuThes.IndexOf(ct) + 1),
                    ct.Cccd,
                    ct.HoVaTen,
                    ct.LoaiThe,
                    ct.DiaChi,
                    ct.GioiTinh == 1 ? "Nam" : "Nữ",
                    ct.NgheNghiep,
                    ct.QuocTich,
                    ct.LoaiBanDoc,
                    ct.Email,
                    ct.NoiLamViec,
                    ct.Status == 1 ? "Hoạt động" : "Ngừng hoạt động");
            }
        }

        #endregion

        #region dgv_chuthe
        private void dgv_chuthe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _chuThes.Count - 1)
            {
                _cccdChon = String.Empty;
                return;
            }

            var ctChon = _chuThes.ElementAt(index);
            _maChuTheChon = ctChon.Id;
            txt_hienthichonchuthe.Text = ctChon.Id.ToString();
        }
        #endregion

        #region btn Them ChuThe
        private void btn_themchuthe_Click(object sender, EventArgs e)
        {
            ShowThemCT();
        }

        private void btn_xoachuthe_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                // Giả sử phương thức Delete trả về một thông báo thành công hoặc thất bại dưới dạng chuỗi
                var ketQua = _chuTheService.Delete(_chuTheIdChon);
                var thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridDataChuThe();
            }
        }
        #endregion

        #region btn_?
        private void btn_sua_Click(object sender, EventArgs e)
        {
            ShowFormSuaTK();

        }
        #endregion


        #region btn_suachuthe
        private void btn_suachuthe_Click(object sender, EventArgs e)
        {
            ShowFormSuaChuThe();
        }
        #endregion

        #region LoadFormDataTheThuVien
        private void LoadFormDataTheThuVien()
        {
            dgv_thethuvien.Columns.Clear();
            dgv_thethuvien.Columns.Add("Clm1", "STT");
            dgv_thethuvien.Columns.Add("clm3", "Ngày Cấp");
            dgv_thethuvien.Columns.Add("clm4", "Ngày Hết Hạn");
            dgv_thethuvien.Columns.Add("clm5", "Mã Thẻ");
            dgv_thethuvien.Columns.Add("clm6", "Status");
        }
        #endregion

        #region LoadGridDataTheThuVien
        private void LoadGridDataTheThuVien()
        {
            dgv_thethuvien.Rows.Clear();
            _theThuViens = _theThuVienService.GetList();

            foreach (var ttv in _theThuViens)
            {
                dgv_thethuvien.Rows.Add(
                    (_theThuViens.IndexOf(ttv) + 1),
                      ttv.NgayCap,
                      ttv.NgayHetHan,
                      ttv.MaThe,
                      ttv.Status
                    );
            }
        }
        #endregion

        #region ShowSuaTheThuVien
        private void ShowSuaTheThuVien()
        {
            if (_maTTVChon == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn thẻ thư viện");
                return;
            }
            var theThuVienChon = _theThuViens.FirstOrDefault(ttv => ttv.Id == _maTTVChon);

            if (theThuVienChon == null)
            {
                MessageBox.Show("Form Sửa Tài khoản chưa đc khởi tạo");
                return;
            }
            var form = new SuaTheThuVien(LoadGridDataTheThuVien);
            this.Enabled = false;
            form.SendDataToTheThuVien(
                    _maTTVChon,
                    theThuVienChon.IdChuThe,
                    theThuVienChon.NgayCap,
                    theThuVienChon.NgayHetHan,
                    theThuVienChon.MaThe,
                    theThuVienChon.Status
                    );
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion

        #region SuaTheThuVien_FormClosed
        private void SuaTheThuVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        #endregion

        #region LoadDataTheThuVien
        private void LoadDataTheThuVien()
        {
            List<TheThuVienVM> theThuViens = _theThuVienService.GetList();
            dgv_thethuvien.DataSource = theThuViens;
        }
        #endregion

        #region ShowThemTheThuVien

        public void ShowThemTheThuVien()
        {
            var form = new ThemTheThuVien(LoadGridDataTheThuVien);
            this.Enabled = false;
            form.Show(); // Hiển thị form mới
            form.FormClosed += (s, e) => this.Enabled = true;
        }

        #endregion

        #region ThemTheThuVien_FormClosed

        private void ThemTheThuVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
        }

        private void btn_xoathethuvien_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                var ketQua = _theThuVienService.Delete(_id);
                string thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridData();
            }
        }
        #endregion

        #region btn Them Thẻ Thư viện
        private void btn_themthethuvien_Click(object sender, EventArgs e)
        {
            ShowThemTheThuVien();
        }
        #endregion

        #region btn_suathethuvien
        private void btn_suathethuvien_Click(object sender, EventArgs e)
        {
            ShowSuaTheThuVien();
        }
        #endregion

        #region dgv_thethuviencellclick

        private void txt_hienthichonthethuvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_thethuvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _theThuViens.Count - 1)
            {
                _id = Guid.Empty;
                return;
            }

            var ttvChon = _theThuViens.ElementAt(index);
            _maTTVChon = ttvChon.Id;
            txt_hienthichonthethuvien.Text = ttvChon.Id.ToString();
        }
        #endregion



        #region Khai báo Sách
        List<SachVM> _sachs;
        ISachService _sachService;
        Guid _idSachChon;
        private SuaSach _suaSach;
        private ThemSach _themSach;
        string _tenSachChon;
        int _namXuatBanChon;
        int _soLuongChon;
        string _theLoaiChon;
        string _maSachChon;
        double _giaTienChon;
        string _tacGiaChon;
        int _statusSachChon;

        #endregion

        #region Load Form Data Sach
        private void LoadFormDataSach()
        {
            dgv_sach.Columns.Clear();
            dgv_sach.Columns.Add("Clm1", "STT");
            dgv_sach.Columns.Add("Clm2", "Ten Sach");
            dgv_sach.Columns.Add("clm3", "Nam Xuat Ban");
            dgv_sach.Columns.Add("clm4", "So luong");
            dgv_sach.Columns.Add("clm5", "The Loai");
            dgv_sach.Columns.Add("clm6", "Ma Sach");
            dgv_sach.Columns.Add("clm7", "Gia Tien");
            dgv_sach.Columns.Add("clm8", "Tac Gia");
            dgv_sach.Columns.Add("clm9", "Status");
        }
        #endregion

        #region LoadGridDataSach
        private void LoadGridDataSach()
        {
            dgv_sach.Rows.Clear();
            _sachs = _sachService.GetList();
            foreach (var s in _sachs)
            {
                dgv_sach.Rows.Add(
                    (_sachs.IndexOf(s) + 1),
                    s.TenSach,
                    s.NamXuatBan,
                    s.SoLuong,
                    s.TheLoai,
                    s.MaSach,
                    s.GiaTien,
                    s.TacGia,
                    s.Status
                    );
            }
        }
        #endregion

        #region ShowSuaSach
        private void ShowSuaSach()
        {
            if (_idSachChon == Guid.Empty)
            {
                MessageBox.Show(" Bạn chưa chọn sách");
                return;
            }
            var sachChon = _sachs.FirstOrDefault(s => s.Id == _idSachChon);

            if (sachChon == null)
            {
                MessageBox.Show("Form Sửa Sách chưa được khởi tạo");
                return;
            }
            var form = new SuaSach(LoadGridDataSach);
            this.Enabled = false;
            form.SendDataToSach(
                _idSachChon,
                sachChon.TenSach,
                sachChon.NamXuatBan,
                sachChon.SoLuong,
                sachChon.TheLoai,
                sachChon.MaSach,
                sachChon.GiaTien,
                sachChon.TacGia,
                sachChon.Status
                );
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion

        #region Sửa Sách FormClosed

        private void SuaSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            LoadGridDataSach();
        }
        #endregion


        #region Load Data Sach

        private void LoadDataSach()
        {
            List<SachVM> sachs = _sachService.GetList();
            dgv_sach.DataSource = sachs;
        }
        #endregion

        #region Show Thêm Sách
        public void ShowThemSach()
        {
            var form = new ThemSach(LoadGridDataSach);
            this.Enabled = false;
            form.Show(); // Hiển thị form mới
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion



        #region Thêm Sách Form CLosed
        private void ThemSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
            LoadGridDataSach(); // Tải lại dữ liệu sách
        }
        #endregion

        #region Btn Sua Sách
        private void btn_suasach_Click(object sender, EventArgs e)
        {
            ShowSuaSach();

        }
        #endregion

        #region BTN Xóa Sách
        private void btn_xoasach_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                var ketQua = _sachService.Delete(_id);
                string thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridData();
            }
        }
        #endregion

        #region THêm Sách
        private void btn_themsach_Click(object sender, EventArgs e)
        {
            ShowThemSach();
        }
        #endregion


        #region Khai Báo Phiếu Mượn
        List<PhieuMuonVM> _phieuMuons;
        IPhieuMuonService _phieuMuonService;
        Guid _idPhieuMuon;
        Guid _idTaiKhoanChon;
        Guid _idTheChon;
        DateTime _ngayMuonChon;
        DateTime _ngayTraChon;
        DateTime _ngayTraThucTeChon;
        string _maPhieuChon;
        int _statusPhieuMuonChon;

        private SuaPhieuMuon _suaPhieuMuon;
        private ThemPhieuMuon _themPhieuMuon;
        #endregion

        #region Show Sửa Phiếu Mượn
        private void ShowSuaPhieuMuon()
        {
            if (_suaPhieuMuon == null)
            {
                _suaPhieuMuon = new SuaPhieuMuon();
                _suaPhieuMuon.FormClosed += SuaPhieuMuon_FormClosed;
            }
            this.Enabled = false;
            _suaPhieuMuon.SendData(_idPhieuMuon, _idTaiKhoanChon, _idTheChon, _ngayMuonChon, _ngayTraChon, _ngayTraThucTeChon, _maPhieuChon, _statusPhieuMuonChon);
            _suaPhieuMuon.Show();
        }
        #endregion

        #region Open Sửa Sửa Phiếu Mượn Form
        private void OpenSuaPhieuMuonForm(Guid id)
        {
            if (_suaPhieuMuon == null)
            {
                _suaPhieuMuon = new SuaPhieuMuon();
                _suaPhieuMuon.FormClosed += SuaPhieuMuon_FormClosed;
            }

            var phieuMuonChon = _phieuMuons.FirstOrDefault(pm => pm.Id == id);

            if (phieuMuonChon != null)
            {
                _suaPhieuMuon.SendData(
                    id,
                    phieuMuonChon.IdTaiKhoan,
                    phieuMuonChon.IdThe,
                    phieuMuonChon.NgayMuon,
                    phieuMuonChon.NgayTra,
                    phieuMuonChon.NgayTraThucTe,
                    phieuMuonChon.MaPhieu,
                    phieuMuonChon.Status
                );
                _suaPhieuMuon.Show();
            }
            else
            {
                MessageBox.Show("Phiếu Mượn không tồn tại trong danh sách.");
            }
        }

        #endregion

        #region Sửa Phiếu Mượn FormCLosed
        private void SuaPhieuMuon_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
            LoadGridDataPhieuMuon();
        }
        #endregion

        #region Load Data 
        private void LoadDataPhieuMuon()
        {
            List<PhieuMuonVM> phieuMuons = _phieuMuonService.GetList();
            dgv_phieumuon.DataSource = phieuMuons;
        }
        #endregion

        #region ShowThemPhieuMuon
        public void ShowThemPhieuMuon()
        {
            if (_themPhieuMuon == null)
            {
                _themPhieuMuon = new ThemPhieuMuon();
                _themPhieuMuon.DataAdded += LoadGridDataPhieuMuon;
                _themPhieuMuon.FormClosed += ThemPhieuMuon_FormClosed;
            }

            this.Enabled = false;
            _themPhieuMuon.Show();
        }
        #endregion 

        private void ThemPhieuMuon_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
            LoadGridDataPhieuMuon();
        }

        private void UpdateDataToSuaPhieuMuon()
        {
            if (_idPhieuMuon == Guid.Empty)
            {
                MessageBox.Show("Chưa chọn Phiếu Mượn để Sửa.");
                return;
            }

            var phieuMuonChon = _phieuMuons.FirstOrDefault(pm => pm.Id == _idPhieuMuon);

            if (phieuMuonChon != null)
            {
                if (_suaPhieuMuon != null)
                {
                    DateTime ngayTraThucTe = phieuMuonChon.NgayTraThucTe ?? DateTime.MinValue;
                    _suaPhieuMuon.SendData(
                          _idPhieuMuon,
                          phieuMuonChon.IdTaiKhoan,
                          phieuMuonChon.IdThe,
                          phieuMuonChon.NgayMuon,
                          phieuMuonChon.NgayTra,
                          ngayTraThucTe,
                          phieuMuonChon.MaPhieu,
                          phieuMuonChon.Status
                        );
                    _suaPhieuMuon.Show();
                }
                else
                {
                    MessageBox.Show("Form Sửa Phiếu mượn chưa đc khởi tạo");
                }
            }
            else
            {
                MessageBox.Show("Phiếu Mượn ko tồn tại trong danh Sách");
            }
        }



        private void LoadFormDataPhieuMuon()
        {
            dgv_phieumuon.Columns.Clear();
            dgv_phieumuon.Columns.Add("clm1", "STT");
            dgv_phieumuon.Columns.Add("clm2", "Id Tài Khoản");
            dgv_phieumuon.Columns.Add("clm3", "Id Thẻ");
            dgv_phieumuon.Columns.Add("clm4", "Ngày Mượn");
            dgv_phieumuon.Columns.Add("clm5", "Ngày Trả");
            dgv_phieumuon.Columns.Add("clm6", "Ngày Trả Thực Tế");
            dgv_phieumuon.Columns.Add("clm7", "Mã Phiếu");
            dgv_phieumuon.Columns.Add("clm8", "Status");
        }

        private void LoadGridDataPhieuMuon()
        {
            dgv_phieumuon.Rows.Clear();
            _phieuMuons = _phieuMuonService.GetList();

            foreach (var pm in _phieuMuons)
            {
                dgv_phieumuon.Rows.Add(
                    (_phieuMuons.IndexOf(pm) + 1),
                    pm.IdTaiKhoan,
                    pm.IdThe,
                    pm.NgayMuon,
                    pm.NgayTra,
                    pm.NgayTraThucTe,
                    pm.MaPhieu,
                    pm.Status
                    );
            }
        }

        private void dgv_taikhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _taiKhoans.Count - 1)
            {
                _maTKChon = Guid.Empty;
                return;
            }

            var tkChon = _taiKhoans.ElementAt(index);
            _maTKChon = tkChon.Id;
            txt_hienthichon.Text = tkChon.Id.ToString();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                var ketQua = _taiKhoanService.Delete(_maTKChon);
                string thongBao = ketQua ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridData();
            }
        }

        private void dgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _sachs.Count - 1)
            {
                _id = Guid.Empty;
                return;
            }

            var sachChon = _sachs.ElementAt(index);
            _idSachChon = sachChon.Id;
            txt_hienthichonsach.Text = sachChon.TenSach;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}