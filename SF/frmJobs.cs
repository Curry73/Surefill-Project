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
    public partial class frmJobs : Form
    {
        SqlDataAdapter daJobs, daCustomer, daProduct, daJobType, daPaymentType, daJobDetails, daCavityType, daWallDetails, daOpeningDetails;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBProduct, cmdBJobType, cmdBPaymentType, cmdBJobDetails, cmdBCavityType, cmdBWallDetails, cmdBOpeningDetails;
        DataRow drJobs, drProduct, drJobType, drPaymentType, drJobDetails, drCavityType, drWallDetails, drOpeningDetails;

        private void txtOpeningLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void txtOpeningHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDeleteJobCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the deletion of job: " + "?", "delete job", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes) ;
            pnlDeleteJob.Visible = false;
        }

        private void txtAddWallHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void txtAddWallLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        String connStr, sqlJobs, sqlCustomer, sqlProduct, sqlJobType, sqlPaymentType, sqlJobDetails, sqlCavityType, sqlWallDetails, sqlOpeningDetails;

        Dictionary<int, List<WallOpening>> openingMap = new System.Collections.Generic.Dictionary<int, List<WallOpening>>();

        int selectedTab = 0;
        bool jobSelected = false;
        string jobNoSelected = "";
        int jobNo = 0;
        int wallNo = 1;

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
            daJobs.FillSchema(dsSurefill, SchemaType.Source, "Jobs");
            daJobs.Fill(dsSurefill, "Jobs");
            dgvJobs.DataSource = dsSurefill.Tables["Jobs"];

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsSurefill, SchemaType.Source, "Customer");
            daCustomer.Fill(dsSurefill, "Customer");

            dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cmbAddJobCustNo.DataSource = dsSurefill.Tables["Customer"];
            cmbAddJobCustNo.ValueMember = "CustomerNo";
            cmbAddJobCustNo.DisplayMember = "CustomerName";

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsSurefill, SchemaType.Source, "Product");
            daProduct.Fill(dsSurefill, "Product");

            cmbAddJobProdName.DataSource = dsSurefill.Tables["Product"];
            cmbAddJobProdName.ValueMember = "ProductNo";
            cmbAddJobProdName.DisplayMember = "ProductDescription";

            sqlJobType = @"select * from JobType";
            daJobType = new SqlDataAdapter(sqlJobType, connStr);
            cmdBJobType = new SqlCommandBuilder(daJobType);
            daJobType.FillSchema(dsSurefill, SchemaType.Source, "JobType");
            daJobType.Fill(dsSurefill, "JobType");

            cmbJobType.DataSource = dsSurefill.Tables["JobType"];
            cmbJobType.ValueMember = "JobTypeID";
            cmbJobType.DisplayMember = "JobTypeDescription";

            sqlPaymentType = @"select * from PaymentType";
            daPaymentType = new SqlDataAdapter(sqlPaymentType, connStr);
            cmdBPaymentType = new SqlCommandBuilder(daPaymentType);
            daPaymentType.FillSchema(dsSurefill, SchemaType.Source, "PaymentType");
            daPaymentType.Fill(dsSurefill, "PaymentType");

            cmbPaymentType.DataSource = dsSurefill.Tables["PaymentType"];
            cmbPaymentType.ValueMember = "PaymentTypeID";
            cmbPaymentType.DisplayMember = "PaymentTypeDesc";

            

            int noRows = dsSurefill.Tables["Jobs"].Rows.Count;
            drJobs = dsSurefill.Tables["Jobs"].Rows[noRows - 1];
            lblActualJobID.Text = (int.Parse(drJobs["JobNo"].ToString()) + 1).ToString();

            //sqlJobDetails = @"select * from JobDetails";
            //daJobDetails = new SqlDataAdapter(sqlJobDetails, connStr);
            //cmdBJobDetails = new SqlCommandBuilder(daJobDetails);
            //daJobDetails.FillSchema(dsSurefill, SchemaType.Source, "JobDetails");
            //daJobDetails.Fill(dsSurefill, "JobDetails");

            sqlCavityType = @"select * from CavityType";
            daCavityType = new SqlDataAdapter(sqlCavityType, connStr);
            cmdBCavityType = new SqlCommandBuilder(daCavityType);
            daCavityType.FillSchema(dsSurefill, SchemaType.Source, "CavityType");
            daCavityType.Fill(dsSurefill, "CavityType");

            cmbCavitySize.DataSource = dsSurefill.Tables["CavityType"];
            cmbCavitySize.ValueMember = "CavityNo";
            cmbCavitySize.DisplayMember = "CavityName";

            sqlOpeningDetails = @"select * from OpeningDetails";
            daOpeningDetails = new SqlDataAdapter(sqlOpeningDetails, connStr);
            cmdBOpeningDetails = new SqlCommandBuilder(daOpeningDetails);
            daOpeningDetails.FillSchema(dsSurefill, SchemaType.Source, "OpeningDetails");
            daOpeningDetails.Fill(dsSurefill, "OpeningDetails");

            sqlWallDetails = @"select * from WallDetails";
            daWallDetails = new SqlDataAdapter(sqlWallDetails, connStr);
            cmdBWallDetails = new SqlCommandBuilder(daWallDetails);
            daWallDetails.FillSchema(dsSurefill, SchemaType.Source, "WallDetails");
            daWallDetails.Fill(dsSurefill, "WallDetails");

            jobNo = (int.Parse(drJobs["JobNo"].ToString()) + 1);
            lblActualJobID.Text = Convert.ToString(jobNo);

            pnlDGVJobs.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
            pnlDeleteJob.Visible = false;
        }

        private void btnAddFinalJob_Click(object sender, EventArgs e)
        {
            DateTime dateBooked = DateTime.Now;
            
            DialogResult paidResult = MessageBox.Show("Has the customer paid?", "Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool paid = false;

            if (paidResult == DialogResult.Yes)
                paid = true;

            
            drJobs = dsSurefill.Tables["Jobs"].NewRow();

            drJobs["JobNo"] = jobNo;
            drJobs["CustomerNo"] = cmbAddJobCustNo.SelectedValue;
            drJobs["DateBooked"] = DateTime.Now;
            drJobs["JobCompletion"] = dtpAddJob.Value;
            drJobs["JobTypeID"] = cmbJobType.SelectedValue;
            drJobs["Paid"] = paid;
            drJobs["PaymentTypeID"] = cmbPaymentType.SelectedValue;
            drJobs["ProductNo"] = cmbAddJobProdName.SelectedValue;

            dsSurefill.Tables["Jobs"].Rows.Add(drJobs);
            daJobs.Update(dsSurefill, "Jobs");
            


        

            int wallNo = 1;
            foreach (ListViewItem item in LVFinal.Items)
            {
                List<WallOpening> lstWallOpenings = openingMap[Convert.ToInt32(item.SubItems[0].Text)];
                drWallDetails = dsSurefill.Tables["WallDetails"].NewRow();

                drWallDetails["JobNo"] = drJobs["JobNo"];
                drWallDetails["WallNo"] = wallNo;
                drWallDetails["WallHeight"] = Convert.ToDouble(item.SubItems[4].Text);
                drWallDetails["WallLength"] = Convert.ToDouble(item.SubItems[5].Text);
                drWallDetails["CavityType"] = cmbCavitySize.SelectedValue;

                dsSurefill.Tables["WallDetails"].Rows.Add(drWallDetails);
                daWallDetails.Update(dsSurefill, "WallDetails");

                int openingNo = 1;

                foreach(WallOpening wallOpening in lstWallOpenings)
                {
                    drOpeningDetails = dsSurefill.Tables["OpeningDetails"].NewRow();

                    drOpeningDetails["OpeningNo"] = openingNo;
                    drOpeningDetails["WallNo"] = wallNo;
                    drOpeningDetails["JobNo"] = jobNo;
                    drOpeningDetails["OpeningHeight"] = wallOpening.OpeningHeight;
                    drOpeningDetails["OpeningLength"] = wallOpening.OpeningLength;

                    dsSurefill.Tables["OpeningDetails"].Rows.Add(drOpeningDetails);
                    daOpeningDetails.Update(dsSurefill, "OpeningDetails");

                    openingNo++;
                }
                wallNo++;
            }
            //daJobs.Update();

            pnlAddJob.Visible = true;

            jobNo = (int.Parse(drJobs["JobNo"].ToString()) + 1);
            lblActualJobID.Text = Convert.ToString(jobNo);

            MessageBox.Show("Job has been added", "Job Added");
            pnlAddJob.Visible = false;
            dgvJobs.Visible = true;
        }



        private void btnAddWall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wall has been added to your list", "Wall Added");
            ListViewItem item = new ListViewItem(Convert.ToString(wallNo));
            double wallSize = Double.Parse(txtAddWallHeight.Text) * Double.Parse(txtAddWallLength.Text);
            Double wallCavitySize = Double.Parse(cmbCavitySize.Text.ToString().Substring(0,6));
            double wallSizeTotal = wallSize * wallCavitySize;
            item.SubItems.Add(Convert.ToString(wallSizeTotal));
            double openingTotal = 0;

            List<WallOpening> lstWallOpening = new List<WallOpening>();

            for (int x = 0; x < LVOpenings.Items.Count; x++)
            {
                WallOpening wallOpening = new WallOpening();
                wallOpening.OpeningHeight = Convert.ToDouble(LVOpenings.Items[x].SubItems[1].Text);
                wallOpening.OpeningLength = Convert.ToDouble(LVOpenings.Items[x].SubItems[0].Text);
                lstWallOpening.Add(wallOpening);
                openingTotal += Double.Parse(LVOpenings.Items[x].SubItems[2].Text);

            }
            openingMap.Add(wallNo, lstWallOpening);
            Double openingActualTotal = openingTotal * wallCavitySize;
            item.SubItems.Add(Convert.ToString(openingActualTotal));

            double total = wallSizeTotal - openingActualTotal;

            item.SubItems.Add(Convert.ToString(total));
            item.SubItems.Add(txtAddWallHeight.Text);
            item.SubItems.Add(txtAddWallLength.Text);

            LVFinal.Items.Add(item);

            wallNo++;
            lblWallNo.Text = Convert.ToString(wallNo);

            LVOpenings.Items.Clear();
            txtAddWallHeight.Clear();
            txtAddWallLength.Clear();

        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            EditJob frmEditJob = new EditJob();
            frmEditJob.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            double OverallTotal = 0;

            for (int x = 0; x < LVFinal.Items.Count; x++)
            {
                OverallTotal += Double.Parse(LVFinal.Items[x].SubItems[3].Text);
            }

           
            drProduct = dsSurefill.Tables["Product"].Rows.Find(cmbAddJobProdName.SelectedValue);
            double productMeasure = Convert.ToDouble(drProduct["ProductMeasure"]);
            double productPrice = Convert.ToDouble(drProduct["ProductPrice"]);

            double pricePerOne = productPrice / productMeasure;

            double productQty = Math.Ceiling(OverallTotal % productMeasure);

            double finalPrice = pricePerOne * productQty;

            lblOverallTotal.Text = Convert.ToString(OverallTotal); 

            MessageBox.Show("This amount of coverage using "+ cmbAddJobProdName.SelectedValue.ToString() + " will cost £"+ Math.Round(finalPrice, 2), "Price");
        }

        private void getNumber (int noRows)
        {
            drJobs = dsSurefill.Tables["Jobs"].Rows[noRows - 1];
            lblActualJobID.Text = (int.Parse(drJobs["JobNo"].ToString()) + 1).ToString();
        }

        private void btnAddOpening_Click(object sender, EventArgs e)
        {
            txtOpeningsTotal.Text = (Convert.ToDouble(txtOpeningLength.Text) * Convert.ToDouble(txtOpeningHeight.Text)).ToString();
            ListViewItem item = new ListViewItem(txtOpeningLength.Text);
            item.SubItems.Add(txtOpeningHeight.Text);
            item.SubItems.Add(txtOpeningsTotal.Text);
            LVOpenings.Items.Add(item);

            txtOpeningLength.Clear();
            txtOpeningHeight.Clear();
        }
        private void btnCancelOpening_Click(object sender, EventArgs e)
        {
            txtOpeningLength.Clear();
            txtOpeningHeight.Clear();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            pnlAddJob.Visible = true;
            dgvJobs.Visible = false;
            pnlDeleteJob.Visible = false;
            pnlEditJob.Visible = false;
        }
        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            dgvJobs.Visible = true;
            pnlDeleteJob.Visible = true;
            pnlAddJob.Visible = false;
            pnlEditJob.Visible = false;
        }

        private void lblPaymentType_Click(object sender, EventArgs e)
        {

        }
        private void btnConfirmDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Job from the list", "Select Job");
            }
            else
            {
                drJobs = dsSurefill.Tables["Jobs"].Rows.Find(dgvJobs.SelectedRows[0].Cells[0].Value);
                //string tempName = drJobs["Forename"].ToString() + "" + drCustomer["Surname"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete job number: " + dgvJobs.SelectedRows[0].Cells[0].Value + "?", "Delete Job", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    drJobs.Delete();
                    daWallDetails.Update(dsSurefill, "WallDetails");                  
                    daCustomer.Update(dsSurefill, "Customer");
                    daJobType.Update(dsSurefill, "JobType");
                    daPaymentType.Update(dsSurefill, "PaymentType");
                    daProduct.Update(dsSurefill, "Product");
                    daJobs.Update(dsSurefill, "Jobs");

                }
            }
            pnlDeleteJob.Visible = false;
        }


    }
}
