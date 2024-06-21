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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                tai_khoan tk1 = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_taikhoan.Text)).FirstOrDefault();
                List<tai_khoan> tk2 = db.tai_khoan.Where(x => x.USERNAME.Equals(txt_taikhoan.Text)).ToList();

                if (!tk2.Any() || txt_taikhoan.Text == "" || txt_matkhaucu.Text == "" || txt_matkhaumoi.Text == "" || txt_xacnhanmatkhaumoi.Text == "")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tk1.PASS != txt_matkhaucu.Text)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txt_xacnhanmatkhaumoi.Text != txt_matkhaumoi.Text)
                        {
                            MessageBox.Show("Xác nhận mật khẩu không đúng vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            tk1.PASS = txt_xacnhanmatkhaumoi.Text;
                            MessageBox.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.SaveChanges();
                        }
                    }
                    
                }
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
    }
}
