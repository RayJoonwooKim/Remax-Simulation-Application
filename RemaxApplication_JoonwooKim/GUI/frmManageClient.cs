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
    public partial class frmManageClient : Form
    {
        public frmManageClient()
        {
            InitializeComponent();
        }
        
        DataTable tabClient, tabEmp;
        string mode;
        int row_index;
        private void frmManageClient_Load(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile == "admin")
            {
                lblInfo.Text = "";
                gridClient.ReadOnly = true;
                tabClient = clsGlobal.mySet.Tables["Client"];
                tabEmp = clsGlobal.mySet.Tables["Employee"];

                gridClient.DataSource = tabClient;
                txtEnable(false, false, false, false, false, false, false, false);
                BtnEnable(true, true, true, false, false);

                var LoadRefE = from DataRow dr in clsGlobal.mySet.Tables["Employee"].Rows
                               select new { re = dr.Field<Int32>("RefEmp") };

                cboRefEmp.DisplayMember = "re";
                cboRefEmp.DataSource = LoadRefE.ToList();

                var LoadRefH = from DataRow dr in clsGlobal.mySet.Tables["House"].Rows
                               select new { rh = dr.Field<Int32>("RefHouse") };
                cboRefHouse.DisplayMember = "rh";
                cboRefHouse.DataSource = LoadRefH.ToList();
            }

            else if (clsGlobal.load_profile == "agent")
            {
                lblInfo.Text = "";
                gridClient.ReadOnly = true;
                tabClient = clsGlobal.mySet.Tables["Client"];
                tabEmp = clsGlobal.mySet.Tables["Employee"];
                
                txtEnable(false, false, false, false, false, false, false, false);
                BtnEnable(true, true, true, false, false);

                int refe = Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"]);
                var LoadClient = from DataRow dr in clsGlobal.mySet.Tables["Client"].Rows
                                 where dr.Field<Int32>("RefEmp") == refe
                                 select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType"), RefEmp = dr.Field<Int32>("RefEmp"), RefHouse = dr.Field<Int32>("RefHouse") };
                gridClient.DataSource = LoadClient.ToList();

                
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile=="admin")
            {
                gridClient.DataSource = tabClient;
            }
            else if (clsGlobal.load_profile=="agent")
            {
                int refe = Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"]);
                var LoadClient = from DataRow dr in clsGlobal.mySet.Tables["Client"].Rows
                                 where dr.Field<Int32>("RefEmp") == refe
                                 select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType"), RefEmp = dr.Field<Int32>("RefEmp"), RefHouse = dr.Field<Int32>("RefHouse") };
                gridClient.DataSource = LoadClient.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Add New Client";
            mode = "add";
            BtnEnable(false, false, false, true, true);
            txtEnable(true, true, true, true, true,true, true,true);
            cboType.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtFirstName.Focus();
        }

        
        private void BtnEnable (bool add, bool update, bool delete, bool save, bool cancel)
        {
            btnAdd.Enabled = add;
            btnUpdate.Enabled = update;
            btnDelete.Enabled = delete;
            btnSave.Enabled = save;
            btnCancel.Enabled = cancel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Update Client";
            mode = "update";
            BtnEnable(false, false, false, true, true);
            txtEnable(true, true, true, true, true, true, true, true);
            txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                clsAdmin.AddNewClient(clsGlobal.myCon, clsGlobal.path, tabClient, txtFirstName.Text, txtLastName.Text, txtPhone.Text, cboType.Text, cboRefEmp.Text, cboRefHouse.Text);
                MessageBox.Show("New client was added successfully!", "Add New Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEnable(true, true, true, false, false);
                txtEnable(false, false, false, false, false, false, false, false);
                lblInfo.Text = "";         
            }
            else if (mode == "update")
            {
                clsAdmin.UpdateClient(clsGlobal.myCon, clsGlobal.path, tabClient, row_index, txtFirstName.Text, txtLastName.Text, txtPhone.Text, cboType.Text, cboRefEmp.Text, cboRefHouse.Text);
                MessageBox.Show("Client was updated successfully!", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                BtnEnable(true, true, true, false, false);
                txtEnable(false, false, false, false, false, false, false, false);
                lblInfo.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete selected client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    clsAdmin.DeleteClient(clsGlobal.myCon, clsGlobal.path, tabClient, row_index);
                    MessageBox.Show("Client was deleted successfully!", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
        }

        private void gridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;
            
            txtFirstName.Text = gridClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = gridClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = gridClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboType.Text = gridClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboRefEmp.Text = gridClient.Rows[e.RowIndex].Cells[5].Value.ToString();
            cboRefHouse.Text = gridClient.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var DisplayClient = from DataRow dr in tabClient.Rows
                                where dr.Field<Int32>("RefClient") == Convert.ToInt32(txtSearchID.Text)
                                select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType") };
            gridClient.DataSource = DisplayClient.ToList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (clsGlobal.load_profile =="admin")
            {
                gridClient.DataSource = tabClient;
            }
            else if (clsGlobal.load_profile == "agent")
            {
                int refe = Convert.ToInt32(clsGlobal.Row_Agent["RefEmp"]);
                var LoadClient = from DataRow dr in clsGlobal.mySet.Tables["Client"].Rows
                                 where dr.Field<Int32>("RefEmp") == refe
                                 select new { RefClient = dr.Field<Int32>("RefClient"), FirstName = dr.Field<string>("ClientFirstName"), LastName = dr.Field<string>("ClientLastName"), Phone = dr.Field<string>("ClientPhone"), Type = dr.Field<string>("ClientType"), RefEmp = dr.Field<Int32>("RefEmp"), RefHouse = dr.Field<Int32>("RefHouse") };
                gridClient.DataSource = LoadClient.ToList();
            }
            
        }

        private void txtEnable (bool r, bool fn, bool ln, bool address, bool phone, bool type, bool refe, bool refh)
        {
            
            txtFirstName.Enabled = fn;
            txtLastName.Enabled = ln;
            txtPhone.Enabled = phone;
            cboType.Enabled = type;
            cboRefEmp.Enabled = refe;
            cboRefHouse.Enabled = refh;
        }
        
    }
}
