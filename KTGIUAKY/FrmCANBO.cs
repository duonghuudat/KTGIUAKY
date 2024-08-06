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
    public partial class FrmCANBO : Form
    {
        public FrmCANBO()
        {
            InitializeComponent();
        }
        KetnoiCSDL kn = new KetnoiCSDL();

        private void LayDuLieu()
        {
            kn.KetNoiDuLieu();
            DataTable dt = kn.LayBang("select * from CANBO");
            dataKQ.DataSource = dt;
            DataTable dt1 = kn.LayBang("select MAPB from PHONGBAN");
            cboMaphongban.DataSource = dt1;
            cboMaphongban.DisplayMember = "MAPB";
            cboMaphongban.SelectedIndex = 0;
            HienThiDuLieu();

        }

        private void HienThiDuLieu()
        {
            txtMacb.DataBindings.Clear();
            txtMacb.DataBindings.Add("Text", dataKQ.DataSource, "MACB");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dataKQ.DataSource, "HOTEN");
            txtNgaysinh.DataBindings.Clear();
            txtNgaysinh.DataBindings.Add("Text", dataKQ.DataSource, "NGAYSINH");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dataKQ.DataSource, "DIACHI");
            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("Text", dataKQ.DataSource, "CHUCVU");
            cboMaphongban.DataBindings.Clear();
            cboMaphongban.DataBindings.Add("Text", dataKQ.DataSource, "MAPB");
            txtHocham.DataBindings.Clear();
            txtHocham.DataBindings.Add("Text", dataKQ.DataSource, "HOCHAM");
            txtHocvi.DataBindings.Clear();
            txtHocvi.DataBindings.Add("Text", dataKQ.DataSource, "HOCVI");
        }

        private void FrmCANBO_Load(object sender, EventArgs e)
        {
            LayDuLieu();

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMacb.Text = "";
            txtHoten.Text = "";
            txtHocvi.Text = "";
            txtDiachi.Text = "";
            txtChucvu.Text = "";
            txtHocham.Text = "";
            cboMaphongban.Text = "";
            optNam.Checked = true;
            optNu.Checked = false;
            txtNgaysinh.Value = DateTime.Now;
            txtMacb.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngaySinh = txtNgaysinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = "";
            if (optNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (optNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            string sql = "INSERT INTO CANBO (MACB, HOTEN, NGAYSINH, GIOITINH, DIACHI, CHUCVU, MAPB, HOCHAM, HOCVI) VALUES ('" + txtMacb.Text + "',N'" + txtHoten.Text + "','" + ngaySinh + "',N'" + gioiTinh +
                "',N'" + txtDiachi.Text + "',N'" + txtChucvu.Text + "',N'" + cboMaphongban.Text + "',N'" + txtHocham.Text + "',N'" + txtHocvi.Text + "')";
            kn.Execute(sql);
            LayDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngaySinh = txtNgaysinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = "";
            if (optNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (optNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            string sql = "UPDATE CANBO SET HOTEN = N'" + txtHoten.Text + "', NGAYSINH = N'" + ngaySinh + "', GIOITINH = N'" + gioiTinh + "', DIACHI = N'" + txtDiachi.Text + "', CHUCVU = N'" + txtChucvu.Text + "', MAPB = N'" + cboMaphongban.Text + "', HOCHAM = N'" + txtHocham.Text + "', HOCVI = N'" + txtHocvi.Text + "' WHERE MACB = '" + txtMacb.Text + "'";
            kn.Execute(sql);
            LayDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CANBO WHERE MACB = '" + txtMacb.Text + "'";
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
