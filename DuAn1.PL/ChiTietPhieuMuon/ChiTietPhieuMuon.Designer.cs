namespace DuAnOne.PL.ChiTietPhieuMuon
{
    partial class ChiTietPhieuMuon
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
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_hienthichon = new TextBox();
            lb_bandangchon = new Label();
            txt_search = new TextBox();
            dgv_chitietphieumuon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_chitietphieumuon).BeginInit();
            SuspendLayout();
            // 
            // btn_them
            // 
            btn_them.Location = new Point(929, 128);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(149, 51);
            btn_them.TabIndex = 57;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(531, 128);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(149, 51);
            btn_sua.TabIndex = 55;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(729, 128);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(149, 51);
            btn_xoa.TabIndex = 54;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // txt_hienthichon
            // 
            txt_hienthichon.Location = new Point(150, 137);
            txt_hienthichon.Name = "txt_hienthichon";
            txt_hienthichon.Size = new Size(173, 23);
            txt_hienthichon.TabIndex = 60;
            // 
            // lb_bandangchon
            // 
            lb_bandangchon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_bandangchon.AutoSize = true;
            lb_bandangchon.Location = new Point(54, 140);
            lb_bandangchon.Name = "lb_bandangchon";
            lb_bandangchon.Size = new Size(90, 15);
            lb_bandangchon.TabIndex = 59;
            lb_bandangchon.Text = "Bạn Đang Chọn";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(54, 75);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(330, 23);
            txt_search.TabIndex = 58;
            txt_search.Text = "Search";
            // 
            // dgv_chitietphieumuon
            // 
            dgv_chitietphieumuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_chitietphieumuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chitietphieumuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chitietphieumuon.Location = new Point(36, 224);
            dgv_chitietphieumuon.Name = "dgv_chitietphieumuon";
            dgv_chitietphieumuon.RowHeadersWidth = 51;
            dgv_chitietphieumuon.RowTemplate.Height = 25;
            dgv_chitietphieumuon.Size = new Size(1297, 386);
            dgv_chitietphieumuon.TabIndex = 56;
            // 
            // ChiTietPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 651);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(txt_hienthichon);
            Controls.Add(lb_bandangchon);
            Controls.Add(txt_search);
            Controls.Add(dgv_chitietphieumuon);
            Name = "ChiTietPhieuMuon";
            Text = "ChiTietPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)dgv_chitietphieumuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox txt_hienthichon;
        private Label lb_bandangchon;
        private TextBox txt_search;
        private DataGridView dgv_chitietphieumuon;
    }
}