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
    public partial class Form_BaoCao : Form
    {
        XuLiDuLieu kn = new XuLiDuLieu();
        public Form_BaoCao()
        {
            InitializeComponent();
            ID_CongViec.SelectedIndexChanged += ID_CongViec_SelectedIndexChanged;
            ID_BaoCao.SelectedIndexChanged += ID_BaoCao_SelectedIndexChanged;

        }
        private void ID_CongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = ID_CongViec.SelectedItem.ToString();
            Load_ID_BaoCao();
            TenCongViec.Text = kn.GetText("CongViec", "ID_CongViec", "TenCongViec", int.Parse(selectedID));
        }
        private void ID_BaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(ID_BaoCao.SelectedItem.ToString());
            NoiDung.Text = kn.GetText("BaoCao", "ID_BaoCao", "NoiDung", ID);
        }
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            string cmd_cv = "SELECT ID_CongViec FROM CongViec";
            kn.AddListToComboBox(ID_CongViec, cmd_cv);
            Load_BangBaoCao();
        }
        private void Load_BangBaoCao()
        {
            string taobang = "SELECT NgayBaoCao,ID_BaoCao,CongViec_ID,NoiDung from BaoCao Order by NgayBaoCao DESC, ID_BaoCao ASC";
            BangBaoCao.DataSource = kn.taoBang(taobang);
            kn.ClearAllTextBoxes(this);
        }
        private void Load_ID_BaoCao()
        {
            string selectedID = ID_CongViec.SelectedItem.ToString();
            string cmd_bv = $"SELECT ID_BaoCao FROM BaoCao WHERE CongViec_ID = {selectedID}";
            kn.AddListToComboBox(ID_BaoCao, cmd_bv);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            int IDCV = int.Parse(ID_CongViec.Text);
            kn.themBC(IDCV, NoiDung.Text, NgayBaoCao.Value);
            Load_BangBaoCao();
            Load_ID_BaoCao();
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            kn.xoa("BaoCao", "ID_BaoCao", ID_BaoCao.SelectedItem.ToString());
            Load_BangBaoCao();
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            kn.thoat(this);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE BaoCao SET NoiDung = '{NoiDung.Text}' WHERE CongViec_ID = {ID_CongViec.Text} AND ID_BaoCao = {ID_BaoCao.Text}";
            kn.sua(sql);
            Load_BangBaoCao();
        }


    }
}
