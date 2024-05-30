
namespace Dangnhap
{
    partial class KhoXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtquanly = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtkhoxe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoakho = new System.Windows.Forms.Button();
            this.btn_themkho = new System.Windows.Forms.Button();
            this.btn_capnhatkho = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntiemkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(524, 218);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(470, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 64);
            this.label1.TabIndex = 35;
            this.label1.Text = "Quản Lý Kho Xe Hơi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtquanly);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtkhoxe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(30, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1414, 175);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // txtquanly
            // 
            this.txtquanly.Location = new System.Drawing.Point(849, 101);
            this.txtquanly.Name = "txtquanly";
            this.txtquanly.Size = new System.Drawing.Size(412, 26);
            this.txtquanly.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(266, 107);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(412, 26);
            this.txtdiachi.TabIndex = 6;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Enabled = false;
            this.txtsoluong.Location = new System.Drawing.Point(849, 25);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ReadOnly = true;
            this.txtsoluong.Size = new System.Drawing.Size(412, 26);
            this.txtsoluong.TabIndex = 5;
            // 
            // txtkhoxe
            // 
            this.txtkhoxe.Location = new System.Drawing.Point(266, 31);
            this.txtkhoxe.Name = "txtkhoxe";
            this.txtkhoxe.Size = new System.Drawing.Size(412, 26);
            this.txtkhoxe.TabIndex = 4;
            this.txtkhoxe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(740, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quản lý bởi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(740, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(193, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(193, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Kho:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.btn_luu);
            this.groupBox4.Controls.Add(this.btn_xoakho);
            this.groupBox4.Controls.Add(this.btn_themkho);
            this.groupBox4.Controls.Add(this.btn_capnhatkho);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(162, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1143, 96);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thêm, cập nhật, xóa kho";
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_luu.Image = global::Dangnhap.Properties.Resources.Save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(818, 25);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(154, 42);
            this.btn_luu.TabIndex = 47;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoakho
            // 
            this.btn_xoakho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoakho.Image = global::Dangnhap.Properties.Resources.Delete;
            this.btn_xoakho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoakho.Location = new System.Drawing.Point(427, 25);
            this.btn_xoakho.Name = "btn_xoakho";
            this.btn_xoakho.Size = new System.Drawing.Size(154, 42);
            this.btn_xoakho.TabIndex = 46;
            this.btn_xoakho.Text = "Xóa kho";
            this.btn_xoakho.UseVisualStyleBackColor = true;
            this.btn_xoakho.Click += new System.EventHandler(this.btn_xoakho_Click);
            // 
            // btn_themkho
            // 
            this.btn_themkho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themkho.Image = global::Dangnhap.Properties.Resources.Add;
            this.btn_themkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themkho.Location = new System.Drawing.Point(232, 25);
            this.btn_themkho.Name = "btn_themkho";
            this.btn_themkho.Size = new System.Drawing.Size(154, 42);
            this.btn_themkho.TabIndex = 42;
            this.btn_themkho.Text = "Thêm kho";
            this.btn_themkho.UseVisualStyleBackColor = true;
            this.btn_themkho.Click += new System.EventHandler(this.btn_themkho_Click);
            // 
            // btn_capnhatkho
            // 
            this.btn_capnhatkho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_capnhatkho.Image = global::Dangnhap.Properties.Resources.Edit;
            this.btn_capnhatkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhatkho.Location = new System.Drawing.Point(622, 25);
            this.btn_capnhatkho.Name = "btn_capnhatkho";
            this.btn_capnhatkho.Size = new System.Drawing.Size(154, 42);
            this.btn_capnhatkho.TabIndex = 44;
            this.btn_capnhatkho.Text = "Cập Nhật";
            this.btn_capnhatkho.UseVisualStyleBackColor = true;
            this.btn_capnhatkho.Click += new System.EventHandler(this.btn_capnhatkho_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(13, 13);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(92, 20);
            this.lbusername.TabIndex = 51;
            this.lbusername.Text = "người dùng ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btntiemkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(1026, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 76);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tìm kiếm";
            // 
            // btntiemkiem
            // 
            this.btntiemkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntiemkiem.Image = global::Dangnhap.Properties.Resources.Search;
            this.btntiemkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntiemkiem.Location = new System.Drawing.Point(271, 22);
            this.btntiemkiem.Name = "btntiemkiem";
            this.btntiemkiem.Size = new System.Drawing.Size(141, 33);
            this.btntiemkiem.TabIndex = 1;
            this.btntiemkiem.Text = "tìm kiếm";
            this.btntiemkiem.UseVisualStyleBackColor = true;
            this.btntiemkiem.Click += new System.EventHandler(this.btntiemkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(21, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(244, 26);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // KhoXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dangnhap.Properties.Resources.pngtree_several_toyota_cars_parked_on_a_busy_street_picture_image_2658633;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1478, 794);
            this.Name = "KhoXe";
            this.ShowIcon = false;
            this.Text = "KhoXe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KhoXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtquanly;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtkhoxe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_themkho;
        private System.Windows.Forms.Button btn_capnhatkho;
        private System.Windows.Forms.Button btn_xoakho;
        private System.Windows.Forms.Label lbusername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntiemkiem;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}