﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmLogin newForm = new frmLogin();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
            
        }

        //JOB BUTTONS
        private void picBoxJob_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmJobs newForm = new frmJobs();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();

        }

        private void lblJobs_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmJobs newForm = new frmJobs();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }


        private void picBoxJob_MouseEnter(object sender, EventArgs e)
        {
            lblJobs.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void picBoxJob_MouseLeave(object sender, EventArgs e)
        {
            lblJobs.ForeColor = Color.White;
        }

        //CUSTOMER BUTTONS

        private void picBoxCust_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmCustomer newForm = new frmCustomer();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }

        private void lblCust_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmCustomer newForm = new frmCustomer();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }


        private void picBoxCust_MouseEnter(object sender, EventArgs e)
        {
            lblCust.ForeColor = Color.FromArgb(237,173,72);
        }

        private void picBoxCust_MouseLeave(object sender, EventArgs e)
        {
            lblCust.ForeColor = Color.White;
        }
        //STOCK BUTTONS

        private void picBoxStock_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmProduct newForm = new frmProduct();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            frmProduct newForm = new frmProduct();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }


        private void picBoxStock_MouseEnter(object sender, EventArgs e)
        {
            lblStock.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void picBoxStock_MouseLeave(object sender, EventArgs e)
        {
            lblStock.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            pnlHome.BackgroundImage = Properties.Resources.niceHouse;
        }

        private void picBoxSupp_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            FrmSupplier newForm = new FrmSupplier();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }

        private void lblSupp_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            FrmSupplier newForm = new FrmSupplier();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(newForm);
            pnlHome.Visible = true;
            newForm.Show();
        }

        private void btnPaymentsForm_Click(object sender, EventArgs e)
        {
            frmPayments frmPayments = new frmPayments();
            frmPayments.Show();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            frmProductOrder frmProductOrder = new frmProductOrder();
            frmProductOrder.Show();
        }
    }
}
