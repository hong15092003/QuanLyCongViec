using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    internal class XuLiDuLieu
    {
        private readonly string connectionString = @"Data Source=PINKD;Initial Catalog=QuanLyCongViec;Integrated Security=True";
        private SqlConnection cnn;
        public XuLiDuLieu()
        {
            cnn = new SqlConnection(connectionString);
        }
        public void moKetNoi()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void dongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        // Tạo bảng:
        public DataTable taoBang(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // Lây ID Nhan Vien
        public int getID()
        {

            // Replace "YourTableName" with the actual table name and "YourIDColumnName" with the actual ID column name
            string query = "SELECT MAX(ID_NhanVien) FROM NhanVien";

            int newID = GetNextID(connectionString, query);
            return newID;
        }

        // ID tự tăng
        static int GetNextID(string connectionString, string query)
        {
            int nextID = 1; // Default starting ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                }
            }

            return nextID;
        }

        // Load Data:
        public void loadData()
        {
            string sql = "select ID_NhanVien,TenNhanVien,ChucDanh,BoPhan from NhanVien";
            taoBang(sql);
        }


        // Thêm nhân viên:
        public void themNV(string TenNhanVien, string ChucDanh, string BoPhan)
        {
            string sql = "INSERT INTO NhanVien (ID_NhanVien, TenNhanVien, ChucDanh, BoPhan) " +
                         "VALUES (@ID_NhanVien, @TenNhanVien, @ChucDanh, @BoPhan)";

            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@ID_NhanVien", getID());
                scm.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                scm.Parameters.AddWithValue("@ChucDanh", ChucDanh);
                scm.Parameters.AddWithValue("@BoPhan", BoPhan);

                scm.ExecuteNonQuery();
            }
            clearTextBox(TenNhanVien, ChucDanh, BoPhan);
        }


        // Sửa nhân viên:
        public void suaNV(int ID_NhanVien, string TenNhanVien, string ChucDanh, string BoPhan)
        {


            // Sửa dữ liệu trong bảng Nhân viên
            string updateQuery = "UPDATE NhanVien SET ID_NhanVien = @ID_NhanVien, TenNhanVien = @TenNhanVien, ChucDanh = @ChucDanh, " +
                                 "BoPhan = @BoPhan WHERE ID_NhanVien = @ID_NhanVien";


            using (SqlCommand cmd = new SqlCommand(updateQuery, cnn))
            {
                cmd.Parameters.AddWithValue("@ID_NhanVien", ID_NhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                cmd.Parameters.AddWithValue("@ChucDanh", ChucDanh);
                cmd.Parameters.AddWithValue("@BoPhan", BoPhan);

                cmd.ExecuteNonQuery();
            }



        }

        //xóa nhân viên:
        public void xoaNV(int ID_NhanVien, string TenNhanVien, string ChucDanh, string BoPhan)
        {
            string sql = "DELETE FROM NhanVien WHERE ID_NhanVien = @ID_NhanVien";
            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@ID_NhanVien", ID_NhanVien);
                scm.ExecuteNonQuery();
            }
        }


        // clear nhan vien
        public void clearTextBox(string TenNhanVien, string ChucDanh, string BoPhan)
        {
            TenNhanVien = "";
            ChucDanh = "";
            BoPhan = "";

        }
        public void clearTextBox(int ID_NhanVien)
        {
            ID_NhanVien = 0;

        }

        public void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }
        }









        // CÔNG VIỆC:

        // lấy id công việc
        public int getID_CV()
        {

            // Replace "YourTableName" with the actual table name and "YourIDColumnName" with the actual ID column name
            string query = "SELECT MAX(ID_CongViec) FROM CongViec";
            //
            int newID = GetNextID_CV(connectionString, query);
            return newID;
        }
        static int GetNextID_CV(string connectionString, string query)
        {
            int nextID = 1; // Default starting ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nextID = Convert.ToInt32(result);

                    }
                }
            }

            return ++nextID;
        }

        public void clearTextBox_CV(string TenCongViec, string NhomCongViec, DateTime NgayBatDau, DateTime NgayKetThuc, string TrangThai)
        {
            TenCongViec = "";
            NhomCongViec = "";
            NgayBatDau = DateTime.Now;
            NgayKetThuc = DateTime.Now;
            TrangThai = "";

        }
        public void clearTextBox_CV(int ID_CongViec)
        {
            ID_CongViec = 0;

        }

        public void loadData_CV()
        {
            string sql = "select ID_CongViec,TenCongViec,NhomCongViec,NgayBatDau,NgayKetThuc,TrangThai from CongViec";
            taoBang(sql);
        }

        // Thêm công việc:
        public void themCV(string TenCongViec, string NhomCongViec, DateTime NgayBatDau, DateTime NgayKetThuc, string TrangThai, string ID_NhanVien)
        {
            string sql = "INSERT INTO CongViec (ID_CongViec, TenCongViec, NhomCongViec, NgayBatDau, NgayKetThuc, TrangThai, NhanVien_ID) " +
                         "VALUES (@ID_CongViec, @TenCongViec, @NhomCongViec, @NgayBatDau, @NgayKetThuc, @TrangThai, @ID_NhanVien)";

            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@ID_CongViec", getID_CV());
                scm.Parameters.AddWithValue("@TenCongViec", TenCongViec);
                scm.Parameters.AddWithValue("@NhomCongViec", NhomCongViec);
                scm.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                scm.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                scm.Parameters.AddWithValue("@TrangThai", TrangThai);
                scm.Parameters.AddWithValue("@ID_NhanVien", int.Parse( ID_NhanVien));

                scm.ExecuteNonQuery();
            }
        }

        // Sửa công việc:
        public void sua(int ID_CongViec, string TenCongViec, string NhomCongViec, DateTime NgayBatDau, DateTime NgayKetThuc, string TrangThai)
        {


            // Sửa dữ liệu trong bảng CongViec
            string updateQuery = "UPDATE CongViec SET ID_CongViec=@ID_CongViec, TenCongViec = @TenCongViec, NhomCongViec = @NhomCongViec, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, " +
                                 "TrangThai = @TrangThai WHERE ID_CongViec = @ID_CongViec";


            using (SqlCommand cmd = new SqlCommand(updateQuery, cnn))
            {
                cmd.Parameters.AddWithValue("@ID_CongViec", ID_CongViec);
                cmd.Parameters.AddWithValue("@TenCongViec", TenCongViec);
                cmd.Parameters.AddWithValue("@NhomCongViec", NhomCongViec);
                cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

                cmd.ExecuteNonQuery();
            }



        }

        //Xóa công việc:
        public void xoa(int ID_CongViec, string TenCongViec, string NhomCongViec, DateTime NgayBatDau, DateTime NgayKetThuc, string TrangThai)
        {
            string sql = "DELETE FROM CongViec WHERE ID_CongViec = @ID_CongViec";
            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@ID_CongViec", ID_CongViec);
                scm.ExecuteNonQuery();
            }
        }

      
        public List<int> getListID(string cmd)
        {
            List<int> listID = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listID.Add(reader.GetInt32(0));
                        }
                    }
                }
            }

            return listID;
        }
        public void AddListToComboBox(ComboBox comboBox, String cmd)
        {
            comboBox.Items.Clear();
            List<int> listID = getListID(cmd);

            foreach (int id in listID)
            {
                comboBox.Items.Add(id);
            }
        }


        // Thêm tiến độ:
        public void themTienDo(int PhanTramHoanThanh, DateTime NgayCapNhat, String ID_CongViec)
        {
            string sql = "INSERT INTO TienDo (CongViec_ID,ID_TienDo,PhanTramHoanThanh,NgayCapNhat) " +
                         "VALUES (@CongViec_ID,@ID_TienDo,@PhanTramHoanThanh,@NgayCapNhat)";
            moKetNoi();
            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@CongViec_ID", ID_CongViec );
                scm.Parameters.AddWithValue("@ID_TienDo", getID_TD());
                scm.Parameters.AddWithValue("@PhanTramhoanThanh", PhanTramHoanThanh);
                scm.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);

                scm.ExecuteNonQuery();
            }
            if(PhanTramHoanThanh == 100)
            {
                string cmd = $"UPDATE CongViec SET  TrangThai = 'Đã Hoàn Thành' WHERE ID_CongViec = {ID_CongViec}";
                using (SqlCommand scm = new SqlCommand(cmd, cnn))
                {
                    scm.ExecuteNonQuery();
                }
            }
            dongKetNoi();
        }
        public int getID_TD()
        {

            // Replace "YourTableName" with the actual table name and "YourIDColumnName" with the actual ID column name
            string query = "SELECT MAX(ID_TienDo) FROM TienDo";
            //
            int newID = GetNextID_CV(connectionString, query);
            return newID;
        }

        public void thoat(Form form)
        {
            form.Hide();
            FormChuongTrinh f = new FormChuongTrinh();
            f.Show();
        }



        // Báo Cáo

         
        public void themBC(int IDCV, string NoiDung, DateTime NgayBaoCao)
        {
            string cmd = "INSERT INTO BaoCao (ID_BaoCao,CongViec_ID, NoiDung, NgayBaoCao) VALUES (@IDBC,@IDCV, @NoiDung, @NgayBaoCao)";
            moKetNoi();
            using (SqlCommand command = new SqlCommand(cmd, cnn))
            {
                command.Parameters.AddWithValue("@IDBC",getID_BC() );
                command.Parameters.AddWithValue("@IDCV", IDCV);
                command.Parameters.AddWithValue("@NoiDung", NoiDung);
                command.Parameters.AddWithValue("@NgayBaoCao", NgayBaoCao);
                command.ExecuteNonQuery();
            }
            dongKetNoi();
        }

        public void sua(string cmd)
        {
            moKetNoi();
            using (SqlCommand command = new SqlCommand(cmd, cnn))
            {
                command.ExecuteNonQuery();
            }
            dongKetNoi();
        }

        public void xoa(string tableName, string idColumnName, string idValue)
        {
            moKetNoi();
            string cmd = $"DELETE FROM {tableName} WHERE {idColumnName} = {idValue}";
            using (SqlCommand command = new SqlCommand(cmd, cnn))
            {
                command.ExecuteNonQuery();
            }
            dongKetNoi();
        }

        public string GetText(string tableName, string idColumnName, string contentColumnName, int idValue)
        {
            string cmd = $"SELECT {contentColumnName} FROM {tableName} WHERE {idColumnName} = {idValue}";
            string result = "";

            using (SqlCommand command = new SqlCommand(cmd, cnn))
            {
                moKetNoi();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                }
                dongKetNoi();
            }
            return result;
        }

        public int getID_BC()
        {

            // Replace "YourTableName" with the actual table name and "YourIDColumnName" with the actual ID column name
            string query = "SELECT MAX(ID_BaoCao) FROM BaoCao";
            //
            int newID = GetNextID_CV(connectionString, query);
            return newID;
        }
    }

}
