namespace SF
{
    partial class frmMenu
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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblJobs = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.picBoxTitle = new System.Windows.Forms.PictureBox();
            this.picBoxSupplier = new System.Windows.Forms.PictureBox();
            this.picBoxStock = new System.Windows.Forms.PictureBox();
            this.picBoxCust = new System.Windows.Forms.PictureBox();
            this.picBoxJob = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJob)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Lime;
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHome.Location = new System.Drawing.Point(102, 94);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(863, 405);
            this.pnlHome.TabIndex = 0;
            // 
            // lblCust
            // 
            this.lblCust.BackColor = System.Drawing.Color.Transparent;
            this.lblCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCust.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.Color.White;
            this.lblCust.Location = new System.Drawing.Point(6, 269);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(90, 29);
            this.lblCust.TabIndex = 13;
            this.lblCust.Text = "Customers";
            this.lblCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(16, 364);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(65, 29);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblJobs
            // 
            this.lblJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobs.ForeColor = System.Drawing.Color.White;
            this.lblJobs.Location = new System.Drawing.Point(20, 167);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(57, 25);
            this.lblJobs.TabIndex = 11;
            this.lblJobs.Text = "Jobs";
            this.lblJobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJobs.Click += new System.EventHandler(this.lblJobs_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.picBoxTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Location = new System.Drawing.Point(102, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(864, 97);
            this.pnlTop.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.DimGray;
            this.pnlSide.Controls.Add(this.lblSupplier);
            this.pnlSide.Controls.Add(this.picBoxSupplier);
            this.pnlSide.Controls.Add(this.lblCust);
            this.pnlSide.Controls.Add(this.lblStock);
            this.pnlSide.Controls.Add(this.picBoxStock);
            this.pnlSide.Controls.Add(this.lblJobs);
            this.pnlSide.Controls.Add(this.picBoxCust);
            this.pnlSide.Controls.Add(this.picBoxJob);
            this.pnlSide.Controls.Add(this.pnlLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(102, 499);
            this.pnlSide.TabIndex = 14;
            // 
            // lblSupplier
            // 
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(6, 469);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(90, 29);
            this.lblSupplier.TabIndex = 18;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // picBoxTitle
            // 
            this.picBoxTitle.BackgroundImage = global::SF.Properties.Resources.SFTitle1;
            this.picBoxTitle.Location = new System.Drawing.Point(147, 27);
            this.picBoxTitle.Name = "picBoxTitle";
            this.picBoxTitle.Size = new System.Drawing.Size(593, 39);
            this.picBoxTitle.TabIndex = 7;
            this.picBoxTitle.TabStop = false;
            // 
            // picBoxSupplier
            // 
            this.picBoxSupplier.Image = global::SF.Properties.Resources.SupplierBLUE;
            this.picBoxSupplier.Location = new System.Drawing.Point(16, 396);
            this.picBoxSupplier.Name = "picBoxSupplier";
            this.picBoxSupplier.Size = new System.Drawing.Size(71, 70);
            this.picBoxSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSupplier.TabIndex = 17;
            this.picBoxSupplier.TabStop = false;
            this.picBoxSupplier.Click += new System.EventHandler(this.picBoxSupplier_Click);
            // 
            // picBoxStock
            // 
            this.picBoxStock.Image = global::SF.Properties.Resources.stockLogo31;
            this.picBoxStock.Location = new System.Drawing.Point(14, 291);
            this.picBoxStock.Name = "picBoxStock";
            this.picBoxStock.Size = new System.Drawing.Size(71, 70);
            this.picBoxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStock.TabIndex = 16;
            this.picBoxStock.TabStop = false;
            this.picBoxStock.Click += new System.EventHandler(this.picBoxStock_Click);
            this.picBoxStock.MouseEnter += new System.EventHandler(this.picBoxStock_MouseEnter);
            this.picBoxStock.MouseLeave += new System.EventHandler(this.picBoxStock_MouseLeave);
            // 
            // picBoxCust
            // 
            this.picBoxCust.Image = global::SF.Properties.Resources.customerLogoPSBlue;
            this.picBoxCust.Location = new System.Drawing.Point(16, 195);
            this.picBoxCust.Name = "picBoxCust";
            this.picBoxCust.Size = new System.Drawing.Size(69, 71);
            this.picBoxCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCust.TabIndex = 14;
            this.picBoxCust.TabStop = false;
            this.picBoxCust.Click += new System.EventHandler(this.picBoxCust_Click);
            this.picBoxCust.MouseEnter += new System.EventHandler(this.picBoxCust_MouseEnter);
            this.picBoxCust.MouseLeave += new System.EventHandler(this.picBoxCust_MouseLeave);
            // 
            // picBoxJob
            // 
            this.picBoxJob.Image = global::SF.Properties.Resources.jobLogoPSBlue1;
            this.picBoxJob.Location = new System.Drawing.Point(16, 103);
            this.picBoxJob.Name = "picBoxJob";
            this.picBoxJob.Size = new System.Drawing.Size(69, 61);
            this.picBoxJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxJob.TabIndex = 12;
            this.picBoxJob.TabStop = false;
            this.picBoxJob.Click += new System.EventHandler(this.picBoxJob_Click);
            this.picBoxJob.MouseEnter += new System.EventHandler(this.picBoxJob_MouseEnter);
            this.picBoxJob.MouseLeave += new System.EventHandler(this.picBoxJob_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::SF.Properties.Resources.SF_Logo1;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(104, 97);
            this.pnlLogo.TabIndex = 10;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 499);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picBoxTitle;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox picBoxStock;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.PictureBox picBoxCust;
        private System.Windows.Forms.PictureBox picBoxJob;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.PictureBox picBoxSupplier;
    }
}