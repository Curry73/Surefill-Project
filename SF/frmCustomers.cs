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
    public partial class frmCustomers : Form
    {

        SqlDataAdapter daCustomer;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        public frmCustomers()
        {
            InitializeComponent();
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = Surefill; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsSurefill, SchemaType.Source,
                "Customer");
            daCustomer.Fill(dsSurefill, "Customer");
            dgvCustomers.DataSource = dsSurefill.Tables["Customer"];
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //tabCustomer.SelectedIndex = 1;
            //tabCustomer.SelectedIndex = 0;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            pnlDelete.Visible = false;
            pnlSearch.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrBanner_Tick(object sender, EventArgs e)
        {
 
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void lblEditCustomer_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.DimGray;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
        }

        private void btnEditCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblEditCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnEditCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblEditCustomer.ForeColor = Color.DimGray;
        }

        private void btnDeleteCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnDeleteCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteCustomer.ForeColor = Color.DimGray;
        }

        private void btnSearchCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblSearchCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblADD_Click(object sender, EventArgs e)
        {

        }



        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = true;
        }

        private void lblDeleteCustomer_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = true;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
        }

        private void lblSearchCustomer_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            
        }

        private void btnConfirmAddCust_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            //ErrorProvider.Clear();

            try
            {
                myCustomer.CustomerNo = lblActualCustomerNo.Text.Trim();                  
            }
            catch (MyException MyEx)
            {
                ok = false;
                //ErrorProvider.SetError(lblActualCustomerNo, MyEx.toString());

            }

            try
            {
                myCustomer.Forename = txtAddCustForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                ErrorProvider.SetError(txtAddCustForename, MyEx.toString());
            }
            }

        private void btnSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblSearchCustomer.ForeColor = Color.DimGray;
        }
    }
}
