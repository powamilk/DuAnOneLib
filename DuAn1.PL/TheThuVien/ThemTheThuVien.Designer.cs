namespace DuAnOne.PL.TheThuVien
{
    partial class ThemTheThuVien
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_idchuthe = new TextBox();
            txt_ngaycap = new TextBox();
            txt_ngayhethan = new TextBox();
            txt_mathe = new TextBox();
            cb_status = new ComboBox();
            btn_xacnhan = new Button();
            btn_huy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Thêm Chủ Thẻ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 343);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 286);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã Thẻ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 232);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày Hết Hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 176);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày Cấp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 120);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 5;
            label6.Text = "ID Chủ Thẻ";
            // 
            // txt_idchuthe
            // 
            txt_idchuthe.Location = new Point(138, 117);
            txt_idchuthe.Name = "txt_idchuthe";
            txt_idchuthe.Size = new Size(175, 23);
            txt_idchuthe.TabIndex = 6;
            // 
            // txt_ngaycap
            // 
            txt_ngaycap.Location = new Point(138, 173);
            txt_ngaycap.Name = "txt_ngaycap";
            txt_ngaycap.Size = new Size(175, 23);
            txt_ngaycap.TabIndex = 7;
            // 
            // txt_ngayhethan
            // 
            txt_ngayhethan.Location = new Point(138, 229);
            txt_ngayhethan.Name = "txt_ngayhethan";
            txt_ngayhethan.Size = new Size(175, 23);
            txt_ngayhethan.TabIndex = 8;
            // 
            // txt_mathe
            // 
            txt_mathe.Location = new Point(138, 283);
            txt_mathe.Name = "txt_mathe";
            txt_mathe.Size = new Size(175, 23);
            txt_mathe.TabIndex = 9;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(138, 340);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(175, 23);
            cb_status.TabIndex = 10;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(546, 131);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(224, 65);
            btn_xacnhan.TabIndex = 11;
            btn_xacnhan.Text = "Xác Nhận Thêm";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(546, 236);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(224, 65);
            btn_huy.TabIndex = 12;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // ThemTheThuVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 513);
            Controls.Add(btn_huy);
            Controls.Add(btn_xacnhan);
            Controls.Add(cb_status);
            Controls.Add(txt_mathe);
            Controls.Add(txt_ngayhethan);
            Controls.Add(txt_ngaycap);
            Controls.Add(txt_idchuthe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemTheThuVien";
            Text = "ThemTheThuVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_idchuthe;
        private TextBox txt_ngaycap;
        private TextBox txt_ngayhethan;
        private TextBox txt_mathe;
        private ComboBox cb_status;
        private Button btn_xacnhan;
        private Button btn_huy;
    }
}