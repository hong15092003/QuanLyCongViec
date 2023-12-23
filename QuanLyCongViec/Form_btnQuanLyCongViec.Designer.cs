namespace QuanLyCongViec
{
    partial class Form_btnQuanLyCongViec
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_NhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtNhomCongViec = new System.Windows.Forms.ComboBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.txtID_CongViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_btn_QLCV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btn_QLCV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ID_NhanVien);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.txtNhomCongViec);
            this.panel1.Controls.Add(this.cmbTrangThai);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTenCongViec);
            this.panel1.Controls.Add(this.txtID_CongViec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 639);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhân viên";
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.FormattingEnabled = true;
            this.ID_NhanVien.Location = new System.Drawing.Point(169, 462);
            this.ID_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.Size = new System.Drawing.Size(239, 32);
            this.ID_NhanVien.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(172, 332);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(236, 29);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(172, 260);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(236, 29);
            this.dtpNgayBatDau.TabIndex = 4;
            // 
            // txtNhomCongViec
            // 
            this.txtNhomCongViec.FormattingEnabled = true;
            this.txtNhomCongViec.Items.AddRange(new object[] {
            "Nhóm công việc 1",
            "Nhóm công việc 2",
            "Nhóm công việc 3",
            "Nhóm công việc 4"});
            this.txtNhomCongViec.Location = new System.Drawing.Point(172, 196);
            this.txtNhomCongViec.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhomCongViec.Name = "txtNhomCongViec";
            this.txtNhomCongViec.Size = new System.Drawing.Size(236, 32);
            this.txtNhomCongViec.TabIndex = 3;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "completed",
            "underway",
            "unfinished"});
            this.cmbTrangThai.Location = new System.Drawing.Point(169, 403);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(239, 32);
            this.cmbTrangThai.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(297, 584);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(297, 533);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(31, 584);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 533);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(169, 138);
            this.txtTenCongViec.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(239, 29);
            this.txtTenCongViec.TabIndex = 1;
            // 
            // txtID_CongViec
            // 
            this.txtID_CongViec.Location = new System.Drawing.Point(169, 70);
            this.txtID_CongViec.Margin = new System.Windows.Forms.Padding(4);
            this.txtID_CongViec.Name = "txtID_CongViec";
            this.txtID_CongViec.Size = new System.Drawing.Size(239, 29);
            this.txtID_CongViec.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên công việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Công việc";
            // 
            // dgv_btn_QLCV
            // 
            this.dgv_btn_QLCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_btn_QLCV.Location = new System.Drawing.Point(455, 18);
            this.dgv_btn_QLCV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_btn_QLCV.Name = "dgv_btn_QLCV";
            this.dgv_btn_QLCV.RowHeadersWidth = 51;
            this.dgv_btn_QLCV.RowTemplate.Height = 24;
            this.dgv_btn_QLCV.Size = new System.Drawing.Size(887, 639);
            this.dgv_btn_QLCV.TabIndex = 1;
            // 
            // Form_btnQuanLyCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 675);
            this.Controls.Add(this.dgv_btn_QLCV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_btnQuanLyCongViec";
            this.Text = "Form_btnQuanLyCongViec";
            this.Load += new System.EventHandler(this.Form_btnQuanLyCongViec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btn_QLCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.ComboBox txtNhomCongViec;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.TextBox txtID_CongViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_btn_QLCV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ID_NhanVien;
    }
}