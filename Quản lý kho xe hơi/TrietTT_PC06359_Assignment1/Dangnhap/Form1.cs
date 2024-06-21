using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)
                || String.IsNullOrWhiteSpace(textBox1.Text)
                || String.IsNullOrEmpty(textBox2.Text)
                || String.IsNullOrWhiteSpace(textBox2.Text))
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
                String role = DBHandler.Login(textBox1.Text, textBox2.Text);
                if (role != null)
                {
                    if (role.Equals("QLK"))
                    {
                        this.Hide();
                        KhoXe form = new KhoXe(textBox1.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("QLX"))
                    {
                        this.Hide();
                        Xe form = new Xe(textBox1.Text);
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
    }
}
