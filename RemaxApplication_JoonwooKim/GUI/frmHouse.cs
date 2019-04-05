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
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }
        DataTable tabHouse;
        DataTable tabClient;
        DataRow myRow;
        int row_index;
        int ref_client;
        string mode;
        
        private void btnEnable(bool add, bool update, bool delete, bool save, bool cancel)
        {
            btnAdd.Enabled = add;
            btnUpdate.Enabled = update;
            btnDelete.Enabled = delete;
            btnSave.Enabled = save;
            btnCancel.Enabled = cancel;
        }
        private void txtEnable(bool location, bool contact, bool price, bool room, bool type)
        {
            txtLocation.Enabled = location;
            txtContact.Enabled = contact;
            txtPrice.Enabled = price;
            txtRoom.Enabled = room;
            cboType.Enabled = type;
        }
        private void frmHouse_Load(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile == "admin")
            {
                lblInfo.Text = "";
                gridHouse.ReadOnly = true;
                tabHouse = clsGlobal.mySet.Tables["House"];
                gridHouse.DataSource = tabHouse;
                txtEnable(false, false, false, false, false);
                btnEnable(true, true, true, false, false);
            }
            else if (clsGlobal.load_profile == "agent")
            {
                lblInfo.Text = "";
                gridHouse.ReadOnly = true;
                txtEnable(false, false, false, false, false);
                btnEnable(true, true, true, false, false);
                tabClient = clsGlobal.mySet.Tables["Client"];
                tabHouse = clsGlobal.mySet.Tables["House"];


                //int refh = Convert.ToInt32(clsGlobal.Row_House["RefHouse"]);

                //var DisplayHouse = from DataRow dr in tabHouse.Rows
                //                   where dr.Field<Int32>("RefHouse") == refh
                //                   select new { RefHouse = dr.Field<Int32>("RefHouse"), Type = dr.Field<string>("Type"), Location = dr.Field<string>("Location"), Room = dr.Field<int>("Room"), Price = dr.Field<decimal>("Price"), Contact = dr.Field<string>("Contact") };
                gridHouse.DataSource = clsGlobal.Row_House.CopyToDataTable();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            lblInfo.Text = "Now Add House";
            btnEnable(false, false, false, true, true);
            txtEnable(true, true, true, true, true);
            txtLocation.Focus();
            txtLocation.Clear();
            txtContact.Clear();
            txtPrice.Clear();
            txtContact.Clear();
            cboType.SelectedIndex = -1;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mode = "update";
            lblInfo.Text = "Now Update House";
            btnEnable(false, false, false, true, true);
            txtEnable(true, true, true, true, true);
            txtLocation.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                lblInfo.Text = "";
                clsAdmin.AddNewHouse(clsGlobal.myCon, clsGlobal.path, tabHouse, txtLocation.Text, cboType.Text, txtContact.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtRoom.Text));
                MessageBox.Show("New house was added successfully!", "Add New House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEnable(true, true, true, false, false);
                txtEnable(false, false, false, false, false);

                
            }
            else if (mode == "update")
            {
                lblInfo.Text = "";
                clsAdmin.UpdateHouse(clsGlobal.myCon, clsGlobal.path, tabHouse, row_index, txtLocation.Text, cboType.Text, txtContact.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtRoom.Text));
                MessageBox.Show("House was updated successfully!", "Update House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEnable(true, true, true, false, false);
                txtEnable(false, false, false, false, false);
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete selected house?", "Delete House", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    clsAdmin.DeleteHouse(clsGlobal.myCon, clsGlobal.path, tabHouse, row_index);
                    MessageBox.Show("House was deleted successfully!", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void gridHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;

            cboType.Text = gridHouse.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLocation.Text = gridHouse.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRoom.Text = gridHouse.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = gridHouse.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtContact.Text = gridHouse.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            gridHouse.DataSource = tabHouse;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            var DisplayHouse =  from DataRow dr in tabHouse.Rows
                                where dr.Field<Int32>("RefHouse") == Convert.ToInt32(txtRefHouse.Text)
                                select new { RefHouse = dr.Field<Int32>("RefHouse"), Type = dr.Field<string>("Type"), Location = dr.Field<string>("Location"), Room = dr.Field<Int32>("Room") ,Price = dr.Field<decimal>("Price"), Contact = dr.Field<string>("Contact") };
            gridHouse.DataSource = DisplayHouse.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
