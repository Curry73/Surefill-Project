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
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";

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
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            //pnlDelete.Visible = false;
            //pnlSearch.Visible = false;
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

        private void btnEditSupplierClick(object sender, EventArgs e)
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

            try
            {
                if (ok)
                {
                    drSupplier = dsSurefill.Tables["Supplier"].NewRow();

                    drSupplier["SupplierNo"] = mySupplier.SupplierNo;
                    drSupplier["Name"] = mySupplier.Name;
                    drSupplier["Street"] = mySupplier.Street;
                    drSupplier["Town"] = mySupplier.Town;
                    drSupplier["County"] = mySupplier.County;
                    drSupplier["Postcode"] = mySupplier.Postcode;
                    drSupplier["Email"] = mySupplier.Email;
                    drSupplier["TelephoneNo"] = mySupplier.TelephoneNo;



                    dsSurefill.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsSurefill, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you want to add another Supplier?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsSurefill.Tables["Supplier"].Rows.Count);
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
            txtAddSupplierName.Clear();
            txtAddSupplierStreet.Clear();
            txtAddSupplierTown.Clear();
            txtEditSupplierCounty.Clear();
            txtAddSupplierPostcode.Clear();
            txtAddSupplierEmail.Clear();
            txtAddSupplierTelephoneNo.Clear();
        }

        private void getNumber(int noRows)
        {
            drSupplier = dsSurefill.Tables["Supplier"].Rows[noRows - 1];
            lblAddActualSupplierNo.Text = (int.Parse(drSupplier["SupplierNo"].ToString()) + 1).ToString();
        }

        private void btnConfirmEditSupplier_Click(object sender, EventArgs e)
        {
            if (btnConfirmEditSupplier.Text == "Edit")
            {
                txtAddSupplierName.Enabled = true;
                txtEditSupplierStreet.Enabled = true;
                txtEditSupplierTown.Enabled = true;
                txtEditSupplierCounty.Enabled = true;
                txtEditSupplierPostcode.Enabled = true;
                txtEditSupplierEmail.Enabled = true;
                txtEditSupplierTelephoneNo.Enabled = true;

                btnConfirmEditSupplier.Text = "Save";

            }
            else
            {
                MySupplier mySupplier = new MySupplier();
                bool ok = true;
                errorProvider1.Clear();

                try
                {
                    mySupplier.SupplierNo = lblEditActualSupplierNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(lblEditActualSupplierNo, MyEx.toString());

                }

                try
                {
                    mySupplier.Name = txtEditSupplierName.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierName, MyEx.toString());
                }

                try
                {
                    mySupplier.Street = txtEditSupplierStreet.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierStreet, MyEx.toString());
                }

                try
                {
                    mySupplier.Town = txtEditSupplierTown.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierTown, MyEx.toString());
                }

                try
                {
                    mySupplier.County = txtEditSupplierCounty.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierCounty, MyEx.toString());
                }

                try
                {
                    mySupplier.Postcode = txtEditSupplierPostcode.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierPostcode, MyEx.toString());
                }

                try
                {
                    mySupplier.Email = txtEditSupplierEmail.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierEmail, MyEx.toString());
                }

                try
                {
                    mySupplier.TelephoneNo = txtEditSupplierTelephoneNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierTelephoneNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drSupplier.BeginEdit();


                        drSupplier["SupplierNo"] = mySupplier.SupplierNo;
                        drSupplier["Name"] = mySupplier.Name;
                        drSupplier["Street"] = mySupplier.Street;
                        drSupplier["Town"] = mySupplier.Town;
                        drSupplier["County"] = mySupplier.County;
                        drSupplier["Postcode"] = mySupplier.Postcode;
                        drSupplier["Email"] = mySupplier.Email;
                        drSupplier["TelephoneNo"] = mySupplier.TelephoneNo;

                        drSupplier.EndEdit();
                        daSupplier.Update(dsSurefill, "Supplier");

                        MessageBox.Show("Supplier details updated", "Supplier");

                        txtAddSupplierName.Enabled = false;
                        txtEditSupplierStreet.Enabled = false;
                        txtEditSupplierTown.Enabled = false;
                        txtEditSupplierCounty.Enabled = false;
                        txtEditSupplierPostcode.Enabled = false;
                        txtEditSupplierEmail.Enabled = false;
                        txtEditSupplierTelephoneNo.Enabled = false;

                        btnConfirmEditSupplier.Text = "Edit";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list", "Select supplier");
            }
            else
            {
                drSupplier = dsSurefill.Tables["Supplier"].Rows.Find(dgvSuppliers.SelectedRows[0].Cells[0].Value);
                string tempName = drSupplier["Name"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Supplier", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsSurefill, "Supplier");
                }
            }
        }

        private void btnCancelAddSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of supplier no: " + lblAddActualSupplierNo.Text + "?", "Add Supplier", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
        }

        private void btnCancelEditSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of supplier no: " + lblEditActualSupplierNo.Text + "?", "Edit Supplier", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
        }

        private void btnSearchSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.DimGray;
        }
    }
}