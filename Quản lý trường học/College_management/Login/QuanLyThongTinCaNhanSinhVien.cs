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
    public partial class QuanLyThongTinCaNhanSinhVien : Form
    {
        public QuanLyThongTinCaNhanSinhVien(String username)
        {
            InitializeComponent();
            txt_masinhvien.Text = username;
        }

        private void QuanLyThongTinCaNhanSinhVien_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                sinh_vien sv = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).FirstOrDefault();
                txt_tensinhvien.Text = sv.ho_ten;
                txt_email.Text = sv.email;
                txt_sodienthoai.Text = sv.mobile;
                if (sv.gioi_tinh == 1)
                {
                    txt_gioitinh.Text = "Nam";
                }
                else
                {
                    txt_gioitinh.Text = "Nữ";
                }
                comboBox1.Items.Clear();
                db.lop_hoc.ToList().ForEach(row =>
                {
                    comboBox1.Items.Add(row.ma_lh);
                });

                dataGridView1.Rows.Clear();
                db.hoc_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList().ForEach(lh =>
                {
                    dataGridView1.Rows.Add(
                        lh.ma_hv,
                        lh.ma_lh,
                        lh.ma_sv,
                        lh.diem,
                        lh.nhan_xet
                        );
                }

                );
            }
        }

        private void update()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                sinh_vien sv = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).FirstOrDefault();
                txt_tensinhvien.Text = sv.ho_ten;
                txt_email.Text = sv.email;
                txt_sodienthoai.Text = sv.mobile;
                if (sv.gioi_tinh == 1)
                {
                    txt_gioitinh.Text = "Nam";
                }
                else
                {
                    txt_gioitinh.Text = "Nữ";
                }
                comboBox1.Items.Clear();
                db.lop_hoc.ToList().ForEach(row =>
                {
                    comboBox1.Items.Add(row.ma_lh);
                });

                dataGridView1.Rows.Clear();
                db.hoc_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList().ForEach(lh =>
                {
                    dataGridView1.Rows.Add(
                        lh.ma_hv,
                        lh.ma_lh,
                        lh.ma_sv,
                        lh.diem,
                        lh.nhan_xet
                        );
                }

                );
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    hoc_vien hv = new hoc_vien();
                    hv.ma_sv = txt_masinhvien.Text;

                    if (comboBox1.SelectedItem != null)
                    {
                        lop_hoc lh = db.lop_hoc.Where(x => x.ma_lh == (int)comboBox1.SelectedItem).FirstOrDefault();
                        hv.ma_lh = lh.ma_lh;
                        hv.diem = int.Parse("0");
                        db.hoc_vien.Add(hv);
                        db.SaveChanges();
                        MessageBox.Show("Đăng ký lớp học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Đăng ký lớp học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đăng ký lớp học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            update();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
            this.Close();
        }
    }
}
