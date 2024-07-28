namespace DuAnOne.PL.TaiKhoan
{
    partial class ThemTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_huy = new Button();
            btn_them = new Button();
            cbx_chucvu = new ComboBox();
            cbx_status = new ComboBox();
            lbl_matkhau = new Label();
            txt_matkhau = new TextBox();
            tbl_taikhoan = new Label();
            txt_taikhoan = new TextBox();
            lbl_chucvu = new Label();
            lbl_status = new Label();
            lbl_manhanvien = new Label();
            txt_manhanvien = new TextBox();
            lbl_email = new Label();
            txt_email = new TextBox();
            lbl_sdt = new Label();
            txt_sodienthoai = new TextBox();
            lbl_diachi = new Label();
            txt_diachi = new TextBox();
            lbl_ngaysinh = new Label();
            txt_ngaysinh = new TextBox();
            lbl_ten = new Label();
            txt_hovaten = new TextBox();
            SuspendLayout();
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(536, 164);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(188, 54);
            btn_huy.TabIndex = 45;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(536, 85);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(188, 54);
            btn_them.TabIndex = 44;
            btn_them.Text = "Xác Nhận Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // cbx_chucvu
            // 
            cbx_chucvu.FormattingEnabled = true;
            cbx_chucvu.Location = new Point(135, 297);
            cbx_chucvu.Name = "cbx_chucvu";
            cbx_chucvu.Size = new Size(215, 23);
            cbx_chucvu.TabIndex = 43;
            // 
            // cbx_status
            // 
            cbx_status.FormattingEnabled = true;
            cbx_status.Location = new Point(135, 269);
            cbx_status.Name = "cbx_status";
            cbx_status.Size = new Size(215, 23);
            cbx_status.TabIndex = 42;
            // 
            // lbl_matkhau
            // 
            lbl_matkhau.AutoSize = true;
            lbl_matkhau.Location = new Point(70, 358);
            lbl_matkhau.Name = "lbl_matkhau";
            lbl_matkhau.Size = new Size(58, 15);
            lbl_matkhau.TabIndex = 41;
            lbl_matkhau.Text = "Mật Khẩu";
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(133, 355);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(217, 23);
            txt_matkhau.TabIndex = 40;
            // 
            // tbl_taikhoan
            // 
            tbl_taikhoan.AutoSize = true;
            tbl_taikhoan.Location = new Point(69, 329);
            tbl_taikhoan.Name = "tbl_taikhoan";
            tbl_taikhoan.Size = new Size(58, 15);
            tbl_taikhoan.TabIndex = 39;
            tbl_taikhoan.Text = "Tài Khoản";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(133, 326);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(217, 23);
            txt_taikhoan.TabIndex = 38;
            // 
            // lbl_chucvu
            // 
            lbl_chucvu.AutoSize = true;
            lbl_chucvu.Location = new Point(73, 300);
            lbl_chucvu.Name = "lbl_chucvu";
            lbl_chucvu.Size = new Size(52, 15);
            lbl_chucvu.TabIndex = 37;
            lbl_chucvu.Text = "Chức Vụ";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(89, 271);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(39, 15);
            lbl_status.TabIndex = 36;
            lbl_status.Text = "Status";
            // 
            // lbl_manhanvien
            // 
            lbl_manhanvien.AutoSize = true;
            lbl_manhanvien.Location = new Point(45, 242);
            lbl_manhanvien.Name = "lbl_manhanvien";
            lbl_manhanvien.Size = new Size(82, 15);
            lbl_manhanvien.TabIndex = 35;
            lbl_manhanvien.Text = "Mã Nhân Viên";
            // 
            // txt_manhanvien
            // 
            txt_manhanvien.Location = new Point(133, 239);
            txt_manhanvien.Name = "txt_manhanvien";
            txt_manhanvien.Size = new Size(217, 23);
            txt_manhanvien.TabIndex = 34;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(89, 213);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 33;
            lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(133, 210);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(217, 23);
            txt_email.TabIndex = 32;
            // 
            // lbl_sdt
            // 
            lbl_sdt.AutoSize = true;
            lbl_sdt.Location = new Point(89, 184);
            lbl_sdt.Name = "lbl_sdt";
            lbl_sdt.Size = new Size(27, 15);
            lbl_sdt.TabIndex = 31;
            lbl_sdt.Text = "SĐT";
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(133, 181);
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(217, 23);
            txt_sodienthoai.TabIndex = 30;
            // 
            // lbl_diachi
            // 
            lbl_diachi.AutoSize = true;
            lbl_diachi.Location = new Point(82, 144);
            lbl_diachi.Name = "lbl_diachi";
            lbl_diachi.Size = new Size(45, 15);
            lbl_diachi.TabIndex = 29;
            lbl_diachi.Text = "Địa Chỉ";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(133, 141);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(217, 23);
            txt_diachi.TabIndex = 28;
            // 
            // lbl_ngaysinh
            // 
            lbl_ngaysinh.AutoSize = true;
            lbl_ngaysinh.Location = new Point(66, 105);
            lbl_ngaysinh.Name = "lbl_ngaysinh";
            lbl_ngaysinh.Size = new Size(61, 15);
            lbl_ngaysinh.TabIndex = 27;
            lbl_ngaysinh.Text = "Ngày Sinh";
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(133, 102);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(217, 23);
            txt_ngaysinh.TabIndex = 26;
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.Location = new Point(89, 67);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(25, 15);
            lbl_ten.TabIndex = 25;
            lbl_ten.Text = "Tên";
            // 
            // txt_hovaten
            // 
            txt_hovaten.Location = new Point(133, 64);
            txt_hovaten.Name = "txt_hovaten";
            txt_hovaten.Size = new Size(217, 23);
            txt_hovaten.TabIndex = 24;
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_huy);
            Controls.Add(btn_them);
            Controls.Add(cbx_chucvu);
            Controls.Add(cbx_status);
            Controls.Add(lbl_matkhau);
            Controls.Add(txt_matkhau);
            Controls.Add(tbl_taikhoan);
            Controls.Add(txt_taikhoan);
            Controls.Add(lbl_chucvu);
            Controls.Add(lbl_status);
            Controls.Add(lbl_manhanvien);
            Controls.Add(txt_manhanvien);
            Controls.Add(lbl_email);
            Controls.Add(txt_email);
            Controls.Add(lbl_sdt);
            Controls.Add(txt_sodienthoai);
            Controls.Add(lbl_diachi);
            Controls.Add(txt_diachi);
            Controls.Add(lbl_ngaysinh);
            Controls.Add(txt_ngaysinh);
            Controls.Add(lbl_ten);
            Controls.Add(txt_hovaten);
            Name = "ThemTaiKhoan";
            Text = "ThemTaiKhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_huy;
        private Button btn_them;
        private ComboBox cbx_chucvu;
        private ComboBox cbx_status;
        private Label lbl_matkhau;
        private TextBox txt_matkhau;
        private Label tbl_taikhoan;
        private TextBox txt_taikhoan;
        private Label lbl_chucvu;
        private Label lbl_status;
        private Label lbl_manhanvien;
        private TextBox txt_manhanvien;
        private Label lbl_email;
        private TextBox txt_email;
        private Label lbl_sdt;
        private TextBox txt_sodienthoai;
        private Label lbl_diachi;
        private TextBox txt_diachi;
        private Label lbl_ngaysinh;
        private TextBox txt_ngaysinh;
        private Label lbl_ten;
        private TextBox txt_hovaten;
    }
}