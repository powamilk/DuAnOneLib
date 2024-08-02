﻿using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.Extensions;
using DuAnOne.PL.TaiKhoan;

namespace DuAnOne.PL
{
    public partial class TabForm : Form
    {
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
        Guid _createByChon;
        DateTime _createTimeChon;
        Guid? _modifyByChon;
        DateTime? _modifyTimeChon;
        Guid? _deleteByChon;
        DateTime? _deleteTimeChon;
        private ThemTaiKhoan _themTaiKhoan;

        private void LoadData()
        {
            List<TaiKhoanVM> taiKhoans = _taiKhoanService.GetList();
            dgv_taikhoan.DataSource = taiKhoans;
        }


        public void ShowThemTK()
        {
            var form = new ThemTaiKhoan(LoadGridData);
            this.Enabled = false; // Vô hiệu hóa form chính
            form.Show(); // Hiển thị form mới
            form.FormClosed += (s, e) => this.Enabled = true;
        }

        private void ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
        }

        public TabForm()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            LoadFormData();
            LoadGridData();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LoadFormData()
        {
            dgv_taikhoan.Columns.Clear();
            dgv_taikhoan.Columns.Add("clm1", "STT");
            dgv_taikhoan.Columns.Add("clm2", "ID");
            dgv_taikhoan.Columns.Add("clm3", "Họ Và Tên");
            dgv_taikhoan.Columns.Add("clm4", "Ngày Sinh");
            dgv_taikhoan.Columns.Add("clm5", "Địa Chỉ");
            dgv_taikhoan.Columns.Add("clm6", "SĐT");
            dgv_taikhoan.Columns.Add("clm7", "Mã Nhân Viên");
            dgv_taikhoan.Columns.Add("clm8", "Mật Khẩu");
            dgv_taikhoan.Columns.Add("clm9", "Tên Tài Khoản");
            dgv_taikhoan.Columns.Add("clm10", "Chức Vụ");
            dgv_taikhoan.Columns.Add("clm11", "Status");


        }

        private void LoadGridData()
        {
            // Code để tải lại dữ liệu cho DataGridView
            dgv_taikhoan.Rows.Clear(); // Xóa các dòng hiện có
            List<TaiKhoanVM> taiKhoans = _taiKhoanService.GetAll(); // Lấy danh sách tài khoản mới
            foreach (var tk in taiKhoans)
            {
                dgv_taikhoan.Rows.Add(
                    (_taiKhoans.IndexOf(tk) + 1),
                    tk.Id,
                    tk.HoVaTen,
                    tk.NgaySinh,
                    tk.DiaChi,
                    tk.Sdt,
                    tk.MaNhanVien,
                    tk.MatKhau,
                    tk.TenTaiKhoan,
                    tk.ChucVu,
                    tk.Status);
            }
        }

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

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            ShowThemTK();
        }
    }
}