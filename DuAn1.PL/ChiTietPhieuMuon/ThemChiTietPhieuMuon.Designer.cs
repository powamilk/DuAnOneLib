namespace DuAnOne.PL.ChiTietPhieuMuon
{
    partial class ThemChiTietPhieuMuon
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
            cb_sach = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_soluong = new TextBox();
            txt_ghichu = new TextBox();
            cb_status = new ComboBox();
            label4 = new Label();
            btn_xacnhan = new Button();
            btn_huy = new Button();
            SuspendLayout();
            // 
            // cb_sach
            // 
            cb_sach.FormattingEnabled = true;
            cb_sach.Location = new Point(126, 93);
            cb_sach.Name = "cb_sach";
            cb_sach.Size = new Size(206, 23);
            cb_sach.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 96);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 166);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 96);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Ghi Chú";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(121, 167);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(211, 23);
            txt_soluong.TabIndex = 4;
            // 
            // txt_ghichu
            // 
            txt_ghichu.Location = new Point(536, 93);
            txt_ghichu.Name = "txt_ghichu";
            txt_ghichu.Size = new Size(211, 23);
            txt_ghichu.TabIndex = 5;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(536, 167);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(206, 23);
            cb_status.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 170);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(218, 266);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(163, 55);
            btn_xacnhan.TabIndex = 8;
            btn_xacnhan.Text = "Xác Nhận Thêm";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(435, 266);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(163, 55);
            btn_huy.TabIndex = 9;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // ThemChiTietPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 407);
            Controls.Add(btn_huy);
            Controls.Add(btn_xacnhan);
            Controls.Add(label4);
            Controls.Add(cb_status);
            Controls.Add(txt_ghichu);
            Controls.Add(txt_soluong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_sach);
            Name = "ThemChiTietPhieuMuon";
            Text = "ThêmChiTietPhieuMuon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_sach;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_soluong;
        private TextBox txt_ghichu;
        private ComboBox cb_status;
        private Label label4;
        private Button btn_xacnhan;
        private Button btn_huy;
    }
}