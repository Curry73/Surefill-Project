namespace SF
{
    partial class frmProductOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.lstSupplier = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSupplierNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.lvwBooking = new System.Windows.Forms.ListView();
            this.colSupplierNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProductNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblOrderQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCust5 = new System.Windows.Forms.Label();
            this.lblSupplierDets = new System.Windows.Forms.Label();
            this.lblCust4 = new System.Windows.Forms.Label();
            this.lblCust3 = new System.Windows.Forms.Label();
            this.lblCust2 = new System.Windows.Forms.Label();
            this.lblCust1 = new System.Windows.Forms.Label();
            this.lblCust0 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b115 = new System.Windows.Forms.Button();
            this.b16 = new System.Windows.Forms.Button();
            this.b17 = new System.Windows.Forms.Button();
            this.b18 = new System.Windows.Forms.Button();
            this.b19 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b24 = new System.Windows.Forms.Button();
            this.b25 = new System.Windows.Forms.Button();
            this.b26 = new System.Windows.Forms.Button();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.lblReturnMenu = new System.Windows.Forms.Label();
            this.lblSearchSupplier = new System.Windows.Forms.Label();
            this.lblDeleteSupplier = new System.Windows.Forms.Label();
            this.lblEditSupplier = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstProduct);
            this.panel1.Controls.Add(this.lstSupplier);
            this.panel1.Controls.Add(this.lblProducts);
            this.panel1.Controls.Add(this.lblSupplierNo);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 196);
            this.panel1.TabIndex = 0;
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 16;
            this.lstProduct.Location = new System.Drawing.Point(288, 29);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(305, 164);
            this.lstProduct.TabIndex = 85;
            // 
            // lstSupplier
            // 
            this.lstSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSupplier.FormattingEnabled = true;
            this.lstSupplier.ItemHeight = 16;
            this.lstSupplier.Location = new System.Drawing.Point(6, 29);
            this.lstSupplier.Name = "lstSupplier";
            this.lstSupplier.Size = new System.Drawing.Size(276, 164);
            this.lstSupplier.TabIndex = 84;
            this.lstSupplier.Click += new System.EventHandler(this.lstSupplier_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(285, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lblSupplierNo
            // 
            this.lblSupplierNo.AutoSize = true;
            this.lblSupplierNo.Location = new System.Drawing.Point(3, 13);
            this.lblSupplierNo.Name = "lblSupplierNo";
            this.lblSupplierNo.Size = new System.Drawing.Size(62, 13);
            this.lblSupplierNo.TabIndex = 0;
            this.lblSupplierNo.Text = "Supplier No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemoveItem);
            this.panel2.Controls.Add(this.btAddItem);
            this.panel2.Controls.Add(this.lvwBooking);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 168);
            this.panel2.TabIndex = 1;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(513, 140);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveItem.TabIndex = 109;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.BackColor = System.Drawing.Color.White;
            this.btAddItem.Location = new System.Drawing.Point(513, 108);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(82, 23);
            this.btAddItem.TabIndex = 108;
            this.btAddItem.Text = "Add Item";
            this.btAddItem.UseVisualStyleBackColor = false;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // lvwBooking
            // 
            this.lvwBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSupplierNo,
            this.colProductNo,
            this.colQty});
            this.lvwBooking.FullRowSelect = true;
            this.lvwBooking.Location = new System.Drawing.Point(287, 99);
            this.lvwBooking.Name = "lvwBooking";
            this.lvwBooking.Size = new System.Drawing.Size(220, 64);
            this.lvwBooking.TabIndex = 107;
            this.lvwBooking.UseCompatibleStateImageBehavior = false;
            this.lvwBooking.View = System.Windows.Forms.View.Details;
            // 
            // colSupplierNo
            // 
            this.colSupplierNo.Text = "Supplier No";
            this.colSupplierNo.Width = 50;
            // 
            // colProductNo
            // 
            this.colProductNo.Text = "Product No";
            this.colProductNo.Width = 80;
            // 
            // colQty
            // 
            this.colQty.Text = "QTY";
            this.colQty.Width = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtOrderQty);
            this.panel5.Controls.Add(this.lblBookingDate);
            this.panel5.Controls.Add(this.lblOrderQty);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(287, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 88);
            this.panel5.TabIndex = 106;
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(128, 44);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(99, 20);
            this.txtOrderQty.TabIndex = 100;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.Black;
            this.lblBookingDate.Location = new System.Drawing.Point(125, 5);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(102, 16);
            this.lblBookingDate.TabIndex = 99;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblOrderQty
            // 
            this.lblOrderQty.AutoSize = true;
            this.lblOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderQty.ForeColor = System.Drawing.Color.Black;
            this.lblOrderQty.Location = new System.Drawing.Point(6, 48);
            this.lblOrderQty.Name = "lblOrderQty";
            this.lblOrderQty.Size = new System.Drawing.Size(31, 16);
            this.lblOrderQty.TabIndex = 95;
            this.lblOrderQty.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 94;
            this.label4.Text = "Booking Date:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblCust5);
            this.panel3.Controls.Add(this.lblSupplierDets);
            this.panel3.Controls.Add(this.lblCust4);
            this.panel3.Controls.Add(this.lblCust3);
            this.panel3.Controls.Add(this.lblCust2);
            this.panel3.Controls.Add(this.lblCust1);
            this.panel3.Controls.Add(this.lblCust0);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 158);
            this.panel3.TabIndex = 103;
            // 
            // lblCust5
            // 
            this.lblCust5.AutoSize = true;
            this.lblCust5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust5.ForeColor = System.Drawing.Color.Gray;
            this.lblCust5.Location = new System.Drawing.Point(2, 135);
            this.lblCust5.Name = "lblCust5";
            this.lblCust5.Size = new System.Drawing.Size(0, 16);
            this.lblCust5.TabIndex = 108;
            // 
            // lblSupplierDets
            // 
            this.lblSupplierDets.AutoSize = true;
            this.lblSupplierDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDets.Location = new System.Drawing.Point(2, 5);
            this.lblSupplierDets.Name = "lblSupplierDets";
            this.lblSupplierDets.Size = new System.Drawing.Size(94, 16);
            this.lblSupplierDets.TabIndex = 107;
            this.lblSupplierDets.Text = "Supplier No:";
            // 
            // lblCust4
            // 
            this.lblCust4.AutoSize = true;
            this.lblCust4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust4.ForeColor = System.Drawing.Color.Gray;
            this.lblCust4.Location = new System.Drawing.Point(2, 110);
            this.lblCust4.Name = "lblCust4";
            this.lblCust4.Size = new System.Drawing.Size(0, 16);
            this.lblCust4.TabIndex = 106;
            // 
            // lblCust3
            // 
            this.lblCust3.AutoSize = true;
            this.lblCust3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust3.ForeColor = System.Drawing.Color.Gray;
            this.lblCust3.Location = new System.Drawing.Point(2, 85);
            this.lblCust3.Name = "lblCust3";
            this.lblCust3.Size = new System.Drawing.Size(0, 16);
            this.lblCust3.TabIndex = 105;
            // 
            // lblCust2
            // 
            this.lblCust2.AutoSize = true;
            this.lblCust2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust2.ForeColor = System.Drawing.Color.Gray;
            this.lblCust2.Location = new System.Drawing.Point(2, 60);
            this.lblCust2.Name = "lblCust2";
            this.lblCust2.Size = new System.Drawing.Size(0, 16);
            this.lblCust2.TabIndex = 104;
            // 
            // lblCust1
            // 
            this.lblCust1.AutoSize = true;
            this.lblCust1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust1.ForeColor = System.Drawing.Color.Gray;
            this.lblCust1.Location = new System.Drawing.Point(2, 35);
            this.lblCust1.Name = "lblCust1";
            this.lblCust1.Size = new System.Drawing.Size(0, 16);
            this.lblCust1.TabIndex = 103;
            // 
            // lblCust0
            // 
            this.lblCust0.AutoSize = true;
            this.lblCust0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust0.ForeColor = System.Drawing.Color.Gray;
            this.lblCust0.Location = new System.Drawing.Point(100, 5);
            this.lblCust0.Name = "lblCust0";
            this.lblCust0.Size = new System.Drawing.Size(0, 16);
            this.lblCust0.TabIndex = 102;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.b1);
            this.pnlButtons.Controls.Add(this.b2);
            this.pnlButtons.Controls.Add(this.b3);
            this.pnlButtons.Controls.Add(this.b4);
            this.pnlButtons.Controls.Add(this.b5);
            this.pnlButtons.Controls.Add(this.b6);
            this.pnlButtons.Controls.Add(this.b7);
            this.pnlButtons.Controls.Add(this.b8);
            this.pnlButtons.Controls.Add(this.b9);
            this.pnlButtons.Controls.Add(this.b10);
            this.pnlButtons.Controls.Add(this.b11);
            this.pnlButtons.Controls.Add(this.b12);
            this.pnlButtons.Controls.Add(this.b13);
            this.pnlButtons.Controls.Add(this.b14);
            this.pnlButtons.Controls.Add(this.b115);
            this.pnlButtons.Controls.Add(this.b16);
            this.pnlButtons.Controls.Add(this.b17);
            this.pnlButtons.Controls.Add(this.b18);
            this.pnlButtons.Controls.Add(this.b19);
            this.pnlButtons.Controls.Add(this.b20);
            this.pnlButtons.Controls.Add(this.b21);
            this.pnlButtons.Controls.Add(this.b22);
            this.pnlButtons.Controls.Add(this.b23);
            this.pnlButtons.Controls.Add(this.b24);
            this.pnlButtons.Controls.Add(this.b25);
            this.pnlButtons.Controls.Add(this.b26);
            this.pnlButtons.Location = new System.Drawing.Point(12, 3);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(596, 28);
            this.pnlButtons.TabIndex = 109;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(34, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(20, 20);
            this.b1.TabIndex = 105;
            this.b1.Text = " ";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(54, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(20, 20);
            this.b2.TabIndex = 104;
            this.b2.Text = " ";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(74, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(20, 20);
            this.b3.TabIndex = 103;
            this.b3.Text = " ";
            this.b3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.Location = new System.Drawing.Point(94, 3);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(20, 20);
            this.b4.TabIndex = 102;
            this.b4.Text = " ";
            this.b4.UseVisualStyleBackColor = false;
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.Location = new System.Drawing.Point(114, 3);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(20, 20);
            this.b5.TabIndex = 101;
            this.b5.Text = " ";
            this.b5.UseVisualStyleBackColor = false;
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.Location = new System.Drawing.Point(134, 3);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(20, 20);
            this.b6.TabIndex = 100;
            this.b6.Text = " ";
            this.b6.UseVisualStyleBackColor = false;
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.Location = new System.Drawing.Point(154, 3);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(20, 20);
            this.b7.TabIndex = 99;
            this.b7.Text = " ";
            this.b7.UseVisualStyleBackColor = false;
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.White;
            this.b8.Location = new System.Drawing.Point(174, 3);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(20, 20);
            this.b8.TabIndex = 98;
            this.b8.Text = " ";
            this.b8.UseVisualStyleBackColor = false;
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.White;
            this.b9.Location = new System.Drawing.Point(194, 3);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(20, 20);
            this.b9.TabIndex = 97;
            this.b9.Text = " ";
            this.b9.UseVisualStyleBackColor = false;
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.White;
            this.b10.Location = new System.Drawing.Point(214, 3);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(20, 20);
            this.b10.TabIndex = 96;
            this.b10.Text = " ";
            this.b10.UseVisualStyleBackColor = false;
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.White;
            this.b11.Location = new System.Drawing.Point(234, 3);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(20, 20);
            this.b11.TabIndex = 95;
            this.b11.Text = " ";
            this.b11.UseVisualStyleBackColor = false;
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.White;
            this.b12.Location = new System.Drawing.Point(254, 3);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(20, 20);
            this.b12.TabIndex = 94;
            this.b12.Text = " ";
            this.b12.UseVisualStyleBackColor = false;
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.White;
            this.b13.Location = new System.Drawing.Point(274, 3);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(20, 20);
            this.b13.TabIndex = 93;
            this.b13.Text = " ";
            this.b13.UseVisualStyleBackColor = false;
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.White;
            this.b14.Location = new System.Drawing.Point(294, 3);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(20, 20);
            this.b14.TabIndex = 92;
            this.b14.Text = " ";
            this.b14.UseVisualStyleBackColor = false;
            // 
            // b115
            // 
            this.b115.BackColor = System.Drawing.Color.White;
            this.b115.Location = new System.Drawing.Point(314, 3);
            this.b115.Name = "b115";
            this.b115.Size = new System.Drawing.Size(20, 20);
            this.b115.TabIndex = 91;
            this.b115.Text = " ";
            this.b115.UseVisualStyleBackColor = false;
            // 
            // b16
            // 
            this.b16.BackColor = System.Drawing.Color.White;
            this.b16.Location = new System.Drawing.Point(334, 3);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(20, 20);
            this.b16.TabIndex = 90;
            this.b16.Text = " ";
            this.b16.UseVisualStyleBackColor = false;
            // 
            // b17
            // 
            this.b17.BackColor = System.Drawing.Color.White;
            this.b17.Location = new System.Drawing.Point(354, 3);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(20, 20);
            this.b17.TabIndex = 89;
            this.b17.Text = " ";
            this.b17.UseVisualStyleBackColor = false;
            // 
            // b18
            // 
            this.b18.BackColor = System.Drawing.Color.White;
            this.b18.Location = new System.Drawing.Point(374, 3);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(20, 20);
            this.b18.TabIndex = 88;
            this.b18.Text = " ";
            this.b18.UseVisualStyleBackColor = false;
            // 
            // b19
            // 
            this.b19.BackColor = System.Drawing.Color.White;
            this.b19.Location = new System.Drawing.Point(394, 3);
            this.b19.Name = "b19";
            this.b19.Size = new System.Drawing.Size(20, 20);
            this.b19.TabIndex = 87;
            this.b19.Text = " ";
            this.b19.UseVisualStyleBackColor = false;
            // 
            // b20
            // 
            this.b20.BackColor = System.Drawing.Color.White;
            this.b20.Location = new System.Drawing.Point(414, 3);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(20, 20);
            this.b20.TabIndex = 86;
            this.b20.Text = " ";
            this.b20.UseVisualStyleBackColor = false;
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.White;
            this.b21.Location = new System.Drawing.Point(434, 3);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(20, 20);
            this.b21.TabIndex = 85;
            this.b21.Text = " ";
            this.b21.UseVisualStyleBackColor = false;
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.White;
            this.b22.Location = new System.Drawing.Point(454, 3);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(20, 20);
            this.b22.TabIndex = 84;
            this.b22.Text = " ";
            this.b22.UseVisualStyleBackColor = false;
            // 
            // b23
            // 
            this.b23.BackColor = System.Drawing.Color.White;
            this.b23.Location = new System.Drawing.Point(474, 3);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(20, 20);
            this.b23.TabIndex = 83;
            this.b23.Text = " ";
            this.b23.UseVisualStyleBackColor = false;
            // 
            // b24
            // 
            this.b24.BackColor = System.Drawing.Color.White;
            this.b24.Location = new System.Drawing.Point(494, 3);
            this.b24.Name = "b24";
            this.b24.Size = new System.Drawing.Size(20, 20);
            this.b24.TabIndex = 82;
            this.b24.Text = " ";
            this.b24.UseVisualStyleBackColor = false;
            // 
            // b25
            // 
            this.b25.BackColor = System.Drawing.Color.White;
            this.b25.Location = new System.Drawing.Point(514, 3);
            this.b25.Name = "b25";
            this.b25.Size = new System.Drawing.Size(20, 20);
            this.b25.TabIndex = 81;
            this.b25.Text = " ";
            this.b25.UseVisualStyleBackColor = false;
            // 
            // b26
            // 
            this.b26.BackColor = System.Drawing.Color.White;
            this.b26.Location = new System.Drawing.Point(534, 3);
            this.b26.Name = "b26";
            this.b26.Size = new System.Drawing.Size(20, 20);
            this.b26.TabIndex = 80;
            this.b26.Text = " ";
            this.b26.UseVisualStyleBackColor = false;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.Gray;
            this.lblAddProduct.Location = new System.Drawing.Point(714, 69);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(42, 23);
            this.lblAddProduct.TabIndex = 111;
            this.lblAddProduct.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnAdd.Location = new System.Drawing.Point(683, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 110;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnReturnMenu.BackgroundImage = global::SF.Properties.Resources.returnBLACKANDBLUE;
            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Location = new System.Drawing.Point(683, 313);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnReturnMenu.TabIndex = 121;
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // lblReturnMenu
            // 
            this.lblReturnMenu.AutoSize = true;
            this.lblReturnMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnMenu.Location = new System.Drawing.Point(719, 323);
            this.lblReturnMenu.Name = "lblReturnMenu";
            this.lblReturnMenu.Size = new System.Drawing.Size(62, 23);
            this.lblReturnMenu.TabIndex = 120;
            this.lblReturnMenu.Text = "Return";
            // 
            // lblSearchSupplier
            // 
            this.lblSearchSupplier.AutoSize = true;
            this.lblSearchSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchSupplier.Location = new System.Drawing.Point(722, 258);
            this.lblSearchSupplier.Name = "lblSearchSupplier";
            this.lblSearchSupplier.Size = new System.Drawing.Size(62, 23);
            this.lblSearchSupplier.TabIndex = 119;
            this.lblSearchSupplier.Text = "Search";
            // 
            // lblDeleteSupplier
            // 
            this.lblDeleteSupplier.AutoSize = true;
            this.lblDeleteSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeleteSupplier.Location = new System.Drawing.Point(722, 192);
            this.lblDeleteSupplier.Name = "lblDeleteSupplier";
            this.lblDeleteSupplier.Size = new System.Drawing.Size(59, 23);
            this.lblDeleteSupplier.TabIndex = 118;
            this.lblDeleteSupplier.Text = "Delete";
            // 
            // lblEditSupplier
            // 
            this.lblEditSupplier.AutoSize = true;
            this.lblEditSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditSupplier.Location = new System.Drawing.Point(722, 123);
            this.lblEditSupplier.Name = "lblEditSupplier";
            this.lblEditSupplier.Size = new System.Drawing.Size(39, 23);
            this.lblEditSupplier.TabIndex = 116;
            this.lblEditSupplier.Text = "Edit";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnSearchSupplier.Location = new System.Drawing.Point(683, 255);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(33, 33);
            this.btnSearchSupplier.TabIndex = 115;
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(683, 189);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(33, 33);
            this.btnDeleteSupplier.TabIndex = 114;
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEditSupplier.Location = new System.Drawing.Point(683, 120);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(33, 33);
            this.btnEditSupplier.TabIndex = 113;
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // frmProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 402);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.lblReturnMenu);
            this.Controls.Add(this.lblSearchSupplier);
            this.Controls.Add(this.lblDeleteSupplier);
            this.Controls.Add(this.lblEditSupplier);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(455, 364);
            this.Name = "frmProductOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "sn";
            this.Load += new System.EventHandler(this.FrmProductOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.ListBox lstSupplier;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSupplierNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCust5;
        private System.Windows.Forms.Label lblSupplierDets;
        private System.Windows.Forms.Label lblCust4;
        private System.Windows.Forms.Label lblCust3;
        private System.Windows.Forms.Label lblCust2;
        private System.Windows.Forms.Label lblCust1;
        private System.Windows.Forms.Label lblCust0;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.ListView lvwBooking;
        private System.Windows.Forms.ColumnHeader colSupplierNo;
        private System.Windows.Forms.ColumnHeader colProductNo;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblOrderQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b14;
        private System.Windows.Forms.Button b115;
        private System.Windows.Forms.Button b16;
        private System.Windows.Forms.Button b17;
        private System.Windows.Forms.Button b18;
        private System.Windows.Forms.Button b19;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b24;
        private System.Windows.Forms.Button b25;
        private System.Windows.Forms.Button b26;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Label lblReturnMenu;
        private System.Windows.Forms.Label lblSearchSupplier;
        private System.Windows.Forms.Label lblDeleteSupplier;
        private System.Windows.Forms.Label lblEditSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
    }
}