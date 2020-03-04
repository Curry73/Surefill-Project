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
    public partial class FrmSupplier : Form
    {

        SqlDataAdapter daSupplier;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = Surefill;
Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsSurefill, SchemaType.Source,
                "Supplier");
            daSupplier.Fill(dsSurefill, "Supplier");
            dgvSuppliers.DataSource = dsSurefill.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //tabCustomer.SelectedIndex = 1;
            //tabCustomer.SelectedIndex = 0;
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
            lblAddSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblAddSupplier.ForeColor = Color.DimGray;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblEditSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnEditCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblEditSupplier.ForeColor = Color.DimGray;
        }

        private void btnDeleteCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnDeleteCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteSupplier.ForeColor = Color.DimGray;
        }

        private void btnSearchCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.FromArgb(15, 117, 189);
        }

        private void btnSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblSearchSupplier.ForeColor = Color.DimGray;
        }
    }
}

