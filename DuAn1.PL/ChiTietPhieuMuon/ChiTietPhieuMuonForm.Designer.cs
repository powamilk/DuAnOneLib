﻿namespace DuAnOne.PL.ChiTietPhieuMuon
{
    partial class ChiTietPhieuMuonForm
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
            components = new System.ComponentModel.Container();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            dgv_chitietphieumuon = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_mathethuvien = new TextBox();
            txt_maphieumuon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_hovatenchuthe = new TextBox();
            txt_ngaymuon = new TextBox();
            txt_ngaytra = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_ngaytrathucte = new TextBox();
            label8 = new Label();
            txt_trangthai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_chitietphieumuon).BeginInit();
            SuspendLayout();
            // 
            // btn_them
            // 
            btn_them.Location = new Point(1112, 234);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(74, 27);
            btn_them.TabIndex = 57;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(1192, 233);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(69, 28);
            btn_sua.TabIndex = 55;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(1267, 233);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(79, 27);
            btn_xoa.TabIndex = 54;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // dgv_chitietphieumuon
            // 
            dgv_chitietphieumuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_chitietphieumuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chitietphieumuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chitietphieumuon.Location = new Point(8, 282);
            dgv_chitietphieumuon.Name = "dgv_chitietphieumuon";
            dgv_chitietphieumuon.RowHeadersWidth = 51;
            dgv_chitietphieumuon.RowTemplate.Height = 25;
            dgv_chitietphieumuon.Size = new Size(1335, 357);
            dgv_chitietphieumuon.TabIndex = 56;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_mathethuvien
            // 
            txt_mathethuvien.Location = new Point(104, 146);
            txt_mathethuvien.Name = "txt_mathethuvien";
            txt_mathethuvien.Size = new Size(246, 23);
            txt_mathethuvien.TabIndex = 63;
            txt_mathethuvien.Text = "Mã Thẻ Thư Viện";
            txt_mathethuvien.TextChanged += textBox2_TextChanged;
            // 
            // txt_maphieumuon
            // 
            txt_maphieumuon.Location = new Point(104, 99);
            txt_maphieumuon.Name = "txt_maphieumuon";
            txt_maphieumuon.Size = new Size(246, 23);
            txt_maphieumuon.TabIndex = 64;
            txt_maphieumuon.Text = "Mã Phiếu Mượn";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 149);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 65;
            label1.Text = "Thẻ Thư Viện";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(8, 102);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 66;
            label2.Text = "Phiếu Mượn";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1232, 9);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 67;
            label3.Text = "Chi Tiết Phiếu Mượn";
            // 
            // txt_hovatenchuthe
            // 
            txt_hovatenchuthe.Location = new Point(575, 146);
            txt_hovatenchuthe.Name = "txt_hovatenchuthe";
            txt_hovatenchuthe.Size = new Size(246, 23);
            txt_hovatenchuthe.TabIndex = 68;
            txt_hovatenchuthe.Text = "Họ và Tên Chủ Thẻ";
            // 
            // txt_ngaymuon
            // 
            txt_ngaymuon.Location = new Point(82, 238);
            txt_ngaymuon.Name = "txt_ngaymuon";
            txt_ngaymuon.Size = new Size(233, 23);
            txt_ngaymuon.TabIndex = 69;
            // 
            // txt_ngaytra
            // 
            txt_ngaytra.Location = new Point(400, 238);
            txt_ngaytra.Name = "txt_ngaytra";
            txt_ngaytra.Size = new Size(233, 23);
            txt_ngaytra.TabIndex = 71;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(454, 149);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 72;
            label4.Text = "Họ Tên Người Mượn";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(6, 241);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 73;
            label5.Text = "Ngày Mượn";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(341, 241);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 74;
            label6.Text = "Ngày Trả";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(649, 244);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 76;
            label7.Text = "Ngày Trả Thực Tế";
            // 
            // txt_ngaytrathucte
            // 
            txt_ngaytrathucte.Location = new Point(752, 241);
            txt_ngaytrathucte.Name = "txt_ngaytrathucte";
            txt_ngaytrathucte.Size = new Size(233, 23);
            txt_ngaytrathucte.TabIndex = 75;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(508, 102);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 78;
            label8.Text = "Trạng Thái";
            // 
            // txt_trangthai
            // 
            txt_trangthai.Location = new Point(575, 99);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(246, 23);
            txt_trangthai.TabIndex = 77;
            // 
            // ChiTietPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 651);
            Controls.Add(label8);
            Controls.Add(txt_trangthai);
            Controls.Add(label7);
            Controls.Add(txt_ngaytrathucte);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_ngaytra);
            Controls.Add(txt_ngaymuon);
            Controls.Add(txt_hovatenchuthe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_maphieumuon);
            Controls.Add(txt_mathethuvien);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
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
        private DataGridView dgv_chitietphieumuon;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_mathethuvien;
        private TextBox txt_maphieumuon;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_hovatenchuthe;
        private TextBox txt_ngaymuon;
        private TextBox txt_ngaytra;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_ngaytrathucte;
        private Label label8;
        private TextBox txt_trangthai;
    }
}