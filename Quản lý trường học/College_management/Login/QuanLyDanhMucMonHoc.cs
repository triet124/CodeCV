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


namespace Login
{
    public partial class QuanLyDanhMucMonHoc : Form
    {
        DataSet ds = new DataSet();
        
        public QuanLyDanhMucMonHoc(String user)
        {
            InitializeComponent();
            label7.Text = user;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatedgv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                dataGridView1.Rows.Clear();
                db.mon_hoc.ToList().ForEach(mh =>
                {
                    dataGridView1.Rows.Add(
                        mh.ma_mh,
                        mh.ten_mh,
                        mh.thoi_luong,
                        mh.so_tc,
                        mh.mo_ta
                        );
                }
                );
            }
        }

        private void QuanLyDanhMucMonHoc_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                updatedgv();
            }
            txt_mamonhoc.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoathongtin.Enabled = false;
            btn_themmonhoc.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String Mamh = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                mon_hoc mh = db.mon_hoc.Where(x => x.ma_mh == Mamh).FirstOrDefault();
                txt_mamonhoc.Text = mh.ma_mh;
                txt_tenmonhoc.Text = mh.ten_mh;
                txt_thoiluong.Text = mh.thoi_luong.ToString();
                txt_sotinchi.Text = mh.so_tc.ToString();
                txt_mota.Text = mh.mo_ta;
            }
            btn_suathongtin.Enabled = true;
            btn_xoathongtin.Enabled = true;
            txt_mamonhoc.Enabled = false;
            btn_themmonhoc.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                mon_hoc mh = db.mon_hoc.Where(mamh => mamh.ma_mh.Equals(txt_timkiem.Text)).FirstOrDefault();
                List<mon_hoc> list = db.mon_hoc.Where(sv => sv.ma_mh.Equals(txt_timkiem.Text)).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("môn học này không tồn tại trong danh mục");
                    }
                    else
                    {
                            txt_mamonhoc.Text = mh.ma_mh;
                            txt_tenmonhoc.Text = mh.ten_mh;
                            txt_thoiluong.Text = mh.thoi_luong.ToString();
                            txt_sotinchi.Text = mh.so_tc.ToString();
                            txt_mota.Text = mh.mo_ta;
                            dataGridView1.Rows.Clear();
                            list.ForEach(sv =>
                            {

                                dataGridView1.Rows.Add(
                                    sv.ma_mh,
                                    sv.ten_mh,
                                    sv.thoi_luong,
                                    sv.so_tc,
                                    sv.mo_ta
                                    );
                            });
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("môn học này không tồn tại trong danh mục");
                }
                
            }
            txt_mamonhoc.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    if (txt_mamonhoc.Text == "")
                    {
                        MessageBox.Show("Không được để trống","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        mon_hoc them = new mon_hoc();
                        them.ma_mh = txt_mamonhoc.Text;
                        them.ten_mh = txt_tenmonhoc.Text;
                        if(int.Parse(txt_thoiluong.Text) < 0)
                        {
                            MessageBox.Show("Thời lượng không được nhỏ hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            them.thoi_luong = int.Parse(txt_thoiluong.Text);
                            them.so_tc = int.Parse(txt_sotinchi.Text);
                            them.mo_ta = txt_mota.Text;
                            db.mon_hoc.Add(them);
                            db.SaveChanges();
                            updatedgv();
                            MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã môn học đã tồn tại vui lòng thử mã khác","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                mon_hoc them = db.mon_hoc
                    .Where(x => x.ma_mh == txt_mamonhoc.Text)
                    .FirstOrDefault();
                them.ten_mh = txt_tenmonhoc.Text;
                them.thoi_luong = int.Parse(txt_thoiluong.Text);
                them.so_tc = int.Parse(txt_sotinchi.Text);
                them.mo_ta = txt_mota.Text;
                db.SaveChanges();
                MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            updatedgv();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_mamonhoc.Text = "";
            txt_tenmonhoc.Text = "";
            txt_thoiluong.Text = "";
            txt_sotinchi.Text = "";
            txt_mota.Text = "";
            txt_timkiem.Text = "";
            btn_themmonhoc.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoathongtin.Enabled = false;
            txt_mamonhoc.Enabled = true;
            updatedgv();
        }

        private void btn_xoathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    mon_hoc xoa = db.mon_hoc.Where(x => x.ma_mh == txt_mamonhoc.Text).FirstOrDefault();
                    db.mon_hoc.Remove(xoa);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            updatedgv();
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy form = new QuanLy(label7.Text);
            form.ShowDialog();
            this.Close();
        }
    }
}
