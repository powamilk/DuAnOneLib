namespace DuAn1.PL
{
    public partial class SuaTK : Form
    {
        public SuaTK()
        {
            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            cbx_chucvu.Items.Add("Nhân Viên");
            cbx_chucvu.Items.Add("Quản Lý");
            cbx_chucvu.Items.Add("Admin");

            cbx_status.Items.Add("1");
            cbx_status.Items.Add("2");
            cbx_status.Items.Add("3");

        }



        public void SendData(Guid id, string hoVaTen, DateTime ngaySinh, string diaChi, string email, string maNhanVien, string tenTaiKhoan, string matKhau, int chucVu, int status)
        {
            txt_hovaten.Text = hoVaTen;
            txt_ngaysinh.Text = ngaySinh.ToString();
            txt_diachi.Text = diaChi;
            txt_email.Text = email;
            txt_manhanvien.Text = maNhanVien;
            txt_matkhau.Text = matKhau;
            txt_taikhoan.Text = tenTaiKhoan;
            cbx_chucvu.Text = chucVu.ToString();
            cbx_status.Text = status.ToString();

        }

    }
}
