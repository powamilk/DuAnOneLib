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
            pln_them = new Panel();
            btn_them = new Button();
            pln_suaxoa = new Panel();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_hienthichon = new TextBox();
            lb_bandangchon = new Label();
            txt_search = new TextBox();
            dgv_taikhoan = new DataGridView();
            tab_chuthe = new TabPage();
            tab_thethuvien = new TabPage();
            tab_sach = new TabPage();
            tab_phieumuon = new TabPage();
            tabDuAn.SuspendLayout();
            tab_taikhoan.SuspendLayout();
            pln_them.SuspendLayout();
            pln_suaxoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).BeginInit();
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
            tab_taikhoan.Controls.Add(pln_them);
            tab_taikhoan.Controls.Add(pln_suaxoa);
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
            tab_taikhoan.Click += tabPage1_Click;
            // 
            // pln_them
            // 
            pln_them.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pln_them.Controls.Add(btn_them);
            pln_them.Location = new Point(1208, 58);
            pln_them.Name = "pln_them";
            pln_them.Size = new Size(132, 67);
            pln_them.TabIndex = 42;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(18, 16);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(102, 39);
            btn_them.TabIndex = 44;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // pln_suaxoa
            // 
            pln_suaxoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pln_suaxoa.Controls.Add(btn_sua);
            pln_suaxoa.Controls.Add(btn_xoa);
            pln_suaxoa.Location = new Point(397, 58);
            pln_suaxoa.Name = "pln_suaxoa";
            pln_suaxoa.Size = new Size(229, 66);
            pln_suaxoa.TabIndex = 41;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(9, 11);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(102, 39);
            btn_sua.TabIndex = 43;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(117, 11);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(102, 39);
            btn_xoa.TabIndex = 42;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_hienthichon
            // 
            txt_hienthichon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_hienthichon.Location = new Point(110, 78);
            txt_hienthichon.Name = "txt_hienthichon";
            txt_hienthichon.Size = new Size(256, 23);
            txt_hienthichon.TabIndex = 40;
            // 
            // lb_bandangchon
            // 
            lb_bandangchon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_bandangchon.AutoSize = true;
            lb_bandangchon.Location = new Point(14, 81);
            lb_bandangchon.Name = "lb_bandangchon";
            lb_bandangchon.Size = new Size(90, 15);
            lb_bandangchon.TabIndex = 39;
            lb_bandangchon.Text = "Bạn Đang Chọn";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(12, 21);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(464, 23);
            txt_search.TabIndex = 35;
            txt_search.Text = "Search";
            // 
            // dgv_taikhoan
            // 
            dgv_taikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_taikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_taikhoan.Location = new Point(14, 130);
            dgv_taikhoan.Name = "dgv_taikhoan";
            dgv_taikhoan.RowTemplate.Height = 25;
            dgv_taikhoan.Size = new Size(1326, 460);
            dgv_taikhoan.TabIndex = 34;
            dgv_taikhoan.CellContentClick += dgv_taikhoan_CellContentClick;
            // 
            // tab_chuthe
            // 
            tab_chuthe.Location = new Point(4, 24);
            tab_chuthe.Name = "tab_chuthe";
            tab_chuthe.Padding = new Padding(3);
            tab_chuthe.Size = new Size(1356, 610);
            tab_chuthe.TabIndex = 1;
            tab_chuthe.Text = "Chủ Thẻ";
            tab_chuthe.UseVisualStyleBackColor = true;
            // 
            // tab_thethuvien
            // 
            tab_thethuvien.Location = new Point(4, 24);
            tab_thethuvien.Name = "tab_thethuvien";
            tab_thethuvien.Padding = new Padding(3);
            tab_thethuvien.Size = new Size(1356, 610);
            tab_thethuvien.TabIndex = 2;
            tab_thethuvien.Text = "Thẻ Thư Viện";
            tab_thethuvien.UseVisualStyleBackColor = true;
            // 
            // tab_sach
            // 
            tab_sach.Location = new Point(4, 24);
            tab_sach.Name = "tab_sach";
            tab_sach.Padding = new Padding(3);
            tab_sach.Size = new Size(1356, 610);
            tab_sach.TabIndex = 3;
            tab_sach.Text = "Sách";
            tab_sach.UseVisualStyleBackColor = true;
            // 
            // tab_phieumuon
            // 
            tab_phieumuon.Location = new Point(4, 24);
            tab_phieumuon.Name = "tab_phieumuon";
            tab_phieumuon.Padding = new Padding(3);
            tab_phieumuon.Size = new Size(1356, 610);
            tab_phieumuon.TabIndex = 4;
            tab_phieumuon.Text = "Phiếu Mượn";
            tab_phieumuon.UseVisualStyleBackColor = true;
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
            pln_them.ResumeLayout(false);
            pln_suaxoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDuAn;
        private TabPage tab_taikhoan;
        private TabPage tab_chuthe;
        private TabPage tab_thethuvien;
        private TabPage tab_sach;
        private TabPage tab_phieumuon;
        private TextBox txt_hienthichon;
        private Label lb_bandangchon;
        private Button btn_them;
        private TextBox txt_search;
        private DataGridView dgv_taikhoan;
        private Panel pln_them;
        private Panel pln_suaxoa;
        private Button btn_sua;
        private Button btn_xoa;
    }
}