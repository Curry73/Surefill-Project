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

        SqlDataAdapter daJobs, daCustomer, daProduct, daJobType, daPaymentType, daJobDetails, daCavityType, daWallDetails, daWallDetails2, daOpeningDetails;

        DataSet dsSurefill = new DataSet();



        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBProduct, cmdBJobType, cmdBPaymentType, cmdBJobDetails, cmdBCavityType, cmdBWallDetails2, cmdBOpeningDetails;
        DataRow drJobs, drProduct, drJobType, drPaymentType, drJobDetails, drCavityType, drWallDetails, drOpeningDetails;
        SqlCommand cmdWallDetails;
        SqlConnection conn;

        String connStr, sqlJobs, sqlCustomer, sqlProduct, sqlJobType, sqlPaymentType, sqlJobDetails, sqlCavityType, sqlWallDetails, sqlWallDetails2, sqlOpeningDetails;


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


            sqlWallDetails2 = @"select * from WallDetails";
            daWallDetails2 = new SqlDataAdapter(sqlWallDetails2, conn);
            cmdBWallDetails2 = new SqlCommandBuilder(daWallDetails2);
            

            daWallDetails2.FillSchema(dsSurefill, SchemaType.Source, "WallDetails");

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

               


            if (int.TryParse(cmbEditJobNo.SelectedValue.ToString(), out number))
            {
                //dsSurefill.Tables["WallDetails"].Clear();
                cmdWallDetails.Parameters["@JobNo"].Value = cmbEditJobNo.SelectedValue;
                daWallDetails.Fill(dsSurefill, "WallDetails");
                //dgvCustomers.DataSource = dsSurefill.Tables["CustDets"];

              

                foreach (DataRow dr in dsSurefill.Tables["WallDetails"].Rows)
                {
                    String wallNo = dr["WallNo"].ToString();

                    ListViewItem lvi = new ListViewItem(wallNo);
                    lvi.SubItems.Add(dr["CavityType"].ToString());
                    lvi.SubItems.Add(dr["WallHeight"].ToString()+"x"+ dr["WallLength"].ToString());

                    LVEditWallList.Items.Add(lvi);
                }
            }
        }
        private void btnEditNewWall_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("NEW WALL");
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
    }
}
