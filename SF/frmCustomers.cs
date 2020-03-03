using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF
{
    public partial class frmCustomers : Form
    {

        SqlDataAdapter daCustomer;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill;
Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsSurefill, SchemaType.Source,
                "Customer");
            daCustomer.Fill(dsSurefill, "Customer");
            dataGridViewCustomer.DataSource = dsSurefill.Tables["Customer"];
            dataGridViewCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            tabCustomer.SelectedIndex = 1;
            tabCustomer.SelectedIndex = 0;
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

        private void lblEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblAddCustomer.ForeColor = Color.DimGray;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblEditCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnEditCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblEditCustomer.ForeColor = Color.DimGray;
        }

        private void btnDeleteCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnDeleteCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteCustomer.ForeColor = Color.DimGray;
        }

        private void btnSearchCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblSearchCustomer.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblSearchCustomer.ForeColor = Color.DimGray;
        }
    }
}
