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
    public partial class frmJobs : Form
    {
        public frmJobs()
        {
            InitializeComponent();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

        }

        private void btnAddJob_MouseEnter(object sender, EventArgs e)
        {
            lblAddJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnAddJob_MouseLeave(object sender, EventArgs e)
        {
            lblAddJob.ForeColor = Color.DimGray;
        }

        private void btnEditJob_MouseEnter(object sender, EventArgs e)
        {
            lblEditJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnEditJob_MouseLeave(object sender, EventArgs e)
        {
            lblEditJob.ForeColor = Color.DimGray;
        }

        private void btnDeleteJob_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnDeleteJob_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteJob.ForeColor = Color.DimGray;
        }

        private void btnSearchJob_MouseEnter(object sender, EventArgs e)
        {
            lblSearchJob.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnSearchJob_MouseLeave(object sender, EventArgs e)
        {
            lblSearchJob.ForeColor = Color.DimGray;
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
