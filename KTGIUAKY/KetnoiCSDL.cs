using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KTGIUAKY
{
    class KetnoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoiDuLieu()
        {
            string strKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=DUONGHUUDAT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }


        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable LayBang(string Sql)
        {
            KetNoiDuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Execute(String sql)
        {
            KetNoiDuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
