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
    public partial class frmCustomer : Form
    {

        SqlDataAdapter daCustomer, daCustDetails, daCustDetails2;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        SqlCommand cmdCustomerDetails, cmdCustomerDetails2;
        SqlConnection conn;
        DataRow drCustomer;
        String connStr, sqlCustomer, sqlCustDetails, sqlCustDetails2;
        int selectedTab = 0;
        bool custSelected = false;
        string custNoSelected = "";

        public frmCustomer()
        {
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            conn = new SqlConnection(connStr);

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsSurefill, SchemaType.Source,
                "Customer");
            daCustomer.Fill(dsSurefill, "Customer");
            dgvCustomers.DataSource = dsSurefill.Tables["Customer"];
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            sqlCustDetails = @"Select * From Customer where Forename LIKE (@Letter + '%') order by CustomerNo";
            cmdCustomerDetails = new SqlCommand(sqlCustDetails, conn);
            cmdCustomerDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daCustDetails = new SqlDataAdapter(cmdCustomerDetails);
            daCustDetails.FillSchema(dsSurefill, SchemaType.Source, "CustDets");

            sqlCustDetails2 = @"Select * From Customer where County LIKE (@Letter + '%') order by CustomerNo";
            cmdCustomerDetails2 = new SqlCommand(sqlCustDetails2, conn);
            cmdCustomerDetails2.Parameters.Add("@Letter", SqlDbType.VarChar);
            daCustDetails2 = new SqlDataAdapter(cmdCustomerDetails2);
            daCustDetails2.FillSchema(dsSurefill, SchemaType.Source, "CustDets");

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
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
            pnlSearch.Visible = false;
        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlSearch.Visible = false;
            pnlEdit.Visible = false;
            pnlDelete.Visible = false;
        }

        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            getNumber(dsSurefill.Tables["Customer"].Rows.Count);
            pnlAdd.Visible = true;
            pnlSearch.Visible = false;
            pnlEdit.Visible = false;
            pnlDelete.Visible = false;
        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.DimGray;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            custNoSelected = (dgvCustomers.SelectedRows[0].Cells[0].Value).ToString();

            pnlEdit.Visible = true;
            pnlDelete.Visible = false;
            pnlAdd.Visible = false;
            pnlSearch.Visible = false;

            if (custNoSelected.Equals(""))
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                lblEditActaulCustNo.Text = custNoSelected.ToString();
                drCustomer = dsSurefill.Tables["Customer"].Rows.Find(lblEditActaulCustNo.Text);

                lblEditActaulCustNo.Text = drCustomer["CustomerNo"].ToString();
                txtEditCustForename.Text = drCustomer["Forename"].ToString();
                txtEditCustSurname.Text = drCustomer["Surname"].ToString();
                txtEditCustStreet.Text = drCustomer["Street"].ToString();
                txtEditCustTown.Text = drCustomer["Town"].ToString();
                txtEditCustCounty.Text = drCustomer["County"].ToString();
                txtEditCustPostcode.Text = drCustomer["Postcode"].ToString();
                txtEditCustTelephoneNo.Text = drCustomer["TelephoneNo"].ToString();
                txtEditCustEmail.Text = drCustomer["Email"].ToString();

            }
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
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            pnlSearch.Visible = false;
        }

        private void lblDeleteCustomer_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = true;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            pnlSearch.Visible = false;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
            pnlEdit.Visible = false;
        }

        private void lblSearchCustomer_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
            pnlEdit.Visible = false;

        }

        private void btnConfirmAddCust_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                myCustomer.CustomerNo = lblAddActualCustomerNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(lblAddActualCustomerNo, MyEx.toString());

            }

            try
            {
                myCustomer.Forename = txtAddCustForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustForename, MyEx.toString());
            }

            try
            {
                myCustomer.Surname = txtAddCustSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustSurname, MyEx.toString());
            }

            try
            {
                myCustomer.Street = txtAddCustStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustStreet, MyEx.toString());
            }

            try
            {
                myCustomer.Town = txtAddCustTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustTown, MyEx.toString());
            }

            try
            {
                myCustomer.County = txtAddCustCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustCounty, MyEx.toString());
            }

            try
            {
                myCustomer.Postcode = txtAddCustPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustPostcode, MyEx.toString());
            }

            try
            {
                myCustomer.TelephoneNo = txtAddCustTelephoneNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustTelephoneNo, MyEx.toString());
            }
            try
            {
                myCustomer.Email = txtAddCustEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddCustEmail, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drCustomer = dsSurefill.Tables["Customer"].NewRow();

                    drCustomer["CustomerNo"] = myCustomer.CustomerNo;
                    drCustomer["Forename"] = myCustomer.Forename;
                    drCustomer["Surname"] = myCustomer.Surname;
                    drCustomer["Street"] = myCustomer.Street;
                    drCustomer["Town"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["Postcode"] = myCustomer.Postcode;
                    drCustomer["TelephoneNo"] = myCustomer.TelephoneNo;
                    drCustomer["Email"] = myCustomer.Email;


                    dsSurefill.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsSurefill, "Customer");

                    MessageBox.Show("Customer Added");
                   

                    if (MessageBox.Show("Do you want to add another customer?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsSurefill.Tables["Customer"].Rows.Count);
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        void clearAddForm()
        {
            txtAddCustForename.Clear();
            txtAddCustSurname.Clear();
            txtAddCustStreet.Clear();
            txtAddCustTown.Clear();
            txtEditCustCounty.Clear();
            txtAddCustPostcode.Clear();
            txtAddCustTelephoneNo.Clear();
        }

        private void getNumber(int noRows)
        {
            drCustomer = dsSurefill.Tables["Customer"].Rows[noRows - 1];


            lblAddActualCustomerNo.Text = ("C" + (int.Parse(drCustomer["CustomerNo"].ToString().Substring(1,5)) + 1).ToString());
        }

        private void btnConfirmEditCust_Click(object sender, EventArgs e)
        {
            if (btnConfirmEditCust.Text == "Edit")
            {
                txtAddCustForename.Enabled = true;
                txtEditCustSurname.Enabled = true;
                txtEditCustStreet.Enabled = true;
                txtEditCustTown.Enabled = true;
                txtEditCustCounty.Enabled = true;
                txtEditCustPostcode.Enabled = true;
                txtEditCustTelephoneNo.Enabled = true;
                txtEditCustEmail.Enabled = true;

                btnConfirmEditCust.Text = "Save";

            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errorProvider1.Clear();

                try
                {
                    myCustomer.CustomerNo = lblEditActaulCustNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(lblEditActaulCustNo, MyEx.toString());

                }

                try
                {
                    myCustomer.Forename = txtEditCustForename.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustForename, MyEx.toString());
                }

                try
                {
                    myCustomer.Surname = txtEditCustSurname.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustSurname, MyEx.toString());
                }

                try
                {
                    myCustomer.Street = txtEditCustStreet.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustStreet, MyEx.toString());
                }

                try
                {
                    myCustomer.Town = txtEditCustTown.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustTown, MyEx.toString());
                }

                try
                {
                    myCustomer.County = txtEditCustCounty.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustCounty, MyEx.toString());
                }

                try
                {
                    myCustomer.Postcode = txtEditCustPostcode.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustPostcode, MyEx.toString());
                }

                try
                {
                    myCustomer.TelephoneNo = txtEditCustTelephoneNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustTelephoneNo, MyEx.toString());
                }
                try
                {
                    myCustomer.Email = txtEditCustEmail.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditCustEmail, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();


                        drCustomer["CustomerNo"] = myCustomer.CustomerNo;
                        drCustomer["Forename"] = myCustomer.Forename;
                        drCustomer["Surname"] = myCustomer.Surname;
                        drCustomer["Street"] = myCustomer.Street;
                        drCustomer["Town"] = myCustomer.Town;
                        drCustomer["County"] = myCustomer.County;
                        drCustomer["Postcode"] = myCustomer.Postcode;
                        drCustomer["TelephoneNo"] = myCustomer.TelephoneNo;
                        drCustomer["Email"] = myCustomer.Email;

                        drCustomer.EndEdit();
                        daCustomer.Update(dsSurefill, "Customer");

                        MessageBox.Show("Customer details updated", "Customer");

                        txtAddCustForename.Enabled = false;
                        txtEditCustSurname.Enabled = false;
                        txtEditCustStreet.Enabled = false;
                        txtEditCustTown.Enabled = false;
                        txtEditCustCounty.Enabled = false;
                        txtEditCustPostcode.Enabled = false;
                        txtEditCustTelephoneNo.Enabled = false;
                        txtEditCustEmail.Enabled = false;

                        btnConfirmEditCust.Text = "Edit";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmDeleteCust_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count ==0)
            {
                MessageBox.Show("Please select a customer from the list", "Select Customer");
            }
            else
            {
                drCustomer = dsSurefill.Tables["Customer"].Rows.Find(dgvCustomers.SelectedRows[0].Cells[0].Value);
                string tempName = drCustomer["Forename"].ToString() + "" + drCustomer["Surname"].ToString() + "\'s";

                if(MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Customer", MessageBoxButtons.YesNo)==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(dsSurefill, "Customer");
                }
            }
        }

        private void btnCancelAddCust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Customer No: " + lblAddActualCustomerNo.Text + "?", "Add Customer", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes);
            {
                pnlAdd.Visible = false;
            }
        }

        private void btnCancelEditCust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Customer No: " + lblEditActaulCustNo.Text + "?", "Edit Customer", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes);
            {
                pnlEdit.Visible = false;
            }
        }

        private void btnDeleteCustCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the deletion of Customer No: " + lblEditActaulCustNo.Text + "?", "Delete Customer", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
            {
                pnlDelete.Visible = false;
            }
        }

        private void lblSearchCustText_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelCustSearch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel search?", "Search", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
            {
                pnlSearch.Visible = false;
            }
        }

        private void btnSearchCustSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCustForename_TextChanged(object sender, EventArgs e)
        {
            dsSurefill.Tables["CustDets"].Clear();
            cmdCustomerDetails.Parameters["@Letter"].Value = txtSearchCustForename.Text;
            daCustDetails.Fill(dsSurefill, "CustDets");
            dgvCustomers.DataSource = dsSurefill.Tables["CustDets"];
        }

        private void txtSearchCustCounty_TextChanged(object sender, EventArgs e)
        {
            dsSurefill.Tables["CustDets"].Clear();
            cmdCustomerDetails2.Parameters["@Letter"].Value = txtSearchCustCounty.Text;
            daCustDetails2.Fill(dsSurefill, "CustDets");
            dgvCustomers.DataSource = dsSurefill.Tables["CustDets"];
        }

        private void btnSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblSearchCustomer.ForeColor = Color.DimGray;
        }
    }
}
