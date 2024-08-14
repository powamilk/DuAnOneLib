using DuAnOne.BUS.Implement;
using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.ChuThes;
using DuAnOne.DAL;
using DuAnOne.DAL.Repositories.Implement;
using DuAnOne.DAL.Repositories.Interfaces;
using DuAnOne.PL.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuAnOne.PL.ChuThe
{
    public partial class SuaChuThe : Form
    {
        private IChuTheService _chuTheService;
        private Guid _id;
        private ChuTheVM _chuTheData;
        private event Action _onDataUpdated;

        public SuaChuThe(Action onDataUpdated)
        {
            InitializeComponent();
            LoadFormData();
            _onDataUpdated = onDataUpdated;
            _chuTheService = new ChuTheService();
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

        public void SendDataToChuThe(Guid id,string cccd, string hoVaTen, int loaiThe, string diaChi, int gioiTinh, string ngheNghiep, int quocTich, int loaiBanDoc, string email, string noiLamViec, int status )
        {
            _id = id;   
            txt_cccd.Text = cccd;  
            txt_hovaten.Text = hoVaTen;
            cb_loaithe.Text = loaiThe.ToString();
            txt_diachi.Text = diaChi;
            cb_gioitinh.Text = gioiTinh.ToString();
            txt_nghenghiep.Text = ngheNghiep;
            cb_quoctich.Text = quocTich.ToString();
            cb_loaibandoc.Text = loaiBanDoc.ToString();
            txt_email.Text = email;
            cb_status.Text = status.ToString();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn sửa thẻ thư viện?"))
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
                    var chuTheUpdate = new ChuTheUpdateVM
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

                    var result = _chuTheService.Update(chuTheUpdate);
                    bool isSuccess = result.Equals("Cập nhật thẻ thư viện thành công", StringComparison.OrdinalIgnoreCase);

                    MessageBoxExtension.Notification("SỬA", result);

                    if (isSuccess)
                    {
                        _onDataUpdated?.Invoke();
                        this.Close();
                    }
              
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
