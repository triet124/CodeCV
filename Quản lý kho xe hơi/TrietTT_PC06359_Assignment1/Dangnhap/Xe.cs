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
    public partial class Xe : Form
    {
        DataSet ds = new DataSet();
        public Xe(String username)
        {
            InitializeComponent();
            lbusername.Text = username;
        }   

        private void XeHoi_Load(object sender, EventArgs e)
        {
            String conn = @"data source=.;Initial Catalog= QuanLyXeHoi;integrated security=SSPI";
            String Querry = "select * from XeHoi";
            SqlDataAdapter adptr = new SqlDataAdapter(Querry, conn);
            ds.Clear();
            adptr.Fill(ds, "XeHoi");
            dataGridView1.DataSource = ds.Tables["XeHoi"];
            txtmaxe.Enabled = false;
            btn_xoaxe.Enabled = false;
            btn_capnhatxe.Enabled = false;
            btn_luu.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;

            var tenxe = ds.Tables["XeHoi"].Rows[row].Field<string>("TenXe").ToString();
            txtten.Text = tenxe;

            var maxe = ds.Tables["Xehoi"].Rows[row].Field<int>("MaXe").ToString();
            txtmaxe.Text = maxe;

            var kho = ds.Tables["XeHoi"].Rows[row].Field<string>("Kho").ToString();
            txtmakho.Text = kho;

            var ngaynhapkho = ds.Tables["XeHoi"].Rows[row].Field<DateTime>("NgayNhapKho").ToString();
            dateTimePicker1.Text = ngaynhapkho;

            var loai = ds.Tables["XeHoi"].Rows[row].Field<int>("MaLoai").ToString();
            txtloai.Text = loai;

            btn_luu.Enabled = false;
            btn_xoaxe.Enabled = true;
            btn_capnhatxe.Enabled = true;
        }

        private void btn_themxe_Click(object sender, EventArgs e)
        {
            txtmakho.Text = "";
            txtten.Text = "";
            txtloai.Text = "";
            txtmaxe.Text = "";
            btn_luu.Enabled = true;
            btn_capnhatxe.Enabled = false;
            btn_xoaxe.Enabled = false;
        }

        private void btn_xoaxe_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtmaxe.Text == "")
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
                    string query = "delete from XeHoi where MaXe = @MaXe";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {


                        command.Parameters.AddWithValue("@MaXe", txtmaxe.Text);

                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        XeHoi_Load(this, EventArgs.Empty);


                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
        }

        private void btn_capnhatxe_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtten.Text == "" || txtmakho.Text == "" || txtloai.Text == "")
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
                    string query = "update XeHoi set TenXe = @TenXe, Kho = @MaKho, MaLoai = @MaLoai, NgayNhapKho =@NgayNhapKho where MaXe =@MaXe";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@MaXe", txtmaxe.Text);
                        command.Parameters.AddWithValue("@TenXe", txtten.Text);
                        command.Parameters.AddWithValue("@MaKho", txtmakho.Text);
                        command.Parameters.AddWithValue("@MaLoai", txtloai.Text);
                        command.Parameters.AddWithValue("@NgayNhapKho", dateTimePicker1.Value);


                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        XeHoi_Load(this, EventArgs.Empty);
                        MessageBox.Show("Cập nhật thành công");
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

                string query = "SELECT MaXe, TenXe, Kho, NgayNhapKho, MaLoai FROM XeHoi WHERE MaXe = @MaXe";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaXe", txttimkiem.Text);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtmaxe.Text = reader["MaXe"].ToString();
                    txtten.Text = reader["TenXe"].ToString();
                    txtmakho.Text = reader["Kho"].ToString();
                    dateTimePicker1.Text = reader["NgayNhapKho"].ToString();
                    txtloai.Text = reader["MaLoai"].ToString();
                }
                else
                {
                    txtmaxe.Text = string.Empty;
                    txtten.Text = string.Empty;
                    txtmakho.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                    txtloai.Text = string.Empty;
                    MessageBox.Show("Không tìm thấy xe");
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyXeHoi; Integrated security = SSPI";
            if (txtten.Text == "" || txtmakho.Text == "" || txtloai.Text == "")
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
                    string query = "insert into XeHoi (TenXe, Kho,NgayNhapKho,MaLoai)" +
                        "values (@TenXe,@Kho, @NgayNhapKho,@MaLoai) ";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {


                        command.Parameters.AddWithValue("@TenXe", txtten.Text);
                        command.Parameters.AddWithValue("@Kho", txtmakho.Text);
                        command.Parameters.AddWithValue("@NgayNhapKho", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@MaLoai", txtloai.Text);


                        conn.Open();
                        command.ExecuteNonQuery();

                        conn.Close();
                        XeHoi_Load(this, EventArgs.Empty);
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
        }
    }
}
