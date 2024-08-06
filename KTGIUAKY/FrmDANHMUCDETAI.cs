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
    public partial class FrmDANHMUCDETAI : Form
    {
        public FrmDANHMUCDETAI()
        {
            InitializeComponent();
        }
        KetnoiCSDL kn = new KetnoiCSDL();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = kn.LayBang("SELECT * FROM DETAI");
            Danhmucdetai crystalReport1 = new Danhmucdetai();
            crystalReport1.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
