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

        SqlDataAdapter daJobs, daCustomer, daProduct, daJobType, daPaymentType, daJobDetails, daCavityType, daWallDetails, daOpeningDetails;

        

        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs, cmdBCustomer, cmdBProduct, cmdBJobType, cmdBPaymentType, cmdBJobDetails, cmdBCavityType, cmdBWallDetails, cmdBOpeningDetails;
        DataRow drJobs, drProduct, drJobType, drPaymentType, drJobDetails, drCavityType, drWallDetails, drOpeningDetails;
        SqlCommand cmdWallDetails;
        SqlConnection conn;

        String connStr, sqlJobs, sqlCustomer, sqlProduct, sqlJobType, sqlPaymentType, sqlJobDetails, sqlCavityType, sqlWallDetails, sqlOpeningDetails;

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
            cmbEditJobNo.DataSource = dsSurefill.Tables["Jobs"];

            cmbEditJobNo.DisplayMember = "JobNo";
            cmbEditJobNo.ValueMember = "JobNo";

            sqlWallDetails = @"select * from WallDetails where JobNo = @JobNo";
            
            cmdWallDetails = new SqlCommand(sqlWallDetails, conn);
            cmdWallDetails.Parameters.Add("@JobNo", SqlDbType.Int);
            daWallDetails = new SqlDataAdapter(cmdWallDetails);
            
            daWallDetails.FillSchema(dsSurefill, SchemaType.Source, "WallDetails");
            //daWallDetails.Fill(dsSurefill, "WallDetails");


        }

        private void cmbEditJobNoSelectedItems(object sender, EventArgs e)
        {
            if (cmbEditJobNo != null) { 
            //dsSurefill.Tables["WallDetails"].Clear();
            cmdWallDetails.Parameters["@JobNo"].Value = cmbEditJobNo.SelectedValue;
            daWallDetails.Fill(dsSurefill, "WallDetails");
            //dgvCustomers.DataSource = dsSurefill.Tables["CustDets"];

            foreach(DataRow dr in dsSurefill.Tables["WallDetails"].Rows)
                {
                    String wallNo = dr["WallNo"].ToString();

                    ListViewItem lvi = new ListViewItem(wallNo);
                    lvi.SubItems.Add("ABC");
                    lvi.SubItems.Add("4");

                    LVEditWallList.Items.Add(lvi);
                }
        }
        }
    }
}
