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
    public partial class EditJob : Form
    {

        SqlDataAdapter daJobs, daCustomer, daProduct, daJobType, daPaymentType, daJobDetails, daCavityType, daWallDetails, daWallDetails2, daOpeningDetails, daOpeningDetails2;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBProduct, cmdBJobType, cmdBPaymentType, cmdBJobDetails, cmdBCavityType, cmdBWallDetails2, cmdBOpeningDetails2;

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DataRow drJobs, drProduct, drJobType, drPaymentType, drJobDetails, drCavityType, drWallDetails, drOpeningDetails;
        SqlCommand cmdWallDetails, cmdOpeningDetails;
        SqlConnection conn;
        String connStr, sqlJobs, sqlCustomer, sqlProduct, sqlJobType, sqlPaymentType, sqlJobDetails, sqlCavityType, sqlWallDetails, sqlWallDetails2, sqlOpeningDetails, sqlOpeningDetails2;


        int wallNo =1;

        public EditJob()
        {
            InitializeComponent();
        }

        private void EditJob_Load(object sender, EventArgs e)
        {

            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            conn = new SqlConnection(connStr);

            sqlJobs = @"select * from Jobs";
            daJobs = new SqlDataAdapter(sqlJobs, connStr);
            cmdBJobs = new SqlCommandBuilder(daJobs);
            daJobs.FillSchema(dsSurefill, SchemaType.Source, "Jobs");
            daJobs.Fill(dsSurefill, "Jobs");
            

            sqlWallDetails = @"select * from WallDetails where JobNo = @JobNo";

            cmdWallDetails = new SqlCommand(sqlWallDetails, conn);
            cmdWallDetails.Parameters.Add("@JobNo", SqlDbType.Int);
            daWallDetails = new SqlDataAdapter(cmdWallDetails);

            daWallDetails.FillSchema(dsSurefill, SchemaType.Source, "WallDetails");
            //daWallDetails.Fill(dsSurefill, "WallDetails");

            sqlOpeningDetails = @"select * from OpeningDetails where JobNo = @JobNo AND WallNo = @WallNo";

            cmdOpeningDetails = new SqlCommand(sqlOpeningDetails, conn);
            cmdOpeningDetails.Parameters.Add("@JobNo", SqlDbType.Int);
            cmdOpeningDetails.Parameters.Add("@WallNo", SqlDbType.Int);
            daOpeningDetails = new SqlDataAdapter(cmdOpeningDetails);
            daOpeningDetails.FillSchema(dsSurefill, SchemaType.Source, "OpeningDetails");


            sqlWallDetails2 = @"select * from WallDetails";
            daWallDetails2 = new SqlDataAdapter(sqlWallDetails2, conn);
            cmdBWallDetails2 = new SqlCommandBuilder(daWallDetails2);          
            daWallDetails2.FillSchema(dsSurefill, SchemaType.Source, "WallDetails");

            sqlOpeningDetails2 = @"select * from OpeningDetails";
            daOpeningDetails2 = new SqlDataAdapter(sqlOpeningDetails2, conn);
            cmdBOpeningDetails2 = new SqlCommandBuilder(daOpeningDetails2);
            daOpeningDetails2.FillSchema(dsSurefill, SchemaType.Source, "OpeningDetails");

            cmbEditJobNo.DataSource = dsSurefill.Tables["Jobs"];

            cmbEditJobNo.DisplayMember = "JobNo";
            cmbEditJobNo.ValueMember = "JobNo";

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsSurefill, SchemaType.Source, "Product");
            daProduct.Fill(dsSurefill, "Product");

            cmbEditProductNo.DataSource = dsSurefill.Tables["Product"];
            cmbEditProductNo.ValueMember = "ProductNo";
            cmbEditProductNo.DisplayMember = "ProductDescription";

            sqlCavityType = @"select * from CavityType";
            daCavityType = new SqlDataAdapter(sqlCavityType, connStr);
            cmdBCavityType = new SqlCommandBuilder(daCavityType);
            daCavityType.FillSchema(dsSurefill, SchemaType.Source, "CavityType");
            daCavityType.Fill(dsSurefill, "CavityType");

            cmbEditCavitySize.DataSource = dsSurefill.Tables["CavityType"];
            cmbEditCavitySize.ValueMember = "CavityNo";
            cmbEditCavitySize.DisplayMember = "CavityName";


        }

        private void cmbEditJobNoSelectedItems(object sender, EventArgs e)
        {
            int number = -1;

 
            LVEditWallList.Items.Clear();
            dsSurefill.Tables["WallDetails"].Clear();




            if (int.TryParse(cmbEditJobNo.SelectedValue.ToString(), out number))
            {
                //dsSurefill.Tables["WallDetails"].Clear();
                cmdWallDetails.Parameters["@JobNo"].Value = cmbEditJobNo.SelectedValue;
                daWallDetails.Fill(dsSurefill, "WallDetails");
                //dgvCustomers.DataSource = dsSurefill.Tables["CustDets"];

              

                foreach (DataRow dr in dsSurefill.Tables["WallDetails"].Rows)
                {
                    String wallNoStr = dr["WallNo"].ToString();

                    ListViewItem lvi = new ListViewItem(wallNoStr);
                    lvi.SubItems.Add(dr["WallHeight"].ToString());
                    lvi.SubItems.Add(dr["WallLength"].ToString());
                    double totalArea = Double.Parse(dr["WallLength"].ToString()) * Double.Parse(dr["WallHeight"].ToString());
                    lvi.SubItems.Add(Convert.ToString(totalArea));
                   // lvi.SubItems.Add(dr["WallHeight"].ToString()+"x"+ dr["WallLength"].ToString());

                   LVEditWallList.Items.Add(lvi);

                    

                    wallNo = Int32.Parse(wallNoStr);
                }
                wallNo++;
                lblEditActualWallNo.Text = Convert.ToString(wallNo);

                DataRow jobRow = dsSurefill.Tables["Jobs"].Rows.Find(cmbEditJobNo.SelectedValue);
                cmbEditProductNo.SelectedValue = jobRow["ProductNo"];
                if (Convert.ToBoolean(jobRow["Paid"]) == true)
                    rbEditPaidYes.Checked = true;
                else
                    rbEditPaidNo.Checked = true;
                lblActualCustNo.Text = jobRow["CustomerNo"].ToString();
                dtpEditJobDate.Value = DateTime.Parse(jobRow["DateBooked"].ToString());;
            }
        }


        private void LVEditWallList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdOpeningDetails.Parameters["@JobNo"].Value = cmbEditJobNo.SelectedValue;
            cmdOpeningDetails.Parameters["@WallNo"].Value = Int32.Parse(LVEditWallList.SelectedItems[0].SubItems[0].Text);
            daOpeningDetails.Fill(dsSurefill, "OpeningDetails");

            foreach (DataRow dr in dsSurefill.Tables["OpeningDetails"].Rows)
            {
                String openingNoStr = dr["OpeningNo"].ToString();

                ListViewItem lvi = new ListViewItem(openingNoStr);
                lvi.SubItems.Add(dr["OpeningHeight"].ToString());
                lvi.SubItems.Add(dr["OpeningLength"].ToString());
                double totalArea = Double.Parse(dr["OpeningHeight"].ToString()) * Double.Parse(dr["OpeningLength"].ToString());
                lvi.SubItems.Add(Convert.ToString(totalArea));
                LVEditOpenings.Items.Add(lvi);
            }
        }

        private void LVEditOpenings_Click(object sender, EventArgs e)
        {
            object[] keys = { Int32.Parse(LVEditOpenings.SelectedItems[0].SubItems[0].Text), Int32.Parse(LVEditWallList.SelectedItems[0].SubItems[0].Text), cmbEditJobNo.SelectedValue };
            drOpeningDetails = dsSurefill.Tables["OpeningDetails"].Rows.Find(keys);

            txtEditOpeningLength.Text = drOpeningDetails["OpeningLength"].ToString();
            txtEditOpeningHeight.Text = drOpeningDetails["OpeningHeight"].ToString();

        }
        private void btnEditNewWall_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(wallNo));
            double wallSize = Double.Parse(txtEditWallHeight.Text) * Double.Parse(txtEditWallLength.Text);
            Double wallCavitySize = Double.Parse(cmbEditCavitySize.Text.ToString().Substring(0, 6));
            double wallSizeTotal = wallSize * wallCavitySize;
            //item.SubItems.Add(Convert.ToString(wallSizeTotal));
            double totalArea = Double.Parse(txtEditWallHeight.Text) * Double.Parse(txtEditWallLength.Text);



            // item.SubItems.Add(Convert.ToString(total));
            //item.SubItems.Add(lblEditActualWallNo.Text);
            item.SubItems.Add(txtEditWallHeight.Text);
            item.SubItems.Add(txtEditWallLength.Text);
            item.SubItems.Add(totalArea.ToString());

            LVEditWallList.Items.Add(item);

            wallNo++;
            lblEditActualWallNo.Text = Convert.ToString(wallNo);

        }

        private void btnDeleteWall_Click(object sender, EventArgs e)
        {
            object[] keys = {cmbEditJobNo.SelectedValue, Convert.ToInt32(LVEditWallList.SelectedItems[0].SubItems[0].Text)};
            DataRow dr = dsSurefill.Tables["WallDetails"].Rows.Find(keys);
            dr.BeginEdit();
            dr["WallLength"] = 4;
            dr.EndEdit();

            dr.Delete();

            daWallDetails2.Update(dsSurefill, "WallDetails");

            dsSurefill.Tables["WallDetails"].Clear();
            daWallDetails.Fill(dsSurefill, "WallDetails");

            LVEditWallList.Items.Remove(LVEditWallList.SelectedItems[0]);

        }

        private void btnEditCalculate_Click(object sender, EventArgs e)
        {
            {
                double OverallTotal = 0;

                for (int x = 0; x < LVEditWallList.Items.Count; x++)
                {
                    OverallTotal += Double.Parse(LVEditWallList.Items[x].SubItems[3].Text);
                }


                drProduct = dsSurefill.Tables["Product"].Rows.Find(cmbEditProductNo.SelectedValue);
                double productMeasure = Convert.ToDouble(drProduct["ProductMeasure"]);
                double productPrice = Convert.ToDouble(drProduct["ProductPrice"]);

                double pricePerOne = productPrice / productMeasure;

                double productQty = Math.Ceiling(OverallTotal % productMeasure);

                double finalPrice = pricePerOne * productQty ; 

                lblOverallTotal.Text = Convert.ToString(OverallTotal);

                MessageBox.Show("Final Price £" + finalPrice);

               // MessageBox.Show("This amount of coverage using " + cmbAddJobProdName.SelectedValue.ToString() + " will cost £" + finalPrice.ToString(), "Price");
            }
        }

        private void btnEditFinalJob_Click(object sender, EventArgs e)
        {



            //dsSurefill.Tables["Jobs"].Clear();
            //daWallDetails.Fill(dsSurefill, "Jobs");

            foreach (ListViewItem item in LVEditWallList.Items)
            {
                object[] keys = { cmbEditJobNo.SelectedValue, Convert.ToInt32(item.SubItems[0].Text) };
                if (dsSurefill.Tables["WallDetails"].Rows.Find(keys) != null)
                    continue;
                drWallDetails = dsSurefill.Tables["WallDetails"].NewRow();

                drWallDetails["JobNo"] = cmbEditJobNo.SelectedValue;
                drWallDetails["WallNo"] = Convert.ToInt32(item.SubItems[0].Text);
                drWallDetails["WallHeight"] = Convert.ToDouble(item.SubItems[1].Text);
                drWallDetails["WallLength"] = Convert.ToDouble(item.SubItems[2].Text);
                drWallDetails["CavityType"] = cmbEditCavitySize.SelectedValue;

                dsSurefill.Tables["WallDetails"].Rows.Add(drWallDetails);
                daWallDetails2.Update(dsSurefill, "WallDetails");
            }

            drJobs = dsSurefill.Tables["Jobs"].Rows.Find(cmbEditJobNo.SelectedValue);

            drJobs["Paid"] = rbEditPaidYes.Checked;
            daJobs.Update(dsSurefill, "Jobs");

            MessageBox.Show("Job has been edited", "Job Edited");
            pnlEditJob.Visible = false;
          
        }
        private void btnEditOpening_Click(object sender, EventArgs e)
        {
            drOpeningDetails["OpeningLength"] = txtEditOpeningLength.Text;
            drOpeningDetails["OpeningHeight"] = txtEditOpeningHeight.Text;

            daOpeningDetails2.Update(dsSurefill, "OpeningDetails");

            LVEditOpenings.SelectedItems[0].SubItems[1].Text = txtEditOpeningLength.Text;
            LVEditOpenings.SelectedItems[0].SubItems[2].Text = txtEditOpeningHeight.Text;
            LVEditOpenings.SelectedItems[0].SubItems[3].Text = Convert.ToString(Double.Parse(txtEditOpeningLength.Text.ToString()) * Double.Parse(txtEditOpeningHeight.Text.ToString()));

            MessageBox.Show("Opening Updated");
        }

    }

   
}
