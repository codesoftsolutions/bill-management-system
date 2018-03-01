using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Billing_System.ConnectServer
{
    public class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataTable dt;
        public SqlDataAdapter da;

        public Connection()
        {
          con = new SqlConnection("Data Source=DESKTOP-TLF4378;Initial Catalog=Billing_System;Integrated Security=True");
         con.Open();
        }
        public Boolean Function(string qry)
        {
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        public void Functionup(string qry)
        {
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("entered");
        }
    }
}