namespace SF
{
    partial class FrmSupplier
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
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnSearchJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lblSearchSupplier = new System.Windows.Forms.Label();
            this.lblDeleteSupplier = new System.Windows.Forms.Label();
            this.lblAddSupplier = new System.Windows.Forms.Label();
            this.lblEditSupplier = new System.Windows.Forms.Label();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.pnlAddSupplier = new System.Windows.Forms.Panel();
            this.txtAddSupplierTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtAddSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtAddSupplierPostcode = new System.Windows.Forms.TextBox();
            this.txtAddSupplierCounty = new System.Windows.Forms.TextBox();
            this.txtAddSupplierTown = new System.Windows.Forms.TextBox();
            this.txtAddSupplierStreet = new System.Windows.Forms.TextBox();
            this.txtAddSupplierName = new System.Windows.Forms.TextBox();
            this.lblAddActualSupplierNo = new System.Windows.Forms.Label();
            this.lblAddSupplierTelephoneNo = new System.Windows.Forms.Label();
            this.lblAddSupplierEmail = new System.Windows.Forms.Label();
            this.lblAddSupplierPostcode = new System.Windows.Forms.Label();
            this.lblAddSupplierCounty = new System.Windows.Forms.Label();
            this.lblAddSupplierTown = new System.Windows.Forms.Label();
            this.lblAddSupplierStreet = new System.Windows.Forms.Label();
            this.lblAddSupplierName = new System.Windows.Forms.Label();
            this.lblAddSupplierNo = new System.Windows.Forms.Label();
            this.pnlEditSupplier = new System.Windows.Forms.Panel();
            this.txtEditSupplierTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtEditSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtEditSupplierPostcode = new System.Windows.Forms.TextBox();
            this.txtEditSupplierStreet = new System.Windows.Forms.TextBox();
            this.txtEditSupplierTown = new System.Windows.Forms.TextBox();
            this.txtEditSupplierCounty = new System.Windows.Forms.TextBox();
            this.txtEditSupplierName = new System.Windows.Forms.TextBox();
            this.lblEditActualSupplierNo = new System.Windows.Forms.Label();
            this.lblEditSupplierTelephoneNo = new System.Windows.Forms.Label();
            this.lblEditSupplierEmail = new System.Windows.Forms.Label();
            this.lblEditSupplierPostcode = new System.Windows.Forms.Label();
            this.lblEditSupplierCounty = new System.Windows.Forms.Label();
            this.lblEditSupplierTown = new System.Windows.Forms.Label();
            this.lblEditSupplierStreet = new System.Windows.Forms.Label();
            this.lblEditSupplierName = new System.Windows.Forms.Label();
            this.lblEditSupplierNo = new System.Windows.Forms.Label();
            this.btnConfirmEditSupplier = new System.Windows.Forms.Button();
            this.btnCancelEditSupplier = new System.Windows.Forms.Button();
            this.btnConfirmAddSupplier = new System.Windows.Forms.Button();
            this.btnCancelAddSupplier = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlAddSupplier.SuspendLayout();
            this.pnlEditSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 12);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(604, 426);
            this.dgvSuppliers.TabIndex = 0;
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchJob.Location = new System.Drawing.Point(639, 273);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(33, 33);
            this.btnSearchJob.TabIndex = 43;
            this.btnSearchJob.UseVisualStyleBackColor = false;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteJob.Location = new System.Drawing.Point(639, 207);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteJob.TabIndex = 42;
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            // 
            // btnEditJob
            // 
            this.btnEditJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditJob.Location = new System.Drawing.Point(639, 138);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(33, 33);
            this.btnEditJob.TabIndex = 41;
            this.btnEditJob.UseVisualStyleBackColor = false;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Location = new System.Drawing.Point(639, 67);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(33, 33);
            this.btnAddJob.TabIndex = 40;
            this.btnAddJob.UseVisualStyleBackColor = false;
            // 
            // lblSearchSupplier
            // 
            this.lblSearchSupplier.AutoSize = true;
            this.lblSearchSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchSupplier.Location = new System.Drawing.Point(678, 276);
            this.lblSearchSupplier.Name = "lblSearchSupplier";
            this.lblSearchSupplier.Size = new System.Drawing.Size(62, 23);
            this.lblSearchSupplier.TabIndex = 47;
            this.lblSearchSupplier.Text = "Search";
            // 
            // lblDeleteSupplier
            // 
            this.lblDeleteSupplier.AutoSize = true;
            this.lblDeleteSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteSupplier.Location = new System.Drawing.Point(678, 210);
            this.lblDeleteSupplier.Name = "lblDeleteSupplier";
            this.lblDeleteSupplier.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteSupplier.TabIndex = 46;
            this.lblDeleteSupplier.Text = "Delete";
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddSupplier.Location = new System.Drawing.Point(678, 70);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(41, 23);
            this.lblAddSupplier.TabIndex = 45;
            this.lblAddSupplier.Text = "Add";
            // 
            // lblEditSupplier
            // 
            this.lblEditSupplier.AutoSize = true;
            this.lblEditSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditSupplier.Location = new System.Drawing.Point(678, 141);
            this.lblEditSupplier.Name = "lblEditSupplier";
            this.lblEditSupplier.Size = new System.Drawing.Size(39, 23);
            this.lblEditSupplier.TabIndex = 44;
            this.lblEditSupplier.Text = "Edit";
            // 
            // lblReturnMenu
            // 
            this.lblReturnMenu.AutoSize = true;
            this.lblReturnMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnMenu.Location = new System.Drawing.Point(675, 341);
            this.lblReturnMenu.Name = "lblReturnMenu";
            this.lblReturnMenu.Size = new System.Drawing.Size(62, 23);
            this.lblReturnMenu.TabIndex = 48;
            this.lblReturnMenu.Text = "Return";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnReturnMenu.BackgroundImage = global::SF.Properties.Resources.returnBLACKANDBLUE;
            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Location = new System.Drawing.Point(639, 331);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnReturnMenu.TabIndex = 49;
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlAddSupplier
            // 
            this.pnlAddSupplier.Controls.Add(this.btnConfirmAddSupplier);
            this.pnlAddSupplier.Controls.Add(this.btnCancelAddSupplier);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierTelephoneNo);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierEmail);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierPostcode);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierCounty);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierTown);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierStreet);
            this.pnlAddSupplier.Controls.Add(this.txtAddSupplierName);
            this.pnlAddSupplier.Controls.Add(this.lblAddActualSupplierNo);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierTelephoneNo);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierEmail);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierPostcode);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierCounty);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierTown);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierStreet);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierName);
            this.pnlAddSupplier.Controls.Add(this.lblAddSupplierNo);
            this.pnlAddSupplier.Location = new System.Drawing.Point(29, 67);
            this.pnlAddSupplier.Name = "pnlAddSupplier";
            this.pnlAddSupplier.Size = new System.Drawing.Size(227, 341);
            this.pnlAddSupplier.TabIndex = 50;
            // 
            // txtAddSupplierTelephoneNo
            // 
            this.txtAddSupplierTelephoneNo.Location = new System.Drawing.Point(97, 251);
            this.txtAddSupplierTelephoneNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierTelephoneNo.Name = "txtAddSupplierTelephoneNo";
            this.txtAddSupplierTelephoneNo.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierTelephoneNo.TabIndex = 25;
            // 
            // txtAddSupplierEmail
            // 
            this.txtAddSupplierEmail.Location = new System.Drawing.Point(97, 216);
            this.txtAddSupplierEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierEmail.Name = "txtAddSupplierEmail";
            this.txtAddSupplierEmail.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierEmail.TabIndex = 26;
            // 
            // txtAddSupplierPostcode
            // 
            this.txtAddSupplierPostcode.Location = new System.Drawing.Point(97, 181);
            this.txtAddSupplierPostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierPostcode.Name = "txtAddSupplierPostcode";
            this.txtAddSupplierPostcode.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierPostcode.TabIndex = 27;
            // 
            // txtAddSupplierCounty
            // 
            this.txtAddSupplierCounty.Location = new System.Drawing.Point(97, 146);
            this.txtAddSupplierCounty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierCounty.Name = "txtAddSupplierCounty";
            this.txtAddSupplierCounty.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierCounty.TabIndex = 28;
            // 
            // txtAddSupplierTown
            // 
            this.txtAddSupplierTown.Location = new System.Drawing.Point(97, 111);
            this.txtAddSupplierTown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierTown.Name = "txtAddSupplierTown";
            this.txtAddSupplierTown.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierTown.TabIndex = 29;
            // 
            // txtAddSupplierStreet
            // 
            this.txtAddSupplierStreet.Location = new System.Drawing.Point(97, 77);
            this.txtAddSupplierStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierStreet.Name = "txtAddSupplierStreet";
            this.txtAddSupplierStreet.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierStreet.TabIndex = 30;
            // 
            // txtAddSupplierName
            // 
            this.txtAddSupplierName.Location = new System.Drawing.Point(97, 47);
            this.txtAddSupplierName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddSupplierName.Name = "txtAddSupplierName";
            this.txtAddSupplierName.Size = new System.Drawing.Size(81, 20);
            this.txtAddSupplierName.TabIndex = 31;
            // 
            // lblAddActualSupplierNo
            // 
            this.lblAddActualSupplierNo.AutoSize = true;
            this.lblAddActualSupplierNo.Location = new System.Drawing.Point(94, 20);
            this.lblAddActualSupplierNo.Name = "lblAddActualSupplierNo";
            this.lblAddActualSupplierNo.Size = new System.Drawing.Size(54, 13);
            this.lblAddActualSupplierNo.TabIndex = 8;
            this.lblAddActualSupplierNo.Text = "NUMBER";
            // 
            // lblAddSupplierTelephoneNo
            // 
            this.lblAddSupplierTelephoneNo.AutoSize = true;
            this.lblAddSupplierTelephoneNo.Location = new System.Drawing.Point(16, 255);
            this.lblAddSupplierTelephoneNo.Name = "lblAddSupplierTelephoneNo";
            this.lblAddSupplierTelephoneNo.Size = new System.Drawing.Size(75, 13);
            this.lblAddSupplierTelephoneNo.TabIndex = 7;
            this.lblAddSupplierTelephoneNo.Text = "Telephone No";
            // 
            // lblAddSupplierEmail
            // 
            this.lblAddSupplierEmail.AutoSize = true;
            this.lblAddSupplierEmail.Location = new System.Drawing.Point(16, 219);
            this.lblAddSupplierEmail.Name = "lblAddSupplierEmail";
            this.lblAddSupplierEmail.Size = new System.Drawing.Size(32, 13);
            this.lblAddSupplierEmail.TabIndex = 6;
            this.lblAddSupplierEmail.Text = "Email";
            // 
            // lblAddSupplierPostcode
            // 
            this.lblAddSupplierPostcode.AutoSize = true;
            this.lblAddSupplierPostcode.Location = new System.Drawing.Point(16, 185);
            this.lblAddSupplierPostcode.Name = "lblAddSupplierPostcode";
            this.lblAddSupplierPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblAddSupplierPostcode.TabIndex = 5;
            this.lblAddSupplierPostcode.Text = "Postcode";
            // 
            // lblAddSupplierCounty
            // 
            this.lblAddSupplierCounty.AutoSize = true;
            this.lblAddSupplierCounty.Location = new System.Drawing.Point(16, 150);
            this.lblAddSupplierCounty.Name = "lblAddSupplierCounty";
            this.lblAddSupplierCounty.Size = new System.Drawing.Size(40, 13);
            this.lblAddSupplierCounty.TabIndex = 4;
            this.lblAddSupplierCounty.Text = "County";
            // 
            // lblAddSupplierTown
            // 
            this.lblAddSupplierTown.AutoSize = true;
            this.lblAddSupplierTown.Location = new System.Drawing.Point(16, 115);
            this.lblAddSupplierTown.Name = "lblAddSupplierTown";
            this.lblAddSupplierTown.Size = new System.Drawing.Size(34, 13);
            this.lblAddSupplierTown.TabIndex = 3;
            this.lblAddSupplierTown.Text = "Town";
            // 
            // lblAddSupplierStreet
            // 
            this.lblAddSupplierStreet.AutoSize = true;
            this.lblAddSupplierStreet.Location = new System.Drawing.Point(16, 81);
            this.lblAddSupplierStreet.Name = "lblAddSupplierStreet";
            this.lblAddSupplierStreet.Size = new System.Drawing.Size(35, 13);
            this.lblAddSupplierStreet.TabIndex = 2;
            this.lblAddSupplierStreet.Text = "Street";
            // 
            // lblAddSupplierName
            // 
            this.lblAddSupplierName.AutoSize = true;
            this.lblAddSupplierName.Location = new System.Drawing.Point(16, 51);
            this.lblAddSupplierName.Name = "lblAddSupplierName";
            this.lblAddSupplierName.Size = new System.Drawing.Size(35, 13);
            this.lblAddSupplierName.TabIndex = 1;
            this.lblAddSupplierName.Text = "Name";
            // 
            // lblAddSupplierNo
            // 
            this.lblAddSupplierNo.AutoSize = true;
            this.lblAddSupplierNo.Location = new System.Drawing.Point(16, 20);
            this.lblAddSupplierNo.Name = "lblAddSupplierNo";
            this.lblAddSupplierNo.Size = new System.Drawing.Size(62, 13);
            this.lblAddSupplierNo.TabIndex = 0;
            this.lblAddSupplierNo.Text = "Supplier No";
            // 
            // pnlEditSupplier
            // 
            this.pnlEditSupplier.Controls.Add(this.btnCancelEditSupplier);
            this.pnlEditSupplier.Controls.Add(this.btnConfirmEditSupplier);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierTelephoneNo);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierEmail);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierPostcode);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierStreet);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierTown);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierCounty);
            this.pnlEditSupplier.Controls.Add(this.txtEditSupplierName);
            this.pnlEditSupplier.Controls.Add(this.lblEditActualSupplierNo);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierTelephoneNo);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierEmail);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierPostcode);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierCounty);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierTown);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierStreet);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierName);
            this.pnlEditSupplier.Controls.Add(this.lblEditSupplierNo);
            this.pnlEditSupplier.Location = new System.Drawing.Point(326, 67);
            this.pnlEditSupplier.Name = "pnlEditSupplier";
            this.pnlEditSupplier.Size = new System.Drawing.Size(227, 341);
            this.pnlEditSupplier.TabIndex = 51;
            // 
            // txtEditSupplierTelephoneNo
            // 
            this.txtEditSupplierTelephoneNo.Location = new System.Drawing.Point(111, 251);
            this.txtEditSupplierTelephoneNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierTelephoneNo.Name = "txtEditSupplierTelephoneNo";
            this.txtEditSupplierTelephoneNo.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierTelephoneNo.TabIndex = 24;
            // 
            // txtEditSupplierEmail
            // 
            this.txtEditSupplierEmail.Location = new System.Drawing.Point(111, 214);
            this.txtEditSupplierEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierEmail.Name = "txtEditSupplierEmail";
            this.txtEditSupplierEmail.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierEmail.TabIndex = 23;
            // 
            // txtEditSupplierPostcode
            // 
            this.txtEditSupplierPostcode.Location = new System.Drawing.Point(111, 179);
            this.txtEditSupplierPostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierPostcode.Name = "txtEditSupplierPostcode";
            this.txtEditSupplierPostcode.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierPostcode.TabIndex = 22;
            // 
            // txtEditSupplierStreet
            // 
            this.txtEditSupplierStreet.Location = new System.Drawing.Point(111, 79);
            this.txtEditSupplierStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierStreet.Name = "txtEditSupplierStreet";
            this.txtEditSupplierStreet.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierStreet.TabIndex = 21;
            // 
            // txtEditSupplierTown
            // 
            this.txtEditSupplierTown.Location = new System.Drawing.Point(111, 111);
            this.txtEditSupplierTown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierTown.Name = "txtEditSupplierTown";
            this.txtEditSupplierTown.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierTown.TabIndex = 20;
            // 
            // txtEditSupplierCounty
            // 
            this.txtEditSupplierCounty.Location = new System.Drawing.Point(111, 143);
            this.txtEditSupplierCounty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierCounty.Name = "txtEditSupplierCounty";
            this.txtEditSupplierCounty.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierCounty.TabIndex = 19;
            // 
            // txtEditSupplierName
            // 
            this.txtEditSupplierName.Location = new System.Drawing.Point(111, 47);
            this.txtEditSupplierName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditSupplierName.Name = "txtEditSupplierName";
            this.txtEditSupplierName.Size = new System.Drawing.Size(81, 20);
            this.txtEditSupplierName.TabIndex = 18;
            // 
            // lblEditActualSupplierNo
            // 
            this.lblEditActualSupplierNo.AutoSize = true;
            this.lblEditActualSupplierNo.Location = new System.Drawing.Point(108, 20);
            this.lblEditActualSupplierNo.Name = "lblEditActualSupplierNo";
            this.lblEditActualSupplierNo.Size = new System.Drawing.Size(54, 13);
            this.lblEditActualSupplierNo.TabIndex = 17;
            this.lblEditActualSupplierNo.Text = "NUMBER";
            // 
            // lblEditSupplierTelephoneNo
            // 
            this.lblEditSupplierTelephoneNo.AutoSize = true;
            this.lblEditSupplierTelephoneNo.Location = new System.Drawing.Point(30, 255);
            this.lblEditSupplierTelephoneNo.Name = "lblEditSupplierTelephoneNo";
            this.lblEditSupplierTelephoneNo.Size = new System.Drawing.Size(75, 13);
            this.lblEditSupplierTelephoneNo.TabIndex = 16;
            this.lblEditSupplierTelephoneNo.Text = "Telephone No";
            // 
            // lblEditSupplierEmail
            // 
            this.lblEditSupplierEmail.AutoSize = true;
            this.lblEditSupplierEmail.Location = new System.Drawing.Point(30, 219);
            this.lblEditSupplierEmail.Name = "lblEditSupplierEmail";
            this.lblEditSupplierEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEditSupplierEmail.TabIndex = 15;
            this.lblEditSupplierEmail.Text = "Email";
            // 
            // lblEditSupplierPostcode
            // 
            this.lblEditSupplierPostcode.AutoSize = true;
            this.lblEditSupplierPostcode.Location = new System.Drawing.Point(30, 185);
            this.lblEditSupplierPostcode.Name = "lblEditSupplierPostcode";
            this.lblEditSupplierPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblEditSupplierPostcode.TabIndex = 14;
            this.lblEditSupplierPostcode.Text = "Postcode";
            // 
            // lblEditSupplierCounty
            // 
            this.lblEditSupplierCounty.AutoSize = true;
            this.lblEditSupplierCounty.Location = new System.Drawing.Point(30, 150);
            this.lblEditSupplierCounty.Name = "lblEditSupplierCounty";
            this.lblEditSupplierCounty.Size = new System.Drawing.Size(40, 13);
            this.lblEditSupplierCounty.TabIndex = 13;
            this.lblEditSupplierCounty.Text = "County";
            // 
            // lblEditSupplierTown
            // 
            this.lblEditSupplierTown.AutoSize = true;
            this.lblEditSupplierTown.Location = new System.Drawing.Point(30, 115);
            this.lblEditSupplierTown.Name = "lblEditSupplierTown";
            this.lblEditSupplierTown.Size = new System.Drawing.Size(34, 13);
            this.lblEditSupplierTown.TabIndex = 12;
            this.lblEditSupplierTown.Text = "Town";
            // 
            // lblEditSupplierStreet
            // 
            this.lblEditSupplierStreet.AutoSize = true;
            this.lblEditSupplierStreet.Location = new System.Drawing.Point(30, 81);
            this.lblEditSupplierStreet.Name = "lblEditSupplierStreet";
            this.lblEditSupplierStreet.Size = new System.Drawing.Size(35, 13);
            this.lblEditSupplierStreet.TabIndex = 11;
            this.lblEditSupplierStreet.Text = "Street";
            // 
            // lblEditSupplierName
            // 
            this.lblEditSupplierName.AutoSize = true;
            this.lblEditSupplierName.Location = new System.Drawing.Point(30, 51);
            this.lblEditSupplierName.Name = "lblEditSupplierName";
            this.lblEditSupplierName.Size = new System.Drawing.Size(35, 13);
            this.lblEditSupplierName.TabIndex = 10;
            this.lblEditSupplierName.Text = "Name";
            // 
            // lblEditSupplierNo
            // 
            this.lblEditSupplierNo.AutoSize = true;
            this.lblEditSupplierNo.Location = new System.Drawing.Point(30, 20);
            this.lblEditSupplierNo.Name = "lblEditSupplierNo";
            this.lblEditSupplierNo.Size = new System.Drawing.Size(62, 13);
            this.lblEditSupplierNo.TabIndex = 9;
            this.lblEditSupplierNo.Text = "Supplier No";
            // 
            // btnConfirmEditSupplier
            // 
            this.btnConfirmEditSupplier.Location = new System.Drawing.Point(69, 289);
            this.btnConfirmEditSupplier.Name = "btnConfirmEditSupplier";
            this.btnConfirmEditSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnConfirmEditSupplier.TabIndex = 25;
            this.btnConfirmEditSupplier.Text = "Edit";
            this.btnConfirmEditSupplier.UseVisualStyleBackColor = true;
            // 
            // btnCancelEditSupplier
            // 
            this.btnCancelEditSupplier.Location = new System.Drawing.Point(145, 289);
            this.btnCancelEditSupplier.Name = "btnCancelEditSupplier";
            this.btnCancelEditSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnCancelEditSupplier.TabIndex = 26;
            this.btnCancelEditSupplier.Text = "Cencel";
            this.btnCancelEditSupplier.UseVisualStyleBackColor = true;
            // 
            // btnConfirmAddSupplier
            // 
            this.btnConfirmAddSupplier.Location = new System.Drawing.Point(69, 289);
            this.btnConfirmAddSupplier.Name = "btnConfirmAddSupplier";
            this.btnConfirmAddSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnConfirmAddSupplier.TabIndex = 27;
            this.btnConfirmAddSupplier.Text = "Add";
            this.btnConfirmAddSupplier.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddSupplier
            // 
            this.btnCancelAddSupplier.Location = new System.Drawing.Point(145, 289);
            this.btnCancelAddSupplier.Name = "btnCancelAddSupplier";
            this.btnCancelAddSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnCancelAddSupplier.TabIndex = 28;
            this.btnCancelAddSupplier.Text = "Cancel";
            this.btnCancelAddSupplier.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEditSupplier);
            this.Controls.Add(this.pnlAddSupplier);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.lblReturnMenu);
            this.Controls.Add(this.lblSearchSupplier);
            this.Controls.Add(this.lblDeleteSupplier);
            this.Controls.Add(this.lblAddSupplier);
            this.Controls.Add(this.lblEditSupplier);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlAddSupplier.ResumeLayout(false);
            this.pnlAddSupplier.PerformLayout();
            this.pnlEditSupplier.ResumeLayout(false);
            this.pnlEditSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnSearchJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label lblSearchSupplier;
        private System.Windows.Forms.Label lblDeleteSupplier;
        private System.Windows.Forms.Label lblAddSupplier;
        private System.Windows.Forms.Label lblEditSupplier;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Panel pnlAddSupplier;
        private System.Windows.Forms.Label lblAddActualSupplierNo;
        private System.Windows.Forms.Label lblAddSupplierTelephoneNo;
        private System.Windows.Forms.Label lblAddSupplierEmail;
        private System.Windows.Forms.Label lblAddSupplierPostcode;
        private System.Windows.Forms.Label lblAddSupplierCounty;
        private System.Windows.Forms.Label lblAddSupplierTown;
        private System.Windows.Forms.Label lblAddSupplierStreet;
        private System.Windows.Forms.Label lblAddSupplierName;
        private System.Windows.Forms.Label lblAddSupplierNo;
        private System.Windows.Forms.Panel pnlEditSupplier;
        private System.Windows.Forms.Label lblEditActualSupplierNo;
        private System.Windows.Forms.Label lblEditSupplierTelephoneNo;
        private System.Windows.Forms.Label lblEditSupplierEmail;
        private System.Windows.Forms.Label lblEditSupplierPostcode;
        private System.Windows.Forms.Label lblEditSupplierCounty;
        private System.Windows.Forms.Label lblEditSupplierTown;
        private System.Windows.Forms.Label lblEditSupplierStreet;
        private System.Windows.Forms.Label lblEditSupplierName;
        private System.Windows.Forms.Label lblEditSupplierNo;
        private System.Windows.Forms.TextBox txtAddSupplierTelephoneNo;
        private System.Windows.Forms.TextBox txtAddSupplierEmail;
        private System.Windows.Forms.TextBox txtAddSupplierPostcode;
        private System.Windows.Forms.TextBox txtAddSupplierCounty;
        private System.Windows.Forms.TextBox txtAddSupplierTown;
        private System.Windows.Forms.TextBox txtAddSupplierStreet;
        private System.Windows.Forms.TextBox txtAddSupplierName;
        private System.Windows.Forms.TextBox txtEditSupplierTelephoneNo;
        private System.Windows.Forms.TextBox txtEditSupplierEmail;
        private System.Windows.Forms.TextBox txtEditSupplierPostcode;
        private System.Windows.Forms.TextBox txtEditSupplierStreet;
        private System.Windows.Forms.TextBox txtEditSupplierTown;
        private System.Windows.Forms.TextBox txtEditSupplierCounty;
        private System.Windows.Forms.TextBox txtEditSupplierName;
        private System.Windows.Forms.Button btnConfirmAddSupplier;
        private System.Windows.Forms.Button btnCancelAddSupplier;
        private System.Windows.Forms.Button btnCancelEditSupplier;
        private System.Windows.Forms.Button btnConfirmEditSupplier;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}