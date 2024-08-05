namespace DuAnOne.PL.PhieuMuon
{
    partial class SuaPhieuMuon
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
            label1 = new Label();
            txt_idtaikhoan = new TextBox();
            txt_idthe = new TextBox();
            txt_ngaymuon = new TextBox();
            txt_ngaytra = new TextBox();
            txt_ngaytrathucte = new TextBox();
            txt_maphieu = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cb_status = new ComboBox();
            label8 = new Label();
            btn_xacnhan = new Button();
            btn_huy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 58);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Sửa Phiếu mượn";
            // 
            // txt_idtaikhoan
            // 
            txt_idtaikhoan.Location = new Point(114, 133);
            txt_idtaikhoan.Name = "txt_idtaikhoan";
            txt_idtaikhoan.Size = new Size(191, 23);
            txt_idtaikhoan.TabIndex = 1;
            // 
            // txt_idthe
            // 
            txt_idthe.Location = new Point(114, 187);
            txt_idthe.Name = "txt_idthe";
            txt_idthe.Size = new Size(191, 23);
            txt_idthe.TabIndex = 2;
            // 
            // txt_ngaymuon
            // 
            txt_ngaymuon.Location = new Point(114, 242);
            txt_ngaymuon.Name = "txt_ngaymuon";
            txt_ngaymuon.Size = new Size(191, 23);
            txt_ngaymuon.TabIndex = 3;
            // 
            // txt_ngaytra
            // 
            txt_ngaytra.Location = new Point(546, 133);
            txt_ngaytra.Name = "txt_ngaytra";
            txt_ngaytra.Size = new Size(191, 23);
            txt_ngaytra.TabIndex = 4;
            // 
            // txt_ngaytrathucte
            // 
            txt_ngaytrathucte.Location = new Point(546, 187);
            txt_ngaytrathucte.Name = "txt_ngaytrathucte";
            txt_ngaytrathucte.Size = new Size(191, 23);
            txt_ngaytrathucte.TabIndex = 5;
            // 
            // txt_maphieu
            // 
            txt_maphieu.Location = new Point(546, 242);
            txt_maphieu.Name = "txt_maphieu";
            txt_maphieu.Size = new Size(191, 23);
            txt_maphieu.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 136);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "ID Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 187);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "ID Thẻ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 250);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 9;
            label4.Text = "Ngày Mượn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 136);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "Ngày Trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 195);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 11;
            label6.Text = "Ngày Trả Thực Tế";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 250);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 12;
            label7.Text = "Mã Phiếu";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(313, 308);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(202, 23);
            cb_status.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 311);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 14;
            label8.Text = "Status";
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(180, 376);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(173, 62);
            btn_xacnhan.TabIndex = 15;
            btn_xacnhan.Text = "Xác Nhận";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(470, 376);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(173, 62);
            btn_huy.TabIndex = 16;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // SuaPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 499);
            Controls.Add(btn_huy);
            Controls.Add(btn_xacnhan);
            Controls.Add(label8);
            Controls.Add(cb_status);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_maphieu);
            Controls.Add(txt_ngaytrathucte);
            Controls.Add(txt_ngaytra);
            Controls.Add(txt_ngaymuon);
            Controls.Add(txt_idthe);
            Controls.Add(txt_idtaikhoan);
            Controls.Add(label1);
            Name = "SuaPhieuMuon";
            Text = "SuaPhieuMuon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_idtaikhoan;
        private TextBox txt_idthe;
        private TextBox txt_ngaymuon;
        private TextBox txt_ngaytra;
        private TextBox txt_ngaytrathucte;
        private TextBox txt_maphieu;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cb_status;
        private Label label8;
        private Button btn_xacnhan;
        private Button btn_huy;
    }
}