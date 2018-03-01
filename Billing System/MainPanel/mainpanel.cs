using schoolmanagementdcmjain.Master;
using schoolmanagementdcmjain.Student;
using System;
using System.Windows.Forms;

namespace schoolmanagementdcmjain
{
    public partial class mainpanel : Form
    {
        public mainpanel()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kkkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                
        }

        private void searchByAdharNoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Load(object sender, EventArgs e)
        {

        }

        private void monthlyFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlyfunds mf = new monthlyfunds();
            mf.Show();

        }

        private void otherFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yearlyfunds yf = new yearlyfunds();
            yf.Show();
            
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook ab = new addbook();
            ab.Show();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adddepartment ad = new adddepartment();
            ad.Show();
        }

        private void giveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook ib = new issuebook();
            ib.Show();
        }

        private void fullDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libraryfulldetail lfd = new libraryfulldetail();
            lfd.Show();
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addshop ash = new addshop();
            ash.Show();
        }

        private void addRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addrent ar = new addrent();
            ar.Show();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbank nb = new newbank();
            nb.Show();
        }

        private void addValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbankaccount nba = new newbankaccount();
            nba.Show();
        }

        private void bankDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountdetail ad = new accountdetail();
            ad.Show();
        }

        private void checkFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopdetail sd = new shopdetail();
            sd.Show();
        }

        private void fundsCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setDailyWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expensisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enterDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }

        private void applyForTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent rs = new RegisterStudent();
            rs.Show();
        }
    }
}
