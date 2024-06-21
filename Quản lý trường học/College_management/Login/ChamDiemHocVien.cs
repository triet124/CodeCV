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
    public partial class ChamDiemHocVien : Form
    {
        public ChamDiemHocVien(String user)
        {
            InitializeComponent();
            label5.Text = user;
        }

        private void ChamDiemHocVien_Load(object sender, EventArgs e)
        {
            updategv();
            txt_mahocvien.Enabled = false;
            txt_malophoc.Enabled = false;
            txt_masinhvien.Enabled = false;
        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                dataGridView1.Rows.Clear();
                var data = from hv in db.hoc_vien
                           join lh in db.lop_hoc on hv.ma_lh equals lh.ma_lh
                           join gv in db.giang_vien on lh.ma_gv equals gv.ma_gv
                           where gv.ma_gv == label5.Text
                           select new
                           {
                               hv.ma_hv,
                               hv.ma_sv,
                               hv.ma_lh,
                               hv.diem,
                               hv.nhan_xet
                           };


                foreach (var item in data)
                {
                    dataGridView1.Rows.Add(item.ma_hv,
                                           item.ma_sv,
                                           item.ma_lh,
                                           item.diem,
                                           item.nhan_xet);
                }

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
        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                List<lop_hoc> malh = db.lop_hoc.Where(x => x.ma_lh.ToString().Equals(txt_malophoc.Text)).ToList();
                if (txt_diem.Text == "" || txt_nhanxet.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    hoc_vien them = db.hoc_vien.Where(x => x.ma_hv.ToString() == txt_mahocvien.Text).FirstOrDefault();
                    them.diem = double.Parse(txt_diem.Text);
                    them.nhan_xet = txt_nhanxet.Text;
                    db.SaveChanges();
                    MessageBox.Show("chấm điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                updategv();
            }
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
                        MessageBox.Show("học viên này không tồn tại trong danh mục", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            QuanLyThongTinCaNhanGiangVien form = new QuanLyThongTinCaNhanGiangVien(label5.Text);
            form.ShowDialog();
            this.Close();
        }

        private void btn_xoahocvien_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
