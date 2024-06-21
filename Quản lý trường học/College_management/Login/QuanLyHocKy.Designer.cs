
namespace Login
{
    partial class QuanLyHocKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHocKy));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bat_dau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ket_thuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_suathongtin = new System.Windows.Forms.Button();
            this.btn_xoahocky = new System.Windows.Forms.Button();
            this.btn_themhocky = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_batdau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mahocky = new System.Windows.Forms.TextBox();
            this.txt_tenhocky = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hk,
            this.ten_hk,
            this.bat_dau,
            this.ket_thuc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 460);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_hk
            // 
            this.ma_hk.HeaderText = "Mã học kỳ";
            this.ma_hk.MinimumWidth = 8;
            this.ma_hk.Name = "ma_hk";
            this.ma_hk.Width = 150;
            // 
            // ten_hk
            // 
            this.ten_hk.HeaderText = "Tên học kỳ";
            this.ten_hk.MinimumWidth = 8;
            this.ten_hk.Name = "ten_hk";
            this.ten_hk.Width = 150;
            // 
            // bat_dau
            // 
            this.bat_dau.HeaderText = "Bắt đầu";
            this.bat_dau.MinimumWidth = 8;
            this.bat_dau.Name = "bat_dau";
            this.bat_dau.Width = 150;
            // 
            // ket_thuc
            // 
            this.ket_thuc.HeaderText = "Kết thúc";
            this.ket_thuc.MinimumWidth = 8;
            this.ket_thuc.Name = "ket_thuc";
            this.ket_thuc.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.btn_refresh);
            this.groupBox3.Controls.Add(this.btn_suathongtin);
            this.groupBox3.Controls.Add(this.btn_xoahocky);
            this.groupBox3.Controls.Add(this.btn_themhocky);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(13, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(809, 86);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btn_refresh
            // 
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(653, 24);
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
            this.btn_suathongtin.Image = ((System.Drawing.Image)(resources.GetObject("btn_suathongtin.Image")));
            this.btn_suathongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtin.Location = new System.Drawing.Point(240, 25);
            this.btn_suathongtin.Name = "btn_suathongtin";
            this.btn_suathongtin.Size = new System.Drawing.Size(141, 52);
            this.btn_suathongtin.TabIndex = 4;
            this.btn_suathongtin.Text = "Sửa thông tin ";
            this.btn_suathongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suathongtin.UseVisualStyleBackColor = true;
            this.btn_suathongtin.Click += new System.EventHandler(this.btn_suathongtin_Click);
            // 
            // btn_xoahocky
            // 
            this.btn_xoahocky.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoahocky.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoahocky.Image")));
            this.btn_xoahocky.Location = new System.Drawing.Point(438, 25);
            this.btn_xoahocky.Name = "btn_xoahocky";
            this.btn_xoahocky.Size = new System.Drawing.Size(147, 52);
            this.btn_xoahocky.TabIndex = 5;
            this.btn_xoahocky.Text = "Xóa học kỳ";
            this.btn_xoahocky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoahocky.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoahocky.UseVisualStyleBackColor = true;
            this.btn_xoahocky.Click += new System.EventHandler(this.btn_xoahocky_Click);
            // 
            // btn_themhocky
            // 
            this.btn_themhocky.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themhocky.Image = ((System.Drawing.Image)(resources.GetObject("btn_themhocky.Image")));
            this.btn_themhocky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themhocky.Location = new System.Drawing.Point(19, 25);
            this.btn_themhocky.Name = "btn_themhocky";
            this.btn_themhocky.Size = new System.Drawing.Size(159, 52);
            this.btn_themhocky.TabIndex = 3;
            this.btn_themhocky.Text = "Thêm học kỳ";
            this.btn_themhocky.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themhocky.UseVisualStyleBackColor = true;
            this.btn_themhocky.Click += new System.EventHandler(this.btn_themhocky_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.dtp_ketthuc);
            this.groupBox1.Controls.Add(this.dtp_batdau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mahocky);
            this.groupBox1.Controls.Add(this.txt_tenhocky);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 349);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học kỳ";
            // 
            // dtp_ketthuc
            // 
            this.dtp_ketthuc.Location = new System.Drawing.Point(835, 149);
            this.dtp_ketthuc.Name = "dtp_ketthuc";
            this.dtp_ketthuc.Size = new System.Drawing.Size(515, 26);
            this.dtp_ketthuc.TabIndex = 13;
            // 
            // dtp_batdau
            // 
            this.dtp_batdau.Location = new System.Drawing.Point(835, 96);
            this.dtp_batdau.Name = "dtp_batdau";
            this.dtp_batdau.Size = new System.Drawing.Size(515, 26);
            this.dtp_batdau.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kết thúc:";
            // 
            // txt_mahocky
            // 
            this.txt_mahocky.Location = new System.Drawing.Point(156, 96);
            this.txt_mahocky.Name = "txt_mahocky";
            this.txt_mahocky.Size = new System.Drawing.Size(509, 26);
            this.txt_mahocky.TabIndex = 6;
            // 
            // txt_tenhocky
            // 
            this.txt_tenhocky.Location = new System.Drawing.Point(156, 149);
            this.txt_tenhocky.Name = "txt_tenhocky";
            this.txt_tenhocky.Size = new System.Drawing.Size(509, 26);
            this.txt_tenhocky.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(726, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã mã học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 64);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản lý học kỳ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.btn_timkiem);
            this.groupBox4.Controls.Add(this.txt_timkiem);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(828, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 86);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
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
            this.txt_timkiem.Location = new System.Drawing.Point(19, 36);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(359, 26);
            this.txt_timkiem.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1349, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(13, 9);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(119, 41);
            this.btn_trove.TabIndex = 31;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // QuanLyHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 1024);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1440, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1006);
            this.Name = "QuanLyHocKy";
            this.Text = "QuanLyHocKy";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.QuanLyHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_suathongtin;
        private System.Windows.Forms.Button btn_xoahocky;
        private System.Windows.Forms.Button btn_themhocky;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mahocky;
        private System.Windows.Forms.TextBox txt_tenhocky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hk;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_dau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ket_thuc;
        private System.Windows.Forms.DateTimePicker dtp_ketthuc;
        private System.Windows.Forms.DateTimePicker dtp_batdau;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_trove;
    }
}