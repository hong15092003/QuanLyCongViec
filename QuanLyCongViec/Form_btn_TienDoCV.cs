using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class Form_btn_TienDoCV : Form
    {
        XuLiDuLieu kn = new XuLiDuLieu();
        public Form_btn_TienDoCV()
        {
            InitializeComponent();
            cmbID_CongViec.SelectedIndexChanged += ID_CongViec_SelectedIndexChanged;
        }


        private void Form_btn_TienDoCV_Load(object sender, EventArgs e)
        {
            string cmd_cv = "SELECT ID_CongViec FROM CongViec";
            kn.AddListToComboBox(cmbID_CongViec, cmd_cv);
        }

        private void ID_CongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = cmbID_CongViec.SelectedItem.ToString();
            string sql = $"Select * from TienDo where CongViec_ID = {selectedID} ";
            
            dgv_btn_TienDoCV.DataSource = kn.taoBang(sql);
        }


        void loaddulieu()
        {
            string sql = "select * from TienDo";
            dgv_btn_TienDoCV.DataSource = kn.taoBang(sql);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            kn.themTienDo(int.Parse(txtPhanTramHoanThanh.Text),dtpNgayCapNhat.Value,cmbID_CongViec.Text);
            loaddulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            kn.thoat(this);
        }
    }
}
