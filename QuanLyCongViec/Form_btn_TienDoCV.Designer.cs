namespace QuanLyCongViec
{
    partial class Form_btn_TienDoCV
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
            this.cmbID_CongViec = new System.Windows.Forms.ComboBox();
            this.dtpNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.txtPhanTramHoanThanh = new System.Windows.Forms.TextBox();
            this.dgv_btn_TienDoCV = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btn_TienDoCV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Công Việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phần trăm hoàn thành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày cập nhật";
            // 
            // cmbID_CongViec
            // 
            this.cmbID_CongViec.FormattingEnabled = true;
            this.cmbID_CongViec.Location = new System.Drawing.Point(271, 54);
            this.cmbID_CongViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbID_CongViec.Name = "cmbID_CongViec";
            this.cmbID_CongViec.Size = new System.Drawing.Size(165, 32);
            this.cmbID_CongViec.TabIndex = 2;
            // 
            // dtpNgayCapNhat
            // 
            this.dtpNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCapNhat.Location = new System.Drawing.Point(271, 130);
            this.dtpNgayCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayCapNhat.Name = "dtpNgayCapNhat";
            this.dtpNgayCapNhat.Size = new System.Drawing.Size(165, 29);
            this.dtpNgayCapNhat.TabIndex = 3;
            // 
            // txtPhanTramHoanThanh
            // 
            this.txtPhanTramHoanThanh.Location = new System.Drawing.Point(271, 213);
            this.txtPhanTramHoanThanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhanTramHoanThanh.Name = "txtPhanTramHoanThanh";
            this.txtPhanTramHoanThanh.Size = new System.Drawing.Size(165, 29);
            this.txtPhanTramHoanThanh.TabIndex = 4;
            // 
            // dgv_btn_TienDoCV
            // 
            this.dgv_btn_TienDoCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_btn_TienDoCV.Location = new System.Drawing.Point(484, 18);
            this.dgv_btn_TienDoCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_btn_TienDoCV.Name = "dgv_btn_TienDoCV";
            this.dgv_btn_TienDoCV.RowHeadersWidth = 51;
            this.dgv_btn_TienDoCV.RowTemplate.Height = 24;
            this.dgv_btn_TienDoCV.Size = new System.Drawing.Size(441, 459);
            this.dgv_btn_TienDoCV.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(48, 308);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 50);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(286, 308);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 50);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form_btn_TienDoCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgv_btn_TienDoCV);
            this.Controls.Add(this.txtPhanTramHoanThanh);
            this.Controls.Add(this.dtpNgayCapNhat);
            this.Controls.Add(this.cmbID_CongViec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_btn_TienDoCV";
            this.Text = "Form_btn_TienDoCV";
            this.Load += new System.EventHandler(this.Form_btn_TienDoCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btn_TienDoCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbID_CongViec;
        private System.Windows.Forms.DateTimePicker dtpNgayCapNhat;
        private System.Windows.Forms.TextBox txtPhanTramHoanThanh;
        private System.Windows.Forms.DataGridView dgv_btn_TienDoCV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}