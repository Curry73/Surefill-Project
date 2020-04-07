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
        SqlDataAdapter daJobs, daCustomer, daProduct;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBProduct;
        DataRow drJobs, drProduct;
        String connStr, sqlJobs, sqlCustomer, sqlProduct;
        int selectedTab = 0;
        bool jobSelected = false;
        string jobNoSelected = "";

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
            daJobs.FillSchema(dsSurefill, SchemaType.Source,"Jobs");
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

            pnlAddJob.Visible = false;

            cmbCavitySize.Items.Add("0.1016 - 4 inch");
            cmbCavitySize.Items.Add("0.1524 - 6 inch");
            cmbCavitySize.Items.Add("0.2032 - 8 inch");

        }

        private void btnAddWall_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(wallNo));
            double wallSize = Double.Parse(txtAddWallHeight.Text) * Double.Parse(txtAddWallLength.Text);
            Double wallCavitySize = Double.Parse(cmbCavitySize.SelectedItem.ToString().Substring(0,6));
            double wallSizeTotal = wallSize * wallCavitySize;
            item.SubItems.Add(Convert.ToString(wallSizeTotal));
            double openingTotal = 0;

            for (int x = 0; x < LVOpenings.Items.Count; x++)
            {
                openingTotal += Double.Parse(LVOpenings.Items[x].SubItems[2].Text);

            }
            Double openingActualTotal = openingTotal * wallCavitySize;
            item.SubItems.Add(Convert.ToString(openingActualTotal));

            double total = wallSizeTotal - openingActualTotal;

            item.SubItems.Add(Convert.ToString(total));

            LVFinal.Items.Add(item);

            wallNo++;
            lblWallNo.Text = Convert.ToString(wallNo);

            LVOpenings.Items.Clear();
            txtAddWallHeight.Clear();
            txtAddWallLength.Clear();

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

            MessageBox.Show(""+ finalPrice);
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DialogResult paidResult = MessageBox.Show("Have you paid?", "Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool paid = false;

            if (paidResult == DialogResult.Yes)
                paid = true;

            drJobs = dsSurefill.Tables["Jobs"].NewRow();

            drJobs["Paid"] = false;

            //daJobs.Update();

            pnlAddJob.Visible = true;
        }



    }
}
