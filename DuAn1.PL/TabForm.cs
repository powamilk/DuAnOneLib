using DuAn1.PL;
using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;
using DuAnOne.PL.Extensions;
using DuAnOne.PL.TaiKhoan;
using System.Diagnostics;

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


        private SuaTK _suaTK;
        private ThemTaiKhoan _themTaiKhoan;

        private void ShowSuaTK()
        {
            if (_suaTK == null)
            {
                _suaTK = new SuaTK();
                _suaTK.FormClosed += SuaTK_FormClosed;
            }

            this.Enabled = false; // Vô hiệu hóa form chính
            _suaTK.SendData(_maTKChon, _hoVaTenChon, _ngaySinhChon, _diaChiChon, _emailChon, _sdtChon, _maNhanVienChon, _tenTaiKhoanChon, _matKhauChon, _chucVuChon, _statusChon);
            _suaTK.Show(); // Hiển thị form mới
        }


        private void OpenSuaTKForm(Guid id)
        {
            if (_suaTK == null)
            {
                _suaTK = new SuaTK();
                _suaTK.FormClosed += SuaTK_FormClosed;
            }
            _suaTK.SendData(id,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.HoVaTen ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.NgaySinh ?? DateTime.Now,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.DiaChi ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.Email ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.Sdt ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.MaNhanVien ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.TenTaiKhoan ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.MatKhau ?? string.Empty,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.ChucVu ?? 0,
                _taiKhoans.FirstOrDefault(tk => tk.Id == id)?.Status ?? 0);
            _suaTK.Show();
        }

        private void SuaTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
            LoadGridData();
        }


        private void LoadData()
        {
            List<TaiKhoanVM> taiKhoans = _taiKhoanService.GetList();
            dgv_taikhoan.DataSource = taiKhoans;
        }

        public void ShowThemTK()
        {
            if (_themTaiKhoan == null)
            {
                _themTaiKhoan = new ThemTaiKhoan();
                _themTaiKhoan.DataAdded += LoadGridData;
                _themTaiKhoan.FormClosed += ThemTaiKhoan_FormClosed;
            }

            this.Enabled = false; // Vô hiệu hóa form chính
            _themTaiKhoan.Show(); // Hiển thị form mới
        }


        private void ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Kích hoạt lại form chính
        }



        private void UpdateDataToSuaTK()
        {
            // Kiểm tra nếu _maTKChon là Guid.Empty hoặc giá trị khác không hợp lệ
            if (_maTKChon == Guid.Empty)
            {
                MessageBox.Show("Chưa chọn tài khoản để sửa.");
                return;
            }

            // Tìm tài khoản đã chọn trong danh sách _taiKhoans
            var taiKhoanChon = _taiKhoans.FirstOrDefault(tk => tk.Id == _maTKChon);

            if (taiKhoanChon != null)
            {
                // Gán các giá trị từ tài khoản chọn vào biến tương ứng
                if (_suaTK != null)
                {
                    _suaTK.SendData(
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
                    _suaTK.Show();
                }
                else
                {
                    MessageBox.Show("Form sửa tài khoản chưa được khởi tạo.");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại trong danh sách.");
            }
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
            dgv_taikhoan.Rows.Clear(); // Xóa các dòng hiện có
            _taiKhoans = _taiKhoanService.GetList(); // Lấy danh sách tài khoản mới

            Debug.WriteLine($"Số lượng tài khoản: {_taiKhoans.Count}");

            foreach (var tk in _taiKhoans)
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ShowSuaTK();
            UpdateDataToSuaTK();
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


        private void btn_them_Click(object sender, EventArgs e)
        {
            ShowThemTK();
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
    }
}
