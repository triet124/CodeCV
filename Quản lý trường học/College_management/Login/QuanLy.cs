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
    public partial class QuanLy : Form
    {
        public QuanLy(String username)
        {
            InitializeComponent();
            textBox1.Text = username;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv.Trim() == textBox1.Text).FirstOrDefault();
                textBox2.Text = nv.ho_ten;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHocVien form = new QuanLyHocVien(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_monhoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDanhMucMonHoc form = new QuanLyDanhMucMonHoc(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_hocky_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHocKy form = new QuanLyHocKy(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLopHoc form = new QuanLyLopHoc(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_giangvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyGiangVien form = new QuanLyGiangVien(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_sinhvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySinhVien form = new QuanLySinhVien(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_thongtincanhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThongTinCaNhanNhanVien form = new QuanLyThongTinCaNhanNhanVien(textBox1.Text);
            form.ShowDialog();
            this.Close();
        }
    }
}
