namespace ThucTap5_QuanLyKhoHang
{
    partial class FormNhapHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoHangDataSet = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.nhacungcapTableAdapter = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSetTableAdapters.nhacungcapTableAdapter();
            this.textBox1Ma = new System.Windows.Forms.TextBox();
            this.maskedTextBox1Thoigian = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2Ghichu = new System.Windows.Forms.TextBox();
            this.textBox1Tien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1Thukhoma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1Tenphieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.donvitinh,
            this.soluong,
            this.xuatxu,
            this.dongia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(743, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ClientSizeChanged += new System.EventHandler(this.dataGridView1_ClientSizeChanged);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.Name = "donvitinh";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // xuatxu
            // 
            this.xuatxu.DataPropertyName = "xuatxu";
            this.xuatxu.HeaderText = "Xuất xứ";
            this.xuatxu.Name = "xuatxu";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nhận hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nhacungcapBindingSource;
            this.comboBox1.DisplayMember = "ten";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ma";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataMember = "nhacungcap";
            this.nhacungcapBindingSource.DataSource = this.quanLyKhoHangDataSet;
            // 
            // quanLyKhoHangDataSet
            // 
            this.quanLyKhoHangDataSet.DataSetName = "QuanLyKhoHangDataSet";
            this.quanLyKhoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhà cung cấp";
            // 
            // nhacungcapTableAdapter
            // 
            this.nhacungcapTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1Ma
            // 
            this.textBox1Ma.Location = new System.Drawing.Point(280, 392);
            this.textBox1Ma.Name = "textBox1Ma";
            this.textBox1Ma.ReadOnly = true;
            this.textBox1Ma.Size = new System.Drawing.Size(100, 20);
            this.textBox1Ma.TabIndex = 4;
            // 
            // maskedTextBox1Thoigian
            // 
            this.maskedTextBox1Thoigian.Location = new System.Drawing.Point(108, 485);
            this.maskedTextBox1Thoigian.Name = "maskedTextBox1Thoigian";
            this.maskedTextBox1Thoigian.ReadOnly = true;
            this.maskedTextBox1Thoigian.Size = new System.Drawing.Size(141, 20);
            this.maskedTextBox1Thoigian.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghi chú";
            // 
            // textBox2Ghichu
            // 
            this.textBox2Ghichu.Location = new System.Drawing.Point(108, 441);
            this.textBox2Ghichu.Name = "textBox2Ghichu";
            this.textBox2Ghichu.Size = new System.Drawing.Size(141, 20);
            this.textBox2Ghichu.TabIndex = 8;
            // 
            // textBox1Tien
            // 
            this.textBox1Tien.Location = new System.Drawing.Point(108, 571);
            this.textBox1Tien.Name = "textBox1Tien";
            this.textBox1Tien.ReadOnly = true;
            this.textBox1Tien.Size = new System.Drawing.Size(141, 20);
            this.textBox1Tien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thủ kho mã";
            // 
            // textBox1Thukhoma
            // 
            this.textBox1Thukhoma.Location = new System.Drawing.Point(108, 532);
            this.textBox1Thukhoma.Name = "textBox1Thukhoma";
            this.textBox1Thukhoma.ReadOnly = true;
            this.textBox1Thukhoma.Size = new System.Drawing.Size(141, 20);
            this.textBox1Thukhoma.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ".000 VND";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Tính tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1Tenphieu
            // 
            this.textBox1Tenphieu.Location = new System.Drawing.Point(108, 346);
            this.textBox1Tenphieu.Name = "textBox1Tenphieu";
            this.textBox1Tenphieu.Size = new System.Drawing.Size(141, 20);
            this.textBox1Tenphieu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên phiếu nhập";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 654);
            this.Controls.Add(this.textBox1Tenphieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1Thukhoma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1Tien);
            this.Controls.Add(this.textBox2Ghichu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1Thoigian);
            this.Controls.Add(this.textBox1Ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private QuanLyKhoHangDataSet quanLyKhoHangDataSet;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private QuanLyKhoHangDataSetTableAdapters.nhacungcapTableAdapter nhacungcapTableAdapter;
        private System.Windows.Forms.TextBox textBox1Ma;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1Thoigian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2Ghichu;
        private System.Windows.Forms.TextBox textBox1Tien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1Thukhoma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1Tenphieu;
        private System.Windows.Forms.Label label4;
    }
}