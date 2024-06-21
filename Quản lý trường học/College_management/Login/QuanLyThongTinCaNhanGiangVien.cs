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
    public partial class QuanLyThongTinCaNhanGiangVien : Form
    {
        public QuanLyThongTinCaNhanGiangVien(String username)
        {
            InitializeComponent();
            txt_magiangvien.Text = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void QuanLyThongTinCaNhanGiangVien_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                giang_vien gv = db.giang_vien.Where(x => x.ma_gv.Equals(txt_magiangvien.Text)).FirstOrDefault();
                txt_tengiangvien.Text = gv.ho_ten;
                txt_email.Text = gv.email;
                txt_sodienthoai.Text = gv.mobile;
                tai_khoan tk = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_magiangvien.Text)).FirstOrDefault();
                txt_matkhau.Text = tk.PASS;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                tai_khoan tk = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_magiangvien.Text)).FirstOrDefault();
                tk.PASS = txt_matkhau.Text;
                db.SaveChanges();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamDiemHocVien form = new ChamDiemHocVien(txt_magiangvien.Text);
            form.ShowDialog();
            this.Close();
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
