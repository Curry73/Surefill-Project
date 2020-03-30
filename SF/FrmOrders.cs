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
    public partial class FrmOrders : Form
    {
        SqlDataAdapter daOrders, daOrderDetails, daProductOrder;
        DataSet dsSurefill = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails, cmdOrderDetails, cmdKennelDetails;
        String sqlOrderDetails;
        SqlCommandBuilder cmdOrders, cmdBBooking, cmdBBookingDet, cmdBBookedKennels;
        DataRow drOrder;

        private void cmbOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderNo = int.Parse(cmbOrderNo.Text);

            drOrder = dsSurefill.Tables["Orders"].Rows.Find(orderNo);


            //lblCust0.Text = drCustomer["CustomerNo"].ToString();
            //lblCust1.Text = title + " " + drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();
            lblActualOrderSupplierNo.Text = drOrder["SupplierNo"].ToString();
            DateTime orderDate = DateTime.Parse(drOrder["OrderDate"].ToString().Trim());
            dtpOrderDate.Value = orderDate;

            populateOrderDetails();
        }

        String connStr, sqlOrders, sqlCustDetails, sqlCustDetails2;

        public FrmOrders()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";

            conn = new SqlConnection(connStr);

            sqlOrders = @"select * from Orders";
            daOrders = new SqlDataAdapter(sqlOrders, connStr);
            cmdOrders = new SqlCommandBuilder(daOrders);
            daOrders.FillSchema(dsSurefill, SchemaType.Source,
                "Orders");
            daOrders.Fill(dsSurefill, "Orders");

            populateOrders();

            sqlOrderDetails = @"Select po.OrderNo, po.OrderQty, p.ProductNo, p.ProductPrice
                                From ProductOrder po
                                join Product p on po.ProductNo = p.ProductNo
                                where po.OrderNo = @OrderNo";
            cmdOrderDetails = new SqlCommand(sqlOrderDetails, conn);
            cmdOrderDetails.Parameters.Add("@OrderNo", SqlDbType.Int);
            daOrderDetails = new SqlDataAdapter(cmdOrderDetails);
            daOrderDetails.FillSchema(dsSurefill, SchemaType.Source, "ProductOrder");

            

        }

        private void populateOrders()
        {
            int noRows = dsSurefill.Tables["Orders"].Rows.Count;

            cmbOrderNo.Items.Clear();

            foreach (DataRow dr in dsSurefill.Tables["Orders"].Rows)
            {
                cmbOrderNo.Items.Add(dr["OrderNo"].ToString());
            }
        }

        private void populateOrderDetails()
        {
            cmdOrderDetails.Parameters["@OrderNo"].Value = int.Parse(cmbOrderNo.Text);

            daOrderDetails.Fill(dsSurefill, "ProductOrder");

            foreach (DataRow dr in dsSurefill.Tables["ProductOrder"].Rows)
            {
                if (dr["OrderNo"].ToString() == cmbOrderNo.Text)
                {
                    ListViewItem item = new ListViewItem(dr["OrderQty"].ToString());
                    item.SubItems.Add(dr["ProductNo"].ToString());
                    item.SubItems.Add(dr["ProductPrice"].ToString());
                    //item.SubItems.Add(dr["ProductPrice"].ToString());
                    lvwOrderDetails.Items.Add(item);
                    
                }
            }
        }
    }
}
