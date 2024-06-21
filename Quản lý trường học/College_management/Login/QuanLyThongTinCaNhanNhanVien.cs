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
    public partial class QuanLyThongTinCaNhanNhanVien : Form
    {
        public QuanLyThongTinCaNhanNhanVien(String user)
        {
            InitializeComponent();
            textBox1.Text = user;
        }

        private void QuanLyThongTinCaNhanNhanVien_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv.Equals(textBox1.Text)).FirstOrDefault();
                textBox2.Text = nv.ho_ten;
                tai_khoan tk = db.tai_khoan.Where(x => x.USERNAME.Equals(textBox1.Text)).FirstOrDefault();
                textBox3.Text = tk.PASS;
            }

        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy form = new QuanLy(textBox1.Text);
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
