namespace SF
{
    partial class frmCustomers
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
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.pnlAddCust = new System.Windows.Forms.Panel();
            this.lblActualCustNo = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustTelNo = new System.Windows.Forms.TextBox();
            this.txtCustCounty = new System.Windows.Forms.TextBox();
            this.txtCustPostcode = new System.Windows.Forms.TextBox();
            this.txtCustTown = new System.Windows.Forms.TextBox();
            this.txtCustStreet = new System.Windows.Forms.TextBox();
            this.txtCustSurname = new System.Windows.Forms.TextBox();
            this.txtCustForename = new System.Windows.Forms.TextBox();
            this.lblCustCounty = new System.Windows.Forms.Label();
            this.lblCustTelephoneNo = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblCustPostcode = new System.Windows.Forms.Label();
            this.lblCustTown = new System.Windows.Forms.Label();
            this.lblCustStreet = new System.Windows.Forms.Label();
            this.lblCustSurname = new System.Windows.Forms.Label();
            this.lblCustForename = new System.Windows.Forms.Label();
            this.lblCustNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlReturn.SuspendLayout();
            this.pnlAddCust.SuspendLayout();
            this.SuspendLayout();
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
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(620, 380);
            this.dgvCustomers.TabIndex = 20;
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
            // tmrBanner
            // 
            this.tmrBanner.Enabled = true;
            this.tmrBanner.Interval = 50;
            this.tmrBanner.Tick += new System.EventHandler(this.tmrBanner_Tick);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(701, 209);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteCustomer.TabIndex = 26;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
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
            // pnlAddCust
            // 
            this.pnlAddCust.Controls.Add(this.lblActualCustNo);
            this.pnlAddCust.Controls.Add(this.txtCustEmail);
            this.pnlAddCust.Controls.Add(this.txtCustTelNo);
            this.pnlAddCust.Controls.Add(this.txtCustCounty);
            this.pnlAddCust.Controls.Add(this.txtCustPostcode);
            this.pnlAddCust.Controls.Add(this.txtCustTown);
            this.pnlAddCust.Controls.Add(this.txtCustStreet);
            this.pnlAddCust.Controls.Add(this.txtCustSurname);
            this.pnlAddCust.Controls.Add(this.txtCustForename);
            this.pnlAddCust.Controls.Add(this.lblCustCounty);
            this.pnlAddCust.Controls.Add(this.lblCustTelephoneNo);
            this.pnlAddCust.Controls.Add(this.lblCustEmail);
            this.pnlAddCust.Controls.Add(this.lblCustPostcode);
            this.pnlAddCust.Controls.Add(this.lblCustTown);
            this.pnlAddCust.Controls.Add(this.lblCustStreet);
            this.pnlAddCust.Controls.Add(this.lblCustSurname);
            this.pnlAddCust.Controls.Add(this.lblCustForename);
            this.pnlAddCust.Controls.Add(this.lblCustNo);
            this.pnlAddCust.Location = new System.Drawing.Point(278, 69);
            this.pnlAddCust.Name = "pnlAddCust";
            this.pnlAddCust.Size = new System.Drawing.Size(279, 297);
            this.pnlAddCust.TabIndex = 63;
            // 
            // lblActualCustNo
            // 
            this.lblActualCustNo.AutoSize = true;
            this.lblActualCustNo.Location = new System.Drawing.Point(152, 5);
            this.lblActualCustNo.Name = "lblActualCustNo";
            this.lblActualCustNo.Size = new System.Drawing.Size(54, 13);
            this.lblActualCustNo.TabIndex = 80;
            this.lblActualCustNo.Text = "NUMBER";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(155, 272);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustEmail.TabIndex = 79;
            // 
            // txtCustTelNo
            // 
            this.txtCustTelNo.Location = new System.Drawing.Point(155, 237);
            this.txtCustTelNo.Name = "txtCustTelNo";
            this.txtCustTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtCustTelNo.TabIndex = 78;
            // 
            // txtCustCounty
            // 
            this.txtCustCounty.Location = new System.Drawing.Point(155, 207);
            this.txtCustCounty.Name = "txtCustCounty";
            this.txtCustCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCustCounty.TabIndex = 77;
            // 
            // txtCustPostcode
            // 
            this.txtCustPostcode.Location = new System.Drawing.Point(155, 175);
            this.txtCustPostcode.Name = "txtCustPostcode";
            this.txtCustPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtCustPostcode.TabIndex = 76;
            // 
            // txtCustTown
            // 
            this.txtCustTown.Location = new System.Drawing.Point(155, 145);
            this.txtCustTown.Name = "txtCustTown";
            this.txtCustTown.Size = new System.Drawing.Size(100, 20);
            this.txtCustTown.TabIndex = 75;
            // 
            // txtCustStreet
            // 
            this.txtCustStreet.Location = new System.Drawing.Point(155, 111);
            this.txtCustStreet.Name = "txtCustStreet";
            this.txtCustStreet.Size = new System.Drawing.Size(100, 20);
            this.txtCustStreet.TabIndex = 74;
            // 
            // txtCustSurname
            // 
            this.txtCustSurname.Location = new System.Drawing.Point(155, 76);
            this.txtCustSurname.Name = "txtCustSurname";
            this.txtCustSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCustSurname.TabIndex = 73;
            // 
            // txtCustForename
            // 
            this.txtCustForename.Location = new System.Drawing.Point(155, 33);
            this.txtCustForename.Name = "txtCustForename";
            this.txtCustForename.Size = new System.Drawing.Size(100, 20);
            this.txtCustForename.TabIndex = 72;
            // 
            // lblCustCounty
            // 
            this.lblCustCounty.AutoSize = true;
            this.lblCustCounty.Location = new System.Drawing.Point(24, 214);
            this.lblCustCounty.Name = "lblCustCounty";
            this.lblCustCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCustCounty.TabIndex = 71;
            this.lblCustCounty.Text = "County";
            // 
            // lblCustTelephoneNo
            // 
            this.lblCustTelephoneNo.AutoSize = true;
            this.lblCustTelephoneNo.Location = new System.Drawing.Point(24, 240);
            this.lblCustTelephoneNo.Name = "lblCustTelephoneNo";
            this.lblCustTelephoneNo.Size = new System.Drawing.Size(98, 13);
            this.lblCustTelephoneNo.TabIndex = 70;
            this.lblCustTelephoneNo.Text = "Telephone Number";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Location = new System.Drawing.Point(24, 275);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(32, 13);
            this.lblCustEmail.TabIndex = 69;
            this.lblCustEmail.Text = "Email";
            // 
            // lblCustPostcode
            // 
            this.lblCustPostcode.AutoSize = true;
            this.lblCustPostcode.Location = new System.Drawing.Point(24, 182);
            this.lblCustPostcode.Name = "lblCustPostcode";
            this.lblCustPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblCustPostcode.TabIndex = 68;
            this.lblCustPostcode.Text = "Postcode";
            // 
            // lblCustTown
            // 
            this.lblCustTown.AutoSize = true;
            this.lblCustTown.Location = new System.Drawing.Point(24, 148);
            this.lblCustTown.Name = "lblCustTown";
            this.lblCustTown.Size = new System.Drawing.Size(34, 13);
            this.lblCustTown.TabIndex = 67;
            this.lblCustTown.Text = "Town";
            // 
            // lblCustStreet
            // 
            this.lblCustStreet.AutoSize = true;
            this.lblCustStreet.Location = new System.Drawing.Point(24, 111);
            this.lblCustStreet.Name = "lblCustStreet";
            this.lblCustStreet.Size = new System.Drawing.Size(35, 13);
            this.lblCustStreet.TabIndex = 66;
            this.lblCustStreet.Text = "Street";
            // 
            // lblCustSurname
            // 
            this.lblCustSurname.AutoSize = true;
            this.lblCustSurname.Location = new System.Drawing.Point(24, 79);
            this.lblCustSurname.Name = "lblCustSurname";
            this.lblCustSurname.Size = new System.Drawing.Size(49, 13);
            this.lblCustSurname.TabIndex = 65;
            this.lblCustSurname.Text = "Surname";
            // 
            // lblCustForename
            // 
            this.lblCustForename.AutoSize = true;
            this.lblCustForename.Location = new System.Drawing.Point(24, 40);
            this.lblCustForename.Name = "lblCustForename";
            this.lblCustForename.Size = new System.Drawing.Size(54, 13);
            this.lblCustForename.TabIndex = 64;
            this.lblCustForename.Text = "Forename";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Location = new System.Drawing.Point(24, 5);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(91, 13);
            this.lblCustNo.TabIndex = 63;
            this.lblCustNo.Text = "Customer Number";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.pnlAddCust);
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
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlReturn.ResumeLayout(false);
            this.pnlReturn.PerformLayout();
            this.pnlAddCust.ResumeLayout(false);
            this.pnlAddCust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Timer tmrBanner;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Panel pnlAddCust;
        private System.Windows.Forms.Label lblActualCustNo;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustTelNo;
        private System.Windows.Forms.TextBox txtCustCounty;
        private System.Windows.Forms.TextBox txtCustPostcode;
        private System.Windows.Forms.TextBox txtCustTown;
        private System.Windows.Forms.TextBox txtCustStreet;
        private System.Windows.Forms.TextBox txtCustSurname;
        private System.Windows.Forms.TextBox txtCustForename;
        private System.Windows.Forms.Label lblCustCounty;
        private System.Windows.Forms.Label lblCustTelephoneNo;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label lblCustPostcode;
        private System.Windows.Forms.Label lblCustTown;
        private System.Windows.Forms.Label lblCustStreet;
        private System.Windows.Forms.Label lblCustSurname;
        private System.Windows.Forms.Label lblCustForename;
        private System.Windows.Forms.Label lblCustNo;
    }
}