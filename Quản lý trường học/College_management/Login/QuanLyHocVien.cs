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
    public partial class QuanLyHocVien : Form
    {
        public QuanLyHocVien(String user)
        {
            InitializeComponent();
            label5.Text = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyHocVien_Load(object sender, EventArgs e)
        {
            updategv();
            txt_mahocvien.Enabled = false;
        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                dataGridView1.Rows.Clear();
                db.hoc_vien.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_hv,
                        kh.ma_sv,
                        kh.ma_lh,
                        kh.diem,
                        kh.nhan_xet
                        );
                });

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String Mahv = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                hoc_vien kh = db.hoc_vien.Where(x => x.ma_hv.ToString() == Mahv).FirstOrDefault();
                txt_mahocvien.Text = kh.ma_hv.ToString();
                txt_masinhvien.Text = kh.ma_sv;
                txt_malophoc.Text = kh.ma_lh.ToString();
                txt_diem.Text = kh.diem.ToString();
                txt_nhanxet.Text = kh.nhan_xet;
            }
            btn_themhocvien.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoahocvien.Enabled = true;
        }

        private void btn_themlophoc_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                List<lop_hoc> malh = db.lop_hoc.Where(x => x.ma_lh.ToString().Equals(txt_malophoc.Text)).ToList();
                List<sinh_vien> masv = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList();
                if (txt_masinhvien.Text == "" || txt_malophoc.Text == "" || txt_diem.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    hoc_vien them = new hoc_vien();
                    if (!malh.Any())
                    {
                        MessageBox.Show("không tồn tại mã lớp học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        them.ma_lh = int.Parse(txt_malophoc.Text);
                        if (!masv.Any())
                        {
                            MessageBox.Show("không tồn tại mã sinh viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            them.ma_sv = txt_masinhvien.Text;
                            if (int.Parse(txt_diem.Text) < 0 || int.Parse(txt_diem.Text) > 10)
                            {
                                MessageBox.Show("điểm không được nhỏ hơn 0 và lớn hơn 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                them.diem = double.Parse(txt_diem.Text);
                                them.nhan_xet = txt_nhanxet.Text;
                                db.hoc_vien.Add(them);
                                db.SaveChanges();
                                MessageBox.Show("thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                updategv();
            }
        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                List<lop_hoc> malh = db.lop_hoc.Where(x => x.ma_lh.ToString().Equals(txt_malophoc.Text)).ToList();
                List<sinh_vien> masv = db.sinh_vien.Where(x => x.ma_sv.Equals(txt_masinhvien.Text)).ToList();
                if (txt_masinhvien.Text == "" || txt_malophoc.Text == "" || txt_diem.Text == "" )
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    hoc_vien them = db.hoc_vien.Where(x => x.ma_hv.ToString() == txt_mahocvien.Text).FirstOrDefault();
                    if (!malh.Any())
                    {
                        MessageBox.Show("không tồn tại mã lớp học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        them.ma_lh = int.Parse(txt_malophoc.Text);
                        if (!masv.Any())
                        {
                            MessageBox.Show("không tồn tại mã sinh viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            them.ma_sv = txt_masinhvien.Text;
                            if (int.Parse(txt_diem.Text) < 0 || int.Parse(txt_diem.Text) > 10)
                            {
                                MessageBox.Show("điểm không được nhỏ hơn 0 và lớn hơn 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                them.diem = double.Parse(txt_diem.Text);
                                them.nhan_xet = txt_nhanxet.Text;
                                db.SaveChanges();
                                MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                updategv();
            }
        }

        private void btn_xoalophoc_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    hoc_vien them = db.hoc_vien.Where(x => x.ma_hv.ToString() == txt_mahocvien.Text).FirstOrDefault();
                    db.hoc_vien.Remove(them);
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_mahocvien.Text = "";
            txt_malophoc.Text = "";
            txt_masinhvien.Text = "";
            txt_diem.Text = "";
            txt_nhanxet.Text = "";
            btn_themhocvien.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoahocvien.Enabled = false;
            updategv();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                hoc_vien hk = db.hoc_vien.Where(x => x.ma_sv.ToString() == txt_timkiem.Text).FirstOrDefault();
                List<hoc_vien> list = db.hoc_vien.Where(sv => sv.ma_sv.ToString() == txt_timkiem.Text).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("học viên này không tồn tại trong danh mục","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        txt_mahocvien.Text = hk.ma_hv.ToString();
                        txt_malophoc.Text = hk.ma_lh.ToString();
                        txt_masinhvien.Text = hk.ma_sv;
                        txt_diem.Text = hk.diem.ToString();
                        txt_nhanxet.Text = hk.nhan_xet;
                        dataGridView1.Rows.Clear();
                        list.ForEach(sv =>
                        {
                            dataGridView1.Rows.Add(
                             sv.ma_hv,
                             sv.ma_sv,
                             sv.ma_lh,
                             sv.diem,
                             sv.nhan_xet
                              );
                        });
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("học viên này không tồn tại trong danh mục", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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
    }
}
