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
    public partial class frmProductOrder : Form
    {
        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daSuppliers, daProducts, daCustomers, daProductOrder, daOrders;
        DataSet dsSurefill = new DataSet();
        SqlConnection conn;
        SqlCommand cmdSupplierDetails, cmdProductDetails, cmdOrders;
        SqlCommandBuilder cmdBSupplier, cmdBOrders, cmdBProducts, cmdBProductOrders;


        DataRow drSupplier;

        String sqlNames, sqlSupplierDetails, sqlProduct, sqlProductDetails, sqlOrders, sqlProductOrder;
        String connStr;

        public frmProductOrder()
        {
            InitializeComponent();
        }

        private void FrmProductOrder_Load(object sender, EventArgs e)
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
                btns[no].BackColor = Color.Black;
                btns[no].ForeColor = Color.White;
            }

            // set up dataAdapter for customer details for the listbox
            sqlSupplierDetails = @"Select SupplierNo, Name, Street, Town, County, Postcode from Supplier where Name LIKE @Letter order by Name";
            conn = new SqlConnection(connStr);
            cmdSupplierDetails = new SqlCommand(sqlSupplierDetails, conn);
            cmdSupplierDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daSuppliers = new SqlDataAdapter(cmdSupplierDetails);
            daSuppliers.FillSchema(dsSurefill, SchemaType.Source, "Supplier");

            sqlProduct = @"Select ProductNo, ProductDescription, ProductPrice, ProductQty, SupplierNo from Product where SupplierNo LIKE @SuppNo order by ProductNo";
            cmdProductDetails = new SqlCommand(sqlProduct, conn);
            cmdProductDetails.Parameters.Add("@SuppNo", SqlDbType.VarChar);
            daProducts = new SqlDataAdapter(cmdProductDetails);
            daProducts.FillSchema(dsSurefill, SchemaType.Source, "Product");

            sqlOrders = @"Select * from Orders";
            daOrders = new SqlDataAdapter(sqlOrders, conn);
            cmdBOrders = new SqlCommandBuilder(daOrders);
            daOrders.FillSchema(dsSurefill, SchemaType.Source, "Orders");
            daOrders.Fill(dsSurefill, "Orders");

            sqlProductOrder = @"Select * from ProductOrder";
            daProductOrder = new SqlDataAdapter(sqlProductOrder, conn);
            cmdBProductOrders = new SqlCommandBuilder(daProductOrder);
            daProductOrder.FillSchema(dsSurefill, SchemaType.Source, "ProductOrder");
            daProductOrder.Fill(dsSurefill, "ProductOrder");

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


        private void lstSupplier_Click(object sender, EventArgs e)
        {

            dsSurefill.Tables["Product"].Clear();

            // get all dog details for listbox
            cmdProductDetails.Parameters["@SuppNo"].Value = lstSupplier.SelectedValue;

            daProducts.Fill(dsSurefill, "Product");

            // fill listbox
            lstProduct.DataSource = dsSurefill.Tables["Product"];
            lstProduct.DisplayMember = "Name";
            lstProduct.ValueMember = "ProductNo";

            lstProduct.SelectedIndex = -1;


            drSupplier = dsSurefill.Tables["Supplier"].Rows.Find(lstSupplier.SelectedValue);


            lblCust0.Text = drSupplier["SupplierNo"].ToString();
            lblCust1.Text = drSupplier["Name"].ToString();
            lblCust2.Text = drSupplier["Street"].ToString();
            lblCust3.Text = drSupplier["Town"].ToString();
            lblCust4.Text = drSupplier["County"].ToString();
            lblCust5.Text = drSupplier["Postcode"].ToString();
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

        private void btAddItem_Click(object sender, EventArgs e)
        {
            bool exits = false;
            bool ok = true;

            if (lstSupplier.SelectedIndex == -1)
                MessageBox.Show("Please select a Supplier", "Supplier");
            else if (lstProduct.SelectedIndex == -1)
                MessageBox.Show("Please select a Product", "Product");

            foreach (ListViewItem item in lvwBooking.Items)
            {
                if (item.SubItems[1].Text == lstProduct.Text)
                {
                    MessageBox.Show("Product already selected for this order.", "Order");
                    exits = true;
                    break;
                }
            }
            if (!exits)
            {
                // Could check product qty
                if (txtOrderQty.Text == "" || txtOrderQty.Text == "0")
                {
                    MessageBox.Show("Please select a quantity.", "ProductOrder");
                    txtOrderQty.Focus();
                }
                else
                {

                    if (ok)
                    {
                        if (lstSupplier.SelectedIndex == -1)
                            MessageBox.Show("Please select a Supplier", "Supplier");
                        else if (lstProduct.SelectedIndex == -1)
                            MessageBox.Show("Please select a Product", "Product");
                        else
                        {
                            ListViewItem item = new ListViewItem(lstSupplier.SelectedValue.ToString());
                            item.SubItems.Add(lstProduct.SelectedValue.ToString());
                            item.SubItems.Add(txtOrderQty.Text);
                            lvwBooking.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow drOrder, drProductOrder;
            DateTime orderDateTime = DateTime.Now;

            int orderNo;

            int noRows = dsSurefill.Tables["Orders"].Rows.Count;

            if (lstSupplier.SelectedIndex == -1)
                MessageBox.Show("Please select a Supplier", "Supplier");
            else if (lstProduct.SelectedIndex == -1)
                MessageBox.Show("Please select a Product", "Product");

            //if (noRows == 0)
            //    orderNo = 1;
            //else
            //{ 
            drOrder = dsSurefill.Tables["Orders"].Rows[noRows - 1];
            orderNo = (int.Parse(drOrder["OrderNo"].ToString()) + 1);
            //}

            drOrder = dsSurefill.Tables["Orders"].NewRow();

            drOrder["OrderNo"] = orderNo;
            drOrder["SupplierNo"] = lstSupplier.SelectedValue.ToString();
            drOrder["Paid"] = 0;
            drOrder["OrderDate"] = orderDateTime;

            dsSurefill.Tables["Orders"].Rows.Add(drOrder);
            daOrders.Update(dsSurefill, "Orders");

            foreach (ListViewItem item in lvwBooking.Items)
            {
                drProductOrder = dsSurefill.Tables["ProductOrder"].NewRow();
                drProductOrder["OrderNo"] = drOrder["OrderNo"];
                drProductOrder["ProductNo"] = item.SubItems[1].Text;
                drProductOrder["OrderQty"] = int.Parse(item.SubItems[2].Text);
                dsSurefill.Tables["ProductOrder"].Rows.Add(drProductOrder);
                daProductOrder.Update(dsSurefill, "ProductOrder");
            }

            MessageBox.Show("Order No: " + drOrder["OrderNo"].ToString() + " added to system");
        }
    }
    }
