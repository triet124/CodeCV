using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dangnhap
{
    public partial class KhoXe : Form
    {
        DataSet ds = new DataSet();

        public KhoXe(String username)
        {
            InitializeComponent();
            lbusername.Text = username;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_timxe_Click(object sender, EventArgs e)
        {
            
        }

        private void KhoXe_Load(object sender, EventArgs e)
        {
            String conn = @"data source=.;Initial Catalog= QuanLyXeHoi;integrated security=SSPI";
            String Querry = "select * from Kho";
            SqlDataAdapter adptr = new SqlDataAdapter(Querry, conn);
            ds.Clear();
            adptr.Fill(ds, "Kho");
            
            dataGridView1.DataSource = ds.Tables["Kho"];
            btn_luu.Enabled = false;
            btn_capnhatkho.Enabled = false;
            btn_xoakho.Enabled = false;
        }

        private void btn_themkho_Click(object sender, EventArgs e)
        {
            txtkhoxe.Text = "";
            txtdiachi.Text = "";
            txtquanly.Text = "";
            txtsoluong.Text = "";
            btn_luu.Enabled = true;
            btn_xoakho.Enabled = false;
            btn_capnhatkho.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoakho_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtkhoxe.Text == "" )
            {
                MessageBox.Show("không được để trống",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "delete from Kho where MaKho = @MaKho";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {


                        command.Parameters.AddWithValue("@MaKho", txtkhoxe.Text);

                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        KhoXe_Load(this, EventArgs.Empty);


                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM XeHoi WHERE Kho = @MaKho";

                    
                    var row = e.RowIndex;

                    var makho = ds.Tables["Kho"].Rows[row].Field<string>("MaKho").ToString();
                    txtkhoxe.Text = makho;

                    var diachi = ds.Tables["Kho"].Rows[row].Field<string>("DiaChi").ToString();
                    txtdiachi.Text = diachi;

                    var quanly = ds.Tables["Kho"].Rows[row].Field<string>("QuanLy").ToString();
                    txtquanly.Text = quanly;

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@MaKho", makho);
                    int tongSoLuong = Convert.ToInt32(command.ExecuteScalar());
                    txtsoluong.Text = tongSoLuong.ToString();
                }
            btn_xoakho.Enabled = true;
            btn_capnhatkho.Enabled = true;
            btn_luu.Enabled = false;
        }
      
        private void btn_capnhatkho_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtkhoxe.Text == "" || txtdiachi.Text == "" || txtquanly.Text == "")
            {
                MessageBox.Show("không được để trống",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "update Kho set DiaChi = @DiaChi, QuanLy = @QuanLy where MaKho =@MaKho";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {


                        command.Parameters.AddWithValue("@MaKho", txtkhoxe.Text);
                        command.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                        command.Parameters.AddWithValue("@QuanLy", txtquanly.Text);


                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        KhoXe_Load(this, EventArgs.Empty);
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtkhoxe.Text == "" || txtdiachi.Text == "" || txtquanly.Text == "")
            {
                MessageBox.Show("không được để trống",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "insert into Kho (MaKho, DiaChi, QuanLy)" +
                        "values (@MaKho,@DiaChi, @QuanLy) ";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {


                        command.Parameters.AddWithValue("@MaKho", txtkhoxe.Text);
                        command.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                        command.Parameters.AddWithValue("@QuanLy", txtquanly.Text);


                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        KhoXe_Load(this, EventArgs.Empty);
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
        }

        private void btntiemkiem_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT MaKho, DiaChi, QuanLy FROM Kho WHERE MaKho = @MaKho";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaKho", txttimkiem.Text);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtkhoxe.Text = reader["MaKho"].ToString();
                    txtdiachi.Text = reader["DiaChi"].ToString();
                    txtquanly.Text = reader["QuanLy"].ToString();
                    
                }
                else
                {
                    txtkhoxe.Text = string.Empty;
                    txtdiachi.Text = string.Empty;
                    txtquanly.Text = string.Empty;
                    txtsoluong.Text = string.Empty;
                    MessageBox.Show("Không tìm thấy xe");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
