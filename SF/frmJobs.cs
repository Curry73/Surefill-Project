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
using System.Configuration;

namespace SF
{
    public partial class frmJobs : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter daJobs, daCustomer, daJobType;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBJobType;
        DataRow drJobs;
        String connStr, sqlJobs, sqlCustomer, sqlJobType;
        int selectedTab = 0;
        bool jobSelected = false;
        String jobNoSelected = "";

        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";

            sqlJobs = @"select * from Jobs";
            daJobs = new SqlDataAdapter(sqlJobs, connStr);
            cmdBJobs = new SqlCommandBuilder(daJobs);
            daJobs.FillSchema(dsSurefill, SchemaType.Source,
                "Jobs");
            daJobs.Fill(dsSurefill, "Jobs");

            sqlCustomer = @"select * from Customer";
            daJobs = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsSurefill, SchemaType.Source,
                "Customer");
            daCustomer.Fill(dsSurefill, "Customer");

            sqlJobType = @"select * from JobType";
            daJobType = new SqlDataAdapter(sqlJobType, connStr);
            cmdBJobType = new SqlCommandBuilder(daJobType);
            daJobType.FillSchema(dsSurefill, SchemaType.Source,
                "JobType");
            daJobs.Fill(dsSurefill, "JobType");

            dgvJobs.DataSource = dsSurefill.Tables["Jobs"];
            dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlAddJob.Visible = false;
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            getNumber(dsSurefill.Tables["Jobs"].Rows.Count);
            pnlAddJob.Visible = true;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlSearchJob.Visible = false;
        }

        private void btnAddJob_MouseEnter(object sender, EventArgs e)
        {
            lblAddJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnAddJob_MouseLeave(object sender, EventArgs e)
        {
            lblAddJob.ForeColor = Color.DimGray;
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            jobNoSelected = (dgvJobs.SelectedRows[0].Cells[0].Value).ToString();

            pnlEditJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlSearchJob.Visible = false;

            if (jobNoSelected.Equals(""))
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                lblAddActualJobNo.Text = jobNoSelected.ToString();
                drJobs = dsSurefill.Tables["Jobs"].Rows.Find(lblAddActualJobNo.Text);

                lblEditActualJobNo.Text = drJobs["JobNo"].ToString();
                txtEditJobCustomerNo.Text = drJobs["CustomerNo"].ToString();
                txtEditJobDateBooked.Text = drJobs["DateBooked"].ToString();
                txtEditJobCompletion.Text = drJobs["JobCompletion"].ToString();
                txtEditJobTypeID.Text = drJobs["JobTypeID"].ToString();
                txtEditJobPaid.Text = drJobs["Paid"].ToString();
                txtEditJobPaymentType.Text = drJobs["PaymentTypeID"].ToString();
            }
        }

        private void btnEditJob_MouseEnter(object sender, EventArgs e)
        {
            lblEditJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnEditJob_MouseLeave(object sender, EventArgs e)
        {
            lblEditJob.ForeColor = Color.DimGray;
        }

        private void lblEditJob_Click(object sender, EventArgs e)
        {
            pnlEditJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlSearchJob.Visible = false;
        }

        private void lblAddJob_Click(object sender, EventArgs e)
        {
            pnlAddJob.Visible = true;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlSearchJob.Visible = false;
        }

        private void btnDeleteJob_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            pnlDeleteJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlSearchJob.Visible = false;
        }

        private void lblDeleteSupplier_Click(object sender, EventArgs e)
        {
            pnlDeleteJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlSearchJob.Visible = false;
        }

        private void btnDeleteJob_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteJob.ForeColor = Color.DimGray;
        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            pnlSearchJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
        }

        private void lblSearchSupplier_Click(object sender, EventArgs e)
        {
            pnlSearchJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
        }

        private void btnSearchJob_MouseEnter(object sender, EventArgs e)
        {
            lblSearchJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnSearchJob_MouseLeave(object sender, EventArgs e)
        {
            lblSearchJob.ForeColor = Color.DimGray;
        }

        private void btnConfirmAddJob_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            MyJob myJob = new MyJob();
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                myJob.JobNo = Convert.ToInt32 (lblAddActualJobNo.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(lblAddActualJobNo, MyEx.toString());

            }

            try
            {
                myJob.CustomerNo = txtAddJobCustomerNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobCustomerNo, MyEx.toString());
            }

            try
            {
                myJob.JobDate = DateTime.Parse(txtAddJobDateBooked.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobDateBooked, MyEx.toString());
            }

            try
            {
                myJob.JobCompletion = txtAddJobCompletion.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobCompletion, MyEx.toString());
            }

            try
            {
                myJob.JobTypeID = txtAddJobTypeID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobTypeID, MyEx.toString());
            }

            try
            {
                myJob.Paid = txtAddJobPaid.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobPaid, MyEx.toString());
            }

            try
            {
                myJob.PaymentTypeID = txtAddJobPaymentType.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddJobPaymentType, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drJobs = dsSurefill.Tables["Supplier"].NewRow();

                    drJobs["JobNo"] = myJob.JobNo;
                    drJobs["CustomerNo"] = myJob.CustomerNo;
                    drJobs["DateBooked"] = myJob.JobDate;
                    drJobs["JobCompletion"] = myJob.JobCompletion;
                    drJobs["JobTypeID"] = myJob.JobTypeID;
                    drJobs["Paid"] = myJob.Paid;
                    drJobs["PaymentTypeID"] = myJob.PaymentTypeID;


                    dsSurefill.Tables["Jobs"].Rows.Add(drJobs);
                    daJobs.Update(dsSurefill, "Jobs");

                    MessageBox.Show("Job Added");

                    if (MessageBox.Show("Do you want to add another Job?", "Add Job", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsSurefill.Tables["Jobs"].Rows.Count);
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
            txtAddJobCustomerNo.Clear();
            txtAddJobDateBooked.Clear();
            txtAddJobCompletion.Clear();
            txtAddJobTypeID.Clear();
            txtAddJobPaid.Clear();
            txtAddJobPaymentType.Clear();
        }

        private void getNumber(int noRows)
        {
            drJobs = dsSurefill.Tables["Jobs"].Rows[noRows - 1];
            //lblAddActualJobNo.Text = ("JT" + (int.Parse(drJobs["JobNo"].ToString().Substring(2, 2)) + 1).ToString());
        }

        private void btnConfirmEditJob_Click(object sender, EventArgs e)
        {
            if (btnConfirmEditJob.Text == "Edit")
            {
                txtAddJobCustomerNo.Enabled = true;
                txtEditJobDateBooked.Enabled = true;
                txtEditJobCompletion.Enabled = true;
                txtEditJobTypeID.Enabled = true;
                txtEditJobPaid.Enabled = true;
                txtEditJobPaymentType.Enabled = true;

                btnConfirmEditJob.Text = "Save";

            }
            else
            {
                MyJob myJob = new MyJob();
                bool ok = true;
                errorProvider1.Clear();

                try
                {
                    myJob.JobNo = Convert.ToInt32 (lblEditActualJobNo.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(lblEditActualJobNo, MyEx.toString());

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
                    mySupplier.TelephoneNo = txtEditSupplierTelephoneNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditSupplierTelephoneNo, MyEx.toString());
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

                        txtEditSupplierName.Enabled = false;
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
    }
}
