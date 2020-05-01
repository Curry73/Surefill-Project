using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SF
{
    public partial class frmEditDeleteProductOrder : Form
    {
        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daSuppliers, daOrder, daOrder2, daProductOrderDet, daProductOrderDet2, daProducts;

        DataSet dsSurefill = new DataSet();
        SqlConnection conn;

        SqlCommand cmdOrder, cmdProductOrder, cmdSupplierDetails, cmdProductDetails, cmdProductOrderDet2, cmdProducts;
        SqlCommandBuilder cmdBOrders2, cmdBProductOrderDet2;
        DataRow drSupplier;


        String sqlNames, sqlSupplierDetails, sqlOrder, sqlOrders2, sqlProductOrderDet, sqlProductOrderDet2;

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to edit the order?", "Edit Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if (btnEditOrder.Text == "Edit Order")
            {
                pnlEditBooking.Enabled = true;
                btnEditOrder.Text = "Save";

                //btnAddItem.Enabled = false;
                // btnEditItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnDeleteBooking.Enabled = false;
                btnEditItem.Enabled = false;
            }
            else
            {
                DataRow drOrder = dsSurefill.Tables["Order2"].Rows.Find(lstOrder.SelectedValue);

                drOrder.BeginEdit();
                drOrder["paid"] = true;
                drOrder.EndEdit();
                daOrder2.Update(dsSurefill, "Order2");

                btnDeleteItem.Enabled = true;
                btnDeleteBooking.Enabled = true;
                btnEditItem.Enabled = true;

                btnEditOrder.Text = "Edit Order";
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete the order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            DataRow drOrder = dsSurefill.Tables["Orders"].Rows.Find(lstOrder.SelectedValue);

            drOrder.Delete();
            daOrder2.Update(dsSurefill, "Orders");
            if (dsSurefill.Tables["ProductOrder"] != null)
                dsSurefill.Tables["ProductOrder"].Clear();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete the product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            //cmdProductOrderDet2.Parameters["@OrderNo"].Value = lstOrder.SelectedValue;
            //cmdProductOrderDet2.Parameters["@ProductNo"].Value = lstProduct.SelectedValue;
            //daProductOrderDet2.Fill(dsSurefill, "ProductDet2");
            object[] keys = { lstOrder.SelectedValue, lstProduct.SelectedValue };
            DataRow drProduct = dsSurefill.Tables["ProductDet2"].Rows.Find(keys);

            drProduct.Delete();
            daProductOrderDet2.Update(dsSurefill, "ProductDet2");

            if (dsSurefill.Tables["ProductOrder"] != null)
                dsSurefill.Tables["ProductOrder"].Clear();
            daProductOrderDet.Fill(dsSurefill, "ProductOrder");
        }

        String sqlProductDetails, connStr;

        public frmEditDeleteProductOrder()
        {
            InitializeComponent();
        }

        private void frmEditDeleteProductOrder_Load(object sender, EventArgs e)
        {
            int no;

            lblBookingDate.Text = DateTime.Now.ToShortDateString();

            for (int i = 0; i < 26; i++)
            {
                btns[i] = (Button)pnlButtons.Controls[i];
                btns[i].Text = "" + (char)(65 + i);
                btns[i].Enabled = false;
                btns[i].Click += new EventHandler(button1_Click);
            }

            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            // connStr = Properties.Resources.connectionStr;

            //get  names for alphabet butttons
            sqlNames = @"Select Name from Supplier order by Name";
            daNames = new SqlDataAdapter(sqlNames, connStr);
            daNames.Fill(dsSurefill, "Name");

            // enable relevant alpha buttons            
            foreach (DataRow dr in dsSurefill.Tables["Name"].Rows)
            {
                no = (int)dr["Name"].ToString()[0] - 65;
                btns[no].Enabled = true;
                btns[no].BackColor = Color.FromArgb(15, 117, 189);
                btns[no].ForeColor = Color.White;
            }

            // set up dataAdapter for customer details for the listbox
            sqlSupplierDetails = @"Select SupplierNo, Name, Street, Town, County, Postcode from Supplier where Name LIKE @Letter order by Name";
            conn = new SqlConnection(connStr);
            cmdSupplierDetails = new SqlCommand(sqlSupplierDetails, conn);
            cmdSupplierDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daSuppliers = new SqlDataAdapter(cmdSupplierDetails);
            daSuppliers.FillSchema(dsSurefill, SchemaType.Source, "Supplier");

            //set up dataAdapter for bookings for the listbox
            sqlOrder = @"SELECT * from Orders where SupplierNo LIKE @SuppNo AND Paid = 0 order by OrderNo";
            daOrder = new SqlDataAdapter(sqlOrder, conn);
            cmdOrder = new SqlCommand(sqlOrder, conn);
            cmdOrder.Parameters.Add("@SuppNo", SqlDbType.VarChar);
            daOrder = new SqlDataAdapter(cmdOrder);
            daOrder.FillSchema(dsSurefill, SchemaType.Source, "Orders");

            //Need a simple dataset with no parameter values to use with delete bookings
            sqlOrders2 = @"select * from Orders";
            daOrder2 = new SqlDataAdapter(sqlOrders2, conn);
            cmdBOrders2 = new SqlCommandBuilder(daOrder2);
            daOrder2.FillSchema(dsSurefill, SchemaType.Source, "Order2");
            daOrder2.Fill(dsSurefill, "Order2");

            //set up dataAdapter for booking details for the listview
            sqlProductOrderDet = @"select * from ProductOrder where OrderNo LIKE @OrderNo order by ProductNo";
            daProductOrderDet = new SqlDataAdapter(sqlProductOrderDet, conn);
            cmdProductDetails = new SqlCommand(sqlProductOrderDet, conn);
            cmdProductDetails.Parameters.Add("@OrderNo", SqlDbType.Int);
            daProductOrderDet = new SqlDataAdapter(cmdProductDetails);
            daProductOrderDet.FillSchema(dsSurefill, SchemaType.Source, "ProductDet");
            //daProductOrderDet.Fill(dsSurefill, "ProductDet");

            //Need a simple dataset with no parameter values to use with delete booking details
            sqlProductOrderDet2 = @"select * from ProductOrder";
            daProductOrderDet2 = new SqlDataAdapter(sqlProductOrderDet2, connStr);
            cmdBProductOrderDet2 = new SqlCommandBuilder(daProductOrderDet2);
            cmdProductOrderDet2 = new SqlCommand(sqlProductOrderDet2, conn);
            cmdProductOrderDet2.Parameters.Add("@OrderNo", SqlDbType.Int);
            cmdProductOrderDet2.Parameters.Add("@ProductNo", SqlDbType.VarChar);

           // daProductOrderDet2 = new SqlDataAdapter(cmdProductOrderDet2);
            daProductOrderDet2.FillSchema(dsSurefill, SchemaType.Source, "ProductDet2");
            //daProductOrderDet2.Fill(dsSurefill, "ProductDet2");

            sqlProductDetails = @"Select ProductNo, ProductDescription, ProductPrice, ProductQty, SupplierNo from Product where SupplierNo LIKE @SuppNo order by ProductNo";
            cmdProducts = new SqlCommand(sqlProductDetails, conn);
            cmdProducts.Parameters.Add("@SuppNo", SqlDbType.VarChar);
            daProducts = new SqlDataAdapter(cmdProducts);
            daProducts.FillSchema(dsSurefill, SchemaType.Source, "Product");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // get  customer details for listbox - use selected button letter for parameter 
            String str = b.Text;

            //empty dataset table customer
            dsSurefill.Tables["Supplier"].Clear();

            fillListboxSupplier(str);

            //clear any previously selected dogs/kennels by emptying the dataset tables
            dsSurefill.Tables["Product"].Clear();


            ClearSupplier();
        }

        private void fillListboxSupplier(String str)
        {

            // get all customer details for listbox   - use wildcard for parameter 
            cmdSupplierDetails.Parameters["@Letter"].Value = str + "%";
            daSuppliers.Fill(dsSurefill, "Supplier");

            // fill listbox
            lstSupplier.DataSource = dsSurefill.Tables["Supplier"];
            lstSupplier.DisplayMember = "name";
            lstSupplier.ValueMember = "SupplierNo";
        }

        private void ClearSupplier()
        {
            lstSupplier.SelectedIndex = -1;

            lblCust0.Text = "";
            lblCust1.Text = "";
            lblCust2.Text = "";
            lblCust3.Text = "";
            lblCust4.Text = "";
            lblCust5.Text = "";
        }

        private void lstSupplier_Click(object sender, EventArgs e)
        {
            PopulateOrderListbox();

            lstOrder.SelectedIndex = -1;

            drSupplier = dsSurefill.Tables["Supplier"].Rows.Find(lstSupplier.SelectedValue);

            if (drSupplier == null)
                return;

            lblCust0.Text = drSupplier["SupplierNo"].ToString();
            lblCust1.Text = drSupplier["Name"].ToString();
            lblCust2.Text = drSupplier["Street"].ToString();
            lblCust3.Text = drSupplier["Town"].ToString();
            lblCust4.Text = drSupplier["County"].ToString();
            lblCust5.Text = drSupplier["Postcode"].ToString();

            

        }

        private void lstOrder_Click(object sender, EventArgs e)
        {
            lvwOrder.Enabled = true;

            lvwOrder.Items.Clear();

            if (lstOrder.Items.Count != 0)
            {

                DataRow drOrder = dsSurefill.Tables["Orders"].Rows.Find(lstOrder.SelectedValue);

                if (drOrder == null)
                    return;


                lblBookingDate.Text = (Convert.ToDateTime(drOrder["OrderDate"].ToString())).ToShortDateString();
                chkPaid.Checked = Convert.ToBoolean(drOrder["Paid"]);



                //if (Convert.ToDateTime(lblBookingDate.Text).Date == DateTime.Now.Date)
                //{
                pnlAddEdit.Enabled = true;
                    chkPaid.Enabled = true;
                    txtQTY.Enabled = true;
                    lvwOrder.Enabled = true;
                //}

                //lstProduct.DataSource = null;
                //lstProduct.Items.Clear();

                PopulateProductListview();

                lstProduct.SelectedIndex = -1;

                ////empty dataset table Kennel
                //dsInTheDogHouse.Tables["BookingDet"].Clear();

                //// get all kennel details for listbox
                //cmdBookingDet.Parameters["@BookingNo"].Value = lstBooking.SelectedValue;

                //daBookingDet.Fill(dsInTheDogHouse, "BookingDet");

                //// fill listview
                //foreach (DataRow dr in dsInTheDogHouse.Tables["BookingDet"].Rows)
                //{
                //    if (dr["BookingNo"].ToString() == lstBooking.Text)
                //    {
                //        ListViewItem item = new ListViewItem(dr["DogNo"].ToString());
                //        item.SubItems.Add(dr["KennelNo"].ToString());
                //        lvwBooking.Items.Add(item);
                //    }
                //}
            }
        }

        private void lstProduct_Click(object sender, EventArgs e)
        {
           
            cmdProductOrderDet2.Parameters["@ProductNo"].Value = lstProduct.SelectedValue;
            cmdProductOrderDet2.Parameters["@OrderNo"].Value = lstOrder.SelectedValue;

            daProductOrderDet2.Fill(dsSurefill, "ProductDet2");

            DataRow drProductOrder = dsSurefill.Tables["ProductOrder"].Rows[0];

            txtQTY.Text = drProductOrder["OrderQty"].ToString();

            pnlEditBooking.Enabled = true;
        }

        private void PopulateOrderListbox()
        {
            if (lstSupplier.SelectedValue == null)
            {
                return;
            }
            dsSurefill.Tables["Orders"].Clear();

            // get all dog details for listbox
            cmdOrder.Parameters["@SuppNo"].Value = lstSupplier.SelectedValue;

            daOrder.Fill(dsSurefill, "Orders");

            // fill listbox
            lstOrder.DataSource = dsSurefill.Tables["Orders"];
            lstOrder.DisplayMember = "OrderNo";
            lstOrder.ValueMember = "OrderNo";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            pnlEditBooking.Enabled = true;
            if (btnEditItem.Text == "Edit Item")
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure you want to edit the item?", "Edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                pnlEditBooking.Enabled = true;
                btnEditItem.Text = "Save";

                //btnAddItem.Enabled = false;
               // btnEditItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnDeleteBooking.Enabled = false;
            } else
            {
                object[] keys = { lstOrder.SelectedValue, lstProduct.SelectedValue };
                DataRow drProductOrder = dsSurefill.Tables["ProductDet2"].Rows.Find(keys);
                drProductOrder.BeginEdit();
                drProductOrder["OrderQty"] = Convert.ToInt32(txtQTY.Text);
                drProductOrder.EndEdit();
                daProductOrderDet2.Update(dsSurefill, "ProductDet2");

                btnDeleteItem.Enabled = true;
                btnDeleteBooking.Enabled = true;

                btnEditItem.Text = "Edit Item";
            }
            //else
            //{
            //    DataRow drBooking = dsSurefill.Tables["Order2"].Rows.Find(Convert.ToInt32(lstOrder.Text));
            //    DataRow drProductOrder = dsSurefill.Tables["ProductOrder"].Rows.Find(lstOrder.SelectedValue);

            //    drBooking.BeginEdit();

            //    drBooking["Paid"] = Convert.ToDateTime(dtpStartDate.Value);
            //    drBooking["NoDays"] = Convert.ToInt32(cmbNoOfDays.Text);

            //    drBooking.EndEdit();
            //    daBooking2.Update(dsInTheDogHouse, "Booking2");

            //    pnlEditBooking.Enabled = false;
            //    btnEditBooking.Text = "Edit Booking";

            //    btnAddItem.Enabled = true;
            //    btnEditItem.Enabled = true;
            //    btnDeleteItem.Enabled = true;
            //    btnDeleteBooking.Enabled = true;
            //}

        }

        private void PopulateProductListview()
        {
            if(dsSurefill.Tables["ProductOrder"] != null)
                dsSurefill.Tables["ProductOrder"].Clear();

            // get all dog details for listbox
            cmdProductDetails.Parameters["@OrderNo"].Value = lstOrder.SelectedValue;
            

            daProductOrderDet.Fill(dsSurefill, "ProductOrder");

            // fill listbox
            lstProduct.DataSource = dsSurefill.Tables["ProductOrder"];
            lstProduct.DisplayMember = "ProductNo";
            lstProduct.ValueMember = "ProductNo";
        }
    }
}