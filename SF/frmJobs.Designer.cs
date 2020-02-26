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
            this.components = new System.ComponentModel.Container();
            this.lblSearchJob = new System.Windows.Forms.Label();
            this.lblDeleteJob = new System.Windows.Forms.Label();
            this.lblAddJob = new System.Windows.Forms.Label();
            this.btnSearchJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.lblEditJob = new System.Windows.Forms.Label();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.pnlReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchJob
            // 
            this.lblSearchJob.AutoSize = true;
            this.lblSearchJob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchJob.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchJob.Location = new System.Drawing.Point(740, 278);
            this.lblSearchJob.Name = "lblSearchJob";
            this.lblSearchJob.Size = new System.Drawing.Size(62, 23);
            this.lblSearchJob.TabIndex = 42;
            this.lblSearchJob.Text = "Search";
            // 
            // lblDeleteJob
            // 
            this.lblDeleteJob.AutoSize = true;
            this.lblDeleteJob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteJob.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteJob.Location = new System.Drawing.Point(740, 212);
            this.lblDeleteJob.Name = "lblDeleteJob";
            this.lblDeleteJob.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteJob.TabIndex = 41;
            this.lblDeleteJob.Text = "Delete";
            // 
            // lblAddJob
            // 
            this.lblAddJob.AutoSize = true;
            this.lblAddJob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddJob.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddJob.Location = new System.Drawing.Point(740, 72);
            this.lblAddJob.Name = "lblAddJob";
            this.lblAddJob.Size = new System.Drawing.Size(41, 23);
            this.lblAddJob.TabIndex = 40;
            this.lblAddJob.Text = "Add";
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchJob.Location = new System.Drawing.Point(701, 275);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(33, 33);
            this.btnSearchJob.TabIndex = 39;
            this.btnSearchJob.UseVisualStyleBackColor = false;
            this.btnSearchJob.MouseEnter += new System.EventHandler(this.btnSearchJob_MouseEnter);
            this.btnSearchJob.MouseLeave += new System.EventHandler(this.btnSearchJob_MouseLeave);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteJob.Location = new System.Drawing.Point(701, 209);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteJob.TabIndex = 38;
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            this.btnDeleteJob.MouseEnter += new System.EventHandler(this.btnDeleteJob_MouseEnter);
            this.btnDeleteJob.MouseLeave += new System.EventHandler(this.btnDeleteJob_MouseLeave);
            // 
            // tmrBanner
            // 
            this.tmrBanner.Enabled = true;
            this.tmrBanner.Interval = 50;
            // 
            // lblEditJob
            // 
            this.lblEditJob.AutoSize = true;
            this.lblEditJob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditJob.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditJob.Location = new System.Drawing.Point(740, 143);
            this.lblEditJob.Name = "lblEditJob";
            this.lblEditJob.Size = new System.Drawing.Size(39, 23);
            this.lblEditJob.TabIndex = 37;
            this.lblEditJob.Text = "Edit";
            // 
            // btnEditJob
            // 
            this.btnEditJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditJob.Location = new System.Drawing.Point(701, 140);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(33, 33);
            this.btnEditJob.TabIndex = 36;
            this.btnEditJob.UseVisualStyleBackColor = false;
            this.btnEditJob.MouseEnter += new System.EventHandler(this.btnEditJob_MouseEnter);
            this.btnEditJob.MouseLeave += new System.EventHandler(this.btnEditJob_MouseLeave);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Location = new System.Drawing.Point(701, 69);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(33, 33);
            this.btnAddJob.TabIndex = 35;
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            this.btnAddJob.MouseEnter += new System.EventHandler(this.btnAddJob_MouseEnter);
            this.btnAddJob.MouseLeave += new System.EventHandler(this.btnAddJob_MouseLeave);
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 12);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.Size = new System.Drawing.Size(620, 380);
            this.dgvJobs.TabIndex = 34;
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.lblReturnMenu);
            this.pnlReturn.Controls.Add(this.btnReturnMenu);
            this.pnlReturn.Location = new System.Drawing.Point(701, 324);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(134, 46);
            this.pnlReturn.TabIndex = 43;
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
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.pnlReturn);
            this.Controls.Add(this.lblSearchJob);
            this.Controls.Add(this.lblDeleteJob);
            this.Controls.Add(this.lblAddJob);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.lblEditJob);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.dgvJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmJobs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.pnlReturn.ResumeLayout(false);
            this.pnlReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchJob;
        private System.Windows.Forms.Label lblDeleteJob;
        private System.Windows.Forms.Label lblAddJob;
        private System.Windows.Forms.Button btnSearchJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Timer tmrBanner;
        private System.Windows.Forms.Label lblEditJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
    }
}