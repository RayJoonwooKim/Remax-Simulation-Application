using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using RemaxApplication_JoonwooKim.DataSource;
namespace RemaxApplication_JoonwooKim.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboProfile.Text == "")
            {
                MessageBox.Show("Please choose your profile!", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter ID!", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPW.Text == "")
            {
                MessageBox.Show("Please enter password!", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPW.Focus();
                return;
            }
            if (cboProfile.Text == "Agent")
            {
                clsGlobal.load_profile = "agent";
                clsGlobal.Row_Agent = clsAdmin.AgentLogin(txtID.Text, txtPW.Text, cboProfile.Text);
                
                frmAgent fa = new frmAgent();
                fa.Show();
            }
            else if (cboProfile.Text == "Administrator")
            {
                clsGlobal.load_profile = "admin";
                clsGlobal.Row_Agent = clsAdmin.AdminLogin(txtID.Text, txtPW.Text, cboProfile.Text);
                
                frmAdmin fa2 = new frmAdmin();
                fa2.Show();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsGlobal.path = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = data\\Remax_Database.mdb";

            clsGlobal.mySet = new DataSet();
            clsGlobal.myCon = new OleDbConnection(clsGlobal.path);
            clsGlobal.myCon.Open();

            clsGlobal.myCmd = new OleDbCommand("SELECT * FROM Employee", clsGlobal.myCon);
            clsGlobal.adpEmp = new OleDbDataAdapter(clsGlobal.myCmd);
            clsGlobal.adpEmp.Fill(clsGlobal.mySet, "Employee");

            clsGlobal.myCmd2 = new OleDbCommand("SELECT * FROM Client", clsGlobal.myCon);
            clsGlobal.adpClient = new OleDbDataAdapter(clsGlobal.myCmd2);
            clsGlobal.adpClient.Fill(clsGlobal.mySet, "Client");

            clsGlobal.myCmd3 = new OleDbCommand("SELECT * FROM House", clsGlobal.myCon);
            clsGlobal.adpHouse = new OleDbDataAdapter(clsGlobal.myCmd3);
            clsGlobal.adpHouse.Fill(clsGlobal.mySet, "House");

            clsGlobal.myCmd4 = new OleDbCommand("SELECT * FROM Sales", clsGlobal.myCon);
            clsGlobal.adpSales = new OleDbDataAdapter(clsGlobal.myCmd4);
            clsGlobal.adpSales.Fill(clsGlobal.mySet, "Sales");
        }
    }
}
