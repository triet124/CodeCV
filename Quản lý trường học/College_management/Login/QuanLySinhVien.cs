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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien(String user)
        {
            InitializeComponent();
            label5.Text = user;
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                updategv();
            }
            txt_masinhvien.Enabled = true;

            btn_suathongtin.Enabled = false;
            btn_xoasinhvien.Enabled = false;
            btn_themsinhvien.Enabled = true;

        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                dataGridView1.Rows.Clear();
                db.sinh_vien.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_sv,
                        kh.ho_ten,
                        kh.gioi_tinh,
                        kh.email,
                        kh.mobile
                        );;
                }

                );
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String Masv = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                sinh_vien kh = db.sinh_vien.Where(x => x.ma_sv == Masv).FirstOrDefault();
                txt_masinhvien.Text = kh.ma_sv;
                txt_tensinhvien.Text = kh.ho_ten;
                if(kh.gioi_tinh == 1)
                {
                    txt_gioitinh.Text = "Nam";
                }
                else
                {
                    txt_gioitinh.Text = "Nữ";

                }
                txt_email.Text = kh.email;
                txt_sodienthoai.Text = kh.mobile;
                tai_khoan tk = db.tai_khoan.Where(x => x.USERNAME == Masv).FirstOrDefault();
                txt_matkhau.Text = tk.PASS;
            }
            txt_masinhvien.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoasinhvien.Enabled = true;
            btn_themsinhvien.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    List<sinh_vien> list = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList();
                    if (txt_masinhvien.Text == "" || txt_tensinhvien.Text == "" || txt_gioitinh.Text == "" || txt_email.Text == "" || txt_sodienthoai.Text == "" || txt_matkhau.Text == "")
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sinh_vien them = new sinh_vien();
                        them.ma_sv = txt_masinhvien.Text;
                        them.ho_ten = txt_tensinhvien.Text;
                        if (txt_gioitinh.Text.Equals("Nam") || txt_gioitinh.Text.Equals("nam"))
                        {
                            them.gioi_tinh = 1;
                        }
                        else
                        {
                            them.gioi_tinh = 2;
                        }
                        them.email = txt_email.Text;
                        them.mobile = txt_sodienthoai.Text;
                        tai_khoan them2 = new tai_khoan();
                        them2.USERNAME = txt_masinhvien.Text;
                        them2.PASS = txt_matkhau.Text;
                        them2.VAITRO = "sinh vien";
                        db.sinh_vien.Add(them);
                        db.tai_khoan.Add(them2);
                        db.SaveChanges();
                        updategv();
                        MessageBox.Show("thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_masinhvien.Text = "";
            txt_tensinhvien.Text = "";
            txt_gioitinh.Text = "";
            txt_email.Text = "";
            txt_sodienthoai.Text = "";
            txt_timkiem.Text = "";
            txt_masinhvien.Enabled = true;
            txt_matkhau.Text = "";
            btn_suathongtin.Enabled = false;
            btn_xoasinhvien.Enabled = false;
            btn_themsinhvien.Enabled = true;
            updategv();

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                sinh_vien Sinhvien = db.sinh_vien.Where(masv => masv.ma_sv.Equals(txt_timkiem.Text)).FirstOrDefault();
                List<sinh_vien> list = db.sinh_vien.Where(sv => sv.ma_sv.Equals(txt_timkiem.Text)).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("môn học này không tồn tại trong danh mục");
                    }
                    else
                    {
                        txt_masinhvien.Text = Sinhvien.ma_sv;
                        txt_tensinhvien.Text = Sinhvien.ho_ten;
                        txt_gioitinh.Text = Sinhvien.gioi_tinh.ToString();
                        txt_email.Text = Sinhvien.email;
                        txt_sodienthoai.Text = Sinhvien.mobile;
                        dataGridView1.Rows.Clear();
                        list.ForEach(sv =>
                        {

                            dataGridView1.Rows.Add(
                                sv.ma_sv,
                                sv.ho_ten,
                                sv.gioi_tinh.ToString(),
                                sv.email,
                                sv.mobile
                                );
                        });
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("môn học này không tồn tại trong danh mục");
                }
            }
            txt_matkhau.Text = "";
            txt_masinhvien.Enabled = false;
            btn_themsinhvien.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoasinhvien.Enabled = true;
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy form = new QuanLy(label5.Text);
            form.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    List<sinh_vien> list = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList();
                    if (txt_masinhvien.Text == "" || txt_tensinhvien.Text == "" || txt_gioitinh.Text == "" || txt_email.Text == "" || txt_sodienthoai.Text == "" || txt_matkhau.Text == "")
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sinh_vien them =db.sinh_vien.Where(x=>x.ma_sv.Equals(txt_masinhvien.Text)).FirstOrDefault();
                        them.ma_sv = txt_masinhvien.Text;
                        them.ho_ten = txt_tensinhvien.Text;
                        them.gioi_tinh = (byte)int.Parse(txt_gioitinh.Text);
                        them.email = txt_email.Text;
                        them.mobile = txt_sodienthoai.Text;
                        tai_khoan them2 = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_masinhvien.Text)).FirstOrDefault();
                        them2.USERNAME = txt_masinhvien.Text;
                        them2.PASS = txt_matkhau.Text;
                        them2.VAITRO = "sinh vien";
                        db.SaveChanges();
                        updategv();
                        MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoasinhvien_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    sinh_vien them = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).FirstOrDefault();
                    tai_khoan them2 = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_masinhvien.Text)).FirstOrDefault();
                    db.sinh_vien.Remove(them);
                    db.tai_khoan.Remove(them2);
                    db.SaveChanges();
                    MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            updategv();
        }
    }

}
