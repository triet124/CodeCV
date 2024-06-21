
namespace Login
{
    partial class ChamDiemHocVien
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_suathongtin = new System.Windows.Forms.Button();
            this.btn_xoahocvien = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhan_xet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nhanxet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_masinhvien = new System.Windows.Forms.TextBox();
            this.txt_malophoc = new System.Windows.Forms.TextBox();
            this.txt_mahocvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.btn_timkiem);
            this.groupBox4.Controls.Add(this.txt_timkiem);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(831, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 86);
            this.groupBox4.TabIndex = 31;
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
            this.groupBox3.Controls.Add(this.btn_xoahocvien);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(15, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 86);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btn_refresh
            // 
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Image = global::Login.Properties.Resources.Refresh;
            this.btn_refresh.Location = new System.Drawing.Point(416, 23);
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
            this.btn_suathongtin.Location = new System.Drawing.Point(15, 23);
            this.btn_suathongtin.Name = "btn_suathongtin";
            this.btn_suathongtin.Size = new System.Drawing.Size(141, 52);
            this.btn_suathongtin.TabIndex = 4;
            this.btn_suathongtin.Text = "chấm điểm";
            this.btn_suathongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suathongtin.UseVisualStyleBackColor = true;
            this.btn_suathongtin.Click += new System.EventHandler(this.btn_suathongtin_Click);
            // 
            // btn_xoahocvien
            // 
            this.btn_xoahocvien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoahocvien.Image = global::Login.Properties.Resources.Delete;
            this.btn_xoahocvien.Location = new System.Drawing.Point(213, 23);
            this.btn_xoahocvien.Name = "btn_xoahocvien";
            this.btn_xoahocvien.Size = new System.Drawing.Size(141, 52);
            this.btn_xoahocvien.TabIndex = 5;
            this.btn_xoahocvien.Text = "Xóa học viên";
            this.btn_xoahocvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoahocvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoahocvien.UseVisualStyleBackColor = true;
            this.btn_xoahocvien.Click += new System.EventHandler(this.btn_xoahocvien_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hv,
            this.ma_sv,
            this.ma_lh,
            this.diem,
            this.nhan_xet});
            this.dataGridView1.Location = new System.Drawing.Point(15, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 460);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_hv
            // 
            this.ma_hv.HeaderText = "Mã học viên";
            this.ma_hv.MinimumWidth = 8;
            this.ma_hv.Name = "ma_hv";
            this.ma_hv.Width = 150;
            // 
            // ma_sv
            // 
            this.ma_sv.HeaderText = "Mã sinh viên";
            this.ma_sv.MinimumWidth = 8;
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.Width = 150;
            // 
            // ma_lh
            // 
            this.ma_lh.HeaderText = "Mã lớp học";
            this.ma_lh.MinimumWidth = 8;
            this.ma_lh.Name = "ma_lh";
            this.ma_lh.Width = 150;
            // 
            // diem
            // 
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 8;
            this.diem.Name = "diem";
            this.diem.Width = 150;
            // 
            // nhan_xet
            // 
            this.nhan_xet.HeaderText = "Nhận xet";
            this.nhan_xet.MinimumWidth = 8;
            this.nhan_xet.Name = "nhan_xet";
            this.nhan_xet.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txt_nhanxet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_masinhvien);
            this.groupBox1.Controls.Add(this.txt_malophoc);
            this.groupBox1.Controls.Add(this.txt_mahocvien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 257);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // txt_nhanxet
            // 
            this.txt_nhanxet.Location = new System.Drawing.Point(146, 149);
            this.txt_nhanxet.Multiline = true;
            this.txt_nhanxet.Name = "txt_nhanxet";
            this.txt_nhanxet.Size = new System.Drawing.Size(1179, 94);
            this.txt_nhanxet.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhận xét:";
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(801, 94);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(524, 26);
            this.txt_diem.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điểm:";
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Location = new System.Drawing.Point(801, 36);
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.Size = new System.Drawing.Size(524, 26);
            this.txt_masinhvien.TabIndex = 9;
            // 
            // txt_malophoc
            // 
            this.txt_malophoc.Location = new System.Drawing.Point(146, 89);
            this.txt_malophoc.Name = "txt_malophoc";
            this.txt_malophoc.Size = new System.Drawing.Size(509, 26);
            this.txt_malophoc.TabIndex = 6;
            // 
            // txt_mahocvien
            // 
            this.txt_mahocvien.Location = new System.Drawing.Point(146, 36);
            this.txt_mahocvien.Name = "txt_mahocvien";
            this.txt_mahocvien.Size = new System.Drawing.Size(509, 26);
            this.txt_mahocvien.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 64);
            this.label1.TabIndex = 32;
            this.label1.Text = "Chấm điểm học viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1352, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "label5";
            // 
            // btn_trove
            // 
            this.btn_trove.Image = global::Login.Properties.Resources.Exit;
            this.btn_trove.Location = new System.Drawing.Point(11, 9);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(119, 41);
            this.btn_trove.TabIndex = 33;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // ChamDiemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources._3409297;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 1024);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChamDiemHocVien";
            this.Text = "ChamDiemHocVien";
            this.Load += new System.EventHandler(this.ChamDiemHocVien_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_suathongtin;
        private System.Windows.Forms.Button btn_xoahocvien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhan_xet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nhanxet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_masinhvien;
        private System.Windows.Forms.TextBox txt_malophoc;
        private System.Windows.Forms.TextBox txt_mahocvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_trove;
    }
}