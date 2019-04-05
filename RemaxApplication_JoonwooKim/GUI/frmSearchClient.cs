using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemaxApplication_JoonwooKim.GUI
{
    public partial class frmSearchClient : Form
    {
        public frmSearchClient()
        {
            InitializeComponent();
        }
        DataTable tabClient;
        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            gridResult.ReadOnly = true;
            tabClient = clsGlobal.mySet.Tables["Client"];
            gridResult.DataSource = tabClient;
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            var DisplayName = from DataRow dr in tabClient.Rows
                              where dr.Field<string>("ClientFirstName").Contains(txtName.Text) || dr.Field<string>("ClientLastName").Contains(txtName.Text)
                              select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType"), RefEmp = dr.Field<Int32>("RefEmp"), RefHouse = dr.Field<Int32>("RefHouse") };
            gridResult.DataSource = DisplayName.ToList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            gridResult.DataSource = tabClient;
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            var DisplayName = from DataRow dr in tabClient.Rows
                              where dr.Field<string>("ClientType") == cboType.Text
                              select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType"), RefEmp = dr.Field<Int32>("RefEmp"), RefHouse = dr.Field<Int32>("RefHouse") };
            gridResult.DataSource = DisplayName.ToList();
        }
    }
}
