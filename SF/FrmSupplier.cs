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
    public partial class FrmSupplier : Form
    {

        SqlDataAdapter daSupplier;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        int selectedTab = 0;
        bool suppSelected = false;
        int suppNoSelected = 0;

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = Surefill;
Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsSurefill, SchemaType.Source,
                "Supplier");
            daSupplier.Fill(dsSurefill, "Supplier");
            dgvSuppliers.DataSource = dsSurefill.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //tabCustomer.SelectedIndex = 1;
            //tabCustomer.SelectedIndex = 0;
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

        private void lblEditSupplier_Click(object sender, EventArgs e)
        {
            pnlEditSupplier.Visible = true;
        }

        private void lblAddSupplier_Click(object sender, EventArgs e)
        {
            pnlAddSupplier.Visible = true;
        }

        private void btnAddSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblAddSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            pnlAddSupplier.Visible = true;
        }

        private void btnAddSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblAddSupplier.ForeColor = Color.DimGray;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            pnlEditSupplier.Visible = true;
        }

        private void btnEditSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblEditSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnEditSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblEditSupplier.ForeColor = Color.DimGray;
        }

        private void btnDeleteSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnDeleteSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteSupplier.ForeColor = Color.DimGray;
        }

        private void btnSearchSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblADD_Click(object sender, EventArgs e)
        {

        }



        //private void btnDeleteCustomer_Click(object sender, EventArgs e)
        //{
        //    pnlDelete.Visible = true;
        //}

        //private void lblDeleteCustomer_Click(object sender, EventArgs e)
        //{
        //    pnlDelete.Visible = true;
        //}

        //private void btnSearchCustomer_Click(object sender, EventArgs e)
        //{
        //    pnlSearch.Visible = true;
        //}

        //private void lblSearchCustomer_Click(object sender, EventArgs e)
        //{
        //    pnlSearch.Visible = true;

        //}

        private void btnConfirmAddSupp_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                mySupplier.SupplierNo = lblAddActualSupplierNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(lblAddActualSupplierNo, MyEx.toString());

            }

            try
            {
                mySupplier.Name = txtAddSupplierName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierName, MyEx.toString());
            }

            try
            {
                mySupplier.Street = txtAddSupplierStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierStreet, MyEx.toString());
            }

            try
            {
                mySupplier.Town = txtAddSupplierTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierTown, MyEx.toString());
            }

            try
            {
                mySupplier.County = txtAddSupplierCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierCounty, MyEx.toString());
            }

            try
            {
                mySupplier.Postcode = txtAddSupplierPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierPostcode, MyEx.toString());
            }

            try
            {
                mySupplier.Email = txtAddSupplierEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierEmail, MyEx.toString());
            }

            try
            {
                mySupplier.TelephoneNo = txtAddSupplierTelephoneNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierTelephoneNo, MyEx.toString());
            }
            //try
            //{
            //    myCustomer.Email = txtAddCustEmail.Text.Trim();
            //}
            //catch (MyException MyEx)
            //{
            //    ok = false;
            //    errorProvider1.SetError(txtAddCustEmail, MyEx.toString());
            //}

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
            lblActualCustomerNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
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

        private void btnSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.DimGray;
        }
    }
}