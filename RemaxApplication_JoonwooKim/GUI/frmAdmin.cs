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
namespace RemaxApplication_JoonwooKim.GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            clsGlobal.path = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = data\\Remax_Database.mdb";

            clsGlobal.mySet = new DataSet();
            clsGlobal.myCon = new OleDbConnection(clsGlobal.path);
            clsGlobal.myCon.Open();

            OleDbCommand myCmd = new OleDbCommand("SELECT * FROM Employee", clsGlobal.myCon);
            clsGlobal.adpEmp = new OleDbDataAdapter(myCmd);
            clsGlobal.adpEmp.Fill(clsGlobal.mySet, "Employee");

            OleDbCommand myCmd2 = new OleDbCommand("SELECT * FROM Client", clsGlobal.myCon);
            clsGlobal.adpClient = new OleDbDataAdapter(myCmd2);
            clsGlobal.adpClient.Fill(clsGlobal.mySet, "Client");

            OleDbCommand myCmd3 = new OleDbCommand("SELECT * FROM House", clsGlobal.myCon);
            clsGlobal.adpHouse = new OleDbDataAdapter(myCmd3);
            clsGlobal.adpHouse.Fill(clsGlobal.mySet, "House");

            clsGlobal.myCmd4 = new OleDbCommand("SELECT * FROM Sales", clsGlobal.myCon);
            clsGlobal.adpSales = new OleDbDataAdapter(clsGlobal.myCmd4);
            clsGlobal.adpSales.Fill(clsGlobal.mySet, "Sales");
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            frmManageEmployee f1 = new frmManageEmployee();
            f1.MdiParent = this;
            f1.Show();
        }

        private void mnuClient_Click(object sender, EventArgs e)
        {
            frmManageClient f2 = new frmManageClient();
            f2.MdiParent = this;
            f2.Show();
        }

        private void mnuHouse_Click(object sender, EventArgs e)
        {
            frmHouse f3 = new frmHouse();
            f3.MdiParent = this;
            f3.Show();
        }

        private void mnuSearchHouse_Click(object sender, EventArgs e)
        {
            frmSearchHouse sh = new frmSearchHouse();
            sh.MdiParent = this;
            sh.Show();
        }

        private void mnuSearchClient_Click(object sender, EventArgs e)
        {
            frmSearchClient sc = new frmSearchClient();
            sc.MdiParent = this;
            sc.Show();
        }

        private void mnuSales_Click(object sender, EventArgs e)
        {
            frmSales fs = new frmSales();
            fs.MdiParent = this;
            fs.Show();
        }

        private void mnuSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
