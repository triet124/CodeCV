﻿
namespace DUAN1
{
    partial class ChiTietHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHangHoa));
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbMau = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtenhanghoa = new System.Windows.Forms.Label();
            this.lbmahanghoa = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGianhap = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.ptbHinh = new System.Windows.Forms.PictureBox();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.ptbQR = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuuQR = new System.Windows.Forms.Button();
            this.btnTaoQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(1057, 479);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(160, 62);
            this.btnhuy.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnhuy, "Hủy");
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsua.Enabled = false;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(812, 479);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(160, 64);
            this.btnsua.TabIndex = 79;
            this.toolTip1.SetToolTip(this.btnsua, "Sửa");
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1665, 479);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(160, 62);
            this.btntimkiem.TabIndex = 78;
            this.toolTip1.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimkiem.Location = new System.Drawing.Point(1225, 479);
            this.tbtimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(599, 63);
            this.tbtimkiem.TabIndex = 77;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(644, 479);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(160, 64);
            this.btnluu.TabIndex = 76;
            this.toolTip1.SetToolTip(this.btnluu, "Lưu");
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(476, 479);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(160, 64);
            this.btnthem.TabIndex = 75;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaHH,
            this.Size,
            this.Mau,
            this.GiaNhap,
            this.GiaBan,
            this.Hinh,
            this.SL});
            this.dataGridView1.Location = new System.Drawing.Point(16, 567);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(2287, 575);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "Mã Hàng Hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Mau
            // 
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hình";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(724, 11);
            this.label3.MaximumSize = new System.Drawing.Size(1453, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(822, 61);
            this.label3.TabIndex = 332;
            this.label3.Text = "QUẢN LÝ CHI TIẾT HÀNG HÓA";
            // 
            // tbMau
            // 
            this.tbMau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMau.Location = new System.Drawing.Point(673, 361);
            this.tbMau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMau.Multiline = true;
            this.tbMau.Name = "tbMau";
            this.tbMau.Size = new System.Drawing.Size(186, 32);
            this.tbMau.TabIndex = 340;
            // 
            // tbSize
            // 
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSize.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.Location = new System.Drawing.Point(673, 281);
            this.tbSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSize.Multiline = true;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(186, 34);
            this.tbSize.TabIndex = 339;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(428, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 338;
            this.label1.Text = "Màu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(428, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 337;
            this.label2.Text = "Size:";
            // 
            // lbtenhanghoa
            // 
            this.lbtenhanghoa.AutoSize = true;
            this.lbtenhanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtenhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenhanghoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenhanghoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbtenhanghoa.Location = new System.Drawing.Point(428, 212);
            this.lbtenhanghoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtenhanghoa.Name = "lbtenhanghoa";
            this.lbtenhanghoa.Size = new System.Drawing.Size(195, 32);
            this.lbtenhanghoa.TabIndex = 336;
            this.lbtenhanghoa.Text = "Tên hàng hóa :";
            // 
            // lbmahanghoa
            // 
            this.lbmahanghoa.AutoSize = true;
            this.lbmahanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbmahanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmahanghoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahanghoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbmahanghoa.Location = new System.Drawing.Point(428, 144);
            this.lbmahanghoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmahanghoa.Name = "lbmahanghoa";
            this.lbmahanghoa.Size = new System.Drawing.Size(54, 32);
            this.lbmahanghoa.TabIndex = 334;
            this.lbmahanghoa.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(673, 142);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(186, 34);
            this.tbID.TabIndex = 333;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(880, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 346;
            this.label4.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(880, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 344;
            this.label6.Text = "Giá bán:";
            // 
            // tbGiaban
            // 
            this.tbGiaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGiaban.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaban.Location = new System.Drawing.Point(1068, 254);
            this.tbGiaban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGiaban.Multiline = true;
            this.tbGiaban.Name = "tbGiaban";
            this.tbGiaban.Size = new System.Drawing.Size(209, 32);
            this.tbGiaban.TabIndex = 343;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(880, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 32);
            this.label7.TabIndex = 342;
            this.label7.Text = "Giá nhập:";
            // 
            // tbGianhap
            // 
            this.tbGianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGianhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGianhap.Location = new System.Drawing.Point(1068, 183);
            this.tbGianhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGianhap.Multiline = true;
            this.tbGianhap.Name = "tbGianhap";
            this.tbGianhap.Size = new System.Drawing.Size(209, 34);
            this.tbGianhap.TabIndex = 341;
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(1068, 325);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSL.Multiline = true;
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(146, 32);
            this.tbSL.TabIndex = 347;
            // 
            // ptbHinh
            // 
            this.ptbHinh.Image = ((System.Drawing.Image)(resources.GetObject("ptbHinh.Image")));
            this.ptbHinh.Location = new System.Drawing.Point(1320, 114);
            this.ptbHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbHinh.MaximumSize = new System.Drawing.Size(300, 300);
            this.ptbHinh.MinimumSize = new System.Drawing.Size(300, 300);
            this.ptbHinh.Name = "ptbHinh";
            this.ptbHinh.Size = new System.Drawing.Size(300, 300);
            this.ptbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHinh.TabIndex = 348;
            this.ptbHinh.TabStop = false;
            this.ptbHinh.Click += new System.EventHandler(this.ptbHinh_Click);
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Location = new System.Drawing.Point(673, 212);
            this.cbbTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(185, 34);
            this.cbbTenHang.TabIndex = 349;
            // 
            // ptbQR
            // 
            this.ptbQR.Location = new System.Drawing.Point(1657, 181);
            this.ptbQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbQR.MaximumSize = new System.Drawing.Size(149, 150);
            this.ptbQR.MinimumSize = new System.Drawing.Size(149, 150);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(149, 150);
            this.ptbQR.TabIndex = 350;
            this.ptbQR.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1628, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 32);
            this.label5.TabIndex = 351;
            this.label5.Text = "Mã QR của SP";
            // 
            // btnLuuQR
            // 
            this.btnLuuQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuQR.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQR.Location = new System.Drawing.Point(1634, 359);
            this.btnLuuQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuQR.Name = "btnLuuQR";
            this.btnLuuQR.Size = new System.Drawing.Size(92, 39);
            this.btnLuuQR.TabIndex = 352;
            this.btnLuuQR.Text = "Lưu QR";
            this.btnLuuQR.UseVisualStyleBackColor = true;
            this.btnLuuQR.Click += new System.EventHandler(this.btnLuuQR_Click);
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoQR.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQR.Location = new System.Drawing.Point(1749, 359);
            this.btnTaoQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(92, 39);
            this.btnTaoQR.TabIndex = 353;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // ChiTietHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnTaoQR);
            this.Controls.Add(this.btnLuuQR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptbQR);
            this.Controls.Add(this.cbbTenHang);
            this.Controls.Add(this.ptbHinh);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGiaban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGianhap);
            this.Controls.Add(this.tbMau);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtenhanghoa);
            this.Controls.Add(this.lbmahanghoa);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(175, 65);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChiTietHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KhoHang_HangHoa";
            this.Load += new System.EventHandler(this.ChiTietHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMau;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtenhanghoa;
        private System.Windows.Forms.Label lbmahanghoa;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGianhap;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.PictureBox ptbHinh;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.PictureBox ptbQR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuuQR;
        private System.Windows.Forms.Button btnTaoQR;
    }
}