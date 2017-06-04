namespace ThucTap5_QuanLyKhoHang
{
    partial class hanghoa
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
            this.components = new System.ComponentModel.Container();
            this.loaisachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textMa = new System.Windows.Forms.TextBox();
            this.button4Luu = new System.Windows.Forms.Button();
            this.textDongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textXuatxu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDOnvitinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texttenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3Them = new System.Windows.Forms.Button();
            this.button2Xoa = new System.Windows.Forms.Button();
            this.button1Sua = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtghanghoa = new System.Windows.Forms.DataGridView();
            this.texttimten = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaisachBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // loaisachBindingSource
            // 
            this.loaisachBindingSource.DataMember = "loaisach";
            // 
            // textMa
            // 
            this.textMa.Location = new System.Drawing.Point(371, 272);
            this.textMa.Name = "textMa";
            this.textMa.ReadOnly = true;
            this.textMa.Size = new System.Drawing.Size(165, 20);
            this.textMa.TabIndex = 16;
            // 
            // button4Luu
            // 
            this.button4Luu.Location = new System.Drawing.Point(371, 328);
            this.button4Luu.Name = "button4Luu";
            this.button4Luu.Size = new System.Drawing.Size(75, 66);
            this.button4Luu.TabIndex = 15;
            this.button4Luu.Text = "Lưu";
            this.button4Luu.UseVisualStyleBackColor = true;
            this.button4Luu.Click += new System.EventHandler(this.button4Luu_Click);
            // 
            // textDongia
            // 
            this.textDongia.Location = new System.Drawing.Point(371, 218);
            this.textDongia.Name = "textDongia";
            this.textDongia.ReadOnly = true;
            this.textDongia.Size = new System.Drawing.Size(165, 20);
            this.textDongia.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đơn giá";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textXuatxu);
            this.groupBox2.Controls.Add(this.textMa);
            this.groupBox2.Controls.Add(this.button4Luu);
            this.groupBox2.Controls.Add(this.textDongia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textSoluong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textDOnvitinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.texttenhang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3Them);
            this.groupBox2.Controls.Add(this.button2Xoa);
            this.groupBox2.Controls.Add(this.button1Sua);
            this.groupBox2.Location = new System.Drawing.Point(501, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 518);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textXuatxu
            // 
            this.textXuatxu.Location = new System.Drawing.Point(371, 168);
            this.textXuatxu.Name = "textXuatxu";
            this.textXuatxu.ReadOnly = true;
            this.textXuatxu.Size = new System.Drawing.Size(165, 20);
            this.textXuatxu.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Xuất xứ";
            // 
            // textSoluong
            // 
            this.textSoluong.Location = new System.Drawing.Point(96, 283);
            this.textSoluong.Name = "textSoluong";
            this.textSoluong.ReadOnly = true;
            this.textSoluong.Size = new System.Drawing.Size(153, 20);
            this.textSoluong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
            // 
            // textDOnvitinh
            // 
            this.textDOnvitinh.Location = new System.Drawing.Point(96, 218);
            this.textDOnvitinh.Name = "textDOnvitinh";
            this.textDOnvitinh.ReadOnly = true;
            this.textDOnvitinh.Size = new System.Drawing.Size(153, 20);
            this.textDOnvitinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn vị tính";
            // 
            // texttenhang
            // 
            this.texttenhang.Location = new System.Drawing.Point(96, 164);
            this.texttenhang.Name = "texttenhang";
            this.texttenhang.ReadOnly = true;
            this.texttenhang.Size = new System.Drawing.Size(153, 20);
            this.texttenhang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên ";
            // 
            // button3Them
            // 
            this.button3Them.Location = new System.Drawing.Point(368, 45);
            this.button3Them.Name = "button3Them";
            this.button3Them.Size = new System.Drawing.Size(75, 23);
            this.button3Them.TabIndex = 2;
            this.button3Them.Text = "Thêm";
            this.button3Them.UseVisualStyleBackColor = true;
            this.button3Them.Click += new System.EventHandler(this.button3Them_Click);
            // 
            // button2Xoa
            // 
            this.button2Xoa.Location = new System.Drawing.Point(206, 45);
            this.button2Xoa.Name = "button2Xoa";
            this.button2Xoa.Size = new System.Drawing.Size(75, 23);
            this.button2Xoa.TabIndex = 1;
            this.button2Xoa.Text = "Xóa";
            this.button2Xoa.UseVisualStyleBackColor = true;
            this.button2Xoa.Click += new System.EventHandler(this.button2Xoa_Click_1);
            // 
            // button1Sua
            // 
            this.button1Sua.Location = new System.Drawing.Point(54, 45);
            this.button1Sua.Name = "button1Sua";
            this.button1Sua.Size = new System.Drawing.Size(75, 23);
            this.button1Sua.TabIndex = 0;
            this.button1Sua.Text = "Sửa";
            this.button1Sua.UseVisualStyleBackColor = true;
            this.button1Sua.Click += new System.EventHandler(this.button1Sua_Click_1);
            // 
            // dtghanghoa
            // 
            this.dtghanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtghanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghanghoa.Location = new System.Drawing.Point(12, 108);
            this.dtghanghoa.Name = "dtghanghoa";
            this.dtghanghoa.Size = new System.Drawing.Size(483, 346);
            this.dtghanghoa.TabIndex = 4;
            // 
            // texttimten
            // 
            this.texttimten.Location = new System.Drawing.Point(129, 49);
            this.texttimten.Name = "texttimten";
            this.texttimten.Size = new System.Drawing.Size(229, 20);
            this.texttimten.TabIndex = 5;
            this.texttimten.TextChanged += new System.EventHandler(this.texttimten_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(234, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 66);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 541);
            this.Controls.Add(this.texttimten);
            this.Controls.Add(this.dtghanghoa);
            this.Controls.Add(this.groupBox2);
            this.Name = "hanghoa";
            this.Text = "hanghoa";
            this.Load += new System.EventHandler(this.hanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaisachBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource loaisachBindingSource;
        private System.Windows.Forms.TextBox textMa;
        private System.Windows.Forms.Button button4Luu;
        private System.Windows.Forms.TextBox textDongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDOnvitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3Them;
        private System.Windows.Forms.Button button2Xoa;
        private System.Windows.Forms.Button button1Sua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtghanghoa;
        private System.Windows.Forms.TextBox texttimten;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textXuatxu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}