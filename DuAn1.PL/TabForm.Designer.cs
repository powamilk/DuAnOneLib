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
            textBox1 = new TextBox();
            label2 = new Label();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            tab_chuthe = new TabPage();
            tab_thethuvien = new TabPage();
            tab_sach = new TabPage();
            tab_phieumuon = new TabPage();
            tabDuAn.SuspendLayout();
            tab_taikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabDuAn.Size = new Size(800, 450);
            tabDuAn.TabIndex = 0;
            // 
            // tab_taikhoan
            // 
            tab_taikhoan.Controls.Add(textBox1);
            tab_taikhoan.Controls.Add(label2);
            tab_taikhoan.Controls.Add(btn_them);
            tab_taikhoan.Controls.Add(btn_sua);
            tab_taikhoan.Controls.Add(btn_xoa);
            tab_taikhoan.Controls.Add(textBox2);
            tab_taikhoan.Controls.Add(dataGridView1);
            tab_taikhoan.Location = new Point(4, 24);
            tab_taikhoan.Name = "tab_taikhoan";
            tab_taikhoan.Padding = new Padding(3);
            tab_taikhoan.Size = new Size(792, 422);
            tab_taikhoan.TabIndex = 0;
            tab_taikhoan.Text = "Tài Khoản";
            tab_taikhoan.UseVisualStyleBackColor = true;
            tab_taikhoan.Click += tabPage1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 39;
            label2.Text = "Bạn Đang Chọn";
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_them.Location = new Point(679, 69);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(102, 39);
            btn_them.TabIndex = 38;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(348, 69);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(102, 39);
            btn_sua.TabIndex = 37;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(456, 69);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(102, 39);
            btn_xoa.TabIndex = 36;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(12, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 23);
            textBox2.TabIndex = 35;
            textBox2.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(762, 272);
            dataGridView1.TabIndex = 34;
            // 
            // tab_chuthe
            // 
            tab_chuthe.Location = new Point(4, 24);
            tab_chuthe.Name = "tab_chuthe";
            tab_chuthe.Padding = new Padding(3);
            tab_chuthe.Size = new Size(792, 422);
            tab_chuthe.TabIndex = 1;
            tab_chuthe.Text = "Chủ Thẻ";
            tab_chuthe.UseVisualStyleBackColor = true;
            // 
            // tab_thethuvien
            // 
            tab_thethuvien.Location = new Point(4, 24);
            tab_thethuvien.Name = "tab_thethuvien";
            tab_thethuvien.Padding = new Padding(3);
            tab_thethuvien.Size = new Size(792, 422);
            tab_thethuvien.TabIndex = 2;
            tab_thethuvien.Text = "Thẻ Thư Viện";
            tab_thethuvien.UseVisualStyleBackColor = true;
            // 
            // tab_sach
            // 
            tab_sach.Location = new Point(4, 24);
            tab_sach.Name = "tab_sach";
            tab_sach.Padding = new Padding(3);
            tab_sach.Size = new Size(792, 422);
            tab_sach.TabIndex = 3;
            tab_sach.Text = "Sách";
            tab_sach.UseVisualStyleBackColor = true;
            // 
            // tab_phieumuon
            // 
            tab_phieumuon.Location = new Point(4, 24);
            tab_phieumuon.Name = "tab_phieumuon";
            tab_phieumuon.Padding = new Padding(3);
            tab_phieumuon.Size = new Size(792, 422);
            tab_phieumuon.TabIndex = 4;
            tab_phieumuon.Text = "Phiếu Mượn";
            tab_phieumuon.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tabDuAn);
            Name = "TabForm";
            Text = "TabForm";
            tabDuAn.ResumeLayout(false);
            tab_taikhoan.ResumeLayout(false);
            tab_taikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDuAn;
        private TabPage tab_taikhoan;
        private TabPage tab_chuthe;
        private TabPage tab_thethuvien;
        private TabPage tab_sach;
        private TabPage tab_phieumuon;
        private TextBox textBox1;
        private Label label2;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}