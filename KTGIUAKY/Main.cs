using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGIUAKY
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCanbo_Click(object sender, EventArgs e)
        {
            FrmCANBO canbo = new FrmCANBO();
            canbo.Show();
        }

        private void btnDangkydetai_Click(object sender, EventArgs e)
        {
            FrmDANGKYDETAI timdetai = new FrmDANGKYDETAI();
            timdetai.Show();
        }

        private void btnTimdetai_Click(object sender, EventArgs e)
        {
           
            FrmTIMDETAIDADK dangkydetai = new FrmTIMDETAIDADK();
            dangkydetai.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDANHMUCDETAI danhmucdetai = new FrmDANHMUCDETAI();
            danhmucdetai.Show();
        }
    }
}
