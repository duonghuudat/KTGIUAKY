
namespace KTGIUAKY
{
    partial class FrmDANGKYDETAI
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.dataKQ = new System.Windows.Forms.DataGridView();
            this.txtNgayhoanthanh = new System.Windows.Forms.DateTimePicker();
            this.txtngaydangky = new System.Windows.Forms.DateTimePicker();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtSothanhvien = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.txtMadetai = new System.Windows.Forms.TextBox();
            this.cboMacanbo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(509, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 34);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(509, 236);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 34);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(509, 188);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 34);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(509, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 34);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(509, 99);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(118, 34);
            this.btnTaomoi.TabIndex = 39;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // dataKQ
            // 
            this.dataKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKQ.Location = new System.Drawing.Point(78, 376);
            this.dataKQ.Name = "dataKQ";
            this.dataKQ.Size = new System.Drawing.Size(622, 184);
            this.dataKQ.TabIndex = 38;
            // 
            // txtNgayhoanthanh
            // 
            this.txtNgayhoanthanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayhoanthanh.Location = new System.Drawing.Point(180, 207);
            this.txtNgayhoanthanh.Name = "txtNgayhoanthanh";
            this.txtNgayhoanthanh.Size = new System.Drawing.Size(179, 20);
            this.txtNgayhoanthanh.TabIndex = 37;
            // 
            // txtngaydangky
            // 
            this.txtngaydangky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaydangky.Location = new System.Drawing.Point(180, 170);
            this.txtngaydangky.Name = "txtngaydangky";
            this.txtngaydangky.Size = new System.Drawing.Size(179, 20);
            this.txtngaydangky.TabIndex = 36;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(180, 300);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(281, 56);
            this.txtGhichu.TabIndex = 34;
            // 
            // txtSothanhvien
            // 
            this.txtSothanhvien.Location = new System.Drawing.Point(180, 271);
            this.txtSothanhvien.Name = "txtSothanhvien";
            this.txtSothanhvien.Size = new System.Drawing.Size(281, 20);
            this.txtSothanhvien.TabIndex = 35;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(180, 236);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(281, 20);
            this.txtKetqua.TabIndex = 33;
            // 
            // txtMadetai
            // 
            this.txtMadetai.Location = new System.Drawing.Point(180, 136);
            this.txtMadetai.Name = "txtMadetai";
            this.txtMadetai.Size = new System.Drawing.Size(281, 20);
            this.txtMadetai.TabIndex = 32;
            // 
            // cboMacanbo
            // 
            this.cboMacanbo.FormattingEnabled = true;
            this.cboMacanbo.Location = new System.Drawing.Point(180, 98);
            this.cboMacanbo.Name = "cboMacanbo";
            this.cboMacanbo.Size = new System.Drawing.Size(281, 21);
            this.cboMacanbo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số thành viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày hoàn thành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã cán bộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "ĐĂNG KÝ ĐỀ TÀI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmDANGKYDETAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.dataKQ);
            this.Controls.Add(this.txtNgayhoanthanh);
            this.Controls.Add(this.txtngaydangky);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtSothanhvien);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtMadetai);
            this.Controls.Add(this.cboMacanbo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDANGKYDETAI";
            this.Text = "FrmTIMDETAIDANGKY";
            this.Load += new System.EventHandler(this.FrmTIMDETAIDANGKY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.DataGridView dataKQ;
        private System.Windows.Forms.DateTimePicker txtNgayhoanthanh;
        private System.Windows.Forms.DateTimePicker txtngaydangky;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtSothanhvien;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.TextBox txtMadetai;
        private System.Windows.Forms.ComboBox cboMacanbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}