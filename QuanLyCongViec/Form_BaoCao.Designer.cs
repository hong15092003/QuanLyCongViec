namespace QuanLyCongViec
{
    partial class Form_BaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_CongViec = new System.Windows.Forms.ComboBox();
            this.ID_BaoCao = new System.Windows.Forms.ComboBox();
            this.NgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.NoiDung = new System.Windows.Forms.TextBox();
            this.BangBaoCao = new System.Windows.Forms.DataGridView();
            this.TenCongViec = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BangBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cong Viec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Bao Cao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NgayBaoCao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Noi Dung Bao Cao";
            // 
            // ID_CongViec
            // 
            this.ID_CongViec.FormattingEnabled = true;
            this.ID_CongViec.Location = new System.Drawing.Point(66, 55);
            this.ID_CongViec.Name = "ID_CongViec";
            this.ID_CongViec.Size = new System.Drawing.Size(85, 32);
            this.ID_CongViec.TabIndex = 4;
            // 
            // ID_BaoCao
            // 
            this.ID_BaoCao.FormattingEnabled = true;
            this.ID_BaoCao.Location = new System.Drawing.Point(525, 54);
            this.ID_BaoCao.Name = "ID_BaoCao";
            this.ID_BaoCao.Size = new System.Drawing.Size(82, 32);
            this.ID_BaoCao.TabIndex = 5;
            // 
            // NgayBaoCao
            // 
            this.NgayBaoCao.CustomFormat = "dd/MM/yyyy";
            this.NgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayBaoCao.Location = new System.Drawing.Point(747, 54);
            this.NgayBaoCao.Name = "NgayBaoCao";
            this.NgayBaoCao.Size = new System.Drawing.Size(200, 29);
            this.NgayBaoCao.TabIndex = 6;
            // 
            // NoiDung
            // 
            this.NoiDung.Location = new System.Drawing.Point(67, 130);
            this.NoiDung.Multiline = true;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(1099, 145);
            this.NoiDung.TabIndex = 7;
            // 
            // BangBaoCao
            // 
            this.BangBaoCao.AllowUserToOrderColumns = true;
            this.BangBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangBaoCao.Location = new System.Drawing.Point(67, 292);
            this.BangBaoCao.Name = "BangBaoCao";
            this.BangBaoCao.RowHeadersWidth = 72;
            this.BangBaoCao.RowTemplate.Height = 31;
            this.BangBaoCao.Size = new System.Drawing.Size(1099, 315);
            this.BangBaoCao.TabIndex = 8;
            // 
            // TenCongViec
            // 
            this.TenCongViec.Location = new System.Drawing.Point(157, 54);
            this.TenCongViec.Multiline = true;
            this.TenCongViec.Name = "TenCongViec";
            this.TenCongViec.ReadOnly = true;
            this.TenCongViec.Size = new System.Drawing.Size(238, 33);
            this.TenCongViec.TabIndex = 9;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(66, 644);
            this.btn_them.Name = "btn_them";
            this.btn_them.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_them.Size = new System.Drawing.Size(138, 50);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(270, 644);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(138, 50);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(474, 644);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(138, 50);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(678, 644);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 50);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 733);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.TenCongViec);
            this.Controls.Add(this.BangBaoCao);
            this.Controls.Add(this.NoiDung);
            this.Controls.Add(this.NgayBaoCao);
            this.Controls.Add(this.ID_BaoCao);
            this.Controls.Add(this.ID_CongViec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_BaoCao";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ID_CongViec;
        private System.Windows.Forms.ComboBox ID_BaoCao;
        private System.Windows.Forms.DateTimePicker NgayBaoCao;
        private System.Windows.Forms.TextBox NoiDung;
        private System.Windows.Forms.DataGridView BangBaoCao;
        private System.Windows.Forms.TextBox TenCongViec;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
    }
}