using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Billing_System.ConnectServer;
using Billing_System.Utility;
namespace Billing_System
{
    public partial class issuebill : Form
    {
        commonutility cu = new commonutility();
        Connection c1 = new Connection();
        public issuebill() => InitializeComponent();

        private void checkString(object sender, KeyPressEventArgs e) => cu.checkIsStringOrNot(e);
        private void checkDigit(object sender, KeyPressEventArgs e) => cu.checkIsDigitOrNot(e);
        private void checkBoth(object sender, KeyPressEventArgs e) => cu.checkBothDS(e);

        private void issuebill_Load(object sender, EventArgs e) => this.Owner.Enabled = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select * from additem where itemcode='" + textBox4.Text + "'";
            c1.cmd = new SqlCommand(str,c1.con);
            c1.cmd.ExecuteNonQuery(); 
            c1.dr = c1.cmd.ExecuteReader();
            if (c1.dr.HasRows==false)
                MessageBox.Show("wrong code");
            else
            {
                while (c1.dr.Read())
                {

                    string itemname = c1.dr.GetString(1);
                    string itemprice = c1.dr.GetSqlMoney(2).ToString();
                    int ty = c1.dr.GetSqlMoney(2).ToInt32() * Convert.ToInt32(textBox5.Text);
                    int discount,gd;
                    discount = Convert.ToInt32(textBox7.Text);
                    gd = ty - discount;
                    dataGridView1.Rows.Add(itemname, itemprice, textBox5.Text, ty, discount, gd);
                }
             }
            c1.dr.Close();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox4.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          /* string str = "select * from additem where code='" + textBox1.Text + "'";
            c1.cmd = new SqlCommand(str, c1.con);
            c1.cmd.ExecuteNonQuery();
            c1.dr = c1.cmd.ExecuteReader();
            c1.dr.Read();
            string ss = c1.dr.GetString(1);
            string ss1 = c1.dr.GetInt32(2).ToString();
            float ty = c1.dr.GetInt32(2) * Convert.ToInt32(textBox2.Text);
            c1.dr.Close();*/
                    string[] getdata = new string[10];
            string str = "insert into buycustomerdetail(invoiceno,customername) values('"+textBox4.Text+"','"+textBox5.Text + "')";
            c1.Functionup(str);

            str = "insert into invoiceitem(invoiceid) values('" + textBox4.Text + "')";
            c1.Functionup(str);
            

            str = "select * from invoiceitem where invoiceid='" + textBox4.Text + "'";
            c1.cmd = new SqlCommand(str, c1.con);
            c1.cmd.ExecuteNonQuery();
            c1.dr = c1.cmd.ExecuteReader();
            c1.dr.Read();
            String itemid = c1.dr.GetInt32(1).ToString();
            c1.dr.Close(); 


            for (int rows = 0; rows < dataGridView1.Rows.Count-1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    getdata[col] = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                //row.Name.ToString();
                }
                string quer = "insert into buyitemdetail(itemid,item,price,quantity,total) values('" + itemid + "','" + getdata[0] + "','" + getdata[1] + "','" + getdata[2] + "','" + getdata[3] + "')";
                c1.Functionup(quer);
            }
            c1.dr.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            else
                MessageBox.Show("No Row Selected");
        }

        private void issuebill_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
