using System;
using System.Windows.Forms;
using Billing_System.item;

namespace Billing_System
{
    public partial class mainpanel : Form
    {
        public mainpanel()
        {
            InitializeComponent();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additem ai= new additem();
            ai.Owner = this;
            ai.Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebill ib = new issuebill();
            ib.Owner = this;
            ib.Show();
        }

        private void showBillToolStripMenuItem_Click(object sender, EventArgs e) => new billviewer().Show();

        private void showBillToolStripMenuItem1_Click(object sender, EventArgs e) => new billviewer().Show();

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Load(object sender, EventArgs e)
        {

        }

        private void deactivateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeactivateItem di = new DeactivateItem();
            di.Owner = this;
            di.Show();
        }
    }
}
