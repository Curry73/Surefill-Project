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
    public partial class frmPayments : Form
    {
        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daSuppliers, daPayments, daCustomers, daPaymentDetails, daPaymentType, daOrders, daOrders2, daPaymentDet2;
        DataSet dsSurefill = new DataSet();
        SqlConnection conn;
        SqlCommand cmdSupplierDetails, cmdPaymentDetails, cmdPaymentType, cmdOrders, cmdPaymentDet2;
        SqlCommandBuilder cmdBSupplier, cmdBOrders, cmdBPayment, cmdBPaymentDetails, cmdBPaymentDet2;

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        DataRow drSupplier;

        String sqlNames, sqlSupplierDetails, sqlPayment, sqlPaymentDetails, sqlOrders, sqlOrders2, sqlPaymentType, sqlPaymentDet2;
        String connStr;
        public frmPayments()
        {
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            int no;

            lblBookingDate.Text = DateTime.Now.ToShortDateString();

            panel5.Enabled = false;

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

            sqlPayment = @"Select PaymentNo, OrderNo from PaymentDetails where OrderNo LIKE @OrderNo order by PaymentNo";
            cmdPaymentDetails = new SqlCommand(sqlPayment, conn);
            cmdPaymentDetails.Parameters.Add("@OrderNo", SqlDbType.VarChar);
            daPayments = new SqlDataAdapter(cmdPaymentDetails);
            daPayments.FillSchema(dsSurefill, SchemaType.Source, "Payments");

            sqlPaymentDet2 = @"select * from PaymentDetails";
            daPaymentDet2 = new SqlDataAdapter(sqlPaymentDet2, connStr);
            cmdBPaymentDet2 = new SqlCommandBuilder(daPaymentDet2);
            cmdPaymentDet2 = new SqlCommand(sqlPaymentDet2, conn);
            cmdPaymentDet2.Parameters.Add("@OrderNo", SqlDbType.Int);
            cmdPaymentDet2.Parameters.Add("@PaymentNo", SqlDbType.VarChar);

            //sqlOrders = @"Select * from Orders";
            //daOrders = new SqlDataAdapter(sqlOrders, conn);
            //cmdBOrders = new SqlCommandBuilder(daOrders);
            //daOrders.FillSchema(dsSurefill, SchemaType.Source, "Orders");
            //daOrders.Fill(dsSurefill, "Orders");

            sqlOrders = @"SELECT * from Orders where SupplierNo LIKE @SuppNo order by OrderNo";
            daOrders = new SqlDataAdapter(sqlOrders, conn);
            cmdOrders = new SqlCommand(sqlOrders, conn);
            cmdOrders.Parameters.Add("@SuppNo", SqlDbType.VarChar);
            daOrders = new SqlDataAdapter(cmdOrders);
            daOrders.FillSchema(dsSurefill, SchemaType.Source, "Orders");

            sqlOrders2 = @"select * from Orders";
            daOrders2 = new SqlDataAdapter(sqlOrders2, conn);
            cmdBOrders = new SqlCommandBuilder(daOrders2);
            daOrders2.FillSchema(dsSurefill, SchemaType.Source, "Order2");
            daOrders2.Fill(dsSurefill, "Order2");

            sqlPaymentDetails = @"Select * from PaymentDetails";
            daPaymentDetails = new SqlDataAdapter(sqlPaymentDetails, conn);
            cmdBPaymentDetails = new SqlCommandBuilder(daPaymentDetails);
            daPaymentDetails.FillSchema(dsSurefill, SchemaType.Source, "PaymentDetails");
            daPaymentDetails.Fill(dsSurefill, "PaymentDetails");

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
            dsSurefill.Tables["Orders"].Clear();


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

            lstOrders.SelectedIndex = -1;

            drSupplier = dsSurefill.Tables["Supplier"].Rows.Find(lstSupplier.SelectedValue);

            lblCust0.Text = drSupplier["SupplierNo"].ToString();
            lblCust1.Text = drSupplier["Name"].ToString();
            lblCust2.Text = drSupplier["Street"].ToString();
            lblCust3.Text = drSupplier["Town"].ToString();
            lblCust4.Text = drSupplier["County"].ToString();
            lblCust5.Text = drSupplier["Postcode"].ToString();
        }

        private void PopulateOrderListbox()
        {

            dsSurefill.Tables["Orders"].Clear();

            // get all dog details for listbox
            cmdOrders.Parameters["@SuppNo"].Value = lstSupplier.SelectedValue;

            daOrders.Fill(dsSurefill, "Orders");

            // fill listbox
            lstOrders.DataSource = dsSurefill.Tables["Orders"];
            lstOrders.DisplayMember = "OrderNo";
            lstOrders.ValueMember = "OrderNo";

            
        }

        private void lstOrder_Click(object sender, EventArgs e)
        {
            lstOrders.Enabled = true;


            if (lstOrders.Items.Count != 0)
            {
                DataRow drOrder = dsSurefill.Tables["Orders"].Rows.Find(lstOrders.SelectedValue);


                chkPaid.Checked = Convert.ToBoolean(drOrder["Paid"]);

                chkPaid.Enabled = true;

                PopulateProductListview();



            }
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            if (btnAddItem.Text == "Edit Item")
            {
                if(MessageBox.Show("Are you sure you want to edit this item?", "Edit Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                //DataRow drOrders = dsSurefill.Tables["Orders"].Rows.Find(lstOrders.SelectedValue);
                //chkPaid.Checked = Convert.ToBoolean(drOrders["Paid"]);
                //chkNotPaid.Checked = Convert.ToBoolean(drOrders["Paid"]);
                

                panel5.Enabled = true;
                btnAddItem.Text = "Save";

            }
            else
            {

                DataRow drOrder = dsSurefill.Tables["Order2"].Rows.Find(lstOrders.SelectedValue);

                drOrder.BeginEdit();
                drOrder["paid"] = chkPaid.Checked;
                drOrder.EndEdit();
                daOrders2.Update(dsSurefill, "Order2");

                dsSurefill.Tables["Orders"].Clear();
                daOrders.Fill(dsSurefill, "Orders");

                btnAddItem.Text = "Edit Item";

                panel5.Enabled = false;
            }


            //else
            //{
            //    DataRow drOrder = dsSurefill.Tables["Orders"].Rows.Find(lstOrders.SelectedValue);

            //    drOrder.BeginEdit();
            //    drOrder["paid"] = true;
            //    drOrder.EndEdit();
            //    daOrders.Update(dsSurefill, "Order2");

            //    btnAddItem.Text = "Add Item";
            //}


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete the payment?", "Delete Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            //DataRow drPayments = dsSurefill.Tables["PaymentDetails"].Rows.Find(lstPayment.SelectedValue);
            cmdPaymentDet2.Parameters["@PaymentNo"].Value = lstPayment.SelectedValue;
            cmdPaymentDet2.Parameters["@OrderNo"].Value = lstOrders.SelectedValue;

            daPaymentDet2.Fill(dsSurefill, "PaymentDetails");
            DataRow drPayments = dsSurefill.Tables["PaymentDetails"].Rows[0];
            drPayments.Delete();
            daPaymentDet2.Update(dsSurefill, "PaymentDetails");
            dsSurefill.Tables["Payments"].Clear();
            daPayments.Fill(dsSurefill, "Payments");
        }

        private void PopulateProductListview()
        {

            if (dsSurefill.Tables["Payments"] != null)
                dsSurefill.Tables["Payments"].Clear();
            // get all dog details for listbox
            cmdPaymentDetails.Parameters["@OrderNo"].Value = lstOrders.SelectedValue;


            daPayments.Fill(dsSurefill, "Payments");

            // fill listbox
            lstPayment.DataSource = dsSurefill.Tables["Payments"];
            lstPayment.DisplayMember = "PaymentNo";
            lstPayment.ValueMember = "PaymentNo";
        }

        private void lstProduct_Click(object sender, EventArgs e)
        {

            cmdPaymentDet2.Parameters["@PaymentNo"].Value = lstPayment.SelectedValue;
            cmdPaymentDet2.Parameters["@OrderNo"].Value = lstOrders.SelectedValue;

            daPaymentDet2.Fill(dsSurefill, "PaymentDetails");

        }
    }
        
}
