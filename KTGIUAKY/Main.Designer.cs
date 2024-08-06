
namespace KTGIUAKY
{
    partial class Main
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
            this.btnCanbo = new System.Windows.Forms.Button();
            this.btnDangkydetai = new System.Windows.Forms.Button();
            this.btnTimdetai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCanbo
            // 
            this.btnCanbo.Location = new System.Drawing.Point(156, 74);
            this.btnCanbo.Name = "btnCanbo";
            this.btnCanbo.Size = new System.Drawing.Size(94, 42);
            this.btnCanbo.TabIndex = 0;
            this.btnCanbo.Text = "Cán bộ";
            this.btnCanbo.UseVisualStyleBackColor = true;
            this.btnCanbo.Click += new System.EventHandler(this.btnCanbo_Click);
            // 
            // btnDangkydetai
            // 
            this.btnDangkydetai.Location = new System.Drawing.Point(319, 74);
            this.btnDangkydetai.Name = "btnDangkydetai";
            this.btnDangkydetai.Size = new System.Drawing.Size(95, 42);
            this.btnDangkydetai.TabIndex = 0;
            this.btnDangkydetai.Text = "Đăng ký đề tài";
            this.btnDangkydetai.UseVisualStyleBackColor = true;
            this.btnDangkydetai.Click += new System.EventHandler(this.btnDangkydetai_Click);
            // 
            // btnTimdetai
            // 
            this.btnTimdetai.Location = new System.Drawing.Point(493, 74);
            this.btnTimdetai.Name = "btnTimdetai";
            this.btnTimdetai.Size = new System.Drawing.Size(91, 42);
            this.btnTimdetai.TabIndex = 0;
            this.btnTimdetai.Text = "Tìm đề tài đăng ký";
            this.btnTimdetai.UseVisualStyleBackColor = true;
            this.btnTimdetai.Click += new System.EventHandler(this.btnTimdetai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(411, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimdetai);
            this.Controls.Add(this.btnDangkydetai);
            this.Controls.Add(this.btnCanbo);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanbo;
        private System.Windows.Forms.Button btnDangkydetai;
        private System.Windows.Forms.Button btnTimdetai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
    }
}