﻿namespace DuAnOne.PL.PhieuMuon
{
    partial class ThemPhieuMuon
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
            btn_xacnhan = new Button();
            label8 = new Label();
            cb_status = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_maphieu = new TextBox();
            txt_ngaytrathucte = new TextBox();
            txt_ngaytra = new TextBox();
            txt_ngaymuon = new TextBox();
            txt_idthe = new TextBox();
            txt_idtaikhoan = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(474, 351);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(173, 62);
            btn_huy.TabIndex = 33;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(184, 351);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(173, 62);
            btn_xacnhan.TabIndex = 32;
            btn_xacnhan.Text = "Xác Nhận";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 286);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 31;
            label8.Text = "Status";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(317, 283);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(202, 23);
            cb_status.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 225);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "Mã Phiếu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 170);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 28;
            label6.Text = "Ngày Trả Thực Tế";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 111);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 27;
            label5.Text = "Ngày Trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 225);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 26;
            label4.Text = "Ngày Mượn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 162);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 25;
            label3.Text = "ID Thẻ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 24;
            label2.Text = "ID Tài Khoản";
            // 
            // txt_maphieu
            // 
            txt_maphieu.Location = new Point(550, 217);
            txt_maphieu.Name = "txt_maphieu";
            txt_maphieu.Size = new Size(191, 23);
            txt_maphieu.TabIndex = 23;
            // 
            // txt_ngaytrathucte
            // 
            txt_ngaytrathucte.Location = new Point(550, 162);
            txt_ngaytrathucte.Name = "txt_ngaytrathucte";
            txt_ngaytrathucte.Size = new Size(191, 23);
            txt_ngaytrathucte.TabIndex = 22;
            // 
            // txt_ngaytra
            // 
            txt_ngaytra.Location = new Point(550, 108);
            txt_ngaytra.Name = "txt_ngaytra";
            txt_ngaytra.Size = new Size(191, 23);
            txt_ngaytra.TabIndex = 21;
            // 
            // txt_ngaymuon
            // 
            txt_ngaymuon.Location = new Point(118, 217);
            txt_ngaymuon.Name = "txt_ngaymuon";
            txt_ngaymuon.Size = new Size(191, 23);
            txt_ngaymuon.TabIndex = 20;
            // 
            // txt_idthe
            // 
            txt_idthe.Location = new Point(118, 162);
            txt_idthe.Name = "txt_idthe";
            txt_idthe.Size = new Size(191, 23);
            txt_idthe.TabIndex = 19;
            // 
            // txt_idtaikhoan
            // 
            txt_idtaikhoan.Location = new Point(118, 108);
            txt_idtaikhoan.Name = "txt_idtaikhoan";
            txt_idtaikhoan.Size = new Size(191, 23);
            txt_idtaikhoan.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 33);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 17;
            label1.Text = "Thêm Phiếu mượn";
            // 
            // ThemPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "ThemPhieuMuon";
            Text = "ThemPhieuMuon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_huy;
        private Button btn_xacnhan;
        private Label label8;
        private ComboBox cb_status;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_maphieu;
        private TextBox txt_ngaytrathucte;
        private TextBox txt_ngaytra;
        private TextBox txt_ngaymuon;
        private TextBox txt_idthe;
        private TextBox txt_idtaikhoan;
        private Label label1;
    }
}