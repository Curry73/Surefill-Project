namespace SF
{
    partial class FrmOrders
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
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.coOrderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coProductNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblActualOrderSupplierNo = new System.Windows.Forms.Label();
            this.lblOrderSupplierNo = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchCustomer.Location = new System.Drawing.Point(714, 267);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(62, 23);
            this.lblSearchCustomer.TabIndex = 62;
            this.lblSearchCustomer.Text = "Search";
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(714, 201);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteCustomer.TabIndex = 61;
            this.lblDeleteCustomer.Text = "Delete";
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddCustomer.Location = new System.Drawing.Point(714, 61);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(41, 23);
            this.lblAddCustomer.TabIndex = 60;
            this.lblAddCustomer.Text = "Add";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchCustomer.Location = new System.Drawing.Point(675, 264);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnSearchCustomer.TabIndex = 59;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(675, 198);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteCustomer.TabIndex = 58;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditCustomer.Location = new System.Drawing.Point(714, 132);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(39, 23);
            this.lblEditCustomer.TabIndex = 57;
            this.lblEditCustomer.Text = "Edit";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditCustomer.Location = new System.Drawing.Point(675, 129);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnEditCustomer.TabIndex = 56;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(675, 58);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(33, 33);
            this.btnAddCustomer.TabIndex = 55;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // lblReturnMenu
            // 
            this.lblReturnMenu.AutoSize = true;
            this.lblReturnMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnMenu.Location = new System.Drawing.Point(714, 324);
            this.lblReturnMenu.Name = "lblReturnMenu";
            this.lblReturnMenu.Size = new System.Drawing.Size(62, 23);
            this.lblReturnMenu.TabIndex = 64;
            this.lblReturnMenu.Text = "Return";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnReturnMenu.BackgroundImage = global::SF.Properties.Resources.returnBLACKANDBLUE;
            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Location = new System.Drawing.Point(675, 321);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnReturnMenu.TabIndex = 63;
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwOrderDetails);
            this.panel1.Controls.Add(this.pnlPayment);
            this.panel1.Controls.Add(this.pnlSupplier);
            this.panel1.Controls.Add(this.pnlOrder);
            this.panel1.Location = new System.Drawing.Point(9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 396);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coOrderQty,
            this.coProductNo,
            this.coProductPrice});
            this.lvwOrderDetails.Location = new System.Drawing.Point(12, 234);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(393, 156);
            this.lvwOrderDetails.TabIndex = 3;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // coOrderQty
            // 
            this.coOrderQty.Text = "Order Qty";
            // 
            // coProductNo
            // 
            this.coProductNo.Text = "Product No";
            // 
            // coProductPrice
            // 
            this.coProductPrice.Text = "Product Price";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Location = new System.Drawing.Point(419, 241);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(201, 80);
            this.pnlPayment.TabIndex = 2;
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Location = new System.Drawing.Point(416, 23);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(205, 204);
            this.pnlSupplier.TabIndex = 1;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.lblActualOrderSupplierNo);
            this.pnlOrder.Controls.Add(this.lblOrderSupplierNo);
            this.pnlOrder.Controls.Add(this.dtpOrderDate);
            this.pnlOrder.Controls.Add(this.lblOrderDate);
            this.pnlOrder.Controls.Add(this.lblOrderNo);
            this.pnlOrder.Controls.Add(this.cmbOrderNo);
            this.pnlOrder.Location = new System.Drawing.Point(12, 23);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(393, 205);
            this.pnlOrder.TabIndex = 0;
            // 
            // lblActualOrderSupplierNo
            // 
            this.lblActualOrderSupplierNo.AutoSize = true;
            this.lblActualOrderSupplierNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualOrderSupplierNo.ForeColor = System.Drawing.Color.Black;
            this.lblActualOrderSupplierNo.Location = new System.Drawing.Point(157, 128);
            this.lblActualOrderSupplierNo.Name = "lblActualOrderSupplierNo";
            this.lblActualOrderSupplierNo.Size = new System.Drawing.Size(90, 16);
            this.lblActualOrderSupplierNo.TabIndex = 119;
            this.lblActualOrderSupplierNo.Text = "Supplier No";
            // 
            // lblOrderSupplierNo
            // 
            this.lblOrderSupplierNo.AutoSize = true;
            this.lblOrderSupplierNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSupplierNo.ForeColor = System.Drawing.Color.Black;
            this.lblOrderSupplierNo.Location = new System.Drawing.Point(35, 128);
            this.lblOrderSupplierNo.Name = "lblOrderSupplierNo";
            this.lblOrderSupplierNo.Size = new System.Drawing.Size(90, 16);
            this.lblOrderSupplierNo.TabIndex = 115;
            this.lblOrderSupplierNo.Text = "Supplier No";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Location = new System.Drawing.Point(160, 84);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(195, 20);
            this.dtpOrderDate.TabIndex = 114;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.ForeColor = System.Drawing.Color.Black;
            this.lblOrderDate.Location = new System.Drawing.Point(35, 84);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(84, 16);
            this.lblOrderDate.TabIndex = 113;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(35, 52);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNo.TabIndex = 1;
            this.lblOrderNo.Text = "Order No";
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(160, 52);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(189, 21);
            this.cmbOrderNo.TabIndex = 0;
            this.cmbOrderNo.SelectedIndexChanged += new System.EventHandler(this.cmbOrderNo_SelectedIndexChanged);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 405);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.panel1.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwOrderDetails;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblActualOrderSupplierNo;
        private System.Windows.Forms.Label lblOrderSupplierNo;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.ColumnHeader coOrderQty;
        private System.Windows.Forms.ColumnHeader coProductNo;
        private System.Windows.Forms.ColumnHeader coProductPrice;
    }
}