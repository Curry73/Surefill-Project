namespace SF
{
    partial class frmStock
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
            this.lblSearchStock = new System.Windows.Forms.Label();
            this.lblDeleteStock = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.lblEditStock = new System.Windows.Forms.Label();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchStock
            // 
            this.lblSearchStock.AutoSize = true;
            this.lblSearchStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchStock.Location = new System.Drawing.Point(740, 277);
            this.lblSearchStock.Name = "lblSearchStock";
            this.lblSearchStock.Size = new System.Drawing.Size(62, 23);
            this.lblSearchStock.TabIndex = 42;
            this.lblSearchStock.Text = "Search";
            // 
            // lblDeleteStock
            // 
            this.lblDeleteStock.AutoSize = true;
            this.lblDeleteStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteStock.Location = new System.Drawing.Point(740, 211);
            this.lblDeleteStock.Name = "lblDeleteStock";
            this.lblDeleteStock.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteStock.TabIndex = 41;
            this.lblDeleteStock.Text = "Delete";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddStock.Location = new System.Drawing.Point(740, 71);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(41, 23);
            this.lblAddStock.TabIndex = 40;
            this.lblAddStock.Text = "Add";
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchStock.Location = new System.Drawing.Point(701, 274);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(33, 33);
            this.btnSearchStock.TabIndex = 39;
            this.btnSearchStock.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteStock.Location = new System.Drawing.Point(701, 208);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteStock.TabIndex = 38;
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            // 
            // tmrBanner
            // 
            this.tmrBanner.Enabled = true;
            this.tmrBanner.Interval = 50;
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditStock.Location = new System.Drawing.Point(740, 142);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(39, 23);
            this.lblEditStock.TabIndex = 37;
            this.lblEditStock.Text = "Edit";
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditStock.Location = new System.Drawing.Point(701, 139);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(33, 33);
            this.btnEditStock.TabIndex = 36;
            this.btnEditStock.UseVisualStyleBackColor = false;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(701, 68);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(33, 33);
            this.btnAddStock.TabIndex = 35;
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(12, 12);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(620, 380);
            this.dgvStock.TabIndex = 34;
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.lblReturnMenu);
            this.pnlReturn.Controls.Add(this.btnReturnMenu);
            this.pnlReturn.Location = new System.Drawing.Point(701, 325);
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
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.pnlReturn);
            this.Controls.Add(this.lblSearchStock);
            this.Controls.Add(this.lblDeleteStock);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.btnSearchStock);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.lblEditStock);
            this.Controls.Add(this.btnEditStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.dgvStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlReturn.ResumeLayout(false);
            this.pnlReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchStock;
        private System.Windows.Forms.Label lblDeleteStock;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Timer tmrBanner;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
    }
}