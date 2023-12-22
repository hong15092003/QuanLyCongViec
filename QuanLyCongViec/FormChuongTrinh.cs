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
    public partial class FormChuongTrinh : Form
    {
        bool isThoat = true;

        XuLiDuLieu kn = new XuLiDuLieu();
        public FormChuongTrinh()
        {
            InitializeComponent();
        }
        public void loadDuLieu()
        {
            string sql = "select ID_CongViec,TenCongViec,NhomCongViec,NgayBatDau,NgayKetThuc,TrangThai from CongViec";
            dgv_FormMain.DataSource = kn.taoBang(sql);
        }
        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            kn.moKetNoi();
            loadDuLieu();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDuLieu();
            if (isThoat)
            {
                Application.Exit();

            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Form_btnQuanLyNhanVien f = new Form_btnQuanLyNhanVien();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDuLieu();
        }

        private void btnQuanLyCV_Click(object sender, EventArgs e)
        {
            Form_btnQuanLyCongViec f = new Form_btnQuanLyCongViec();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void btnTienDoCV_Click(object sender, EventArgs e)
        {
            Form_btn_TienDoCV f = new Form_btn_TienDoCV();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void btnThongKeCV_Click(object sender, EventArgs e)
        {
            string sql = "SELECT\r\n    COUNT(CASE WHEN TrangThai = 'completed' THEN 1 END) AS SoLuongDaHoanThanh,\r\n    COUNT(CASE WHEN TrangThai = 'underway' THEN 1 END) AS SoLuongDangThucHien,\r\n    COUNT(CASE WHEN TrangThai = 'unfinished' THEN 1 END) AS SoLuongChuaHoanThanh\r\nFROM\r\n    CongViec;\r\n";
            dgv_FormMain.DataSource = kn.taoBang(sql);
        }

        private void btnBaoCaoCV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BaoCao f = new Form_BaoCao();
            f.Show();
        }
    }
}
