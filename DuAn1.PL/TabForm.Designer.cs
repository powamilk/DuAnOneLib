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
            tab_phieumuon = new TabPage();
            tabDuAn.SuspendLayout();
            tab_taikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).BeginInit();
            tab_chuthe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_chuthe).BeginInit();
            tab_thethuvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thethuvien).BeginInit();
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
            tabDuAn.Margin = new Padding(3, 4, 3, 4);
            tabDuAn.Name = "tabDuAn";
            tabDuAn.SelectedIndex = 0;
            tabDuAn.Size = new Size(1559, 851);
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
            tab_taikhoan.Location = new Point(4, 29);
            tab_taikhoan.Margin = new Padding(3, 4, 3, 4);
            tab_taikhoan.Name = "tab_taikhoan";
            tab_taikhoan.Padding = new Padding(3, 4, 3, 4);
            tab_taikhoan.Size = new Size(1551, 818);
            tab_taikhoan.TabIndex = 0;
            tab_taikhoan.Text = "Tài Khoản";
            tab_taikhoan.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(1331, 129);
            btn_them.Margin = new Padding(3, 4, 3, 4);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(170, 80);
            btn_them.TabIndex = 50;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click_1;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(608, 129);
            btn_sua.Margin = new Padding(3, 4, 3, 4);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(170, 80);
            btn_sua.TabIndex = 48;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(834, 129);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(170, 80);
            btn_xoa.TabIndex = 47;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // txt_hienthichon
            // 
            txt_hienthichon.Location = new Point(173, 141);
            txt_hienthichon.Margin = new Padding(3, 4, 3, 4);
            txt_hienthichon.Name = "txt_hienthichon";
            txt_hienthichon.Size = new Size(197, 27);
            txt_hienthichon.TabIndex = 53;
            // 
            // lb_bandangchon
            // 
            lb_bandangchon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_bandangchon.AutoSize = true;
            lb_bandangchon.Location = new Point(63, 145);
            lb_bandangchon.Name = "lb_bandangchon";
            lb_bandangchon.Size = new Size(112, 20);
            lb_bandangchon.TabIndex = 52;
            lb_bandangchon.Text = "Bạn Đang Chọn";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(55, 39);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(377, 27);
            txt_search.TabIndex = 51;
            txt_search.Text = "Search";
            // 
            // dgv_taikhoan
            // 
            dgv_taikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_taikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_taikhoan.Location = new Point(42, 257);
            dgv_taikhoan.Margin = new Padding(3, 4, 3, 4);
            dgv_taikhoan.Name = "dgv_taikhoan";
            dgv_taikhoan.RowHeadersWidth = 51;
            dgv_taikhoan.RowTemplate.Height = 25;
            dgv_taikhoan.Size = new Size(1482, 527);
            dgv_taikhoan.TabIndex = 49;
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
            tab_chuthe.Location = new Point(4, 29);
            tab_chuthe.Margin = new Padding(3, 4, 3, 4);
            tab_chuthe.Name = "tab_chuthe";
            tab_chuthe.Padding = new Padding(3, 4, 3, 4);
            tab_chuthe.Size = new Size(1551, 818);
            tab_chuthe.TabIndex = 1;
            tab_chuthe.Text = "Chủ Thẻ";
            tab_chuthe.UseVisualStyleBackColor = true;
            // 
            // btn_themchuthe
            // 
            btn_themchuthe.Location = new Point(1323, 125);
            btn_themchuthe.Margin = new Padding(3, 4, 3, 4);
            btn_themchuthe.Name = "btn_themchuthe";
            btn_themchuthe.Size = new Size(170, 80);
            btn_themchuthe.TabIndex = 57;
            btn_themchuthe.Text = "Thêm";
            btn_themchuthe.UseVisualStyleBackColor = true;
            btn_themchuthe.Click += btn_themchuthe_Click;
            // 
            // btn_suachuthe
            // 
            btn_suachuthe.Location = new Point(600, 125);
            btn_suachuthe.Margin = new Padding(3, 4, 3, 4);
            btn_suachuthe.Name = "btn_suachuthe";
            btn_suachuthe.Size = new Size(170, 80);
            btn_suachuthe.TabIndex = 55;
            btn_suachuthe.Text = "Sửa";
            btn_suachuthe.UseVisualStyleBackColor = true;
            // 
            // btn_xoachuthe
            // 
            btn_xoachuthe.Location = new Point(826, 125);
            btn_xoachuthe.Margin = new Padding(3, 4, 3, 4);
            btn_xoachuthe.Name = "btn_xoachuthe";
            btn_xoachuthe.Size = new Size(170, 80);
            btn_xoachuthe.TabIndex = 54;
            btn_xoachuthe.Text = "Xóa";
            btn_xoachuthe.UseVisualStyleBackColor = true;
            btn_xoachuthe.Click += btn_xoachuthe_Click;
            // 
            // txt_hienthichonchuthe
            // 
            txt_hienthichonchuthe.Location = new Point(173, 138);
            txt_hienthichonchuthe.Margin = new Padding(3, 4, 3, 4);
            txt_hienthichonchuthe.Name = "txt_hienthichonchuthe";
            txt_hienthichonchuthe.Size = new Size(197, 27);
            txt_hienthichonchuthe.TabIndex = 60;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(55, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 59;
            label2.Text = "Bạn Đang Chọn";
            // 
            // txt_searchchuthe
            // 
            txt_searchchuthe.Location = new Point(47, 35);
            txt_searchchuthe.Margin = new Padding(3, 4, 3, 4);
            txt_searchchuthe.Name = "txt_searchchuthe";
            txt_searchchuthe.Size = new Size(377, 27);
            txt_searchchuthe.TabIndex = 58;
            txt_searchchuthe.Text = "Search";
            // 
            // dgv_chuthe
            // 
            dgv_chuthe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_chuthe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chuthe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chuthe.Location = new Point(34, 253);
            dgv_chuthe.Margin = new Padding(3, 4, 3, 4);
            dgv_chuthe.Name = "dgv_chuthe";
            dgv_chuthe.RowHeadersWidth = 51;
            dgv_chuthe.RowTemplate.Height = 25;
            dgv_chuthe.Size = new Size(1482, 527);
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
            tab_thethuvien.Location = new Point(4, 29);
            tab_thethuvien.Margin = new Padding(3, 4, 3, 4);
            tab_thethuvien.Name = "tab_thethuvien";
            tab_thethuvien.Padding = new Padding(3, 4, 3, 4);
            tab_thethuvien.Size = new Size(1551, 818);
            tab_thethuvien.TabIndex = 2;
            tab_thethuvien.Text = "Thẻ Thư Viện";
            tab_thethuvien.UseVisualStyleBackColor = true;
            // 
            // btn_themthethuvien
            // 
            btn_themthethuvien.Location = new Point(1323, 125);
            btn_themthethuvien.Margin = new Padding(3, 4, 3, 4);
            btn_themthethuvien.Name = "btn_themthethuvien";
            btn_themthethuvien.Size = new Size(170, 80);
            btn_themthethuvien.TabIndex = 64;
            btn_themthethuvien.Text = "Thêm";
            btn_themthethuvien.UseVisualStyleBackColor = true;
            // 
            // btn_suathethuvien
            // 
            btn_suathethuvien.Location = new Point(600, 125);
            btn_suathethuvien.Margin = new Padding(3, 4, 3, 4);
            btn_suathethuvien.Name = "btn_suathethuvien";
            btn_suathethuvien.Size = new Size(170, 80);
            btn_suathethuvien.TabIndex = 62;
            btn_suathethuvien.Text = "Sửa";
            btn_suathethuvien.UseVisualStyleBackColor = true;
            // 
            // btn_xoathethuvien
            // 
            btn_xoathethuvien.Location = new Point(826, 125);
            btn_xoathethuvien.Margin = new Padding(3, 4, 3, 4);
            btn_xoathethuvien.Name = "btn_xoathethuvien";
            btn_xoathethuvien.Size = new Size(170, 80);
            btn_xoathethuvien.TabIndex = 61;
            btn_xoathethuvien.Text = "Xóa";
            btn_xoathethuvien.UseVisualStyleBackColor = true;
            // 
            // txt_hienthichonthethuvien
            // 
            txt_hienthichonthethuvien.Location = new Point(165, 137);
            txt_hienthichonthethuvien.Margin = new Padding(3, 4, 3, 4);
            txt_hienthichonthethuvien.Name = "txt_hienthichonthethuvien";
            txt_hienthichonthethuvien.Size = new Size(197, 27);
            txt_hienthichonthethuvien.TabIndex = 67;
            // 
            // lbl_hienthichonthethuvien
            // 
            lbl_hienthichonthethuvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hienthichonthethuvien.AutoSize = true;
            lbl_hienthichonthethuvien.Location = new Point(55, 141);
            lbl_hienthichonthethuvien.Name = "lbl_hienthichonthethuvien";
            lbl_hienthichonthethuvien.Size = new Size(112, 20);
            lbl_hienthichonthethuvien.TabIndex = 66;
            lbl_hienthichonthethuvien.Text = "Bạn Đang Chọn";
            // 
            // txt_searchthethuvien
            // 
            txt_searchthethuvien.Location = new Point(47, 35);
            txt_searchthethuvien.Margin = new Padding(3, 4, 3, 4);
            txt_searchthethuvien.Name = "txt_searchthethuvien";
            txt_searchthethuvien.Size = new Size(377, 27);
            txt_searchthethuvien.TabIndex = 65;
            txt_searchthethuvien.Text = "Search";
            // 
            // dgv_thethuvien
            // 
            dgv_thethuvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_thethuvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thethuvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thethuvien.Location = new Point(34, 253);
            dgv_thethuvien.Margin = new Padding(3, 4, 3, 4);
            dgv_thethuvien.Name = "dgv_thethuvien";
            dgv_thethuvien.RowHeadersWidth = 51;
            dgv_thethuvien.RowTemplate.Height = 25;
            dgv_thethuvien.Size = new Size(1482, 527);
            dgv_thethuvien.TabIndex = 63;
            // 
            // tab_sach
            // 
            tab_sach.Location = new Point(4, 29);
            tab_sach.Margin = new Padding(3, 4, 3, 4);
            tab_sach.Name = "tab_sach";
            tab_sach.Padding = new Padding(3, 4, 3, 4);
            tab_sach.Size = new Size(1551, 818);
            tab_sach.TabIndex = 3;
            tab_sach.Text = "Sách";
            tab_sach.UseVisualStyleBackColor = true;
            // 
            // tab_phieumuon
            // 
            tab_phieumuon.Location = new Point(4, 29);
            tab_phieumuon.Margin = new Padding(3, 4, 3, 4);
            tab_phieumuon.Name = "tab_phieumuon";
            tab_phieumuon.Padding = new Padding(3, 4, 3, 4);
            tab_phieumuon.Size = new Size(1551, 818);
            tab_phieumuon.TabIndex = 4;
            tab_phieumuon.Text = "Phiếu Mượn";
            tab_phieumuon.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1559, 851);
            Controls.Add(tabDuAn);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}