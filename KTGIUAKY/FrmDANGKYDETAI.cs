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
    public partial class FrmDANGKYDETAI : Form
    {
        public FrmDANGKYDETAI()
        {
            InitializeComponent();
        }
        KetnoiCSDL kn = new KetnoiCSDL();
        private void LayDuLieu()
        {
            kn.KetNoiDuLieu();
            DataTable dt = kn.LayBang("select * from DANGKY_DETAI");
            dataKQ.DataSource = dt;
            DataTable dt1 = kn.LayBang("select MACB from CANBO");
            cboMacanbo.DataSource = dt1;
            cboMacanbo.DisplayMember = "MACB";
            cboMacanbo.SelectedIndex = 0;
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            cboMacanbo.DataBindings.Clear();
            cboMacanbo.DataBindings.Add("Text", dataKQ.DataSource, "MACB");
            txtMadetai.DataBindings.Clear();
            txtMadetai.DataBindings.Add("Text", dataKQ.DataSource, "MADT");
            txtKetqua.DataBindings.Clear();
            txtKetqua.DataBindings.Add("Text", dataKQ.DataSource, "KETQUA");
            txtngaydangky.DataBindings.Clear();
            txtngaydangky.DataBindings.Add("Text", dataKQ.DataSource, "NGAYDK");
            txtNgayhoanthanh.DataBindings.Clear();
            txtNgayhoanthanh.DataBindings.Add("Text", dataKQ.DataSource, "NGAYHT");
            txtSothanhvien.DataBindings.Clear();
            txtSothanhvien.DataBindings.Add("Text", dataKQ.DataSource, "SOTV");
            txtGhichu.DataBindings.Clear();
            txtGhichu.DataBindings.Add("Text", dataKQ.DataSource, "GHICHU");
        }
        private void FrmTIMDETAIDANGKY_Load(object sender, EventArgs e)
        {
            LayDuLieu();

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            cboMacanbo.Text = "";
            txtMadetai.Text = "";
            txtKetqua.Text = "";
            txtSothanhvien.Text = "";
            txtGhichu.Text = "";
            txtngaydangky.Value = DateTime.Now;
            txtNgayhoanthanh.Value = DateTime.Now;
            cboMacanbo.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngaydangky = txtngaydangky.Value.ToString("yyyy-MM-dd");
            string ngayhoanthanh = txtNgayhoanthanh.Value.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO DANGKY_DETAI (MACB, MADT, NGAYDK, NGAYHT, KETQUA, SOTV, GHICHU) VALUES ('" + cboMacanbo.Text + "',N'" + txtMadetai.Text + "','" + ngaydangky + "',N'" + ngayhoanthanh +
                "',N'" + txtKetqua.Text + "',N'" + txtSothanhvien.Text + "',N'" + txtGhichu.Text + "')";
            kn.Execute(sql);
            LayDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngaydangky = txtngaydangky.Value.ToString("yyyy-MM-dd");
            string ngayhoanthanh = txtNgayhoanthanh.Value.ToString("yyyy-MM-dd");
            string sql = "UPDATE DANGKY_DETAI SET NGAYDK = N'" + ngaydangky + "', NGAYHT = N'" + ngayhoanthanh + "', " +
                "KETQUA = N'" + txtKetqua.Text + "', SOTV = N'" + txtSothanhvien.Text + "', GHICHU = N'" + txtGhichu.Text + "' WHERE MADT = N'" + txtMadetai.Text + "' AND MACB = N'" + cboMacanbo.Text + "'";

            kn.Execute(sql);
            LayDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM DANGKY_DETAI WHERE MADT = N'" + txtMadetai.Text + "' AND MACB ='" + cboMacanbo.Text + "'";
            kn.Execute(sql);
            LayDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
