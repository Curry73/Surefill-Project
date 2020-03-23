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

  }
    }
}
