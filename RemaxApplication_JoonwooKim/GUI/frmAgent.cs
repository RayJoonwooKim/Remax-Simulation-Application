using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemaxApplication_JoonwooKim.DataSource;

namespace RemaxApplication_JoonwooKim.GUI
{
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        DataRow row_h;
        private void frmAgent_Load(object sender, EventArgs e)
        {
            
            clsGlobal.Row_Client = clsAdmin.GetClientInfo(clsGlobal.Row_Agent);
            clsGlobal.Row_House = clsAdmin.GetHouseRef((int)clsGlobal.Row_Agent["RefEmp"]);



        }

        private void mnuClient_Click(object sender, EventArgs e)
        {
            frmManageClient fc = new frmManageClient();
            fc.MdiParent = this;
            fc.Show();
        }

        private void mnuHouse_Click(object sender, EventArgs e)
        {
            frmHouse fh = new frmHouse();
            fh.MdiParent = this;
            fh.Show();
        }

        private void mnuSearchClient_Click(object sender, EventArgs e)
        {
            frmSearchClient sc = new frmSearchClient();
            sc.MdiParent = this;
            sc.Show();
        }

        private void mnuSearchHouse_Click(object sender, EventArgs e)
        {
            frmSearchHouse sh = new frmSearchHouse();
            sh.MdiParent = this;
            sh.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales sale = new frmSales();
            sale.MdiParent = this;
            sale.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
