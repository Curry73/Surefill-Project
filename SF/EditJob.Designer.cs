namespace SF
{
    partial class EditJob
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
            this.pnlEditJob = new System.Windows.Forms.Panel();
            this.cmbEditJobNo = new System.Windows.Forms.ComboBox();
            this.btnEditFinalJob = new System.Windows.Forms.Button();
            this.cmbEditPayment = new System.Windows.Forms.ComboBox();
            this.lblEditPayment = new System.Windows.Forms.Label();
            this.lblEditPaid = new System.Windows.Forms.Label();
            this.rbEditPaidNo = new System.Windows.Forms.RadioButton();
            this.rbEditPaidYes = new System.Windows.Forms.RadioButton();
            this.cmbEditJobType = new System.Windows.Forms.ComboBox();
            this.pnlEditWall = new System.Windows.Forms.Panel();
            this.cmbEditProductNo = new System.Windows.Forms.ComboBox();
            this.lblEditProductName = new System.Windows.Forms.Label();
            this.lblEditActualWallNo = new System.Windows.Forms.Label();
            this.cmbEditCavitySize = new System.Windows.Forms.ComboBox();
            this.lblEditCavitySize = new System.Windows.Forms.Label();
            this.txtEditWallHeight = new System.Windows.Forms.TextBox();
            this.lblEditWallHeight = new System.Windows.Forms.Label();
            this.txtEditWallLength = new System.Windows.Forms.TextBox();
            this.LblEditWallLength = new System.Windows.Forms.Label();
            this.lblEditWallNo = new System.Windows.Forms.Label();
            this.lblEditJobType = new System.Windows.Forms.Label();
            this.lblEditJobDate = new System.Windows.Forms.Label();
            this.dtpEditJobDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEditCustNo = new System.Windows.Forms.ComboBox();
            this.lblEditCustNo = new System.Windows.Forms.Label();
            this.lblEditJobNo = new System.Windows.Forms.Label();
            this.pnlEditWallList = new System.Windows.Forms.Panel();
            this.btnDeleteWall = new System.Windows.Forms.Button();
            this.LVEditWallList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEditCancelCalc = new System.Windows.Forms.Button();
            this.btnEditCalculate = new System.Windows.Forms.Button();
            this.pnlEditOpening = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEditAddWall = new System.Windows.Forms.Button();
            this.btnEditCancelOpening = new System.Windows.Forms.Button();
            this.LVEditOpenings = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditAddOpening = new System.Windows.Forms.Button();
            this.txtEditOpeningHeight = new System.Windows.Forms.TextBox();
            this.lblEditOpeningHeight = new System.Windows.Forms.Label();
            this.txtEditOpeningLength = new System.Windows.Forms.TextBox();
            this.lblEditOpeningLength = new System.Windows.Forms.Label();
            this.pnlEditJob.SuspendLayout();
            this.pnlEditWall.SuspendLayout();
            this.pnlEditWallList.SuspendLayout();
            this.pnlEditOpening.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditJob
            // 
            this.pnlEditJob.Controls.Add(this.cmbEditJobNo);
            this.pnlEditJob.Controls.Add(this.btnEditFinalJob);
            this.pnlEditJob.Controls.Add(this.cmbEditPayment);
            this.pnlEditJob.Controls.Add(this.lblEditPayment);
            this.pnlEditJob.Controls.Add(this.lblEditPaid);
            this.pnlEditJob.Controls.Add(this.rbEditPaidNo);
            this.pnlEditJob.Controls.Add(this.rbEditPaidYes);
            this.pnlEditJob.Controls.Add(this.cmbEditJobType);
            this.pnlEditJob.Controls.Add(this.pnlEditWall);
            this.pnlEditJob.Controls.Add(this.lblEditJobType);
            this.pnlEditJob.Controls.Add(this.lblEditJobDate);
            this.pnlEditJob.Controls.Add(this.dtpEditJobDate);
            this.pnlEditJob.Controls.Add(this.cmbEditCustNo);
            this.pnlEditJob.Controls.Add(this.lblEditCustNo);
            this.pnlEditJob.Controls.Add(this.lblEditJobNo);
            this.pnlEditJob.Controls.Add(this.pnlEditWallList);
            this.pnlEditJob.Controls.Add(this.pnlEditOpening);
            this.pnlEditJob.Location = new System.Drawing.Point(12, 3);
            this.pnlEditJob.Name = "pnlEditJob";
            this.pnlEditJob.Size = new System.Drawing.Size(662, 380);
            this.pnlEditJob.TabIndex = 57;
            // 
            // cmbEditJobNo
            // 
            this.cmbEditJobNo.FormattingEnabled = true;
            this.cmbEditJobNo.Location = new System.Drawing.Point(540, 25);
            this.cmbEditJobNo.Name = "cmbEditJobNo";
            this.cmbEditJobNo.Size = new System.Drawing.Size(70, 21);
            this.cmbEditJobNo.TabIndex = 19;
            this.cmbEditJobNo.Click += new System.EventHandler(this.cmbEditJobNoSelectedItems);
            // 
            // btnEditFinalJob
            // 
            this.btnEditFinalJob.Location = new System.Drawing.Point(564, 297);
            this.btnEditFinalJob.Name = "btnEditFinalJob";
            this.btnEditFinalJob.Size = new System.Drawing.Size(75, 23);
            this.btnEditFinalJob.TabIndex = 18;
            this.btnEditFinalJob.Text = "Edit Job";
            this.btnEditFinalJob.UseVisualStyleBackColor = true;
            // 
            // cmbEditPayment
            // 
            this.cmbEditPayment.FormattingEnabled = true;
            this.cmbEditPayment.Location = new System.Drawing.Point(540, 245);
            this.cmbEditPayment.Name = "cmbEditPayment";
            this.cmbEditPayment.Size = new System.Drawing.Size(115, 21);
            this.cmbEditPayment.TabIndex = 17;
            // 
            // lblEditPayment
            // 
            this.lblEditPayment.AutoSize = true;
            this.lblEditPayment.Location = new System.Drawing.Point(460, 248);
            this.lblEditPayment.Name = "lblEditPayment";
            this.lblEditPayment.Size = new System.Drawing.Size(78, 13);
            this.lblEditPayment.TabIndex = 16;
            this.lblEditPayment.Text = "Payment Type:";
            // 
            // lblEditPaid
            // 
            this.lblEditPaid.AutoSize = true;
            this.lblEditPaid.Location = new System.Drawing.Point(503, 206);
            this.lblEditPaid.Name = "lblEditPaid";
            this.lblEditPaid.Size = new System.Drawing.Size(31, 13);
            this.lblEditPaid.TabIndex = 15;
            this.lblEditPaid.Text = "Paid:";
            // 
            // rbEditPaidNo
            // 
            this.rbEditPaidNo.AutoSize = true;
            this.rbEditPaidNo.Location = new System.Drawing.Point(600, 205);
            this.rbEditPaidNo.Name = "rbEditPaidNo";
            this.rbEditPaidNo.Size = new System.Drawing.Size(39, 17);
            this.rbEditPaidNo.TabIndex = 14;
            this.rbEditPaidNo.TabStop = true;
            this.rbEditPaidNo.Text = "No";
            this.rbEditPaidNo.UseVisualStyleBackColor = true;
            // 
            // rbEditPaidYes
            // 
            this.rbEditPaidYes.AutoSize = true;
            this.rbEditPaidYes.Location = new System.Drawing.Point(540, 205);
            this.rbEditPaidYes.Name = "rbEditPaidYes";
            this.rbEditPaidYes.Size = new System.Drawing.Size(43, 17);
            this.rbEditPaidYes.TabIndex = 13;
            this.rbEditPaidYes.TabStop = true;
            this.rbEditPaidYes.Text = "Yes";
            this.rbEditPaidYes.UseVisualStyleBackColor = true;
            // 
            // cmbEditJobType
            // 
            this.cmbEditJobType.FormattingEnabled = true;
            this.cmbEditJobType.Location = new System.Drawing.Point(540, 152);
            this.cmbEditJobType.Name = "cmbEditJobType";
            this.cmbEditJobType.Size = new System.Drawing.Size(116, 21);
            this.cmbEditJobType.TabIndex = 12;
            // 
            // pnlEditWall
            // 
            this.pnlEditWall.Controls.Add(this.cmbEditProductNo);
            this.pnlEditWall.Controls.Add(this.lblEditProductName);
            this.pnlEditWall.Controls.Add(this.lblEditActualWallNo);
            this.pnlEditWall.Controls.Add(this.cmbEditCavitySize);
            this.pnlEditWall.Controls.Add(this.lblEditCavitySize);
            this.pnlEditWall.Controls.Add(this.txtEditWallHeight);
            this.pnlEditWall.Controls.Add(this.lblEditWallHeight);
            this.pnlEditWall.Controls.Add(this.txtEditWallLength);
            this.pnlEditWall.Controls.Add(this.LblEditWallLength);
            this.pnlEditWall.Controls.Add(this.lblEditWallNo);
            this.pnlEditWall.Location = new System.Drawing.Point(3, 5);
            this.pnlEditWall.Name = "pnlEditWall";
            this.pnlEditWall.Size = new System.Drawing.Size(214, 168);
            this.pnlEditWall.TabIndex = 2;
            // 
            // cmbEditProductNo
            // 
            this.cmbEditProductNo.FormattingEnabled = true;
            this.cmbEditProductNo.Location = new System.Drawing.Point(82, 138);
            this.cmbEditProductNo.Name = "cmbEditProductNo";
            this.cmbEditProductNo.Size = new System.Drawing.Size(80, 21);
            this.cmbEditProductNo.TabIndex = 23;
            // 
            // lblEditProductName
            // 
            this.lblEditProductName.AutoSize = true;
            this.lblEditProductName.Location = new System.Drawing.Point(5, 141);
            this.lblEditProductName.Name = "lblEditProductName";
            this.lblEditProductName.Size = new System.Drawing.Size(75, 13);
            this.lblEditProductName.TabIndex = 22;
            this.lblEditProductName.Text = "Product Name";
            // 
            // lblEditActualWallNo
            // 
            this.lblEditActualWallNo.AutoSize = true;
            this.lblEditActualWallNo.Location = new System.Drawing.Point(79, 11);
            this.lblEditActualWallNo.Name = "lblEditActualWallNo";
            this.lblEditActualWallNo.Size = new System.Drawing.Size(13, 13);
            this.lblEditActualWallNo.TabIndex = 21;
            this.lblEditActualWallNo.Text = "1";
            // 
            // cmbEditCavitySize
            // 
            this.cmbEditCavitySize.FormattingEnabled = true;
            this.cmbEditCavitySize.Location = new System.Drawing.Point(72, 102);
            this.cmbEditCavitySize.Name = "cmbEditCavitySize";
            this.cmbEditCavitySize.Size = new System.Drawing.Size(80, 21);
            this.cmbEditCavitySize.TabIndex = 7;
            // 
            // lblEditCavitySize
            // 
            this.lblEditCavitySize.AutoSize = true;
            this.lblEditCavitySize.Location = new System.Drawing.Point(3, 110);
            this.lblEditCavitySize.Name = "lblEditCavitySize";
            this.lblEditCavitySize.Size = new System.Drawing.Size(62, 13);
            this.lblEditCavitySize.TabIndex = 6;
            this.lblEditCavitySize.Text = "Cavity Size:";
            // 
            // txtEditWallHeight
            // 
            this.txtEditWallHeight.Location = new System.Drawing.Point(72, 72);
            this.txtEditWallHeight.Name = "txtEditWallHeight";
            this.txtEditWallHeight.Size = new System.Drawing.Size(100, 20);
            this.txtEditWallHeight.TabIndex = 4;
            // 
            // lblEditWallHeight
            // 
            this.lblEditWallHeight.AutoSize = true;
            this.lblEditWallHeight.Location = new System.Drawing.Point(3, 75);
            this.lblEditWallHeight.Name = "lblEditWallHeight";
            this.lblEditWallHeight.Size = new System.Drawing.Size(63, 13);
            this.lblEditWallHeight.TabIndex = 5;
            this.lblEditWallHeight.Text = "Wall height:";
            // 
            // txtEditWallLength
            // 
            this.txtEditWallLength.Location = new System.Drawing.Point(72, 36);
            this.txtEditWallLength.Name = "txtEditWallLength";
            this.txtEditWallLength.Size = new System.Drawing.Size(100, 20);
            this.txtEditWallLength.TabIndex = 3;
            // 
            // LblEditWallLength
            // 
            this.LblEditWallLength.AutoSize = true;
            this.LblEditWallLength.Location = new System.Drawing.Point(3, 39);
            this.LblEditWallLength.Name = "LblEditWallLength";
            this.LblEditWallLength.Size = new System.Drawing.Size(63, 13);
            this.LblEditWallLength.TabIndex = 4;
            this.LblEditWallLength.Text = "Wall length:";
            // 
            // lblEditWallNo
            // 
            this.lblEditWallNo.AutoSize = true;
            this.lblEditWallNo.Location = new System.Drawing.Point(3, 9);
            this.lblEditWallNo.Name = "lblEditWallNo";
            this.lblEditWallNo.Size = new System.Drawing.Size(69, 13);
            this.lblEditWallNo.TabIndex = 3;
            this.lblEditWallNo.Text = "Wall number:";
            // 
            // lblEditJobType
            // 
            this.lblEditJobType.AutoSize = true;
            this.lblEditJobType.Location = new System.Drawing.Point(480, 155);
            this.lblEditJobType.Name = "lblEditJobType";
            this.lblEditJobType.Size = new System.Drawing.Size(54, 13);
            this.lblEditJobType.TabIndex = 11;
            this.lblEditJobType.Text = "Job Type:";
            // 
            // lblEditJobDate
            // 
            this.lblEditJobDate.AutoSize = true;
            this.lblEditJobDate.Location = new System.Drawing.Point(469, 110);
            this.lblEditJobDate.Name = "lblEditJobDate";
            this.lblEditJobDate.Size = new System.Drawing.Size(65, 13);
            this.lblEditJobDate.TabIndex = 10;
            this.lblEditJobDate.Text = "Date of Job:";
            // 
            // dtpEditJobDate
            // 
            this.dtpEditJobDate.Location = new System.Drawing.Point(540, 104);
            this.dtpEditJobDate.Name = "dtpEditJobDate";
            this.dtpEditJobDate.Size = new System.Drawing.Size(119, 20);
            this.dtpEditJobDate.TabIndex = 9;
            // 
            // cmbEditCustNo
            // 
            this.cmbEditCustNo.FormattingEnabled = true;
            this.cmbEditCustNo.Location = new System.Drawing.Point(540, 68);
            this.cmbEditCustNo.Name = "cmbEditCustNo";
            this.cmbEditCustNo.Size = new System.Drawing.Size(70, 21);
            this.cmbEditCustNo.TabIndex = 7;
            // 
            // lblEditCustNo
            // 
            this.lblEditCustNo.AutoSize = true;
            this.lblEditCustNo.Location = new System.Drawing.Point(466, 71);
            this.lblEditCustNo.Name = "lblEditCustNo";
            this.lblEditCustNo.Size = new System.Drawing.Size(71, 13);
            this.lblEditCustNo.TabIndex = 6;
            this.lblEditCustNo.Text = "Customer No:";
            // 
            // lblEditJobNo
            // 
            this.lblEditJobNo.AutoSize = true;
            this.lblEditJobNo.Location = new System.Drawing.Point(493, 33);
            this.lblEditJobNo.Name = "lblEditJobNo";
            this.lblEditJobNo.Size = new System.Drawing.Size(41, 13);
            this.lblEditJobNo.TabIndex = 0;
            this.lblEditJobNo.Text = "Job ID:";
            // 
            // pnlEditWallList
            // 
            this.pnlEditWallList.Controls.Add(this.btnDeleteWall);
            this.pnlEditWallList.Controls.Add(this.LVEditWallList);
            this.pnlEditWallList.Controls.Add(this.label14);
            this.pnlEditWallList.Controls.Add(this.label15);
            this.pnlEditWallList.Controls.Add(this.btnEditCancelCalc);
            this.pnlEditWallList.Controls.Add(this.btnEditCalculate);
            this.pnlEditWallList.Location = new System.Drawing.Point(220, 3);
            this.pnlEditWallList.Name = "pnlEditWallList";
            this.pnlEditWallList.Size = new System.Drawing.Size(240, 317);
            this.pnlEditWallList.TabIndex = 3;
            // 
            // btnDeleteWall
            // 
            this.btnDeleteWall.Location = new System.Drawing.Point(43, 291);
            this.btnDeleteWall.Name = "btnDeleteWall";
            this.btnDeleteWall.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWall.TabIndex = 9;
            this.btnDeleteWall.Text = "Delete";
            this.btnDeleteWall.UseVisualStyleBackColor = true;
            // 
            // LVEditWallList
            // 
            this.LVEditWallList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LVEditWallList.FullRowSelect = true;
            this.LVEditWallList.Location = new System.Drawing.Point(9, 36);
            this.LVEditWallList.MultiSelect = false;
            this.LVEditWallList.Name = "LVEditWallList";
            this.LVEditWallList.Size = new System.Drawing.Size(225, 226);
            this.LVEditWallList.TabIndex = 3;
            this.LVEditWallList.UseCompatibleStateImageBehavior = false;
            this.LVEditWallList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WallNo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Wall";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Openings";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Wall List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "0";
            // 
            // btnEditCancelCalc
            // 
            this.btnEditCancelCalc.Location = new System.Drawing.Point(43, 269);
            this.btnEditCancelCalc.Name = "btnEditCancelCalc";
            this.btnEditCancelCalc.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancelCalc.TabIndex = 5;
            this.btnEditCancelCalc.Text = "Cancel";
            this.btnEditCancelCalc.UseVisualStyleBackColor = true;
            // 
            // btnEditCalculate
            // 
            this.btnEditCalculate.Location = new System.Drawing.Point(153, 269);
            this.btnEditCalculate.Name = "btnEditCalculate";
            this.btnEditCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnEditCalculate.TabIndex = 4;
            this.btnEditCalculate.Text = "Calculate";
            this.btnEditCalculate.UseVisualStyleBackColor = true;
            // 
            // pnlEditOpening
            // 
            this.pnlEditOpening.Controls.Add(this.textBox3);
            this.pnlEditOpening.Controls.Add(this.btnEditAddWall);
            this.pnlEditOpening.Controls.Add(this.btnEditCancelOpening);
            this.pnlEditOpening.Controls.Add(this.LVEditOpenings);
            this.pnlEditOpening.Controls.Add(this.btnEditAddOpening);
            this.pnlEditOpening.Controls.Add(this.txtEditOpeningHeight);
            this.pnlEditOpening.Controls.Add(this.lblEditOpeningHeight);
            this.pnlEditOpening.Controls.Add(this.txtEditOpeningLength);
            this.pnlEditOpening.Controls.Add(this.lblEditOpeningLength);
            this.pnlEditOpening.Location = new System.Drawing.Point(0, 169);
            this.pnlEditOpening.Name = "pnlEditOpening";
            this.pnlEditOpening.Size = new System.Drawing.Size(214, 208);
            this.pnlEditOpening.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(19, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.Visible = false;
            // 
            // btnEditAddWall
            // 
            this.btnEditAddWall.Location = new System.Drawing.Point(122, 182);
            this.btnEditAddWall.Name = "btnEditAddWall";
            this.btnEditAddWall.Size = new System.Drawing.Size(88, 23);
            this.btnEditAddWall.TabIndex = 19;
            this.btnEditAddWall.Text = "Add Wall";
            this.btnEditAddWall.UseVisualStyleBackColor = true;
            // 
            // btnEditCancelOpening
            // 
            this.btnEditCancelOpening.Location = new System.Drawing.Point(28, 55);
            this.btnEditCancelOpening.Name = "btnEditCancelOpening";
            this.btnEditCancelOpening.Size = new System.Drawing.Size(88, 23);
            this.btnEditCancelOpening.TabIndex = 20;
            this.btnEditCancelOpening.Text = "Cancel";
            this.btnEditCancelOpening.UseVisualStyleBackColor = true;
            // 
            // LVEditOpenings
            // 
            this.LVEditOpenings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LVEditOpenings.Location = new System.Drawing.Point(13, 84);
            this.LVEditOpenings.Name = "LVEditOpenings";
            this.LVEditOpenings.Size = new System.Drawing.Size(185, 96);
            this.LVEditOpenings.TabIndex = 19;
            this.LVEditOpenings.UseCompatibleStateImageBehavior = false;
            this.LVEditOpenings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Length";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Height";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            // 
            // btnEditAddOpening
            // 
            this.btnEditAddOpening.Location = new System.Drawing.Point(122, 55);
            this.btnEditAddOpening.Name = "btnEditAddOpening";
            this.btnEditAddOpening.Size = new System.Drawing.Size(88, 23);
            this.btnEditAddOpening.TabIndex = 10;
            this.btnEditAddOpening.Text = "Add";
            this.btnEditAddOpening.UseVisualStyleBackColor = true;
            // 
            // txtEditOpeningHeight
            // 
            this.txtEditOpeningHeight.Location = new System.Drawing.Point(110, 30);
            this.txtEditOpeningHeight.Name = "txtEditOpeningHeight";
            this.txtEditOpeningHeight.Size = new System.Drawing.Size(100, 20);
            this.txtEditOpeningHeight.TabIndex = 7;
            // 
            // lblEditOpeningHeight
            // 
            this.lblEditOpeningHeight.AutoSize = true;
            this.lblEditOpeningHeight.Location = new System.Drawing.Point(10, 33);
            this.lblEditOpeningHeight.Name = "lblEditOpeningHeight";
            this.lblEditOpeningHeight.Size = new System.Drawing.Size(82, 13);
            this.lblEditOpeningHeight.TabIndex = 9;
            this.lblEditOpeningHeight.Text = "Opening height:";
            // 
            // txtEditOpeningLength
            // 
            this.txtEditOpeningLength.Location = new System.Drawing.Point(110, 6);
            this.txtEditOpeningLength.Name = "txtEditOpeningLength";
            this.txtEditOpeningLength.Size = new System.Drawing.Size(100, 20);
            this.txtEditOpeningLength.TabIndex = 6;
            // 
            // lblEditOpeningLength
            // 
            this.lblEditOpeningLength.AutoSize = true;
            this.lblEditOpeningLength.Location = new System.Drawing.Point(10, 6);
            this.lblEditOpeningLength.Name = "lblEditOpeningLength";
            this.lblEditOpeningLength.Size = new System.Drawing.Size(82, 13);
            this.lblEditOpeningLength.TabIndex = 8;
            this.lblEditOpeningLength.Text = "Opening length:";
            // 
            // EditJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.pnlEditJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditJob";
            this.Text = "EditJob";
            this.Load += new System.EventHandler(this.EditJob_Load);
            this.pnlEditJob.ResumeLayout(false);
            this.pnlEditJob.PerformLayout();
            this.pnlEditWall.ResumeLayout(false);
            this.pnlEditWall.PerformLayout();
            this.pnlEditWallList.ResumeLayout(false);
            this.pnlEditWallList.PerformLayout();
            this.pnlEditOpening.ResumeLayout(false);
            this.pnlEditOpening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditJob;
        private System.Windows.Forms.ComboBox cmbEditJobNo;
        private System.Windows.Forms.Button btnEditFinalJob;
        private System.Windows.Forms.ComboBox cmbEditPayment;
        private System.Windows.Forms.Label lblEditPayment;
        private System.Windows.Forms.Label lblEditPaid;
        private System.Windows.Forms.RadioButton rbEditPaidNo;
        private System.Windows.Forms.RadioButton rbEditPaidYes;
        private System.Windows.Forms.ComboBox cmbEditJobType;
        private System.Windows.Forms.Panel pnlEditWall;
        private System.Windows.Forms.ComboBox cmbEditProductNo;
        private System.Windows.Forms.Label lblEditProductName;
        private System.Windows.Forms.Label lblEditActualWallNo;
        private System.Windows.Forms.ComboBox cmbEditCavitySize;
        private System.Windows.Forms.Label lblEditCavitySize;
        private System.Windows.Forms.TextBox txtEditWallHeight;
        private System.Windows.Forms.Label lblEditWallHeight;
        private System.Windows.Forms.TextBox txtEditWallLength;
        private System.Windows.Forms.Label LblEditWallLength;
        private System.Windows.Forms.Label lblEditWallNo;
        private System.Windows.Forms.Label lblEditJobType;
        private System.Windows.Forms.Label lblEditJobDate;
        private System.Windows.Forms.DateTimePicker dtpEditJobDate;
        private System.Windows.Forms.ComboBox cmbEditCustNo;
        private System.Windows.Forms.Label lblEditCustNo;
        private System.Windows.Forms.Label lblEditJobNo;
        private System.Windows.Forms.Panel pnlEditWallList;
        private System.Windows.Forms.Button btnDeleteWall;
        private System.Windows.Forms.ListView LVEditWallList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEditCancelCalc;
        private System.Windows.Forms.Button btnEditCalculate;
        private System.Windows.Forms.Panel pnlEditOpening;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnEditAddWall;
        private System.Windows.Forms.Button btnEditCancelOpening;
        private System.Windows.Forms.ListView LVEditOpenings;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnEditAddOpening;
        private System.Windows.Forms.TextBox txtEditOpeningHeight;
        private System.Windows.Forms.Label lblEditOpeningHeight;
        private System.Windows.Forms.TextBox txtEditOpeningLength;
        private System.Windows.Forms.Label lblEditOpeningLength;
    }
}