﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DUAN1
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            //usernamenv.Text = username;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                updatedgv();
                tbmanhanvien.Enabled = false;
            }
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;

            tbcv.ReadOnly = true;
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.Enabled = false;
        }

        private void updatedgv()
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                dataGridView1.Rows.Clear();

                db.nhan_vien.ToList().ForEach(nv =>
                    dataGridView1.Rows.Add(
                        nv.ma_nv,
                        nv.ten_nv,
                        nv.sdt,
                        nv.email
                   )
                );
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;

            tbcv.ReadOnly = false;
            tbmanhanvien.ReadOnly = false;
            tbtennhanvien.ReadOnly = false;
            tbsdt.Enabled = true;
            tbmanhanvien.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (tbmanhanvien.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                nhan_vien them = new nhan_vien();
                them.ma_nv = tbmanhanvien.Text;
                them.ten_nv = tbtennhanvien.Text;
                them.sdt = tbsdt.Text;
                them.email = tbcv.Text;
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    nhan_vien nv = db.nhan_vien
                        .Where(x => x.ma_nv == tbmanhanvien.Text)
                        .FirstOrDefault();

                    if (nv == null) // Check if the record doesn't exist
                    {
                        db.nhan_vien.Add(them);
                        db.SaveChanges();
                        updatedgv();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                    }
                }

            }
            updatedgv();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                nhan_vien them = db.nhan_vien
                    .Where(x => x.ma_nv == tbmanhanvien.Text)
                    .FirstOrDefault();

                if (them != null)
                {
                    them.ma_nv = tbmanhanvien.Text;
                    them.ten_nv = tbtennhanvien.Text;
                    them.sdt = tbsdt.Text;
                    them.email = tbcv.Text;

                    db.SaveChanges();
                }
            }
            MessageBox.Show("Sửa thành công");
            updatedgv();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                nhan_vien xoa = db.nhan_vien.Where(x => x.ma_nv == tbmanhanvien.Text).FirstOrDefault();
                db.nhan_vien.Remove(xoa);
                db.SaveChanges();
            }
            updatedgv();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;

            tbcv.ReadOnly = true;
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.Enabled = false;

            tbmanhanvien.Text = "";
            tbtennhanvien.Text = "";
            tbsdt.Text = "";
            tbcv.Text = " ";

            updatedgv();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbtimkiem.Text.Equals(""))
                {
                    tbtimkiem.Text = "";
                }

                //using (DUAN1Entities db = new DUAN1Entities())
                //{
                //    List<nhan_vien> listhd = db.nhan_vien.Where(x => x.ma_nv.Equals(tbtimkiem.Text)).ToList();
                //    dataGridView1.Rows.Clear();
                //    listhd.ToList().ForEach(hd =>
                //    {
                //        dataGridView1.Rows.Add(
                //        hd.ma_nv,
                //        hd.ten_nv,
                //        hd.sdt,
                //        hd.tai_khoan_dangnhap
                //       );
                //    }
                //    );
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
            updatedgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            String Manv = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv == Manv).FirstOrDefault();
                tbmanhanvien.Text = nv.ma_nv;
                tbtennhanvien.Text = nv.ten_nv;
                tbsdt.Text = nv.sdt;
                tbcv.Text = nv.email;
            }

            btnthem.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            tbmanhanvien.ReadOnly = true;

        }
        //private void btnthoat_Click(object sender, EventArgs e)
        //{
        //    //Nút thoát ra ngoài form Đăng nhập
        //    this.Hide();
        //    Login form = new Login();
        //    form.ShowDialog();
        //    this.Close();
        //}
        //private void btnhanghoa_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(usernamenv.Text);
        //    quanLyHangHoa.ShowDialog();
        //    this.Close();
        //}

        //private void btnkhohang_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ChiTietHangHoa khhh = new ChiTietHangHoa(usernamenv.Text);
        //    khhh.ShowDialog();
        //    this.Close();
        //}

        //private void btnhoadon_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyHoaDon qlhd = new QuanLyHoaDon(usernamenv.Text);
        //    qlhd.ShowDialog();
        //    this.Close();
        //}

        //private void btnnhanvien_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyNhanVien qlnv = new QuanLyNhanVien(usernamenv.Text);
        //    qlnv.ShowDialog();
        //    this.Close();
        //}

        //private void btnkhachhang_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyKhachHang qlkh = new QuanLyKhachHang(usernamenv.Text);
        //    qlkh.ShowDialog();
        //    this.Close();
        //}

        //private void btnthongke_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ThongKe tk = new ThongKe(usernamenv.Text);
        //    tk.ShowDialog();
        //    this.Close();
        //}

        //private void btnthongtinnv_Click(object sender, EventArgs e)
        //{
        //    ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(usernamenv.Text);
        //    this.Hide();
        //    tinNhanVien.ShowDialog();
        //    this.Close();
        //}

        //private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        //{
        //    ChiTietHoaDon tinNhanVien = new ChiTietHoaDon(usernamenv.Text);
        //    this.Hide();
        //    tinNhanVien.ShowDialog();
        //    this.Close();
        //}

        private void lbmanhanvien_Click(object sender, EventArgs e)
        {

        }

        private void tbmanhanvien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
