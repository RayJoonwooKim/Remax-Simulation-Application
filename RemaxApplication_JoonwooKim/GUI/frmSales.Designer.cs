namespace RemaxApplication_JoonwooKim.GUI
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.RadEmp = new System.Windows.Forms.RadioButton();
            this.RadHouse = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.RadClient = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearchStatus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefSales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRefHouse = new System.Windows.Forms.TextBox();
            this.cboUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSales
            // 
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSales.Location = new System.Drawing.Point(268, 118);
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(541, 361);
            this.gridSales.TabIndex = 0;
            this.gridSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadClient);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.RadHouse);
            this.groupBox1.Controls.Add(this.RadEmp);
            this.groupBox1.Controls.Add(this.radSales);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Reference";
            // 
            // radSales
            // 
            this.radSales.AutoSize = true;
            this.radSales.Location = new System.Drawing.Point(22, 43);
            this.radSales.Name = "radSales";
            this.radSales.Size = new System.Drawing.Size(182, 28);
            this.radSales.TabIndex = 0;
            this.radSales.TabStop = true;
            this.radSales.Text = "Sales Reference";
            this.radSales.UseVisualStyleBackColor = true;
            // 
            // RadEmp
            // 
            this.RadEmp.AutoSize = true;
            this.RadEmp.Location = new System.Drawing.Point(22, 77);
            this.RadEmp.Name = "RadEmp";
            this.RadEmp.Size = new System.Drawing.Size(225, 28);
            this.RadEmp.TabIndex = 1;
            this.RadEmp.TabStop = true;
            this.RadEmp.Text = "Employee Reference";
            this.RadEmp.UseVisualStyleBackColor = true;
            // 
            // RadHouse
            // 
            this.RadHouse.AutoSize = true;
            this.RadHouse.Location = new System.Drawing.Point(22, 145);
            this.RadHouse.Name = "RadHouse";
            this.RadHouse.Size = new System.Drawing.Size(192, 28);
            this.RadHouse.TabIndex = 2;
            this.RadHouse.TabStop = true;
            this.RadHouse.Text = "House Reference";
            this.RadHouse.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 201);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(133, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // RadClient
            // 
            this.RadClient.AutoSize = true;
            this.RadClient.Location = new System.Drawing.Point(22, 111);
            this.RadClient.Name = "RadClient";
            this.RadClient.Size = new System.Drawing.Size(184, 28);
            this.RadClient.TabIndex = 5;
            this.RadClient.TabStop = true;
            this.RadClient.Text = "Client Reference";
            this.RadClient.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchStatus);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Status";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "On Hold",
            "Completed"});
            this.cboStatus.Location = new System.Drawing.Point(6, 48);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 32);
            this.cboStatus.TabIndex = 0;
            // 
            // btnSearchStatus
            // 
            this.btnSearchStatus.Location = new System.Drawing.Point(133, 48);
            this.btnSearchStatus.Name = "btnSearchStatus";
            this.btnSearchStatus.Size = new System.Drawing.Size(99, 32);
            this.btnSearchStatus.TabIndex = 1;
            this.btnSearchStatus.Text = "Search";
            this.btnSearchStatus.UseVisualStyleBackColor = true;
            this.btnSearchStatus.Click += new System.EventHandler(this.btnSearchStatus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboUpdateStatus);
            this.groupBox3.Controls.Add(this.txtRefHouse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtRefClient);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtRefEmp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRefSales);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(815, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 398);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ref Sales : ";
            // 
            // txtRefSales
            // 
            this.txtRefSales.Location = new System.Drawing.Point(128, 42);
            this.txtRefSales.Name = "txtRefSales";
            this.txtRefSales.Size = new System.Drawing.Size(100, 29);
            this.txtRefSales.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ref Emp : ";
            // 
            // txtRefEmp
            // 
            this.txtRefEmp.Location = new System.Drawing.Point(128, 91);
            this.txtRefEmp.Name = "txtRefEmp";
            this.txtRefEmp.Size = new System.Drawing.Size(100, 29);
            this.txtRefEmp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ref Client : ";
            // 
            // txtRefClient
            // 
            this.txtRefClient.Location = new System.Drawing.Point(128, 144);
            this.txtRefClient.Name = "txtRefClient";
            this.txtRefClient.Size = new System.Drawing.Size(100, 29);
            this.txtRefClient.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ref House : ";
            // 
            // txtRefHouse
            // 
            this.txtRefHouse.Location = new System.Drawing.Point(128, 192);
            this.txtRefHouse.Name = "txtRefHouse";
            this.txtRefHouse.Size = new System.Drawing.Size(100, 29);
            this.txtRefHouse.TabIndex = 7;
            // 
            // cboUpdateStatus
            // 
            this.cboUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateStatus.FormattingEnabled = true;
            this.cboUpdateStatus.Items.AddRange(new object[] {
            "On Hold",
            "Completed"});
            this.cboUpdateStatus.Location = new System.Drawing.Point(128, 241);
            this.cboUpdateStatus.Name = "cboUpdateStatus";
            this.cboUpdateStatus.Size = new System.Drawing.Size(121, 32);
            this.cboUpdateStatus.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(35, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(693, 485);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(116, 31);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 540);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSales";
            this.Text = "REMAX Sales Window";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton RadHouse;
        private System.Windows.Forms.RadioButton RadEmp;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton RadClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRefClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRefEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRefSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.TextBox txtRefHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewAll;
    }
}