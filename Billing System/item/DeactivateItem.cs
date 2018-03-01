using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Billing_System.ConnectServer;

namespace Billing_System.item
{
    public partial class DeactivateItem : Form
    {
        Connection c1 = new Connection();
        public DeactivateItem()
        {
            InitializeComponent();
            string sql = "select * from additem";
            c1.da = new SqlDataAdapter(sql, c1.con);
            DataSet ds = new DataSet();
            ds.Tables.Add("items");
            c1.da.Fill(ds, "items");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "items";
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string str = "update additem set itemstatus= '"+0+"' where itemname='"+textBox1.Text+"'";
           Boolean ss;
            ss=c1.Function(str);
            if (ss = true)
                MessageBox.Show("Data updated");
            else
                MessageBox.Show("wrong Input");

            textBox1.Clear();
            textBox1.Focus();
        }

        private void DeactivateItem_Load(object sender, EventArgs e) => this.Owner.Enabled = false;

        private void DeactivateItem_FormClosed(object sender, FormClosedEventArgs e) => this.Owner.Enabled = true;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}
