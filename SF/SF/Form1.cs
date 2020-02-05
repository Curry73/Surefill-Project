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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblJobs.ForeColor = Color.Red;
        }

      

        private void pnlSide_MouseEnter(object sender, EventArgs e)
        {
            lblJobs.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Green;
        }

        private void lblJobs_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
