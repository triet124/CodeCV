
namespace Login
{
    partial class QuanLyLopHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_lh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_hk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mahocky = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mamonhoc = new System.Windows.Forms.TextBox();
            this.txt_magiangvien = new System.Windows.Forms.TextBox();
            this.txt_malophoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_suathongtin = new System.Windows.Forms.Button();
            this.btn_xoalophoc = new System.Windows.Forms.Button();
            this.btn_themlophoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_lh,
            this.ma_mh,
            this.ma_gv,
            this.ma_hk});
            this.dataGridView1.Location = new System.Drawing.Point(12, 552);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 460);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_lh
            // 
            this.ma_lh.HeaderText = "Mã lớp học";
            this.ma_lh.MinimumWidth = 8;
            this.ma_lh.Name = "ma_lh";
            this.ma_lh.Width = 150;
            // 
            // ma_mh
            // 
            this.ma_mh.HeaderText = "Mã môn học";
            this.ma_mh.MinimumWidth = 8;
            this.ma_mh.Name = "ma_mh";
            this.ma_mh.Width = 150;
            // 
            // ma_gv
            // 
            this.ma_gv.HeaderText = "Mã giảng viên";
            this.ma_gv.MinimumWidth = 8;
            this.ma_gv.Name = "ma_gv";
            this.ma_gv.Width = 150;
            // 
            // ma_hk
            // 
            this.ma_hk.HeaderText = "Mã học kỳ";
            this.ma_hk.MinimumWidth = 8;
            this.ma_hk.Name = "ma_hk";
            this.ma_hk.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txt_mahocky);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mamonhoc);
            this.groupBox1.Controls.Add(this.txt_magiangvien);
            this.groupBox1.Controls.Add(this.txt_malophoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 349);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // txt_mahocky
            // 
            this.txt_mahocky.Location = new System.Drawing.Point(818, 194);
            this.txt_mahocky.Name = "txt_mahocky";
            this.txt_mahocky.Size = new System.Drawing.Size(524, 26);
            this.txt_mahocky.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã học kỳ:";
            // 
            // txt_mamonhoc
            // 
            this.txt_mamonhoc.Location = new System.Drawing.Point(818, 136);
            this.txt_mamonhoc.Name = "txt_mamonhoc";
            this.txt_mamonhoc.Size = new System.Drawing.Size(524, 26);
            this.txt_mamonhoc.TabIndex = 9;
            // 
            // txt_magiangvien
            // 
            this.txt_magiangvien.Location = new System.Drawing.Point(163, 189);
            this.txt_magiangvien.Name = "txt_magiangvien";
            this.txt_magiangvien.Size = new System.Drawing.Size(509, 26);
            this.txt_magiangvien.TabIndex = 6;
            // 
            // txt_malophoc
            // 
            this.txt_malophoc.Location = new System.Drawing.Point(163, 136);
            this.txt_malophoc.Name = "txt_malophoc";
            this.txt_malophoc.Size = new System.Drawing.Size(509, 26);
            this.txt_malophoc.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã giảng viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 64);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản lý lớp học";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.btn_timkiem);
            this.groupBox4.Controls.Add(this.txt_timkiem);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(828, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 86);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiem.Image = global::Login.Properties.Resources.Search;
            this.btn_timkiem.Location = new System.Drawing.Point(405, 23);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(141, 52);
            this.btn_timkiem.TabIndex = 6;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(6, 36);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(372, 26);
            this.txt_timkiem.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.btn_refresh);
            this.groupBox3.Controls.Add(this.btn_suathongtin);
            this.groupBox3.Controls.Add(this.btn_xoalophoc);
            this.groupBox3.Controls.Add(this.btn_themlophoc);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 86);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btn_refresh
            // 
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Image = global::Login.Properties.Resources.Refresh;
            this.btn_refresh.Location = new System.Drawing.Point(623, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(141, 52);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_suathongtin
            // 
            this.btn_suathongtin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_suathongtin.Image = global::Login.Properties.Resources.Edit;
            this.btn_suathongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtin.Location = new System.Drawing.Point(222, 25);
            this.btn_suathongtin.Name = "btn_suathongtin";
            this.btn_suathongtin.Size = new System.Drawing.Size(141, 52);
            this.btn_suathongtin.TabIndex = 4;
            this.btn_suathongtin.Text = "Sửa thông tin ";
            this.btn_suathongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suathongtin.UseVisualStyleBackColor = true;
            this.btn_suathongtin.Click += new System.EventHandler(this.btn_suathongtin_Click);
            // 
            // btn_xoalophoc
            // 
            this.btn_xoalophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoalophoc.Image = global::Login.Properties.Resources.Delete;
            this.btn_xoalophoc.Location = new System.Drawing.Point(420, 25);
            this.btn_xoalophoc.Name = "btn_xoalophoc";
            this.btn_xoalophoc.Size = new System.Drawing.Size(141, 52);
            this.btn_xoalophoc.TabIndex = 5;
            this.btn_xoalophoc.Text = "Xóa lớp học";
            this.btn_xoalophoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoalophoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoalophoc.UseVisualStyleBackColor = true;
            this.btn_xoalophoc.Click += new System.EventHandler(this.btn_xoalophoc_Click);
            // 
            // btn_themlophoc
            // 
            this.btn_themlophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themlophoc.Image = global::Login.Properties.Resources.Add;
            this.btn_themlophoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themlophoc.Location = new System.Drawing.Point(10, 25);
            this.btn_themlophoc.Name = "btn_themlophoc";
            this.btn_themlophoc.Size = new System.Drawing.Size(150, 52);
            this.btn_themlophoc.TabIndex = 3;
            this.btn_themlophoc.Text = "Thêm lớp học";
            this.btn_themlophoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themlophoc.UseVisualStyleBackColor = true;
            this.btn_themlophoc.Click += new System.EventHandler(this.btn_themlophoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(12, 9);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(119, 41);
            this.btn_trove.TabIndex = 33;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources._3409297;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 1024);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1440, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1006);
            this.Name = "QuanLyLopHoc";
            this.Text = "QuanLyLopHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mahocky;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mamonhoc;
        private System.Windows.Forms.TextBox txt_magiangvien;
        private System.Windows.Forms.TextBox txt_malophoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_suathongtin;
        private System.Windows.Forms.Button btn_xoalophoc;
        private System.Windows.Forms.Button btn_themlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_trove;
    }
}