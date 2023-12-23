using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class Form_btnQuanLyCongViec : Form
    {
        XuLiDuLieu kn = new XuLiDuLieu();

        SqlConnection connection;
        SqlCommand command;
        string str = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Form_btnQuanLyCongViec()
        {
            InitializeComponent();
            HandleCellContentClickEvent();

        }

        public void LoadDuLieu()
        {
            string sql = "select ID_CongViec,TenCongViec,NhomCongViec,NgayBatDau,NgayKetThuc,TrangThai from CongViec";
            dgv_btn_QLCV.DataSource = kn.taoBang(sql);
        }

        private void Form_btnQuanLyCongViec_Load(object sender, EventArgs e)
        {
            kn.moKetNoi();
            LoadDuLieu();
        }
        private void dgv_btn_QLCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv_btn_QLCV.DataSource;
            chiso = dgv_btn_QLCV.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];

            txtID_CongViec.Text = hang["ID_CongViec"].ToString();
            txtTenCongViec.Text = hang["TenCongViec"].ToString();
            txtNhomCongViec.Text = hang["NhomCongViec"].ToString();
            dtpNgayBatDau.Value = Convert.ToDateTime(hang["NgayBatDau"].ToString());
            dtpNgayKetThuc.Value = Convert.ToDateTime(hang["NgayKetThuc"].ToString());
            cmbTrangThai.Text = hang["TrangThai"].ToString();
        }
        private void HandleCellContentClickEvent()
        {
            dgv_btn_QLCV.CellContentClick += dgv_btn_QLCV_CellContentClick;
             ID_NhanVien_SelectedIndexChanged();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kn.themCV(txtTenCongViec.Text, txtNhomCongViec.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, cmbTrangThai.Text, ID_NhanVien.Text);
            LoadDuLieu();
            kn.ClearAllTextBoxes(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = "select * from CongViec where ID_CongViec = '" + txtID_CongViec.Text + "'";
            DataTable dt = new DataTable(s);
            dt = kn.taoBang(s);
            kn.sua(int.Parse(txtID_CongViec.Text), txtTenCongViec.Text, txtNhomCongViec.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, cmbTrangThai.Text);
            LoadDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string s = "DELETE FROM CongViec WHERE ID_CongViec = '" + txtID_CongViec.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.taoBang(s);

            kn.xoa(int.Parse(txtID_CongViec.Text), txtTenCongViec.Text, txtNhomCongViec.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, cmbTrangThai.Text);

            txtID_CongViec.ResetText();
            txtTenCongViec.ResetText();
            txtNhomCongViec.ResetText();
            cmbTrangThai.ResetText();
            dtpNgayKetThuc.ResetText();
            dtpNgayKetThuc.ResetText();

            LoadDuLieu();
            // kn.dongKetNoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ID_NhanVien_SelectedIndexChanged()
        {
            string cmd = "Select ID_NhanVien from NhanVien";
            kn.AddListToComboBox(ID_NhanVien,cmd);
        }
    }
}
