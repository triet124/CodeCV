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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cb_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthimatkhau.Checked)
            {
                txt_matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click_1(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text == "" || txt_matkhau.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ tài khoản và mật khẩu",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                String role = DBhandler.Login(txt_taikhoan.Text, txt_matkhau.Text);
                if (role != null)
                {
                    if (role.Equals("nhan vien"))
                    {
                        this.Hide();
                        QuanLy form = new QuanLy(txt_taikhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("giang vien"))
                    {
                        this.Hide();
                        QuanLyThongTinCaNhanGiangVien form = new QuanLyThongTinCaNhanGiangVien(txt_taikhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("sinh vien"))
                    {
                        this.Hide();
                        QuanLyThongTinCaNhanSinhVien form = new QuanLyThongTinCaNhanSinhVien(txt_taikhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tài khoản chưa được cấp quyền",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Tài khoản hoặc mật khẩu chưa đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }


            }
        }

        private void cb_hienthimatkhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_hienthimatkhau.Checked)
            {
                txt_matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void btn_quenmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
