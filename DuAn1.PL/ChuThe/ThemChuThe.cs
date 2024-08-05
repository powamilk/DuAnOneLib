using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.Utils.Validation;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;
using DuAnOne.DAL;
using DuAnOne.PL.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnOne.PL.ChuThe
{
    public partial class ThemChuTHe : Form
    {
        List<ChuTheVM> _chuThes;
        IChuTheService _chuTheService;

        public event Action DataAdded;

        public ThemChuTHe()
        {
            InitializeComponent();

            // Khởi tạo AppDbContext
            var appDbContext = new AppDbContext();

            // Khởi tạo ChuTheRepo với AppDbContext
            IChuTheRepo chuTheRepo = new ChuTheRepo(appDbContext);

            // Khởi tạo ChuTheService với ChuTheRepo
            _chuTheService = new ChuTheService(chuTheRepo);

            // Lấy dữ liệu và tải form
            _chuThes = _chuTheService.GetList();
            LoadFormData();
        }
        private void LoadFormData()
        {
            // Thêm các giá trị vào ComboBox
            cb_loaithe.Items.Add("Thường");
            cb_loaithe.Items.Add("Plus");
            cb_loaithe.Items.Add("VVIP");

            cb_status.Items.Add("Hoạt động");
            cb_status.Items.Add("Ngừng hoạt động");

            cb_quoctich.Items.Add("Việt Nam");
            cb_quoctich.Items.Add("Ngoại quốc");

            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");

            var loaiTheValues = _chuThes.Select(ct => ct.LoaiThe).Distinct().ToList();
            var statusValues = _chuThes.Select(ct => ct.Status).Distinct().ToList();

            cb_loaithe.Items.AddRange(loaiTheValues.Select(lt => lt.ToString()).ToArray());
            cb_status.Items.AddRange(statusValues.Select(s => s.ToString()).ToArray());
        }

        public void SendData(Guid id, string cmnd, string hoVaTen, string diaChi, int loaiThe, int gioiTinh, string ngheNghiep, int quocTich, int loaiBanDoc, string email, string noiLamViec)
        {
            txt_cccd.Text = cmnd;
            txt_hovaten.Text = hoVaTen;
            txt_diachi.Text = diaChi;
            cb_loaithe.SelectedIndex = cb_loaithe.Items.IndexOf(loaiThe.ToString());
            cb_gioitinh.SelectedIndex = cb_gioitinh.Items.IndexOf(gioiTinh == 1 ? "Nam" : "Nữ");
            txt_nghenghiep.Text = ngheNghiep;
            cb_quoctich.SelectedIndex = cb_quoctich.Items.IndexOf(quocTich.ToString());
            cb_loaibandoc.SelectedIndex = cb_loaibandoc.Items.IndexOf(loaiBanDoc.ToString());
            txt_email.Text = email;
            txt_noilamviec.Text = noiLamViec;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn thêm thẻ thư viện?"))
            {
                int loaiThe;
                string loaiTheText = cb_loaithe.Text.Trim();
                if (string.IsNullOrEmpty(loaiTheText) || !int.TryParse(loaiTheText, out loaiThe))
                {
                    MessageBoxExtension.Notification("Lỗi", "Loại thẻ không hợp lệ.");
                    return;
                }

                int gioiTinh;
                string gioiTinhText = cb_gioitinh.Text.Trim();
                if (string.IsNullOrEmpty(gioiTinhText) || !int.TryParse(gioiTinhText, out gioiTinh))
                {
                    MessageBoxExtension.Notification("Lỗi", "Giới tính không hợp lệ.");
                    return;
                }

                int quocTich;
                string quocTichText = cb_quoctich.Text.Trim();
                if (string.IsNullOrEmpty(quocTichText) || !int.TryParse(quocTichText, out quocTich))
                {
                    MessageBoxExtension.Notification("Lỗi", "Quốc tịch không hợp lệ.");
                    return;
                }

                int loaiBanDoc;
                string loaiBanDocText = cb_loaibandoc.Text.Trim();
                if (string.IsNullOrEmpty(loaiBanDocText) || !int.TryParse(loaiBanDocText, out loaiBanDoc))
                {
                    MessageBoxExtension.Notification("Lỗi", "Loại bạn đọc không hợp lệ.");
                    return;
                }

                var chuTheCreate = new ChuTheCreateVM
                {
                    Cccd = txt_cccd.Text,
                    HoVaTen = txt_hovaten.Text,
                    DiaChi = txt_diachi.Text,
                    LoaiThe = loaiThe,
                    GioiTinh = gioiTinh,
                    NgheNghiep = txt_nghenghiep.Text,
                    QuocTich = quocTich,
                    LoaiBanDoc = loaiBanDoc,
                    Email = txt_email.Text,
                    NoiLamViec = txt_noilamviec.Text,
                };

                var validResult = ChuTheValidation.ValidateCreateVM(chuTheCreate);

                if (string.IsNullOrEmpty(validResult))
                {
                    var result = _chuTheService.Create(chuTheCreate);
                    bool isSuccess = result.Equals("Thẻ thư viện đã được thêm thành công.", StringComparison.OrdinalIgnoreCase);
                    MessageBoxExtension.Notification("THÊM", result);

                    if (isSuccess)
                    {
                        DataAdded?.Invoke();
                        this.Close(); // Đóng form sau khi thêm thành công
                    }
                }
                else
                {
                    MessageBoxExtension.Notification("THÊM", validResult);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
