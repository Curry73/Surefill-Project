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
        SqlDataAdapter daJobs;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBJobs;
        DataRow drJobs;
        String connStr, sqlJobs;
        int selectedTab = 0;
        bool jobSelected = false;
        string jobNoSelected = "";

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
            dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            pnlAddJob.Visible = false;

            cmbWallNumber.Items.Add("1");
            cmbWallNumber.Items.Add("2");
            cmbWallNumber.Items.Add("3");
            cmbWallNumber.Items.Add("4");
            cmbWallNumber.Items.Add("5");
            cmbWallNumber.Items.Add("6");
            cmbWallNumber.Items.Add("7");
            cmbWallNumber.Items.Add("8");
            cmbWallNumber.Items.Add("9");
        }

        private void btnAddOpening_Click(object sender, EventArgs e)
        {
            double openLength, openHeight, totalOpen;
            double.TryParse(txtOpeningLength.Text, out openLength);
            double.TryParse(txtOpeningHeight.Text, out openHeight);
            totalOpen = openLength * openHeight;
            lblActualOpening1.Text = totalOpen.ToString("0.00");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            pnlAddJob.Visible = true;
        }



    }
}
