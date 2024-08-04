using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;

namespace DuAnOne.PL.ChuThe
{
    public partial class SuaChuThe : Form
    {
        List<ChuTheVM> chuThes;
        IChuTheService _chuTheService;
        private Guid _id;
        private event Action DataUpdated;
        private ChuTheVM _chuTheData;

        public SuaChuThe()
        {   
            InitializeComponent();
            LoadFormData();
            // Khởi tạo AppDbContext
            var appDbContext = new AppDbContext();

            // Khởi tạo ChuTheRepo với AppDbContext
            IChuTheRepo chuTheRepo = new ChuTheRepo(appDbContext);

            // Khởi tạo ChuTheService với ChuTheRepo
            _chuTheService = new ChuTheService(chuTheRepo);
        }

        private void LoadFormData()
        {
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");

            cb_loaibandoc.Items.Add("Học Sinh");
            cb_loaibandoc.Items.Add("Sinh Viên");

            cb_loaithe.Items.Add("Thường");
            cb_loaithe.Items.Add("Plus");
            cb_loaithe.Items.Add("VVIP");

            cb_status.Items.Add("1");
            cb_status.Items.Add("2");
            cb_status.Items.Add("3");
            cb_status.Items.Add("4");

            cb_quoctich.Items.Add("Việt Nam");
            cb_quoctich.Items.Add("Ngoại quốc");
        }

        public void SendDataToChuThe(ChuTheVM chuTheData)
        {
            _chuTheData = chuTheData;

            // Thiết lập dữ liệu lên các control trên form
            txt_cccd.Text = _chuTheData.Cccd;
            txt_hovaten.Text = _chuTheData.HoVaTen;
            cb_loaithe.SelectedIndex = cb_loaithe.Items.IndexOf(_chuTheData.LoaiThe.ToString());
            txt_diachi.Text = _chuTheData.DiaChi;
            cb_gioitinh.SelectedIndex = cb_gioitinh.Items.IndexOf(_chuTheData.GioiTinh == 1 ? "Nam" : "Nữ");
            txt_nghenghiep.Text = _chuTheData.NgheNghiep;
            cb_quoctich.SelectedIndex = cb_quoctich.Items.IndexOf(_chuTheData.QuocTich.ToString());
            cb_loaibandoc.SelectedIndex = cb_loaibandoc.Items.IndexOf(_chuTheData.LoaiBanDoc.ToString());
            txt_email.Text = _chuTheData.Email;
            txt_noilamviec.Text = _chuTheData.NoiLamViec;
            cb_status.SelectedIndex = cb_status.Items.IndexOf(_chuTheData.Status == 1 ? "Hoạt động" : "Ngừng hoạt động");
        }

        
    }
}
