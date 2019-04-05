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
using System.Data.OleDb;
namespace RemaxApplication_JoonwooKim.GUI
{
    public partial class frmManageEmployee : Form
    {
        public frmManageEmployee()
        {
            InitializeComponent();
        }
        int current;
        DataTable tabEmp;
        string mode;
        int row_index;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Add New Employee";
            txtID.Focus();
            TXT_ReadOnly(true, true, true, true, true, true);
            BtnEnabled(false, false, false, true, true);
            txtID.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cboPosition.SelectedIndex = -1;

            mode = "add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                lblInfo.Text = "";
                clsAdmin.AddNewEmp(clsGlobal.myCon, clsGlobal.path, tabEmp, txtID.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, cboPosition.Text);
                MessageBox.Show("New employee was added successfully!", "Add New Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEnabled(true, true, true, false, false);
                TXT_ReadOnly(false,false,false,false,false,false);
                mode = "";
                
            }
            else if (mode == "update")
            {
                lblInfo.Text = "";
                clsAdmin.UpdateEmp(clsGlobal.myCon, clsGlobal.path, tabEmp, row_index, txtID.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, cboPosition.Text);
                MessageBox.Show("Employee was updated successfully!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEnabled(true, true, true, false, false);
                TXT_ReadOnly(false, false, false, false, false,false);
                mode = "";
                
            }
        }

        
        private void BtnEnabled(bool add, bool update, bool delete, bool save, bool cancel)
        {
            btnAdd.Enabled = add;
            btnUpdate.Enabled = update;
            btnDelete.Enabled = delete;
            btnSave.Enabled = save;
            btnCancel.Enabled = cancel;
        }
        private void TXT_ReadOnly(bool id, bool pw, bool fn, bool ln, bool phone, bool post)
        {
            txtID.Enabled = id;
            txtPassword.Enabled = pw;
            txtFirstName.Enabled = fn;
            txtLastName.Enabled = ln;
            txtPhone.Enabled = phone;
            cboPosition.Enabled = post;
        }
        
        private void frmManageEmployee_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            gridEmp.ReadOnly = true;
            tabEmp = clsGlobal.mySet.Tables["Employee"];
            gridEmp.DataSource = tabEmp;
            BtnEnabled(true, true, true, false, false);
            TXT_ReadOnly(false, false, false, false, false, false);
            current = 0;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete selected employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    clsAdmin.DeleteEmp(clsGlobal.myCon, clsGlobal.path, tabEmp, row_index);
                    MessageBox.Show("Employee was deleted successfully!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gridEmp.DataSource = tabEmp;
            txtID.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cboPosition.SelectedIndex = -1;
            TXT_ReadOnly(false, false, false, false, false, false);
            BtnEnabled(true, true, true, false, false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Update Employee";
            mode = "update";

            TXT_ReadOnly(true, true, true, true, true, true);
            BtnEnabled(false, false, false, true, true);
            txtID.Focus();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var DisplayEmp = from DataRow dr in tabEmp.Rows
                                 where dr.Field<string>("EmpID") == txtSearchID.Text
                                 select new { RefEmp = dr.Field<Int32>("RefEmp"), EmpID = dr.Field<string>("EmpID"), Password = dr.Field<string>("EmpPW"), FirstName = dr.Field<string>("FirstName"), LastName = dr.Field<string>("LastName"), Phone = dr.Field<string>("Phone"), Position = dr.Field<string>("Post") };
                gridEmp.DataSource = DisplayEmp.ToList();
            }
            catch
            {
                MessageBox.Show("Employee ID does not exist!", "Search ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void gridEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;
            txtID.Text = gridEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = gridEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFirstName.Text = gridEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLastName.Text = gridEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhone.Text = gridEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
            cboPosition.Text = gridEmp.Rows[e.RowIndex].Cells[6].Value.ToString();
            

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            gridEmp.DataSource = tabEmp;
        }
    }
}
