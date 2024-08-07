namespace DuAnOne.PL
{
    partial class TabForm
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
            tabDuAn = new TabControl();
            tab_taikhoan = new TabPage();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_hienthichon = new TextBox();
            lb_bandangchon = new Label();
            txt_search = new TextBox();
            dgv_taikhoan = new DataGridView();
            tab_chuthe = new TabPage();
            btn_themchuthe = new Button();
            btn_suachuthe = new Button();
            btn_xoachuthe = new Button();
            txt_hienthichonchuthe = new TextBox();
            label2 = new Label();
            txt_searchchuthe = new TextBox();
            dgv_chuthe = new DataGridView();
            tab_thethuvien = new TabPage();
            btn_themthethuvien = new Button();
            btn_suathethuvien = new Button();
            btn_xoathethuvien = new Button();
            txt_hienthichonthethuvien = new TextBox();
            lbl_hienthichonthethuvien = new Label();
            txt_searchthethuvien = new TextBox();
            dgv_thethuvien = new DataGridView();
            tab_sach = new TabPage();
            btn_themsach = new Button();
            btn_suasach = new Button();
            btn_xoasach = new Button();
            txt_hienthichonsach = new TextBox();
            label1 = new Label();
            tb_searchSach = new TextBox();
            dgv_sach = new DataGridView();
            tab_phieumuon = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dgv_phieumuon = new DataGridView();
            tabDuAn.SuspendLayout();
            tab_taikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).BeginInit();
            tab_chuthe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_chuthe).BeginInit();
            tab_thethuvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thethuvien).BeginInit();
            tab_sach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sach).BeginInit();
            tab_phieumuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_phieumuon).BeginInit();
            SuspendLayout();
            // 
            // tabDuAn
            // 
            tabDuAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDuAn.Controls.Add(tab_taikhoan);
            tabDuAn.Controls.Add(tab_chuthe);
            tabDuAn.Controls.Add(tab_thethuvien);
            tabDuAn.Controls.Add(tab_sach);
            tabDuAn.Controls.Add(tab_phieumuon);
            tabDuAn.Location = new Point(0, 0);
            tabDuAn.Name = "tabDuAn";
            tabDuAn.SelectedIndex = 0;
            tabDuAn.Size = new Size(1364, 638);
            tabDuAn.TabIndex = 0;
            // 
            // tab_taikhoan
            // 
            tab_taikhoan.Controls.Add(btn_them);
            tab_taikhoan.Controls.Add(btn_sua);
            tab_taikhoan.Controls.Add(btn_xoa);
            tab_taikhoan.Controls.Add(txt_hienthichon);
            tab_taikhoan.Controls.Add(lb_bandangchon);
            tab_taikhoan.Controls.Add(txt_search);
            tab_taikhoan.Controls.Add(dgv_taikhoan);
            tab_taikhoan.Location = new Point(4, 24);
            tab_taikhoan.Name = "tab_taikhoan";
            tab_taikhoan.Padding = new Padding(3);
            tab_taikhoan.Size = new Size(1356, 610);
            tab_taikhoan.TabIndex = 0;
            tab_taikhoan.Text = "Tài Khoản";
            tab_taikhoan.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(1165, 97);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(149, 60);
            btn_them.TabIndex = 50;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click_1;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(532, 97);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(149, 60);
            btn_sua.TabIndex = 48;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(730, 97);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(149, 60);
            btn_xoa.TabIndex = 47;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click_1;
            // 
            // txt_hienthichon
            // 
            txt_hienthichon.Location = new Point(151, 106);
            txt_hienthichon.Name = "txt_hienthichon";
            txt_hienthichon.Size = new Size(173, 23);
            txt_hienthichon.TabIndex = 53;
            // 
            // lb_bandangchon
            // 
            lb_bandangchon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_bandangchon.AutoSize = true;
            lb_bandangchon.Location = new Point(55, 109);
            lb_bandangchon.Name = "lb_bandangchon";
            lb_bandangchon.Size = new Size(90, 15);
            lb_bandangchon.TabIndex = 52;
            lb_bandangchon.Text = "Bạn Đang Chọn";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(48, 29);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(330, 23);
            txt_search.TabIndex = 51;
            txt_search.Text = "Search";
            // 
            // dgv_taikhoan
            // 
            dgv_taikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_taikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_taikhoan.Location = new Point(37, 193);
            dgv_taikhoan.Name = "dgv_taikhoan";
            dgv_taikhoan.RowHeadersWidth = 51;
            dgv_taikhoan.RowTemplate.Height = 25;
            dgv_taikhoan.Size = new Size(1297, 395);
            dgv_taikhoan.TabIndex = 49;
            dgv_taikhoan.CellClick += dgv_taikhoan_CellClick_1;
            // 
            // tab_chuthe
            // 
            tab_chuthe.Controls.Add(btn_themchuthe);
            tab_chuthe.Controls.Add(btn_suachuthe);
            tab_chuthe.Controls.Add(btn_xoachuthe);
            tab_chuthe.Controls.Add(txt_hienthichonchuthe);
            tab_chuthe.Controls.Add(label2);
            tab_chuthe.Controls.Add(txt_searchchuthe);
            tab_chuthe.Controls.Add(dgv_chuthe);
            tab_chuthe.Location = new Point(4, 24);
            tab_chuthe.Name = "tab_chuthe";
            tab_chuthe.Padding = new Padding(3);
            tab_chuthe.Size = new Size(1356, 610);
            tab_chuthe.TabIndex = 1;
            tab_chuthe.Text = "Chủ Thẻ";
            tab_chuthe.UseVisualStyleBackColor = true;
            // 
            // btn_themchuthe
            // 
            btn_themchuthe.Location = new Point(1158, 94);
            btn_themchuthe.Name = "btn_themchuthe";
            btn_themchuthe.Size = new Size(149, 60);
            btn_themchuthe.TabIndex = 57;
            btn_themchuthe.Text = "Thêm";
            btn_themchuthe.UseVisualStyleBackColor = true;
            btn_themchuthe.Click += btn_themchuthe_Click;
            // 
            // btn_suachuthe
            // 
            btn_suachuthe.Location = new Point(525, 94);
            btn_suachuthe.Name = "btn_suachuthe";
            btn_suachuthe.Size = new Size(149, 60);
            btn_suachuthe.TabIndex = 55;
            btn_suachuthe.Text = "Sửa";
            btn_suachuthe.UseVisualStyleBackColor = true;
            btn_suachuthe.Click += btn_suachuthe_Click;
            // 
            // btn_xoachuthe
            // 
            btn_xoachuthe.Location = new Point(723, 94);
            btn_xoachuthe.Name = "btn_xoachuthe";
            btn_xoachuthe.Size = new Size(149, 60);
            btn_xoachuthe.TabIndex = 54;
            btn_xoachuthe.Text = "Xóa";
            btn_xoachuthe.UseVisualStyleBackColor = true;
            btn_xoachuthe.Click += btn_xoachuthe_Click;
            // 
            // txt_hienthichonchuthe
            // 
            txt_hienthichonchuthe.Location = new Point(151, 104);
            txt_hienthichonchuthe.Name = "txt_hienthichonchuthe";
            txt_hienthichonchuthe.Size = new Size(173, 23);
            txt_hienthichonchuthe.TabIndex = 60;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(48, 106);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 59;
            label2.Text = "Bạn Đang Chọn";
            // 
            // txt_searchchuthe
            // 
            txt_searchchuthe.Location = new Point(41, 26);
            txt_searchchuthe.Name = "txt_searchchuthe";
            txt_searchchuthe.Size = new Size(330, 23);
            txt_searchchuthe.TabIndex = 58;
            txt_searchchuthe.Text = "Search";
            // 
            // dgv_chuthe
            // 
            dgv_chuthe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_chuthe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chuthe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chuthe.Location = new Point(30, 190);
            dgv_chuthe.Name = "dgv_chuthe";
            dgv_chuthe.RowHeadersWidth = 51;
            dgv_chuthe.RowTemplate.Height = 25;
            dgv_chuthe.Size = new Size(1297, 395);
            dgv_chuthe.TabIndex = 56;
            dgv_chuthe.CellClick += dgv_chuthe_CellClick;
            // 
            // tab_thethuvien
            // 
            tab_thethuvien.Controls.Add(btn_themthethuvien);
            tab_thethuvien.Controls.Add(btn_suathethuvien);
            tab_thethuvien.Controls.Add(btn_xoathethuvien);
            tab_thethuvien.Controls.Add(txt_hienthichonthethuvien);
            tab_thethuvien.Controls.Add(lbl_hienthichonthethuvien);
            tab_thethuvien.Controls.Add(txt_searchthethuvien);
            tab_thethuvien.Controls.Add(dgv_thethuvien);
            tab_thethuvien.Location = new Point(4, 24);
            tab_thethuvien.Name = "tab_thethuvien";
            tab_thethuvien.Padding = new Padding(3);
            tab_thethuvien.Size = new Size(1356, 610);
            tab_thethuvien.TabIndex = 2;
            tab_thethuvien.Text = "Thẻ Thư Viện";
            tab_thethuvien.UseVisualStyleBackColor = true;
            // 
            // btn_themthethuvien
            // 
            btn_themthethuvien.Location = new Point(1158, 94);
            btn_themthethuvien.Name = "btn_themthethuvien";
            btn_themthethuvien.Size = new Size(149, 60);
            btn_themthethuvien.TabIndex = 64;
            btn_themthethuvien.Text = "Thêm";
            btn_themthethuvien.UseVisualStyleBackColor = true;
            btn_themthethuvien.Click += btn_themthethuvien_Click;
            // 
            // btn_suathethuvien
            // 
            btn_suathethuvien.Location = new Point(525, 94);
            btn_suathethuvien.Name = "btn_suathethuvien";
            btn_suathethuvien.Size = new Size(149, 60);
            btn_suathethuvien.TabIndex = 62;
            btn_suathethuvien.Text = "Sửa";
            btn_suathethuvien.UseVisualStyleBackColor = true;
            btn_suathethuvien.Click += btn_suathethuvien_Click;
            // 
            // btn_xoathethuvien
            // 
            btn_xoathethuvien.Location = new Point(723, 94);
            btn_xoathethuvien.Name = "btn_xoathethuvien";
            btn_xoathethuvien.Size = new Size(149, 60);
            btn_xoathethuvien.TabIndex = 61;
            btn_xoathethuvien.Text = "Xóa";
            btn_xoathethuvien.UseVisualStyleBackColor = true;
            btn_xoathethuvien.Click += btn_xoathethuvien_Click;
            // 
            // txt_hienthichonthethuvien
            // 
            txt_hienthichonthethuvien.Location = new Point(144, 103);
            txt_hienthichonthethuvien.Name = "txt_hienthichonthethuvien";
            txt_hienthichonthethuvien.Size = new Size(173, 23);
            txt_hienthichonthethuvien.TabIndex = 67;
            txt_hienthichonthethuvien.TextChanged += txt_hienthichonthethuvien_TextChanged;
            // 
            // lbl_hienthichonthethuvien
            // 
            lbl_hienthichonthethuvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hienthichonthethuvien.AutoSize = true;
            lbl_hienthichonthethuvien.Location = new Point(48, 106);
            lbl_hienthichonthethuvien.Name = "lbl_hienthichonthethuvien";
            lbl_hienthichonthethuvien.Size = new Size(90, 15);
            lbl_hienthichonthethuvien.TabIndex = 66;
            lbl_hienthichonthethuvien.Text = "Bạn Đang Chọn";
            // 
            // txt_searchthethuvien
            // 
            txt_searchthethuvien.Location = new Point(41, 26);
            txt_searchthethuvien.Name = "txt_searchthethuvien";
            txt_searchthethuvien.Size = new Size(330, 23);
            txt_searchthethuvien.TabIndex = 65;
            txt_searchthethuvien.Text = "Search";
            // 
            // dgv_thethuvien
            // 
            dgv_thethuvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_thethuvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thethuvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thethuvien.Location = new Point(30, 190);
            dgv_thethuvien.Name = "dgv_thethuvien";
            dgv_thethuvien.RowHeadersWidth = 51;
            dgv_thethuvien.RowTemplate.Height = 25;
            dgv_thethuvien.Size = new Size(1297, 395);
            dgv_thethuvien.TabIndex = 63;
            dgv_thethuvien.CellClick += dgv_thethuvien_CellClick;
            // 
            // tab_sach
            // 
            tab_sach.Controls.Add(btn_themsach);
            tab_sach.Controls.Add(btn_suasach);
            tab_sach.Controls.Add(btn_xoasach);
            tab_sach.Controls.Add(txt_hienthichonsach);
            tab_sach.Controls.Add(label1);
            tab_sach.Controls.Add(tb_searchSach);
            tab_sach.Controls.Add(dgv_sach);
            tab_sach.Location = new Point(4, 24);
            tab_sach.Name = "tab_sach";
            tab_sach.Padding = new Padding(3);
            tab_sach.Size = new Size(1356, 610);
            tab_sach.TabIndex = 3;
            tab_sach.Text = "Sách";
            tab_sach.UseVisualStyleBackColor = true;
            // 
            // btn_themsach
            // 
            btn_themsach.Location = new Point(1158, 94);
            btn_themsach.Name = "btn_themsach";
            btn_themsach.Size = new Size(149, 60);
            btn_themsach.TabIndex = 71;
            btn_themsach.Text = "Thêm";
            btn_themsach.UseVisualStyleBackColor = true;
            btn_themsach.Click += btn_themsach_Click;
            // 
            // btn_suasach
            // 
            btn_suasach.Location = new Point(525, 94);
            btn_suasach.Name = "btn_suasach";
            btn_suasach.Size = new Size(149, 60);
            btn_suasach.TabIndex = 69;
            btn_suasach.Text = "Sửa";
            btn_suasach.UseVisualStyleBackColor = true;
            btn_suasach.Click += btn_suasach_Click;
            // 
            // btn_xoasach
            // 
            btn_xoasach.Location = new Point(723, 94);
            btn_xoasach.Name = "btn_xoasach";
            btn_xoasach.Size = new Size(149, 60);
            btn_xoasach.TabIndex = 68;
            btn_xoasach.Text = "Xóa";
            btn_xoasach.UseVisualStyleBackColor = true;
            btn_xoasach.Click += btn_xoasach_Click;
            // 
            // txt_hienthichonsach
            // 
            txt_hienthichonsach.Location = new Point(144, 103);
            txt_hienthichonsach.Name = "txt_hienthichonsach";
            txt_hienthichonsach.Size = new Size(173, 23);
            txt_hienthichonsach.TabIndex = 74;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(48, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 73;
            label1.Text = "Bạn Đang Chọn";
            // 
            // tb_searchSach
            // 
            tb_searchSach.Location = new Point(41, 26);
            tb_searchSach.Name = "tb_searchSach";
            tb_searchSach.Size = new Size(330, 23);
            tb_searchSach.TabIndex = 72;
            tb_searchSach.Text = "Search";
            // 
            // dgv_sach
            // 
            dgv_sach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sach.Location = new Point(30, 190);
            dgv_sach.Name = "dgv_sach";
            dgv_sach.RowHeadersWidth = 51;
            dgv_sach.RowTemplate.Height = 25;
            dgv_sach.Size = new Size(1297, 395);
            dgv_sach.TabIndex = 70;
            // 
            // tab_phieumuon
            // 
            tab_phieumuon.Controls.Add(button1);
            tab_phieumuon.Controls.Add(button2);
            tab_phieumuon.Controls.Add(button3);
            tab_phieumuon.Controls.Add(textBox1);
            tab_phieumuon.Controls.Add(label3);
            tab_phieumuon.Controls.Add(textBox2);
            tab_phieumuon.Controls.Add(dgv_phieumuon);
            tab_phieumuon.Location = new Point(4, 24);
            tab_phieumuon.Name = "tab_phieumuon";
            tab_phieumuon.Padding = new Padding(3);
            tab_phieumuon.Size = new Size(1356, 610);
            tab_phieumuon.TabIndex = 4;
            tab_phieumuon.Text = "Phiếu Mượn";
            tab_phieumuon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1145, 111);
            button1.Name = "button1";
            button1.Size = new Size(149, 60);
            button1.TabIndex = 78;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(512, 111);
            button2.Name = "button2";
            button2.Size = new Size(149, 60);
            button2.TabIndex = 76;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(710, 111);
            button3.Name = "button3";
            button3.Size = new Size(149, 60);
            button3.TabIndex = 75;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 81;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(35, 123);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 80;
            label3.Text = "Bạn Đang Chọn";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 23);
            textBox2.TabIndex = 79;
            textBox2.Text = "Search";
            // 
            // dgv_phieumuon
            // 
            dgv_phieumuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_phieumuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phieumuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_phieumuon.Location = new Point(17, 207);
            dgv_phieumuon.Name = "dgv_phieumuon";
            dgv_phieumuon.RowHeadersWidth = 51;
            dgv_phieumuon.RowTemplate.Height = 25;
            dgv_phieumuon.Size = new Size(1297, 395);
            dgv_phieumuon.TabIndex = 77;
            // 
            // TabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1364, 638);
            Controls.Add(tabDuAn);
            Name = "TabForm";
            Text = "TabForm";
            tabDuAn.ResumeLayout(false);
            tab_taikhoan.ResumeLayout(false);
            tab_taikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).EndInit();
            tab_chuthe.ResumeLayout(false);
            tab_chuthe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_chuthe).EndInit();
            tab_thethuvien.ResumeLayout(false);
            tab_thethuvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thethuvien).EndInit();
            tab_sach.ResumeLayout(false);
            tab_sach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sach).EndInit();
            tab_phieumuon.ResumeLayout(false);
            tab_phieumuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_phieumuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDuAn;
        private TabPage tab_taikhoan;
        private TabPage tab_chuthe;
        private TabPage tab_thethuvien;
        private TabPage tab_sach;
        private TabPage tab_phieumuon;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox txt_hienthichon;
        private Label lb_bandangchon;
        private TextBox txt_search;
        private DataGridView dgv_taikhoan;
        private Button btn_themchuthe;
        private Button btn_suachuthe;
        private Button btn_xoachuthe;
        private TextBox txt_hienthichonchuthe;
        private Label label2;
        private TextBox txt_searchchuthe;
        private DataGridView dgv_chuthe;
        private Button btn_themthethuvien;
        private Button btn_suathethuvien;
        private Button btn_xoathethuvien;
        private TextBox txt_hienthichonthethuvien;
        private Label lbl_hienthichonthethuvien;
        private TextBox txt_searchthethuvien;
        private DataGridView dgv_thethuvien;
        private Button btn_themsach;
        private Button btn_suasach;
        private Button btn_xoasach;
        private TextBox txt_hienthichonsach;
        private Label label1;
        private TextBox tb_searchSach;
        private DataGridView dgv_sach;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dgv_phieumuon;
    }
}