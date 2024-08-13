namespace DuAnOne.PL
{
    partial class Login
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
            Dangnhaplb = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // Dangnhaplb
            // 
            Dangnhaplb.AutoSize = true;
            Dangnhaplb.Location = new Point(178, 43);
            Dangnhaplb.Name = "Dangnhaplb";
            Dangnhaplb.Size = new Size(67, 15);
            Dangnhaplb.TabIndex = 0;
            Dangnhaplb.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(131, 76);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(170, 23);
            txt_username.TabIndex = 3;
            txt_username.Text = "Nhập Username";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(131, 133);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(170, 23);
            txt_password.TabIndex = 4;
            txt_password.Text = "Nhập Password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(131, 175);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(160, 48);
            btn_login.TabIndex = 5;
            btn_login.Text = "Đăng Nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 257);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Dangnhaplb);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dangnhaplb;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
    }
}