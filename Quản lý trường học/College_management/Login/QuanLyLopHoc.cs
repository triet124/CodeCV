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
    public partial class QuanLyLopHoc : Form
    {
        public QuanLyLopHoc(String user)
        {
            InitializeComponent();
            label4.Text = user;
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                updategv();
            }
            txt_malophoc.Enabled = false;
            btn_themlophoc.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoalophoc.Enabled = false;
        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                dataGridView1.Rows.Clear();
                db.lop_hoc.ToList().ForEach(lh =>
                {
                    dataGridView1.Rows.Add(
                        lh.ma_lh,
                        lh.ma_mh,
                        lh.ma_gv,
                        lh.ma_hk
                        );
                }
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String malh = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                lop_hoc mh = db.lop_hoc.Where(x => x.ma_lh.ToString() == malh).FirstOrDefault();
                txt_malophoc.Text = mh.ma_lh.ToString();
                txt_mamonhoc.Text = mh.ma_mh;
                txt_magiangvien.Text = mh.ma_gv;
                txt_mahocky.Text = mh.ma_hk;
            }
            txt_malophoc.Enabled = false;
            btn_themlophoc.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoalophoc.Enabled = true;
        }

        private void btn_themlophoc_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                List<giang_vien> magv = db.giang_vien.Where(x => x.ma_gv.Equals(txt_magiangvien.Text)).ToList();
                List<mon_hoc> mamh = db.mon_hoc.Where(x => x.ma_mh.Equals(txt_mamonhoc.Text)).ToList();
                List<hoc_ky> mahk = db.hoc_ky.Where(x => x.ma_hk.Equals(txt_mahocky.Text)).ToList();
                if (txt_mamonhoc.Text == "" || txt_mahocky.Text == "" || txt_magiangvien.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lop_hoc them = new lop_hoc();
                    if (!magv.Any())
                    {
                        MessageBox.Show("không tồn tại mã giảng viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        them.ma_gv = txt_magiangvien.Text;
                        if (!mamh.Any())
                        {
                            MessageBox.Show("không tồn tại mã môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            them.ma_mh = txt_mamonhoc.Text;
                            if (!mahk.Any())
                            {
                                MessageBox.Show("không tồn tại mã học kỳ này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                them.ma_hk = txt_mahocky.Text;
                                db.lop_hoc.Add(them);
                                db.SaveChanges();
                                MessageBox.Show("thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                updategv();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_malophoc.Text = "";
            txt_magiangvien.Text = "";
            txt_mamonhoc.Text = "";
            txt_mahocky.Text = "";
            txt_timkiem.Text = "";
            txt_malophoc.Enabled = false;
            btn_themlophoc.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoalophoc.Enabled = false;
            updategv();
        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                List<giang_vien> magv = db.giang_vien.Where(x => x.ma_gv.Equals(txt_magiangvien.Text)).ToList();
                List<mon_hoc> mamh = db.mon_hoc.Where(x => x.ma_mh.Equals(txt_mamonhoc.Text)).ToList();
                List<hoc_ky> mahk = db.hoc_ky.Where(x => x.ma_hk.Equals(txt_mahocky.Text)).ToList();
                if (txt_mamonhoc.Text == "" || txt_mahocky.Text == "" || txt_magiangvien.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lop_hoc them = db.lop_hoc.Where(x => x.ma_lh.ToString() == txt_malophoc.Text).FirstOrDefault();
                    if (!magv.Any())
                    {
                        MessageBox.Show("không tồn tại mã giảng viên này");
                    }
                    else
                    {
                        them.ma_gv = txt_magiangvien.Text;
                        if (!mamh.Any())
                        {
                            MessageBox.Show("không tồn tại mã môn học này");
                        }
                        else
                        {
                            them.ma_mh = txt_mamonhoc.Text;
                            if (!mahk.Any())
                            {
                                MessageBox.Show("không tồn tại mã học kỳ này");
                            }
                            else
                            {
                                them.ma_hk = txt_mahocky.Text;
                                db.SaveChanges();
                                MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            updategv();
        }

        private void btn_xoalophoc_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    lop_hoc them = db.lop_hoc.Where(x => x.ma_lh.ToString() == txt_malophoc.Text).FirstOrDefault();
                    db.lop_hoc.Remove(them);
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                lop_hoc hk = db.lop_hoc.Where(malh => malh.ma_lh.ToString() == txt_timkiem.Text).FirstOrDefault();
                List<lop_hoc> list = db.lop_hoc.Where(sv => sv.ma_lh.ToString() == txt_timkiem.Text).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("lớp học này không tồn tại trong danh mục");
                    }
                    else
                    {
                        txt_malophoc.Text = hk.ma_lh.ToString();
                        txt_mamonhoc.Text = hk.ma_mh;
                        txt_mahocky.Text = hk.ma_hk;
                        txt_magiangvien.Text = hk.ma_gv;
                        dataGridView1.Rows.Clear();
                        list.ForEach(sv =>
                        {
                            dataGridView1.Rows.Add(
                                                    sv.ma_lh,
                                                    sv.ma_mh,
                                                    sv.ma_gv,
                                                    sv.ma_hk
                                                    );
                        });
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("lớp học này không tồn tại trong danh mục");
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
