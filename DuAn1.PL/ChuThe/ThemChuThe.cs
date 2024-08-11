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
        public event Action _onDataAdded;

       

        public ThemChuTHe(Action onDataAdded)
        {
            InitializeComponent();
            _chuTheService = new ChuTheService();
            _onDataAdded = onDataAdded;
            LoadFormData();
        }
        private void LoadFormData()
        {
            cb_gioitinh.Items.Add("1");
            cb_gioitinh.Items.Add("2");

            cb_loaibandoc.Items.Add("1");
            cb_loaibandoc.Items.Add("2");

            cb_loaithe.Items.Add("1");
            cb_loaithe.Items.Add("2");
            cb_loaithe.Items.Add("3");

            cb_status.Items.Add("1");
            cb_status.Items.Add("2");

            cb_quoctich.Items.Add("1");
            cb_quoctich.Items.Add("2");
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

                int status;
                string statusText = cb_status.Text.Trim();
                if (string.IsNullOrEmpty(statusText) || !int.TryParse(statusText, out status))
                {
                    MessageBoxExtension.Notification("Lỗi", "Status không hợp lệ.");
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
                    Status = status,
                };

                var validResult = ChuTheValidation.ValidateCreateVM(chuTheCreate);

                if (string.IsNullOrEmpty(validResult))
                {
                    var result = _chuTheService.Create(chuTheCreate);
                    bool isSuccess = result.Equals("Chủ thẻ đã được thêm thành công", StringComparison.OrdinalIgnoreCase);
                    MessageBoxExtension.Notification("THÊM", result);

                    if (isSuccess)
                    {
                        _onDataAdded?.Invoke();
                        
                    }
                    this.Close();
                }
                else
                {
                    MessageBoxExtension.Notification("THÊM", validResult);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
