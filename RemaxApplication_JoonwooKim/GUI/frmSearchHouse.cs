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
    public partial class frmSearchHouse : Form
    {
        public frmSearchHouse()
        {
            InitializeComponent();
        }
        DataTable tabHouse;
        private void FillPrice()
        {
            for (decimal i = 30000000; i < 99999999; i += 20000000)
            {
                cboPrice.Items.Add(i);
            }
            cboPrice.SelectedIndex = -1;
        }
        private void frmSearchHouse_Load(object sender, EventArgs e)
        {
            gridResult.ReadOnly = true;
            FillPrice();
            tabHouse = clsGlobal.mySet.Tables["House"];
            gridResult.DataSource = tabHouse;

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            gridResult.DataSource = tabHouse;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            var DisplayPrice = from DataRow dr in tabHouse.Rows
                               where dr.Field<decimal>("Price") < Convert.ToDecimal(cboPrice.SelectedItem)
                               select new { RefHouse = dr.Field<Int32>("RefHouse"), Type = dr.Field<string>("Type"), Location = dr.Field<string>("Location"), Room = dr.Field<Int32>("Room"), Price = dr.Field<decimal>("Price"), Contact = dr.Field<string>("Contact") };
            gridResult.DataSource = DisplayPrice.ToList();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            var DisplayPrice = from DataRow dr in tabHouse.Rows
                               where dr.Field<string>("Location").Contains(txtLocation.Text.Trim())
                               select new { RefHouse = dr.Field<Int32>("RefHouse"), Type = dr.Field<string>("Type"), Location = dr.Field<string>("Location"), Room = dr.Field<Int32>("Room"), Price = dr.Field<decimal>("Price"), Contact = dr.Field<string>("Contact") };
            gridResult.DataSource = DisplayPrice.ToList();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            var DisplayPrice = from DataRow dr in tabHouse.Rows
                               where dr.Field<string>("Type") == cboType.Text
                               select new { RefHouse = dr.Field<Int32>("RefHouse"), Type = dr.Field<string>("Type"), Location = dr.Field<string>("Location"), Room = dr.Field<Int32>("Room"), Price = dr.Field<decimal>("Price"), Contact = dr.Field<string>("Contact") };
            gridResult.DataSource = DisplayPrice.ToList();
        }
    }
}
