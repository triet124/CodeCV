using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class QuanLyGiangVien : Form
    {
        public QuanLyGiangVien(String user)
        {
            InitializeComponent();
            label4.Text = user;
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                updategv();
            }
            btn_suathongtin.Enabled = false;
            btn_xoagiangvien.Enabled = false;
            btn_themgiangvien.Enabled = true;
            txt_magiangvien.Enabled = true;
        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                dataGridView1.Rows.Clear();
                db.giang_vien.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_gv,
                        kh.ho_ten,
                        kh.email,
                        kh.mobile.ToString()
                        );
                }
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String Mamh = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                giang_vien mh = db.giang_vien.Where(x => x.ma_gv == Mamh).FirstOrDefault();
                txt_magiangvien.Text = mh.ma_gv;
                txt_tengiangvien.Text = mh.ho_ten;
                txt_email.Text = mh.email;
                txt_sodienthoai.Text = mh.mobile.ToString();
                tai_khoan tk = db.tai_khoan.Where(x => x.USERNAME == Mamh).FirstOrDefault();
                txt_matkhau.Text = tk.PASS;
            }
            btn_suathongtin.Enabled = true;
            btn_xoagiangvien.Enabled = true;
            btn_themgiangvien.Enabled = true;
            btn_themgiangvien.Enabled = false;
            txt_magiangvien.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    if (txt_magiangvien.Text == "" || txt_tengiangvien.Text == "" || txt_email.Text == "" || txt_sodienthoai.Text == "")
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        giang_vien them = new giang_vien();
                        them.ma_gv = txt_magiangvien.Text;
                        them.ho_ten = txt_tengiangvien.Text;
                        them.email = txt_email.Text;
                        them.mobile = txt_sodienthoai.Text.ToString();
                        tai_khoan them2 = new tai_khoan();
                        them2.USERNAME = txt_magiangvien.Text;
                        them2.PASS = txt_matkhau.Text;
                        them2.VAITRO = "giang vien";
                        db.giang_vien.Add(them);
                        db.tai_khoan.Add(them2);
                        db.SaveChanges();
                        updategv();
                        MessageBox.Show("thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã giảng viên này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {


        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                giang_vien them = db.giang_vien.Where(x => x.ma_gv == txt_magiangvien.Text).FirstOrDefault();
                them.ma_gv = txt_magiangvien.Text;
                them.ho_ten = txt_tengiangvien.Text;
                them.email = txt_email.Text;
                them.mobile = txt_sodienthoai.Text.ToString();
                tai_khoan them2 =db.tai_khoan.Where(x => x.USERNAME == txt_magiangvien.Text).FirstOrDefault();
                them2.USERNAME = txt_magiangvien.Text;
                them2.PASS = txt_matkhau.Text;
                them2.VAITRO = "giang vien";
                db.SaveChanges();
            }
            MessageBox.Show("sửa thành công");
            updategv();
        }

        private void btn_xoagiangvien_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    giang_vien xoa = db.giang_vien.Where(x => x.ma_gv == txt_magiangvien.Text).FirstOrDefault();
                    tai_khoan xoa2 = db.tai_khoan.Where(x => x.USERNAME == txt_magiangvien.Text).FirstOrDefault();
                    db.giang_vien.Remove(xoa);
                    db.tai_khoan.Remove(xoa2);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            updategv();
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_magiangvien.Text = "";
            txt_tengiangvien.Text = "";
            txt_email.Text = "";
            txt_sodienthoai.Text = "";
            txt_timkiem.Text = "";
            txt_matkhau.Text = "";
            btn_themgiangvien.Enabled = true;
            txt_magiangvien.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoagiangvien.Enabled = false;
            updategv();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                giang_vien hk = db.giang_vien.Where(mahk => mahk.ma_gv.Equals(txt_timkiem.Text)).FirstOrDefault();
                List<giang_vien> list = db.giang_vien.Where(sv => sv.ma_gv.Equals(txt_timkiem.Text)).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("Giảng viên này không tồn tại trong danh mục");
                    }
                    else
                    {
                        txt_magiangvien.Text = hk.ma_gv;
                        txt_tengiangvien.Text = hk.ho_ten;
                        txt_email.Text = hk.email;
                        txt_sodienthoai.Text = hk.mobile.ToString();
                        dataGridView1.Rows.Clear();
                        list.ForEach(kh =>
                        {

                            dataGridView1.Rows.Add(
                                kh.ma_gv,
                                kh.ho_ten,
                                kh.email,
                                kh.mobile.ToString()
                                );
                        });
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Giảng viên này không tồn tại trong danh mục");
                }
            }
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy form = new QuanLy(label4.Text);
            form.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
