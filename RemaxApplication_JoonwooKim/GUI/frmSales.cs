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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        DataTable tabSales;
        int row_index;
        private void frmSales_Load(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile == "admin")
            {
                gridSales.ReadOnly = true;
                txtRefClient.ReadOnly = true;
                txtRefEmp.ReadOnly = true;
                txtRefHouse.ReadOnly = true;
                txtRefSales.ReadOnly = true;
                tabSales = clsGlobal.mySet.Tables["Sales"];
                gridSales.DataSource = tabSales;
            }
            if (clsGlobal.load_profile == "agent")
            {
                gridSales.ReadOnly = true;
                txtRefClient.ReadOnly = true;
                txtRefEmp.ReadOnly = true;
                txtRefHouse.ReadOnly = true;
                txtRefSales.ReadOnly = true;
                tabSales = clsGlobal.mySet.Tables["Sales"];

                int refemp = Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"]);
                var DisplaySales = from DataRow dr in tabSales.Rows
                                   where dr.Field<Int32>("RefEmp") == refemp
                                   select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                gridSales.DataSource = DisplaySales.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!radSales.Checked && !RadEmp.Checked && !RadClient.Checked && !RadHouse.Checked)
            {
                MessageBox.Show("Please check reference to search", "SEARCH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsGlobal.load_profile == "admin")
            {
                if (radSales.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefSales") == Convert.ToInt32(txtSearch.Text)
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadEmp.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefEmp") == Convert.ToInt32(txtSearch.Text)
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadClient.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefClient") == Convert.ToInt32(txtSearch.Text)
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadHouse.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefHouse") == Convert.ToInt32(txtSearch.Text)
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
            }
            else if (clsGlobal.load_profile =="agent")
            {
                if (radSales.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefSales") == Convert.ToInt32(txtSearch.Text) && dr.Field<Int32>("RefEmp") == Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"])
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadEmp.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefEmp") == Convert.ToInt32(txtSearch.Text) && dr.Field<Int32>("RefEmp") == Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"])
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadClient.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefClient") == Convert.ToInt32(txtSearch.Text) && dr.Field<Int32>("RefEmp") == Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"])
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
                else if (RadHouse.Checked)
                {
                    var DisplaySales = from DataRow dr in tabSales.Rows
                                       where dr.Field<Int32>("RefHouse") == Convert.ToInt32(txtSearch.Text) && dr.Field<Int32>("RefEmp") == Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"])
                                       select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                    gridSales.DataSource = DisplaySales.ToList();
                }
            }
        }

        private void btnSearchStatus_Click(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile == "admin")
            {
                var DisplaySales = from DataRow dr in tabSales.Rows
                                   where dr.Field<string>("Status") == cboStatus.Text
                                   select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                gridSales.DataSource = DisplaySales.ToList();
            }
            else if (clsGlobal.load_profile =="agent")
            {
                var DisplaySales = from DataRow dr in tabSales.Rows
                                   where dr.Field<string>("Status") == cboStatus.Text && dr.Field<Int32>("RefEmp") == Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"])
                                   select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                gridSales.DataSource = DisplaySales.ToList();
            }
        }

        private void gridSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;
            txtRefSales.Text = gridSales.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRefEmp.Text = gridSales.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRefClient.Text = gridSales.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRefHouse.Text = gridSales.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboUpdateStatus.Text = gridSales.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to update sales?","Update Sales",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                clsAdmin.UpdateSales(clsGlobal.myCon, clsGlobal.path, tabSales, row_index, cboUpdateStatus.Text);
                MessageBox.Show("Sales updated successfully!", "Update Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridSales.DataSource = tabSales;
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gridSales.DataSource = tabSales;
            
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile == "admin")
            {
                gridSales.DataSource = tabSales;
            }
            else if (clsGlobal.load_profile == "agent")
            {
                int refemp = Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"]);
                var DisplaySales = from DataRow dr in tabSales.Rows
                                   where dr.Field<Int32>("RefEmp") == refemp
                                   select new { RefSales = dr.Field<Int32>("RefSales"), RefEmp = dr.Field<Int32>("RefEmp"), RefClient = dr.Field<Int32>("RefClient"), RefHouse = dr.Field<Int32>("RefHouse"), Status = dr.Field<string>("Status") };
                gridSales.DataSource = DisplaySales.ToList();
            }
            
        }
    }
}
