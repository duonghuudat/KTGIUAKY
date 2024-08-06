
namespace KTGIUAKY
{
    partial class FrmTIMDETAIDADK
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
            this.btninketqua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.cboMaDT = new System.Windows.Forms.ComboBox();
            this.cboMaCB = new System.Windows.Forms.ComboBox();
            this.optMaDT = new System.Windows.Forms.RadioButton();
            this.optMaCB = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataHienThi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btninketqua
            // 
            this.btninketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninketqua.Location = new System.Drawing.Point(636, 173);
            this.btninketqua.Name = "btninketqua";
            this.btninketqua.Size = new System.Drawing.Size(118, 42);
            this.btninketqua.TabIndex = 58;
            this.btninketqua.Text = "In kết quả";
            this.btninketqua.UseVisualStyleBackColor = true;
            this.btninketqua.Click += new System.EventHandler(this.btninketqua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(516, 173);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(114, 42);
            this.btnLammoi.TabIndex = 57;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click_1);
            // 
            // cboMaDT
            // 
            this.cboMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDT.FormattingEnabled = true;
            this.cboMaDT.Location = new System.Drawing.Point(186, 173);
            this.cboMaDT.Name = "cboMaDT";
            this.cboMaDT.Size = new System.Drawing.Size(298, 32);
            this.cboMaDT.TabIndex = 55;
            // 
            // cboMaCB
            // 
            this.cboMaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCB.FormattingEnabled = true;
            this.cboMaCB.Location = new System.Drawing.Point(186, 129);
            this.cboMaCB.Name = "cboMaCB";
            this.cboMaCB.Size = new System.Drawing.Size(298, 32);
            this.cboMaCB.TabIndex = 56;
            // 
            // optMaDT
            // 
            this.optMaDT.AutoSize = true;
            this.optMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaDT.Location = new System.Drawing.Point(51, 173);
            this.optMaDT.Name = "optMaDT";
            this.optMaDT.Size = new System.Drawing.Size(89, 28);
            this.optMaDT.TabIndex = 53;
            this.optMaDT.TabStop = true;
            this.optMaDT.Text = "Mã ĐT:";
            this.optMaDT.UseVisualStyleBackColor = true;
            // 
            // optMaCB
            // 
            this.optMaCB.AutoSize = true;
            this.optMaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaCB.Location = new System.Drawing.Point(51, 129);
            this.optMaCB.Name = "optMaCB";
            this.optMaCB.Size = new System.Drawing.Size(89, 28);
            this.optMaCB.TabIndex = 54;
            this.optMaCB.TabStop = true;
            this.optMaCB.Text = "Mã CB:";
            this.optMaCB.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(636, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 39);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(516, 128);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 39);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // dataHienThi
            // 
            this.dataHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThi.Location = new System.Drawing.Point(113, 250);
            this.dataHienThi.Name = "dataHienThi";
            this.dataHienThi.Size = new System.Drawing.Size(583, 150);
            this.dataHienThi.TabIndex = 49;
            this.dataHienThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHienThi_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "TÌM THÔNG TIN ĐỀ TÀI ĐĂNG KÝ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmTIMDETAIDADK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninketqua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.cboMaDT);
            this.Controls.Add(this.cboMaCB);
            this.Controls.Add(this.optMaDT);
            this.Controls.Add(this.optMaCB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataHienThi);
            this.Controls.Add(this.label1);
            this.Name = "FrmTIMDETAIDADK";
            this.Text = "FrmDANGKY_DETAI";
            this.Load += new System.EventHandler(this.FrmTIMDETAIDADK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninketqua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.ComboBox cboMaDT;
        private System.Windows.Forms.ComboBox cboMaCB;
        private System.Windows.Forms.RadioButton optMaDT;
        private System.Windows.Forms.RadioButton optMaCB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataHienThi;
        private System.Windows.Forms.Label label1;
    }
}