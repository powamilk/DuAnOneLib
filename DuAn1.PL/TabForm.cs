using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.ChuThe;
using DuAnOne.PL.Extensions;
using DuAnOne.PL.TaiKhoan;
using DuAnOne.DAL.Entities;

namespace DuAnOne.PL
{
    public partial class TabForm : Form
    {
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
        Guid _createByChon;
        DateTime _createTimeChon;
        Guid? _modifyByChon;
        DateTime? _modifyTimeChon;
        Guid? _deleteByChon;
        DateTime? _deleteTimeChon;
        private ThemTaiKhoan _themTaiKhoan;
        #endregion

        #region Load Data Tài Khoản
        private void LoadData()
        {
            List<TaiKhoanVM> taiKhoans = _taiKhoanService.GetList();
            dgv_taikhoan.DataSource = taiKhoans;
        }
        #endregion

        #region Show Thêm Tài Khoản
        public void ShowThemTK()
        {
            var form = new ThemTaiKhoan(LoadGridData);
            this.Enabled = false; // Vô hiệu hóa form chính
            form.Show(); // Hiển thị form mới
            form.FormClosed += (s, e) => this.Enabled = true;
        }
        #endregion

        #region Thêm Tài Khoản Form Close
        private void ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
        }
        #endregion

        public TabForm()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            LoadFormData();
            LoadGridData();
            LoadFormDataChuThe();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #region Load Form Data Tài Khoản
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
        #endregion

        #region Load Grid Data Tài Khoản
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
        #endregion

        #region btn_them Tài Khoản
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            ShowThemTK();
        }
        #endregion

        #region Khai bái chủ thẻ
        List<ChuTheVM> _chuThes;
        IChuTheService _chuTheService;
        string _cccdChon;
        Guid _chuTheIdChon;
        
       


        private ThemChuTHe _theChuThe;
        private SuaChuThe _suaChuThe;

        #endregion

        private void LoadDataToChuThe()
        {
            List<ChuTheVM> chuThes = _chuTheService.GetList();
            dgv_chuthe.DataSource = chuThes;
        }

        public void ShowThemCT()
        {
            var form = new ThemChuTHe();
            this.Enabled = false;
            form.Show();
            form.FormClosed += (s, e) => this.Enabled = true;
        }

        private void ShowSuaChuThe()
        {
            if (_suaChuThe == null)
            {
                _suaChuThe = new SuaChuThe();
                _suaChuThe.FormClosed += SuaChuThe_FormClosed;
            }

            // Lấy dữ liệu chủ thẻ từ danh sách chủ thẻ
            var chuTheData = _chuThes.FirstOrDefault(ct => ct.Id == _chuTheIdChon);

            // Gửi dữ liệu đến form sửa
            if (chuTheData != null)
            {
                if (chuTheData != null)
                {
                    this.Enabled = false;
                    _suaChuThe.SendDataToChuThe(chuTheData);
                    _suaChuThe.Show();
                }
            }
        }

        public void SuaChuThe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            LoadGridData();
        }

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
            dgv_chuthe.Rows.Clear();
            List<ChuTheVM> chuThes = _chuTheService.GetList();
            foreach (var ct in chuThes)
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


        private void dgv_chuthe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _chuThes.Count - 1)
            {
                _cccdChon = String.Empty;
                return;
            }

            var ctChon = _chuThes.ElementAt(index);
            _cccdChon = ctChon.Cccd;
            txt_hienthichonchuthe.Text = ctChon.Id.ToString();
        }

        private void btn_themchuthe_Click(object sender, EventArgs e)
        {
            ShowThemCT();
        }

        private void btn_xoachuthe_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("xóa"))
            {
                // Giả sử phương thức Delete trả về một thông báo thành công hoặc thất bại dưới dạng chuỗi
                string ketQua = _chuTheService.Delete(_chuTheIdChon);
                string thongBao = ketQua == "Xóa thành công" ? "Xóa thành công" : "Xóa thất bại";

                MessageBoxExtension.Notification("Thông Báo", thongBao);

                LoadGridData();
            }
        }
    }
}