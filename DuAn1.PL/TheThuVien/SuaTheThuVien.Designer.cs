namespace DuAnOne.PL.TheThuVien
{
    partial class SuaTheThuVien
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
            cb_status = new ComboBox();
            txt_mathe = new TextBox();
            txt_ngayhethan = new TextBox();
            txt_ngaycap = new TextBox();
            txt_idchuthe = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(561, 263);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(224, 65);
            btn_huy.TabIndex = 25;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(561, 158);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(224, 65);
            btn_xacnhan.TabIndex = 24;
            btn_xacnhan.Text = "Xác Nhận Sửa";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(153, 367);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(175, 23);
            cb_status.TabIndex = 23;
            // 
            // txt_mathe
            // 
            txt_mathe.Location = new Point(153, 310);
            txt_mathe.Name = "txt_mathe";
            txt_mathe.Size = new Size(175, 23);
            txt_mathe.TabIndex = 22;
            // 
            // txt_ngayhethan
            // 
            txt_ngayhethan.Location = new Point(153, 256);
            txt_ngayhethan.Name = "txt_ngayhethan";
            txt_ngayhethan.Size = new Size(175, 23);
            txt_ngayhethan.TabIndex = 21;
            // 
            // txt_ngaycap
            // 
            txt_ngaycap.Location = new Point(153, 200);
            txt_ngaycap.Name = "txt_ngaycap";
            txt_ngaycap.Size = new Size(175, 23);
            txt_ngaycap.TabIndex = 20;
            // 
            // txt_idchuthe
            // 
            txt_idchuthe.Location = new Point(153, 144);
            txt_idchuthe.Name = "txt_idchuthe";
            txt_idchuthe.Size = new Size(175, 23);
            txt_idchuthe.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 147);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 18;
            label6.Text = "ID Chủ Thẻ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 203);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 17;
            label5.Text = "Ngày Cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 259);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 16;
            label4.Text = "Ngày Hết Hạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 313);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 15;
            label3.Text = "Mã Thẻ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 370);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 78);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 13;
            label1.Text = "Sửa Chủ Thẻ";
            // 
            // SuaTheThuVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 507);
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
            Name = "SuaTheThuVien";
            Text = "SuaTheThuVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_huy;
        private Button btn_xacnhan;
        private ComboBox cb_status;
        private TextBox txt_mathe;
        private TextBox txt_ngayhethan;
        private TextBox txt_ngaycap;
        private TextBox txt_idchuthe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}