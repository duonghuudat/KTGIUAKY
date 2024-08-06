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
    public partial class FrmTIMDETAIDADK : Form
    {
        public FrmTIMDETAIDADK()
        {
            InitializeComponent();
        }
        KetnoiCSDL kn = new KetnoiCSDL();
        public void LAYDULIEU()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("select * from v_Timkiem");
            dataHienThi.DataSource = dta;
            HienThiDulieu();
        }
        private void HienThiDulieu()
        {

            cboMaCB.DataSource = dataHienThi.DataSource;
            cboMaCB.DisplayMember = "MACB";
            cboMaCB.ValueMember = "MACB";

            cboMaDT.DataSource = dataHienThi.DataSource;
            cboMaDT.DisplayMember = "MADT";
            cboMaDT.ValueMember = "MADT";
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (optMaCB.Checked)
            {
                try
                {
                    string sql = $"select * from v_Timkiem where MACB = N'{cboMaCB.Text}'";
                    kn.KetNoiDuLieu();
                    DataTable dt = kn.LayBang(sql);
                    dataHienThi.DataSource = dt;
                    HienThiDulieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                try
                {
                    string sql = $"select * from v_Timkiem where MADT like N'%{cboMaDT.Text}%'";
                    kn.KetNoiDuLieu();
                    DataTable dt = kn.LayBang(sql);
                    dataHienThi.DataSource = dt;
                    HienThiDulieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                    throw new Exception(ex.Message);

                }
            }
        }

        private void btnLammoi_Click_1(object sender, EventArgs e)
        {
            LAYDULIEU();
            HienThiDulieu();
            cboMaCB.Text = "";
            cboMaDT.Text = "";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmTIMDETAIDADK_Load(object sender, EventArgs e)
        {
            LAYDULIEU();

        }

        private void dataHienThi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("select * from v_Timkiem ");
        }

        private void btninketqua_Click(object sender, EventArgs e)
        {
            FrmDANHMUCDETAI baocao = new FrmDANHMUCDETAI();
            baocao.Show();
        }
    }
}
