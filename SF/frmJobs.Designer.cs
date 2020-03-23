namespace SF
{
    partial class frmJobs
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
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblActualJobID = new System.Windows.Forms.Label();
            this.pnlAddWall = new System.Windows.Forms.Panel();
            this.lblAddWall = new System.Windows.Forms.Label();
            this.pnlAddOpenings = new System.Windows.Forms.Panel();
            this.lblAddOpenings = new System.Windows.Forms.Label();
            this.pnlWallSizeList = new System.Windows.Forms.Panel();
            this.lblWallList = new System.Windows.Forms.Label();
            this.lblWallNumber = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAddWallLength = new System.Windows.Forms.Label();
            this.lblAddWallHeight = new System.Windows.Forms.Label();
            this.txtAddWallLength = new System.Windows.Forms.TextBox();
            this.txtAddWallHeight = new System.Windows.Forms.TextBox();
            this.lblAddCavitySize = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddOpeningHeight = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAddOpeningLength = new System.Windows.Forms.Label();
            this.btnAddOpening = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddJob = new System.Windows.Forms.Panel();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCancelCalculate = new System.Windows.Forms.Button();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.cmbAddJobCustNo = new System.Windows.Forms.ComboBox();
            this.pnlAddWall.SuspendLayout();
            this.pnlAddOpenings.SuspendLayout();
            this.pnlWallSizeList.SuspendLayout();
            this.pnlAddJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(45, 11);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(41, 13);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblActualJobID
            // 
            this.lblActualJobID.AutoSize = true;
            this.lblActualJobID.Location = new System.Drawing.Point(120, 11);
            this.lblActualJobID.Name = "lblActualJobID";
            this.lblActualJobID.Size = new System.Drawing.Size(74, 13);
            this.lblActualJobID.TabIndex = 1;
            this.lblActualJobID.Text = "AUTO JOB ID";
            // 
            // pnlAddWall
            // 
            this.pnlAddWall.Controls.Add(this.comboBox2);
            this.pnlAddWall.Controls.Add(this.lblAddCavitySize);
            this.pnlAddWall.Controls.Add(this.txtAddWallHeight);
            this.pnlAddWall.Controls.Add(this.lblAddWallHeight);
            this.pnlAddWall.Controls.Add(this.txtAddWallLength);
            this.pnlAddWall.Controls.Add(this.lblAddWallLength);
            this.pnlAddWall.Controls.Add(this.comboBox1);
            this.pnlAddWall.Controls.Add(this.lblWallNumber);
            this.pnlAddWall.Controls.Add(this.lblAddWall);
            this.pnlAddWall.Location = new System.Drawing.Point(6, 36);
            this.pnlAddWall.Name = "pnlAddWall";
            this.pnlAddWall.Size = new System.Drawing.Size(205, 297);
            this.pnlAddWall.TabIndex = 2;
            // 
            // lblAddWall
            // 
            this.lblAddWall.AutoSize = true;
            this.lblAddWall.Location = new System.Drawing.Point(68, 13);
            this.lblAddWall.Name = "lblAddWall";
            this.lblAddWall.Size = new System.Drawing.Size(50, 13);
            this.lblAddWall.TabIndex = 2;
            this.lblAddWall.Text = "Add Wall";
            // 
            // pnlAddOpenings
            // 
            this.pnlAddOpenings.Controls.Add(this.label1);
            this.pnlAddOpenings.Controls.Add(this.btnAddOpening);
            this.pnlAddOpenings.Controls.Add(this.textBox1);
            this.pnlAddOpenings.Controls.Add(this.lblAddOpeningHeight);
            this.pnlAddOpenings.Controls.Add(this.textBox2);
            this.pnlAddOpenings.Controls.Add(this.lblAddOpeningLength);
            this.pnlAddOpenings.Controls.Add(this.lblAddOpenings);
            this.pnlAddOpenings.Location = new System.Drawing.Point(217, 36);
            this.pnlAddOpenings.Name = "pnlAddOpenings";
            this.pnlAddOpenings.Size = new System.Drawing.Size(195, 297);
            this.pnlAddOpenings.TabIndex = 3;
            // 
            // lblAddOpenings
            // 
            this.lblAddOpenings.AutoSize = true;
            this.lblAddOpenings.Location = new System.Drawing.Point(71, 13);
            this.lblAddOpenings.Name = "lblAddOpenings";
            this.lblAddOpenings.Size = new System.Drawing.Size(74, 13);
            this.lblAddOpenings.TabIndex = 2;
            this.lblAddOpenings.Text = "Add Openings";
            // 
            // pnlWallSizeList
            // 
            this.pnlWallSizeList.Controls.Add(this.lblWallList);
            this.pnlWallSizeList.Location = new System.Drawing.Point(431, 36);
            this.pnlWallSizeList.Name = "pnlWallSizeList";
            this.pnlWallSizeList.Size = new System.Drawing.Size(174, 227);
            this.pnlWallSizeList.TabIndex = 3;
            // 
            // lblWallList
            // 
            this.lblWallList.AutoSize = true;
            this.lblWallList.Location = new System.Drawing.Point(71, 13);
            this.lblWallList.Name = "lblWallList";
            this.lblWallList.Size = new System.Drawing.Size(47, 13);
            this.lblWallList.TabIndex = 2;
            this.lblWallList.Text = "Wall List";
            // 
            // lblWallNumber
            // 
            this.lblWallNumber.AutoSize = true;
            this.lblWallNumber.Location = new System.Drawing.Point(19, 48);
            this.lblWallNumber.Name = "lblWallNumber";
            this.lblWallNumber.Size = new System.Drawing.Size(69, 13);
            this.lblWallNumber.TabIndex = 3;
            this.lblWallNumber.Text = "Wall number:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblAddWallLength
            // 
            this.lblAddWallLength.AutoSize = true;
            this.lblAddWallLength.Location = new System.Drawing.Point(19, 103);
            this.lblAddWallLength.Name = "lblAddWallLength";
            this.lblAddWallLength.Size = new System.Drawing.Size(63, 13);
            this.lblAddWallLength.TabIndex = 4;
            this.lblAddWallLength.Text = "Wall length:";
            // 
            // lblAddWallHeight
            // 
            this.lblAddWallHeight.AutoSize = true;
            this.lblAddWallHeight.Location = new System.Drawing.Point(19, 139);
            this.lblAddWallHeight.Name = "lblAddWallHeight";
            this.lblAddWallHeight.Size = new System.Drawing.Size(63, 13);
            this.lblAddWallHeight.TabIndex = 5;
            this.lblAddWallHeight.Text = "Wall height:";
            // 
            // txtAddWallLength
            // 
            this.txtAddWallLength.Location = new System.Drawing.Point(88, 100);
            this.txtAddWallLength.Name = "txtAddWallLength";
            this.txtAddWallLength.Size = new System.Drawing.Size(100, 20);
            this.txtAddWallLength.TabIndex = 3;
            // 
            // txtAddWallHeight
            // 
            this.txtAddWallHeight.Location = new System.Drawing.Point(88, 136);
            this.txtAddWallHeight.Name = "txtAddWallHeight";
            this.txtAddWallHeight.Size = new System.Drawing.Size(100, 20);
            this.txtAddWallHeight.TabIndex = 4;
            // 
            // lblAddCavitySize
            // 
            this.lblAddCavitySize.AutoSize = true;
            this.lblAddCavitySize.Location = new System.Drawing.Point(19, 174);
            this.lblAddCavitySize.Name = "lblAddCavitySize";
            this.lblAddCavitySize.Size = new System.Drawing.Size(71, 13);
            this.lblAddCavitySize.TabIndex = 6;
            this.lblAddCavitySize.Text = "Cavity Depth:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblAddOpeningHeight
            // 
            this.lblAddOpeningHeight.AutoSize = true;
            this.lblAddOpeningHeight.Location = new System.Drawing.Point(3, 75);
            this.lblAddOpeningHeight.Name = "lblAddOpeningHeight";
            this.lblAddOpeningHeight.Size = new System.Drawing.Size(82, 13);
            this.lblAddOpeningHeight.TabIndex = 9;
            this.lblAddOpeningHeight.Text = "Opening height:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblAddOpeningLength
            // 
            this.lblAddOpeningLength.AutoSize = true;
            this.lblAddOpeningLength.Location = new System.Drawing.Point(3, 51);
            this.lblAddOpeningLength.Name = "lblAddOpeningLength";
            this.lblAddOpeningLength.Size = new System.Drawing.Size(82, 13);
            this.lblAddOpeningLength.TabIndex = 8;
            this.lblAddOpeningLength.Text = "Opening length:";
            this.lblAddOpeningLength.Click += new System.EventHandler(this.lblAddOpeningLength_Click);
            // 
            // btnAddOpening
            // 
            this.btnAddOpening.Location = new System.Drawing.Point(113, 101);
            this.btnAddOpening.Name = "btnAddOpening";
            this.btnAddOpening.Size = new System.Drawing.Size(75, 23);
            this.btnAddOpening.TabIndex = 10;
            this.btnAddOpening.Text = "Add";
            this.btnAddOpening.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "????";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlAddJob
            // 
            this.pnlAddJob.Controls.Add(this.cmbAddJobCustNo);
            this.pnlAddJob.Controls.Add(this.lblCustomerNo);
            this.pnlAddJob.Controls.Add(this.btnCancelCalculate);
            this.pnlAddJob.Controls.Add(this.btnCalculate);
            this.pnlAddJob.Controls.Add(this.pnlAddWall);
            this.pnlAddJob.Controls.Add(this.lblActualJobID);
            this.pnlAddJob.Controls.Add(this.lblJobID);
            this.pnlAddJob.Controls.Add(this.pnlWallSizeList);
            this.pnlAddJob.Controls.Add(this.pnlAddOpenings);
            this.pnlAddJob.Location = new System.Drawing.Point(12, 3);
            this.pnlAddJob.Name = "pnlAddJob";
            this.pnlAddJob.Size = new System.Drawing.Size(620, 380);
            this.pnlAddJob.TabIndex = 4;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddCustomer.Location = new System.Drawing.Point(719, 63);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(41, 23);
            this.lblAddCustomer.TabIndex = 50;
            this.lblAddCustomer.Text = "Add";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(680, 60);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnAddCustomer.TabIndex = 45;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditCustomer.Location = new System.Drawing.Point(719, 134);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(39, 23);
            this.lblEditCustomer.TabIndex = 47;
            this.lblEditCustomer.Text = "Edit";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditCustomer.Location = new System.Drawing.Point(680, 131);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnEditCustomer.TabIndex = 46;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(719, 203);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteCustomer.TabIndex = 51;
            this.lblDeleteCustomer.Text = "Delete";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(680, 200);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteCustomer.TabIndex = 48;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchCustomer.Location = new System.Drawing.Point(719, 269);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(62, 23);
            this.lblSearchCustomer.TabIndex = 52;
            this.lblSearchCustomer.Text = "Search";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchCustomer.Location = new System.Drawing.Point(680, 266);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnSearchCustomer.TabIndex = 49;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // lblReturnMenu
            // 
            this.lblReturnMenu.AutoSize = true;
            this.lblReturnMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnMenu.Location = new System.Drawing.Point(719, 326);
            this.lblReturnMenu.Name = "lblReturnMenu";
            this.lblReturnMenu.Size = new System.Drawing.Size(62, 23);
            this.lblReturnMenu.TabIndex = 54;
            this.lblReturnMenu.Text = "Return";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnReturnMenu.BackgroundImage = global::SF.Properties.Resources.returnBLACKANDBLUE;
            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Location = new System.Drawing.Point(680, 323);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnReturnMenu.TabIndex = 53;
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(530, 318);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnCancelCalculate
            // 
            this.btnCancelCalculate.Location = new System.Drawing.Point(449, 318);
            this.btnCancelCalculate.Name = "btnCancelCalculate";
            this.btnCancelCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCalculate.TabIndex = 5;
            this.btnCancelCalculate.Text = "Cancel";
            this.btnCancelCalculate.UseVisualStyleBackColor = true;
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(292, 11);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(71, 13);
            this.lblCustomerNo.TabIndex = 6;
            this.lblCustomerNo.Text = "Customer No:";
            // 
            // cmbAddJobCustNo
            // 
            this.cmbAddJobCustNo.FormattingEnabled = true;
            this.cmbAddJobCustNo.Location = new System.Drawing.Point(369, 8);
            this.cmbAddJobCustNo.Name = "cmbAddJobCustNo";
            this.cmbAddJobCustNo.Size = new System.Drawing.Size(80, 21);
            this.cmbAddJobCustNo.TabIndex = 7;
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.lblDeleteCustomer);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.lblEditCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblReturnMenu);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.pnlAddJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJobs";
            this.Text = "frmJobs";
            this.pnlAddWall.ResumeLayout(false);
            this.pnlAddWall.PerformLayout();
            this.pnlAddOpenings.ResumeLayout(false);
            this.pnlAddOpenings.PerformLayout();
            this.pnlWallSizeList.ResumeLayout(false);
            this.pnlWallSizeList.PerformLayout();
            this.pnlAddJob.ResumeLayout(false);
            this.pnlAddJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblActualJobID;
        private System.Windows.Forms.Panel pnlAddWall;
        private System.Windows.Forms.Label lblAddWall;
        private System.Windows.Forms.Panel pnlAddOpenings;
        private System.Windows.Forms.Label lblAddOpenings;
        private System.Windows.Forms.Panel pnlWallSizeList;
        private System.Windows.Forms.Label lblWallList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblWallNumber;
        private System.Windows.Forms.TextBox txtAddWallHeight;
        private System.Windows.Forms.Label lblAddWallHeight;
        private System.Windows.Forms.TextBox txtAddWallLength;
        private System.Windows.Forms.Label lblAddWallLength;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblAddCavitySize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddOpeningHeight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAddOpeningLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOpening;
        private System.Windows.Forms.Panel pnlAddJob;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnCancelCalculate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbAddJobCustNo;
        private System.Windows.Forms.Label lblCustomerNo;
    }
}