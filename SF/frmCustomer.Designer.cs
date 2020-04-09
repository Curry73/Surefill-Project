namespace SF
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnCancelAddCust = new System.Windows.Forms.Button();
            this.btnConfirmAddCust = new System.Windows.Forms.Button();
            this.lblADD = new System.Windows.Forms.Label();
            this.txtAddCustEmail = new System.Windows.Forms.TextBox();
            this.txtAddCustTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtAddCustPostcode = new System.Windows.Forms.TextBox();
            this.txtAddCustCounty = new System.Windows.Forms.TextBox();
            this.txtAddCustTown = new System.Windows.Forms.TextBox();
            this.txtAddCustStreet = new System.Windows.Forms.TextBox();
            this.txtAddCustSurname = new System.Windows.Forms.TextBox();
            this.txtAddCustForename = new System.Windows.Forms.TextBox();
            this.lblAddActualCustomerNo = new System.Windows.Forms.Label();
            this.lblAddCustEmail = new System.Windows.Forms.Label();
            this.lblAddCustTelephoneNo = new System.Windows.Forms.Label();
            this.lblAddCustPostcode = new System.Windows.Forms.Label();
            this.lblAddCustCounty = new System.Windows.Forms.Label();
            this.lblAddCustTown = new System.Windows.Forms.Label();
            this.lblAddCustStreet = new System.Windows.Forms.Label();
            this.lblAddCustSurname = new System.Windows.Forms.Label();
            this.lblAddCustForename = new System.Windows.Forms.Label();
            this.lblAddCustNo = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnCancelEditCust = new System.Windows.Forms.Button();
            this.btnConfirmEditCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditCustEmail = new System.Windows.Forms.TextBox();
            this.txtEditCustTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtEditCustPostcode = new System.Windows.Forms.TextBox();
            this.txtEditCustCounty = new System.Windows.Forms.TextBox();
            this.txtEditCustTown = new System.Windows.Forms.TextBox();
            this.txtEditCustStreet = new System.Windows.Forms.TextBox();
            this.txtEditCustSurname = new System.Windows.Forms.TextBox();
            this.txtEditCustForename = new System.Windows.Forms.TextBox();
            this.lblEditActaulCustNo = new System.Windows.Forms.Label();
            this.lblEditCustEmail = new System.Windows.Forms.Label();
            this.lblEditCustTelephoneNo = new System.Windows.Forms.Label();
            this.lblEditCustPostcode = new System.Windows.Forms.Label();
            this.lblEditCustCounty = new System.Windows.Forms.Label();
            this.lblEditCustTown = new System.Windows.Forms.Label();
            this.lblEditCustStreet = new System.Windows.Forms.Label();
            this.lblEditCustSurname = new System.Windows.Forms.Label();
            this.lblEditCustForename = new System.Windows.Forms.Label();
            this.lblEditCustNo = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnCancelCustSearch = new System.Windows.Forms.Button();
            this.txtSearchCustCounty = new System.Windows.Forms.TextBox();
            this.txtSearchCustForename = new System.Windows.Forms.TextBox();
            this.lblSearchCustCounty = new System.Windows.Forms.Label();
            this.lblSearchCustForename = new System.Windows.Forms.Label();
            this.lblSEARCH = new System.Windows.Forms.Label();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDeleteCustCancel = new System.Windows.Forms.Button();
            this.btnConfirmDeleteCust = new System.Windows.Forms.Button();
            this.lblActualCustNoDelete = new System.Windows.Forms.Label();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(1, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(620, 380);
            this.dgvCustomers.TabIndex = 20;
            // 
            // tmrBanner
            // 
            this.tmrBanner.Enabled = true;
            this.tmrBanner.Interval = 50;
            this.tmrBanner.Tick += new System.EventHandler(this.tmrBanner_Tick);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlAdd.Controls.Add(this.btnCancelAddCust);
            this.pnlAdd.Controls.Add(this.btnConfirmAddCust);
            this.pnlAdd.Controls.Add(this.lblADD);
            this.pnlAdd.Controls.Add(this.txtAddCustEmail);
            this.pnlAdd.Controls.Add(this.txtAddCustTelephoneNo);
            this.pnlAdd.Controls.Add(this.txtAddCustPostcode);
            this.pnlAdd.Controls.Add(this.txtAddCustCounty);
            this.pnlAdd.Controls.Add(this.txtAddCustTown);
            this.pnlAdd.Controls.Add(this.txtAddCustStreet);
            this.pnlAdd.Controls.Add(this.txtAddCustSurname);
            this.pnlAdd.Controls.Add(this.txtAddCustForename);
            this.pnlAdd.Controls.Add(this.lblAddActualCustomerNo);
            this.pnlAdd.Controls.Add(this.lblAddCustEmail);
            this.pnlAdd.Controls.Add(this.lblAddCustTelephoneNo);
            this.pnlAdd.Controls.Add(this.lblAddCustPostcode);
            this.pnlAdd.Controls.Add(this.lblAddCustCounty);
            this.pnlAdd.Controls.Add(this.lblAddCustTown);
            this.pnlAdd.Controls.Add(this.lblAddCustStreet);
            this.pnlAdd.Controls.Add(this.lblAddCustSurname);
            this.pnlAdd.Controls.Add(this.lblAddCustForename);
            this.pnlAdd.Controls.Add(this.lblAddCustNo);
            this.pnlAdd.Location = new System.Drawing.Point(638, 12);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(230, 380);
            this.pnlAdd.TabIndex = 45;
            // 
            // btnCancelAddCust
            // 
            this.btnCancelAddCust.Location = new System.Drawing.Point(143, 330);
            this.btnCancelAddCust.Name = "btnCancelAddCust";
            this.btnCancelAddCust.Size = new System.Drawing.Size(75, 25);
            this.btnCancelAddCust.TabIndex = 20;
            this.btnCancelAddCust.Text = "Cancel";
            this.btnCancelAddCust.UseVisualStyleBackColor = true;
            this.btnCancelAddCust.Click += new System.EventHandler(this.btnCancelAddCust_Click);
            // 
            // btnConfirmAddCust
            // 
            this.btnConfirmAddCust.Location = new System.Drawing.Point(49, 330);
            this.btnConfirmAddCust.Name = "btnConfirmAddCust";
            this.btnConfirmAddCust.Size = new System.Drawing.Size(75, 25);
            this.btnConfirmAddCust.TabIndex = 19;
            this.btnConfirmAddCust.Text = "Add";
            this.btnConfirmAddCust.UseVisualStyleBackColor = true;
            this.btnConfirmAddCust.Click += new System.EventHandler(this.btnConfirmAddCust_Click);
            // 
            // lblADD
            // 
            this.lblADD.AutoSize = true;
            this.lblADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADD.Location = new System.Drawing.Point(103, 9);
            this.lblADD.Name = "lblADD";
            this.lblADD.Size = new System.Drawing.Size(33, 13);
            this.lblADD.TabIndex = 18;
            this.lblADD.Text = "ADD";
            this.lblADD.Click += new System.EventHandler(this.lblADD_Click);
            // 
            // txtAddCustEmail
            // 
            this.txtAddCustEmail.Location = new System.Drawing.Point(118, 277);
            this.txtAddCustEmail.Name = "txtAddCustEmail";
            this.txtAddCustEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustEmail.TabIndex = 17;
            // 
            // txtAddCustTelephoneNo
            // 
            this.txtAddCustTelephoneNo.Location = new System.Drawing.Point(118, 247);
            this.txtAddCustTelephoneNo.Name = "txtAddCustTelephoneNo";
            this.txtAddCustTelephoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustTelephoneNo.TabIndex = 16;
            // 
            // txtAddCustPostcode
            // 
            this.txtAddCustPostcode.Location = new System.Drawing.Point(118, 216);
            this.txtAddCustPostcode.Name = "txtAddCustPostcode";
            this.txtAddCustPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustPostcode.TabIndex = 15;
            // 
            // txtAddCustCounty
            // 
            this.txtAddCustCounty.Location = new System.Drawing.Point(118, 189);
            this.txtAddCustCounty.Name = "txtAddCustCounty";
            this.txtAddCustCounty.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustCounty.TabIndex = 14;
            // 
            // txtAddCustTown
            // 
            this.txtAddCustTown.Location = new System.Drawing.Point(118, 157);
            this.txtAddCustTown.Name = "txtAddCustTown";
            this.txtAddCustTown.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustTown.TabIndex = 13;
            // 
            // txtAddCustStreet
            // 
            this.txtAddCustStreet.Location = new System.Drawing.Point(118, 122);
            this.txtAddCustStreet.Name = "txtAddCustStreet";
            this.txtAddCustStreet.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustStreet.TabIndex = 12;
            // 
            // txtAddCustSurname
            // 
            this.txtAddCustSurname.Location = new System.Drawing.Point(118, 94);
            this.txtAddCustSurname.Name = "txtAddCustSurname";
            this.txtAddCustSurname.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustSurname.TabIndex = 11;
            // 
            // txtAddCustForename
            // 
            this.txtAddCustForename.Location = new System.Drawing.Point(118, 60);
            this.txtAddCustForename.Name = "txtAddCustForename";
            this.txtAddCustForename.Size = new System.Drawing.Size(100, 20);
            this.txtAddCustForename.TabIndex = 10;
            // 
            // lblAddActualCustomerNo
            // 
            this.lblAddActualCustomerNo.AutoSize = true;
            this.lblAddActualCustomerNo.Location = new System.Drawing.Point(119, 31);
            this.lblAddActualCustomerNo.Name = "lblAddActualCustomerNo";
            this.lblAddActualCustomerNo.Size = new System.Drawing.Size(54, 13);
            this.lblAddActualCustomerNo.TabIndex = 9;
            this.lblAddActualCustomerNo.Text = "NUMBER";
            this.lblAddActualCustomerNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddCustEmail
            // 
            this.lblAddCustEmail.AutoSize = true;
            this.lblAddCustEmail.Location = new System.Drawing.Point(18, 282);
            this.lblAddCustEmail.Name = "lblAddCustEmail";
            this.lblAddCustEmail.Size = new System.Drawing.Size(32, 13);
            this.lblAddCustEmail.TabIndex = 8;
            this.lblAddCustEmail.Text = "Email";
            // 
            // lblAddCustTelephoneNo
            // 
            this.lblAddCustTelephoneNo.AutoSize = true;
            this.lblAddCustTelephoneNo.Location = new System.Drawing.Point(18, 252);
            this.lblAddCustTelephoneNo.Name = "lblAddCustTelephoneNo";
            this.lblAddCustTelephoneNo.Size = new System.Drawing.Size(77, 13);
            this.lblAddCustTelephoneNo.TabIndex = 7;
            this.lblAddCustTelephoneNo.Text = "Telephione No";
            // 
            // lblAddCustPostcode
            // 
            this.lblAddCustPostcode.AutoSize = true;
            this.lblAddCustPostcode.Location = new System.Drawing.Point(18, 221);
            this.lblAddCustPostcode.Name = "lblAddCustPostcode";
            this.lblAddCustPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblAddCustPostcode.TabIndex = 6;
            this.lblAddCustPostcode.Text = "Postcode";
            // 
            // lblAddCustCounty
            // 
            this.lblAddCustCounty.AutoSize = true;
            this.lblAddCustCounty.Location = new System.Drawing.Point(18, 187);
            this.lblAddCustCounty.Name = "lblAddCustCounty";
            this.lblAddCustCounty.Size = new System.Drawing.Size(40, 13);
            this.lblAddCustCounty.TabIndex = 5;
            this.lblAddCustCounty.Text = "County";
            // 
            // lblAddCustTown
            // 
            this.lblAddCustTown.AutoSize = true;
            this.lblAddCustTown.Location = new System.Drawing.Point(18, 155);
            this.lblAddCustTown.Name = "lblAddCustTown";
            this.lblAddCustTown.Size = new System.Drawing.Size(34, 13);
            this.lblAddCustTown.TabIndex = 4;
            this.lblAddCustTown.Text = "Town";
            // 
            // lblAddCustStreet
            // 
            this.lblAddCustStreet.AutoSize = true;
            this.lblAddCustStreet.Location = new System.Drawing.Point(18, 120);
            this.lblAddCustStreet.Name = "lblAddCustStreet";
            this.lblAddCustStreet.Size = new System.Drawing.Size(35, 13);
            this.lblAddCustStreet.TabIndex = 3;
            this.lblAddCustStreet.Text = "Street";
            // 
            // lblAddCustSurname
            // 
            this.lblAddCustSurname.AutoSize = true;
            this.lblAddCustSurname.Location = new System.Drawing.Point(18, 89);
            this.lblAddCustSurname.Name = "lblAddCustSurname";
            this.lblAddCustSurname.Size = new System.Drawing.Size(49, 13);
            this.lblAddCustSurname.TabIndex = 2;
            this.lblAddCustSurname.Text = "Surname";
            // 
            // lblAddCustForename
            // 
            this.lblAddCustForename.AutoSize = true;
            this.lblAddCustForename.Location = new System.Drawing.Point(18, 61);
            this.lblAddCustForename.Name = "lblAddCustForename";
            this.lblAddCustForename.Size = new System.Drawing.Size(54, 13);
            this.lblAddCustForename.TabIndex = 1;
            this.lblAddCustForename.Text = "Forename";
            // 
            // lblAddCustNo
            // 
            this.lblAddCustNo.AutoSize = true;
            this.lblAddCustNo.Location = new System.Drawing.Point(14, 31);
            this.lblAddCustNo.Name = "lblAddCustNo";
            this.lblAddCustNo.Size = new System.Drawing.Size(68, 13);
            this.lblAddCustNo.TabIndex = 0;
            this.lblAddCustNo.Text = "Customer No";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Maroon;
            this.pnlEdit.Controls.Add(this.btnCancelEditCust);
            this.pnlEdit.Controls.Add(this.btnConfirmEditCust);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.txtEditCustEmail);
            this.pnlEdit.Controls.Add(this.txtEditCustTelephoneNo);
            this.pnlEdit.Controls.Add(this.txtEditCustPostcode);
            this.pnlEdit.Controls.Add(this.txtEditCustCounty);
            this.pnlEdit.Controls.Add(this.txtEditCustTown);
            this.pnlEdit.Controls.Add(this.txtEditCustStreet);
            this.pnlEdit.Controls.Add(this.txtEditCustSurname);
            this.pnlEdit.Controls.Add(this.txtEditCustForename);
            this.pnlEdit.Controls.Add(this.lblEditActaulCustNo);
            this.pnlEdit.Controls.Add(this.lblEditCustEmail);
            this.pnlEdit.Controls.Add(this.lblEditCustTelephoneNo);
            this.pnlEdit.Controls.Add(this.lblEditCustPostcode);
            this.pnlEdit.Controls.Add(this.lblEditCustCounty);
            this.pnlEdit.Controls.Add(this.lblEditCustTown);
            this.pnlEdit.Controls.Add(this.lblEditCustStreet);
            this.pnlEdit.Controls.Add(this.lblEditCustSurname);
            this.pnlEdit.Controls.Add(this.lblEditCustForename);
            this.pnlEdit.Controls.Add(this.lblEditCustNo);
            this.pnlEdit.Location = new System.Drawing.Point(638, 12);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(230, 380);
            this.pnlEdit.TabIndex = 46;
            // 
            // btnCancelEditCust
            // 
            this.btnCancelEditCust.Location = new System.Drawing.Point(136, 327);
            this.btnCancelEditCust.Name = "btnCancelEditCust";
            this.btnCancelEditCust.Size = new System.Drawing.Size(75, 25);
            this.btnCancelEditCust.TabIndex = 21;
            this.btnCancelEditCust.Text = "Cancel";
            this.btnCancelEditCust.UseVisualStyleBackColor = true;
            this.btnCancelEditCust.Click += new System.EventHandler(this.btnCancelEditCust_Click);
            // 
            // btnConfirmEditCust
            // 
            this.btnConfirmEditCust.Location = new System.Drawing.Point(45, 327);
            this.btnConfirmEditCust.Name = "btnConfirmEditCust";
            this.btnConfirmEditCust.Size = new System.Drawing.Size(75, 25);
            this.btnConfirmEditCust.TabIndex = 20;
            this.btnConfirmEditCust.Text = "Edit";
            this.btnConfirmEditCust.UseVisualStyleBackColor = true;
            this.btnConfirmEditCust.Click += new System.EventHandler(this.btnConfirmEditCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "EDIT";
            // 
            // txtEditCustEmail
            // 
            this.txtEditCustEmail.Location = new System.Drawing.Point(111, 277);
            this.txtEditCustEmail.Name = "txtEditCustEmail";
            this.txtEditCustEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustEmail.TabIndex = 17;
            // 
            // txtEditCustTelephoneNo
            // 
            this.txtEditCustTelephoneNo.Location = new System.Drawing.Point(111, 247);
            this.txtEditCustTelephoneNo.Name = "txtEditCustTelephoneNo";
            this.txtEditCustTelephoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustTelephoneNo.TabIndex = 16;
            // 
            // txtEditCustPostcode
            // 
            this.txtEditCustPostcode.Location = new System.Drawing.Point(111, 216);
            this.txtEditCustPostcode.Name = "txtEditCustPostcode";
            this.txtEditCustPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustPostcode.TabIndex = 15;
            // 
            // txtEditCustCounty
            // 
            this.txtEditCustCounty.Location = new System.Drawing.Point(111, 189);
            this.txtEditCustCounty.Name = "txtEditCustCounty";
            this.txtEditCustCounty.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustCounty.TabIndex = 14;
            // 
            // txtEditCustTown
            // 
            this.txtEditCustTown.Location = new System.Drawing.Point(111, 157);
            this.txtEditCustTown.Name = "txtEditCustTown";
            this.txtEditCustTown.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustTown.TabIndex = 13;
            // 
            // txtEditCustStreet
            // 
            this.txtEditCustStreet.Location = new System.Drawing.Point(111, 122);
            this.txtEditCustStreet.Name = "txtEditCustStreet";
            this.txtEditCustStreet.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustStreet.TabIndex = 12;
            // 
            // txtEditCustSurname
            // 
            this.txtEditCustSurname.Location = new System.Drawing.Point(111, 94);
            this.txtEditCustSurname.Name = "txtEditCustSurname";
            this.txtEditCustSurname.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustSurname.TabIndex = 11;
            // 
            // txtEditCustForename
            // 
            this.txtEditCustForename.Location = new System.Drawing.Point(111, 60);
            this.txtEditCustForename.Name = "txtEditCustForename";
            this.txtEditCustForename.Size = new System.Drawing.Size(100, 20);
            this.txtEditCustForename.TabIndex = 10;
            // 
            // lblEditActaulCustNo
            // 
            this.lblEditActaulCustNo.AutoSize = true;
            this.lblEditActaulCustNo.Location = new System.Drawing.Point(112, 31);
            this.lblEditActaulCustNo.Name = "lblEditActaulCustNo";
            this.lblEditActaulCustNo.Size = new System.Drawing.Size(49, 13);
            this.lblEditActaulCustNo.TabIndex = 9;
            this.lblEditActaulCustNo.Text = "NUMBEr";
            // 
            // lblEditCustEmail
            // 
            this.lblEditCustEmail.AutoSize = true;
            this.lblEditCustEmail.Location = new System.Drawing.Point(11, 284);
            this.lblEditCustEmail.Name = "lblEditCustEmail";
            this.lblEditCustEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEditCustEmail.TabIndex = 8;
            this.lblEditCustEmail.Text = "Email";
            // 
            // lblEditCustTelephoneNo
            // 
            this.lblEditCustTelephoneNo.AutoSize = true;
            this.lblEditCustTelephoneNo.Location = new System.Drawing.Point(11, 254);
            this.lblEditCustTelephoneNo.Name = "lblEditCustTelephoneNo";
            this.lblEditCustTelephoneNo.Size = new System.Drawing.Size(77, 13);
            this.lblEditCustTelephoneNo.TabIndex = 7;
            this.lblEditCustTelephoneNo.Text = "Telephione No";
            // 
            // lblEditCustPostcode
            // 
            this.lblEditCustPostcode.AutoSize = true;
            this.lblEditCustPostcode.Location = new System.Drawing.Point(11, 223);
            this.lblEditCustPostcode.Name = "lblEditCustPostcode";
            this.lblEditCustPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblEditCustPostcode.TabIndex = 6;
            this.lblEditCustPostcode.Text = "Postcode";
            // 
            // lblEditCustCounty
            // 
            this.lblEditCustCounty.AutoSize = true;
            this.lblEditCustCounty.Location = new System.Drawing.Point(11, 189);
            this.lblEditCustCounty.Name = "lblEditCustCounty";
            this.lblEditCustCounty.Size = new System.Drawing.Size(40, 13);
            this.lblEditCustCounty.TabIndex = 5;
            this.lblEditCustCounty.Text = "County";
            // 
            // lblEditCustTown
            // 
            this.lblEditCustTown.AutoSize = true;
            this.lblEditCustTown.Location = new System.Drawing.Point(11, 157);
            this.lblEditCustTown.Name = "lblEditCustTown";
            this.lblEditCustTown.Size = new System.Drawing.Size(34, 13);
            this.lblEditCustTown.TabIndex = 4;
            this.lblEditCustTown.Text = "Town";
            // 
            // lblEditCustStreet
            // 
            this.lblEditCustStreet.AutoSize = true;
            this.lblEditCustStreet.Location = new System.Drawing.Point(11, 122);
            this.lblEditCustStreet.Name = "lblEditCustStreet";
            this.lblEditCustStreet.Size = new System.Drawing.Size(35, 13);
            this.lblEditCustStreet.TabIndex = 3;
            this.lblEditCustStreet.Text = "Street";
            // 
            // lblEditCustSurname
            // 
            this.lblEditCustSurname.AutoSize = true;
            this.lblEditCustSurname.Location = new System.Drawing.Point(11, 91);
            this.lblEditCustSurname.Name = "lblEditCustSurname";
            this.lblEditCustSurname.Size = new System.Drawing.Size(49, 13);
            this.lblEditCustSurname.TabIndex = 2;
            this.lblEditCustSurname.Text = "Surname";
            // 
            // lblEditCustForename
            // 
            this.lblEditCustForename.AutoSize = true;
            this.lblEditCustForename.Location = new System.Drawing.Point(11, 63);
            this.lblEditCustForename.Name = "lblEditCustForename";
            this.lblEditCustForename.Size = new System.Drawing.Size(54, 13);
            this.lblEditCustForename.TabIndex = 1;
            this.lblEditCustForename.Text = "Forename";
            // 
            // lblEditCustNo
            // 
            this.lblEditCustNo.AutoSize = true;
            this.lblEditCustNo.Location = new System.Drawing.Point(11, 31);
            this.lblEditCustNo.Name = "lblEditCustNo";
            this.lblEditCustNo.Size = new System.Drawing.Size(68, 13);
            this.lblEditCustNo.TabIndex = 0;
            this.lblEditCustNo.Text = "Customer No";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlSearch.Controls.Add(this.btnCancelCustSearch);
            this.pnlSearch.Controls.Add(this.txtSearchCustCounty);
            this.pnlSearch.Controls.Add(this.txtSearchCustForename);
            this.pnlSearch.Controls.Add(this.lblSearchCustCounty);
            this.pnlSearch.Controls.Add(this.lblSearchCustForename);
            this.pnlSearch.Controls.Add(this.lblSEARCH);
            this.pnlSearch.Location = new System.Drawing.Point(51, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(230, 380);
            this.pnlSearch.TabIndex = 48;
            // 
            // btnCancelCustSearch
            // 
            this.btnCancelCustSearch.Location = new System.Drawing.Point(85, 225);
            this.btnCancelCustSearch.Name = "btnCancelCustSearch";
            this.btnCancelCustSearch.Size = new System.Drawing.Size(75, 25);
            this.btnCancelCustSearch.TabIndex = 38;
            this.btnCancelCustSearch.Text = "Cancel";
            this.btnCancelCustSearch.UseVisualStyleBackColor = true;
            this.btnCancelCustSearch.Click += new System.EventHandler(this.btnCancelCustSearch_Click);
            // 
            // txtSearchCustCounty
            // 
            this.txtSearchCustCounty.Location = new System.Drawing.Point(106, 162);
            this.txtSearchCustCounty.Name = "txtSearchCustCounty";
            this.txtSearchCustCounty.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustCounty.TabIndex = 32;
            this.txtSearchCustCounty.TextChanged += new System.EventHandler(this.txtSearchCustCounty_TextChanged);
            // 
            // txtSearchCustForename
            // 
            this.txtSearchCustForename.Location = new System.Drawing.Point(106, 115);
            this.txtSearchCustForename.Name = "txtSearchCustForename";
            this.txtSearchCustForename.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustForename.TabIndex = 28;
            this.txtSearchCustForename.TextChanged += new System.EventHandler(this.txtSearchCustForename_TextChanged);
            // 
            // lblSearchCustCounty
            // 
            this.lblSearchCustCounty.AutoSize = true;
            this.lblSearchCustCounty.Location = new System.Drawing.Point(29, 169);
            this.lblSearchCustCounty.Name = "lblSearchCustCounty";
            this.lblSearchCustCounty.Size = new System.Drawing.Size(40, 13);
            this.lblSearchCustCounty.TabIndex = 24;
            this.lblSearchCustCounty.Text = "County";
            // 
            // lblSearchCustForename
            // 
            this.lblSearchCustForename.AutoSize = true;
            this.lblSearchCustForename.Location = new System.Drawing.Point(29, 122);
            this.lblSearchCustForename.Name = "lblSearchCustForename";
            this.lblSearchCustForename.Size = new System.Drawing.Size(54, 13);
            this.lblSearchCustForename.TabIndex = 20;
            this.lblSearchCustForename.Text = "Forename";
            // 
            // lblSEARCH
            // 
            this.lblSEARCH.AutoSize = true;
            this.lblSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEARCH.Location = new System.Drawing.Point(82, 40);
            this.lblSEARCH.Name = "lblSEARCH";
            this.lblSEARCH.Size = new System.Drawing.Size(57, 13);
            this.lblSEARCH.TabIndex = 19;
            this.lblSEARCH.Text = "SEARCH";
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlDelete.Controls.Add(this.btnDeleteCustCancel);
            this.pnlDelete.Controls.Add(this.btnConfirmDeleteCust);
            this.pnlDelete.Controls.Add(this.lblActualCustNoDelete);
            this.pnlDelete.Controls.Add(this.lblDeleteTitle);
            this.pnlDelete.Location = new System.Drawing.Point(638, 12);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(230, 380);
            this.pnlDelete.TabIndex = 47;
            this.pnlDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDelete_Paint);
            // 
            // btnDeleteCustCancel
            // 
            this.btnDeleteCustCancel.Location = new System.Drawing.Point(110, 203);
            this.btnDeleteCustCancel.Name = "btnDeleteCustCancel";
            this.btnDeleteCustCancel.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteCustCancel.TabIndex = 22;
            this.btnDeleteCustCancel.Text = "Cancel";
            this.btnDeleteCustCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCustCancel.Click += new System.EventHandler(this.btnDeleteCustCancel_Click);
            // 
            // btnConfirmDeleteCust
            // 
            this.btnConfirmDeleteCust.Location = new System.Drawing.Point(29, 203);
            this.btnConfirmDeleteCust.Name = "btnConfirmDeleteCust";
            this.btnConfirmDeleteCust.Size = new System.Drawing.Size(75, 25);
            this.btnConfirmDeleteCust.TabIndex = 21;
            this.btnConfirmDeleteCust.Text = "Delete";
            this.btnConfirmDeleteCust.UseVisualStyleBackColor = true;
            this.btnConfirmDeleteCust.Click += new System.EventHandler(this.btnConfirmDeleteCust_Click);
            // 
            // lblActualCustNoDelete
            // 
            this.lblActualCustNoDelete.AutoSize = true;
            this.lblActualCustNoDelete.Location = new System.Drawing.Point(3, 164);
            this.lblActualCustNoDelete.Name = "lblActualCustNoDelete";
            this.lblActualCustNoDelete.Size = new System.Drawing.Size(227, 13);
            this.lblActualCustNoDelete.TabIndex = 20;
            this.lblActualCustNoDelete.Text = "Are you sure you want to delete this customer?";
            this.lblActualCustNoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.AutoSize = true;
            this.lblDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTitle.Location = new System.Drawing.Point(82, 131);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(55, 13);
            this.lblDeleteTitle.TabIndex = 19;
            this.lblDeleteTitle.Text = "DELETE";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(701, 69);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnAddCustomer.TabIndex = 21;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            this.btnAddCustomer.MouseEnter += new System.EventHandler(this.btnAddCustomer_MouseEnter);
            this.btnAddCustomer.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditCustomer.Location = new System.Drawing.Point(701, 140);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnEditCustomer.TabIndex = 22;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            this.btnEditCustomer.MouseEnter += new System.EventHandler(this.btnEditCustomer_MouseEnter);
            this.btnEditCustomer.MouseLeave += new System.EventHandler(this.btnEditCustomer_MouseLeave);
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditCustomer.Location = new System.Drawing.Point(740, 143);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(39, 23);
            this.lblEditCustomer.TabIndex = 25;
            this.lblEditCustomer.Text = "Edit";
            this.lblEditCustomer.Click += new System.EventHandler(this.lblEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(701, 209);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteCustomer.TabIndex = 26;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            this.btnDeleteCustomer.MouseEnter += new System.EventHandler(this.btnDeleteCustomer_MouseEnter);
            this.btnDeleteCustomer.MouseLeave += new System.EventHandler(this.btnDeleteCustomer_MouseLeave);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchCustomer.Location = new System.Drawing.Point(701, 275);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnSearchCustomer.TabIndex = 27;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            this.btnSearchCustomer.MouseEnter += new System.EventHandler(this.btnSearchCustomer_MouseEnter);
            this.btnSearchCustomer.MouseLeave += new System.EventHandler(this.btnSearchCustomer_MouseLeave);
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddCustomer.Location = new System.Drawing.Point(740, 72);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(41, 23);
            this.lblAddCustomer.TabIndex = 28;
            this.lblAddCustomer.Text = "Add";
            this.lblAddCustomer.Click += new System.EventHandler(this.lblAddCustomer_Click);
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(740, 212);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteCustomer.TabIndex = 29;
            this.lblDeleteCustomer.Text = "Delete";
            this.lblDeleteCustomer.Click += new System.EventHandler(this.lblDeleteCustomer_Click);
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchCustomer.Location = new System.Drawing.Point(740, 278);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(62, 23);
            this.lblSearchCustomer.TabIndex = 30;
            this.lblSearchCustomer.Text = "Search";
            this.lblSearchCustomer.Click += new System.EventHandler(this.lblSearchCustomer_Click);
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.lblReturnMenu);
            this.pnlReturn.Controls.Add(this.btnReturnMenu);
            this.pnlReturn.Location = new System.Drawing.Point(701, 326);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(134, 46);
            this.pnlReturn.TabIndex = 44;
            // 
            // lblReturnMenu
            // 
            this.lblReturnMenu.AutoSize = true;
            this.lblReturnMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnMenu.Location = new System.Drawing.Point(39, 13);
            this.lblReturnMenu.Name = "lblReturnMenu";
            this.lblReturnMenu.Size = new System.Drawing.Size(62, 23);
            this.lblReturnMenu.TabIndex = 44;
            this.lblReturnMenu.Text = "Return";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnReturnMenu.BackgroundImage = global::SF.Properties.Resources.returnBLACKANDBLUE;
            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Location = new System.Drawing.Point(0, 10);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnReturnMenu.TabIndex = 43;
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlReturn);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.lblDeleteCustomer);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.lblEditCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlReturn.ResumeLayout(false);
            this.pnlReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Timer tmrBanner;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddCustEmail;
        private System.Windows.Forms.Label lblAddCustTelephoneNo;
        private System.Windows.Forms.Label lblAddCustPostcode;
        private System.Windows.Forms.Label lblAddCustCounty;
        private System.Windows.Forms.Label lblAddCustTown;
        private System.Windows.Forms.Label lblAddCustStreet;
        private System.Windows.Forms.Label lblAddCustSurname;
        private System.Windows.Forms.Label lblAddCustForename;
        private System.Windows.Forms.Label lblAddCustNo;
        private System.Windows.Forms.Label lblAddActualCustomerNo;
        private System.Windows.Forms.TextBox txtAddCustEmail;
        private System.Windows.Forms.TextBox txtAddCustTelephoneNo;
        private System.Windows.Forms.TextBox txtAddCustPostcode;
        private System.Windows.Forms.TextBox txtAddCustCounty;
        private System.Windows.Forms.TextBox txtAddCustTown;
        private System.Windows.Forms.TextBox txtAddCustStreet;
        private System.Windows.Forms.TextBox txtAddCustSurname;
        private System.Windows.Forms.TextBox txtAddCustForename;
        private System.Windows.Forms.Label lblADD;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditCustEmail;
        private System.Windows.Forms.TextBox txtEditCustTelephoneNo;
        private System.Windows.Forms.TextBox txtEditCustPostcode;
        private System.Windows.Forms.TextBox txtEditCustCounty;
        private System.Windows.Forms.TextBox txtEditCustTown;
        private System.Windows.Forms.TextBox txtEditCustStreet;
        private System.Windows.Forms.TextBox txtEditCustSurname;
        private System.Windows.Forms.TextBox txtEditCustForename;
        private System.Windows.Forms.Label lblEditActaulCustNo;
        private System.Windows.Forms.Label lblEditCustEmail;
        private System.Windows.Forms.Label lblEditCustTelephoneNo;
        private System.Windows.Forms.Label lblEditCustPostcode;
        private System.Windows.Forms.Label lblEditCustCounty;
        private System.Windows.Forms.Label lblEditCustTown;
        private System.Windows.Forms.Label lblEditCustStreet;
        private System.Windows.Forms.Label lblEditCustSurname;
        private System.Windows.Forms.Label lblEditCustForename;
        private System.Windows.Forms.Label lblEditCustNo;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Label lblActualCustNoDelete;
        private System.Windows.Forms.Label lblDeleteTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSEARCH;
        private System.Windows.Forms.Button btnCancelAddCust;
        private System.Windows.Forms.Button btnConfirmAddCust;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelEditCust;
        private System.Windows.Forms.Button btnConfirmEditCust;
        private System.Windows.Forms.Button btnConfirmDeleteCust;
        private System.Windows.Forms.Button btnDeleteCustCancel;
        private System.Windows.Forms.TextBox txtSearchCustCounty;
        private System.Windows.Forms.TextBox txtSearchCustForename;
        private System.Windows.Forms.Label lblSearchCustCounty;
        private System.Windows.Forms.Label lblSearchCustForename;
        private System.Windows.Forms.Button btnCancelCustSearch;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}
