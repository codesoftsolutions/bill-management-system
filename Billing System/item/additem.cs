using System;
using System.Windows.Forms;
using Billing_System.Utility;
using System.Data.SqlClient;
using Billing_System.ConnectServer;

namespace Billing_System.item
{
    public partial class additem : Form
    {
        Connection c1 = new Connection();
        commonutility cu = new commonutility();
        public additem()
        {
            InitializeComponent();
        }
        private void checkString(object sender, KeyPressEventArgs e) => cu.checkIsStringOrNot(e);
        private void checkDigit(object sender, KeyPressEventArgs e) => cu.checkIsDigitOrNot(e);
        private void checkBoth(object sender, KeyPressEventArgs e) => cu.checkBothDS(e);


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                MessageBox.Show("Enter Data");
            else if (textBox1.Text == "")
                MessageBox.Show("Enter Name of Item");
            else if (textBox2.Text == "")
                MessageBox.Show("Enter Price of Item");
            else if (textBox3.Text == "")
                MessageBox.Show("Enter Code Of Item");
            else
            {
                Boolean check = true;

                string str = "select * from additem where itemstatus=1 ";
                c1.cmd = new SqlCommand(str, c1.con);
                c1.cmd.ExecuteNonQuery();
                c1.dr = c1.cmd.ExecuteReader();
                while (c1.dr.Read())
                {
                    if (c1.dr.GetString(1) == textBox1.Text)
                    {
                        MessageBox.Show("Item already Exists");
                        check = false;
                        break;
                    }
                    if (c1.dr.GetString(3) == textBox3.Text)
                    {
                        MessageBox.Show("Code already Exists");
                        check = false;
                        break;
                    }

                }
                c1.dr.Close();
             if (check == true)
                { 
                string qur = "INSERT INTO additem(itemname,itemprice,itemcode) VALUES('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "')";
                c1.Functionup(qur);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                }
        }
        private void additem_Load(object sender, EventArgs e) => this.Owner.Enabled = false;
        private void additem_FormClosed(object sender, FormClosedEventArgs e) => this.Owner.Enabled = true;
        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}