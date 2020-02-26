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
        public frmCustomers()
        {
            InitializeComponent();
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
