namespace SF
{
    partial class frmHome
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.picBoxStock = new System.Windows.Forms.PictureBox();
            this.lblJobs = new System.Windows.Forms.Label();
            this.picBoxCust = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picBoxJob = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxBG = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJob)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.DimGray;
            this.pnlSide.Controls.Add(this.lblCust);
            this.pnlSide.Controls.Add(this.lblStock);
            this.pnlSide.Controls.Add(this.picBoxStock);
            this.pnlSide.Controls.Add(this.lblJobs);
            this.pnlSide.Controls.Add(this.picBoxCust);
            this.pnlSide.Controls.Add(this.pnlLogo);
            this.pnlSide.Controls.Add(this.picBoxJob);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(152, 505);
            this.pnlSide.TabIndex = 0;
            this.pnlSide.MouseEnter += new System.EventHandler(this.pnlSide_MouseEnter);
            // 
            // lblCust
            // 
            this.lblCust.BackColor = System.Drawing.Color.Transparent;
            this.lblCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCust.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.Color.White;
            this.lblCust.Location = new System.Drawing.Point(12, 324);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(137, 32);
            this.lblCust.TabIndex = 3;
            this.lblCust.Text = "Customers";
            this.lblCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCust.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(26, 453);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(99, 32);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxStock
            // 
            this.picBoxStock.Image = global::SF.Properties.Resources.stockLogo31;
            this.picBoxStock.Location = new System.Drawing.Point(22, 366);
            this.picBoxStock.Name = "picBoxStock";
            this.picBoxStock.Size = new System.Drawing.Size(107, 84);
            this.picBoxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStock.TabIndex = 4;
            this.picBoxStock.TabStop = false;
            // 
            // lblJobs
            // 
            this.lblJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobs.ForeColor = System.Drawing.Color.White;
            this.lblJobs.Location = new System.Drawing.Point(26, 200);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(99, 32);
            this.lblJobs.TabIndex = 2;
            this.lblJobs.Text = "Jobs";
            this.lblJobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJobs.Click += new System.EventHandler(this.lblJobs_Click);
            this.lblJobs.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // picBoxCust
            // 
            this.picBoxCust.Image = global::SF.Properties.Resources.customerLogoPSBlue;
            this.picBoxCust.Location = new System.Drawing.Point(26, 248);
            this.picBoxCust.Name = "picBoxCust";
            this.picBoxCust.Size = new System.Drawing.Size(103, 73);
            this.picBoxCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCust.TabIndex = 3;
            this.picBoxCust.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::SF.Properties.Resources.SF_Logo1;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(152, 97);
            this.pnlLogo.TabIndex = 0;
            // 
            // picBoxJob
            // 
            this.picBoxJob.Image = global::SF.Properties.Resources.jobLogoPSBlue1;
            this.picBoxJob.Location = new System.Drawing.Point(26, 124);
            this.picBoxJob.Name = "picBoxJob";
            this.picBoxJob.Size = new System.Drawing.Size(103, 73);
            this.picBoxJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxJob.TabIndex = 2;
            this.picBoxJob.TabStop = false;
            this.picBoxJob.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Location = new System.Drawing.Point(152, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(832, 97);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bell MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.lblTitle.Location = new System.Drawing.Point(198, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 56);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SureFill Insulation";
            // 
            // picBoxBG
            // 
            this.picBoxBG.Image = global::SF.Properties.Resources.niceHouse;
            this.picBoxBG.Location = new System.Drawing.Point(152, 99);
            this.picBoxBG.Name = "picBoxBG";
            this.picBoxBG.Size = new System.Drawing.Size(832, 406);
            this.picBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBG.TabIndex = 2;
            this.picBoxBG.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(816, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 34);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(816, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 34);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(697, 127);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 27);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(697, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 27);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(874, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 41);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(874, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 505);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picBoxBG);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJob)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picBoxJob;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBoxStock;
        private System.Windows.Forms.PictureBox picBoxCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox picBoxBG;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

