namespace DuAnOne.PL.ChiTietPhieuMuon
{
    partial class SuaChiTietPhieuMuon
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
            label4 = new Label();
            cb_status = new ComboBox();
            txt_soluong = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_sach = new ComboBox();
            txt_ghichu = new TextBox();
            SuspendLayout();
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(167, 191);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(163, 55);
            btn_huy.TabIndex = 19;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(368, 191);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(163, 55);
            btn_xacnhan.TabIndex = 18;
            btn_xacnhan.Text = "Xác Nhận Sửa";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 147);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Status";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(419, 144);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(211, 23);
            cb_status.TabIndex = 16;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(98, 144);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(206, 23);
            txt_soluong.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 105);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 13;
            label3.Text = "Ghi Chú";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 143);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Số Lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 105);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 11;
            label1.Text = "Sách";
            // 
            // cb_sach
            // 
            cb_sach.FormattingEnabled = true;
            cb_sach.Location = new Point(98, 102);
            cb_sach.Name = "cb_sach";
            cb_sach.Size = new Size(206, 23);
            cb_sach.TabIndex = 10;
            // 
            // txt_ghichu
            // 
            txt_ghichu.Location = new Point(419, 102);
            txt_ghichu.Name = "txt_ghichu";
            txt_ghichu.Size = new Size(211, 23);
            txt_ghichu.TabIndex = 15;
            // 
            // SuaChiTietPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 290);
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
            Name = "SuaChiTietPhieuMuon";
            Text = "SuaChiTietPhieuMuon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_huy;
        private Button btn_xacnhan;
        private Label label4;
        private ComboBox cb_status;
        private TextBox txt_soluong;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_sach;
        private TextBox txt_ghichu;
    }
}