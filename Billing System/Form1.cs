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
namespace Billing_System
{
    public partial class Form1 : Form
    {
        Connection cc1 = new Connection();
        Boolean get = false;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            String query = "select * from user_detail where userid = '" + this.textBox1.Text + "' and password = '" + this.textBox2.Text+"'" ;
            get=cc1.Function(query);
            if (get == true)
            {
               mainpanel mp= new mainpanel();
                mp.Owner = this;
                mp.Show();
             
            }
            else
                MessageBox.Show("wrong input");
          
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e) => this.Close();
    }
}
