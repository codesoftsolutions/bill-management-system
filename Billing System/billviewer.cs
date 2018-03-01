using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Billing_System.ConnectServer;

namespace Billing_System
{
    public partial class billviewer : Form
    {
        Connection c1 = new Connection();
        public billviewer()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string qr = "select itemid from invoiceitem where invoiceid='"+textBox1.Text+"'";
            c1.cmd = new SqlCommand(qr, c1.con);
            c1.cmd.ExecuteNonQuery();
            c1.dr = c1.cmd.ExecuteReader();
            c1.dr.Read();
            string itemid = c1.dr.GetInt32(0).ToString();
            c1.dr.Close();


//            buycustomerdetail.invoiceno = '"+textBox1.Text+"'
             c1.da = new SqlDataAdapter("select * from buycustomerdetail where invoiceno='" +textBox1.Text+ "'", c1.con);
            SqlDataAdapter sad = new SqlDataAdapter("select * from buyitemdetail where itemid='" + itemid + "'", c1.con);
            DataSet dst = new DataSet();
            c1.da.Fill(dst, "buycustomerdetail");
            sad.Fill(dst, "buyitemdetail");
            ReportDocument cr = new ReportDocument();
            cr.Load("C:\\Users\\Lenovo\\Desktop\\billing system\\Billing System\\Billing System\\showbill.rpt");
            cr.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cr;

            crystalReportViewer1.Refresh();

        }
    }
}

