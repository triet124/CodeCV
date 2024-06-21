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
    public partial class QuanLyHocKy : Form
    {
        public QuanLyHocKy(String user)
        {
            InitializeComponent();
            label4.Text = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyHocKy_Load(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                updategv();
            }
            btn_suathongtin.Enabled = false;
            btn_xoahocky.Enabled = false;
            btn_themhocky.Enabled = true;
            txt_mahocky.Enabled = true;
        }
        private void updategv()
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {

                dataGridView1.Rows.Clear();
                db.hoc_ky.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_hk,
                        kh.ten_hk,
                        kh.bat_dau.ToShortDateString(),
                        kh.ket_thuc.ToShortDateString()
                          );
                }
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtp_batdau.Format = DateTimePickerFormat.Custom;
            dtp_ketthuc.Format = DateTimePickerFormat.Custom;
            dtp_batdau.CustomFormat = "dd/MM/yyyy";
            dtp_ketthuc.CustomFormat = "dd/MM/yyyy";

            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowdata = dataGridView1.Rows[row];
            String Mahk = rowdata.Cells[0].Value.ToString();
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                hoc_ky kh = db.hoc_ky.Where(x => x.ma_hk == Mahk).FirstOrDefault();
                txt_mahocky.Text = kh.ma_hk;
                txt_tenhocky.Text = kh.ten_hk;
                dtp_batdau.Text = kh.bat_dau.ToShortDateString();
                dtp_ketthuc.Text = kh.ket_thuc.ToShortDateString();
                
            }
            btn_themhocky.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoahocky.Enabled = true;
            txt_mahocky.Enabled = false;
        }

        private void btn_themhocky_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    if (txt_mahocky.Text == "" || txt_tenhocky.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
                        hoc_ky them = new hoc_ky();
                        them.ma_hk = txt_mahocky.Text;
                        them.ten_hk = txt_tenhocky.Text;
                        them.bat_dau = dtp_batdau.Value;
                        them.ket_thuc = dtp_ketthuc.Value;
                        db.hoc_ky.Add(them);
                        db.SaveChanges();
                        updategv();
                        MessageBox.Show("thêm thành công");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã học kỳ đã tồn tại vui lòng thử mã khác");
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                hoc_ky them = db.hoc_ky.Where(x => x.ma_hk == txt_mahocky.Text).FirstOrDefault();
                them.ma_hk = txt_mahocky.Text;
                them.ten_hk = txt_tenhocky.Text;
                them.bat_dau = dtp_batdau.Value;
                them.ket_thuc = dtp_ketthuc.Value;
                db.SaveChanges();
            }
            MessageBox.Show("sửa thành công");
            updategv();
        }

        private void btn_xoahocky_Click(object sender, EventArgs e)
        {
            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                try
                {
                    hoc_ky xoa = db.hoc_ky.Where(x => x.ma_hk == txt_mahocky.Text).FirstOrDefault();
                    db.hoc_ky.Remove(xoa);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            updategv();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_mahocky.Text = "";
            txt_tenhocky.Text = "";
            dtp_batdau.Text = "";
            dtp_ketthuc.Text = "";
            txt_timkiem.Text = "";

            btn_themhocky.Enabled = true;
            btn_suathongtin.Enabled = false;
            btn_xoahocky.Enabled = false;
            txt_mahocky.Enabled = true;
            updategv();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            using (COLLEGE_MANAGEMENTEntities1 db = new COLLEGE_MANAGEMENTEntities1())
            {
                hoc_ky hk = db.hoc_ky.Where(mahk => mahk.ma_hk.Equals(txt_timkiem.Text)).FirstOrDefault();
                List<hoc_ky> list = db.hoc_ky.Where(sv => sv.ma_hk.Equals(txt_timkiem.Text)).ToList();

                try
                {
                    if (txt_timkiem.Text == "" || !list.Any())
                    {
                        MessageBox.Show("môn học này không tồn tại trong danh mục");
                    }
                    else
                    {
                        txt_mahocky.Text = hk.ma_hk;
                        txt_tenhocky.Text = hk.ten_hk;
                        dtp_batdau.Text = hk.bat_dau.ToShortDateString();
                        dtp_ketthuc.Text = hk.ket_thuc.ToShortDateString();
                        dataGridView1.Rows.Clear(); 
                        list.ForEach(sv =>
                        {

                            dataGridView1.Rows.Add(
                                sv.ma_hk,
                                sv.ten_hk,
                                sv.bat_dau.ToShortDateString(),
                                sv.ket_thuc.ToShortDateString()
                                );
                        });
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("môn học này không tồn tại trong danh mục");
                }

            }
            txt_mahocky.Enabled = false;
            btn_themhocky.Enabled = false;
            btn_suathongtin.Enabled = true;
            btn_xoahocky.Enabled = true;
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
