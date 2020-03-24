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
    public partial class FrmSupplier : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter daSupplier, daSuppDetails;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        SqlCommand cmdSupplierDetails;
        SqlConnection conn;
        DataRow drSupplier;
        String connStr, sqlSupplier, sqlSuppDetails;
        int selectedTab = 0;
        bool suppSelected = false;
        String suppNoSelected = "";

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            conn = new SqlConnection(connStr);

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsSurefill, SchemaType.Source,
                "Supplier");
            daSupplier.Fill(dsSurefill, "Supplier");
            dgvSuppliers.DataSource = dsSurefill.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
            pnlSearchSupp.Visible = false;

            sqlSuppDetails = @"Select * From Supplier where Name LIKE (@Letter + '%') order by SupplierNo";
            cmdSupplierDetails = new SqlCommand(sqlSuppDetails, conn);
            cmdSupplierDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daSuppDetails = new SqlDataAdapter(cmdSupplierDetails);
            daSuppDetails.FillSchema(dsSurefill, SchemaType.Source, "SuppDets");

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
            pnlAddSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
            pnlSearchSupp.Visible = false;
        }

        private void lblAddSupplier_Click(object sender, EventArgs e)
        {
            pnlAddSupplier.Visible = true;
            pnlEditSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
            pnlSearchSupp.Visible = false;
        }

        private void btnAddSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblAddSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            getNumber(dsSurefill.Tables["Supplier"].Rows.Count);
            pnlAddSupplier.Visible = true;
            pnlEditSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
            pnlSearchSupp.Visible = false;
        }

        private void btnAddSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblAddSupplier.ForeColor = Color.DimGray;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {

            suppNoSelected = (dgvSuppliers.SelectedRows[0].Cells[0].Value).ToString();

            pnlEditSupplier.Visible = true;
            pnlAddSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
            pnlSearchSupp.Visible = false;

            if (suppNoSelected.Equals(""))
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                lblAddActualSupplierNo.Text = suppNoSelected.ToString();
                drSupplier = dsSurefill.Tables["Supplier"].Rows.Find(lblAddActualSupplierNo.Text);

                lblEditActualSupplierNo.Text = drSupplier["SupplierNO"].ToString();
                txtEditSupplierName.Text = drSupplier["Name"].ToString();
                txtEditSupplierStreet.Text = drSupplier["Street"].ToString();
                txtEditSupplierTown.Text = drSupplier["Town"].ToString();
                txtEditSupplierCounty.Text = drSupplier["County"].ToString();
                txtEditSupplierPostcode.Text = drSupplier["Postcode"].ToString();
                txtEditSupplierEmail.Text = drSupplier["Email"].ToString();
                txtEditSupplierTelephoneNo.Text = drSupplier["TelephoneNo"].ToString();
            }
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



        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            pnlDeleteSupp.Visible = true;
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            pnlSearchSupp.Visible = false;
            //    btnAddSupplier.Visible = false;
            //    btnEditSupplier.Visible = false;
            //    btnDeleteSupplier.Visible = false;
            //    btnSearchSupplier.Visible = false;
        }

        private void lblDeleteSupplier_Click(object sender, EventArgs e)
        {
            pnlDeleteSupp.Visible = true;
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            pnlSearchSupp.Visible = false;
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            pnlSearchSupp.Visible = true;
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
        }

        private void lblSearchSupplier_Click(object sender, EventArgs e)
        {
            pnlSearchSupp.Visible = true;
            pnlAddSupplier.Visible = false;
            pnlEditSupplier.Visible = false;
            pnlDeleteSupp.Visible = false;
        }

        private void btnConfirmAddSupplier_Click(object sender, EventArgs e)
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
                mySupplier.TelephoneNo = txtAddSupplierTelephoneNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddSupplierTelephoneNo, MyEx.toString());
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
            txtAddSupplierCounty.Clear();
            txtAddSupplierPostcode.Clear();
            txtAddSupplierEmail.Clear();
            txtAddSupplierTelephoneNo.Clear();
        }

        private void getNumber(int noRows)
        {
            drSupplier = dsSurefill.Tables["Supplier"].Rows[noRows - 1];
            lblAddActualSupplierNo.Text = ("S" + (int.Parse(drSupplier["SupplierNo"].ToString().Substring(1, 5)) + 1).ToString());
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

        private void pnlDeleteSupp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list", "Select Supplier");
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
            if (MessageBox.Show("Cancel the addition of Supplier No: " + lblAddActualSupplierNo.Text + "?", "Add Supplier", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
            pnlAddSupplier.Visible = false;
        }

        private void btnCancelEditSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Supplier No: " + lblEditActualSupplierNo.Text + "?", "Edit Supplier", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
            pnlEditSupplier.Visible = false;
        }

        private void btnConfirmCancelSearchSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel Search?", "Search", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;

            pnlSearchSupp.Visible = false;
        }

        private void txtSearchActualSupplierNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchSupplierName_TextChanged(object sender, EventArgs e)
        {
            dsSurefill.Tables["SuppDets"].Clear();
            cmdSupplierDetails.Parameters["@Letter"].Value = txtSearchSupplierName.Text;
            daSuppDetails.Fill(dsSurefill, "SuppDets");
            dgvSuppliers.DataSource = dsSurefill.Tables["SuppDets"];
        }

        private void txtSearchSupplierCounty_TextChanged(object sender, EventArgs e)
        {
            dsSurefill.Tables["SuppDets"].Clear();
            cmdSupplierDetails.Parameters["@Letter"].Value = txtSearchSupplierCounty.Text;
            daSuppDetails.Fill(dsSurefill, "SuppDets");
            dgvSuppliers.DataSource = dsSurefill.Tables["SuppDets"];
        }

        private void pnlSearchSupp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteSuppCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the deletion of Supplier No: " + lblEditActualSupplierNo.Text + "?", "Delete Supplier", MessageBoxButtons.YesNo) ==
            System.Windows.Forms.DialogResult.Yes) ;
            pnlDeleteSupp.Visible = false;
        }

        //private void btnConfirmSearchSupplier_Click(object sender, EventArgs e)
        //{
        //    connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
        //    con.Open();
        //    SqlCommand cmdSupplier = new SqlCommand("select * from Supplier" + txtSearchActualSupplierNo.Text + "'", con);
        //    SqlDataReader dr = cmdSupplier.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        txtSearchActualSupplierNo.Text = dr.GetValue(3).ToString();
        //    }
        //    con.Close();
        //}

        private void btnSearchSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.DimGray;

        }
    }
}
