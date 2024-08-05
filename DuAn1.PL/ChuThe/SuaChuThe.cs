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
        private event Action DataUpdated;

        public SuaChuThe(IChuTheRepo chuTheRepo)
        {
            InitializeComponent();
            LoadFormData();
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

            cb_status.Items.Add("Hoạt động");
            cb_status.Items.Add("Ngừng hoạt động");

            cb_quoctich.Items.Add("Việt Nam");
            cb_quoctich.Items.Add("Ngoại quốc");
        }

        public void SendDataToChuThe(ChuTheVM chuTheData)
        {
            _chuTheData = chuTheData;

            if (_chuTheData != null)
            {
                txt_cccd.Text = _chuTheData.Cccd;
                txt_hovaten.Text = _chuTheData.HoVaTen;
                cb_loaithe.SelectedIndex = _chuTheData.LoaiThe >= 0 ? cb_loaithe.Items.IndexOf(_chuTheData.LoaiThe.ToString()) : -1;
                txt_diachi.Text = _chuTheData.DiaChi;
                cb_gioitinh.SelectedIndex = _chuTheData.GioiTinh == 1 ? 0 : 1;
                txt_nghenghiep.Text = _chuTheData.NgheNghiep;
                cb_quoctich.SelectedIndex = _chuTheData.QuocTich >= 0 ? cb_quoctich.Items.IndexOf(_chuTheData.QuocTich.ToString()) : -1;
                cb_loaibandoc.SelectedIndex = _chuTheData.LoaiBanDoc >= 0 ? cb_loaibandoc.Items.IndexOf(_chuTheData.LoaiBanDoc.ToString()) : -1;
                txt_email.Text = _chuTheData.Email;
                txt_noilamviec.Text = _chuTheData.NoiLamViec;
                cb_status.SelectedIndex = _chuTheData.Status == 1 ? 0 : 1;
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("Bạn có chắc chắn muốn sửa thẻ thư viện?"))
            {
                if (int.TryParse(cb_loaithe.Text, out int loaiThe) &&
                    int.TryParse(cb_gioitinh.Text, out int gioiTinh) &&
                    int.TryParse(cb_status.Text, out int status))
                {
                    var chuTheUpdate = new ChuTheUpdateVM
                    {
                        Id = _id,
                        Cccd = txt_cccd.Text,
                        HoVaTen = txt_hovaten.Text,
                        LoaiThe = loaiThe,
                        DiaChi = txt_diachi.Text,
                        GioiTinh = gioiTinh,
                        NgheNghiep = txt_nghenghiep.Text,
                        QuocTich = cb_quoctich.SelectedIndex >= 0 ? cb_quoctich.SelectedIndex : -1,
                        LoaiBanDoc = cb_loaibandoc.SelectedIndex >= 0 ? cb_loaibandoc.SelectedIndex : -1,
                        Email = txt_email.Text,
                        NoiLamViec = txt_noilamviec.Text,
                        Status = status
                    };

                    var result = _chuTheService.Update(chuTheUpdate);
                    bool isSuccess = result.Equals("Cập nhật thẻ thư viện thành công", StringComparison.OrdinalIgnoreCase);

                    MessageBoxExtension.Notification("SỬA", result);

                    if (isSuccess)
                    {
                        DataUpdated?.Invoke();
                        this.Close();
                    }
                }
                else
                {
                    MessageBoxExtension.Notification("Lỗi", "Dữ liệu nhập vào không hợp lệ.");
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
