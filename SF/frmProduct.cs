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
    public partial class frmProduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter daProduct, daProdDetails;
        DataSet dsSurefill = new DataSet();
        SqlCommandBuilder cmdBProduct;
        SqlCommand cmdProductDetails;
        SqlConnection conn;
        DataRow drProduct;
        String connStr, sqlProduct, sqlProdDetails;
        int selectedTab = 0;
        bool prodSelected = false;
        String prodNoSelected = "";

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            conn = new SqlConnection(connStr);

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsSurefill, SchemaType.Source,
                "Product");
            daProduct.Fill(dsSurefill, "Product");
            dgvProduct.DataSource = dsSurefill.Tables["Product"];
            dgvProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            pnlAddProduct.Visible = false;
            pnlEditProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlSearchProduct.Visible = false;

            sqlProdDetails = @"Select * From Product where ProductDescription LIKE (@Letter + '%') order by ProductNo";
            cmdProductDetails = new SqlCommand(sqlProdDetails, conn);
            cmdProductDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daProdDetails = new SqlDataAdapter(cmdProductDetails);
            daProdDetails.FillSchema(dsSurefill, SchemaType.Source, "ProdDets");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            getNumber(dsSurefill.Tables["Product"].Rows.Count);
            pnlAddProduct.Visible = true;
            pnlEditProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlSearchProduct.Visible = false;
        }

        private void btnAddProduct_MouseEnter(object sender, EventArgs e)
        {
            lblAddProduct.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnAddProduct_MouseLeave(object sender, EventArgs e)
        {
            lblAddProduct.ForeColor = Color.DimGray;
        }

        private void lblAddProduct_Click(object sender, EventArgs e)
        {
            pnlAddProduct.Visible = true;
            pnlEditProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlSearchProduct.Visible = false;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            prodNoSelected = (dgvProduct.SelectedRows[0].Cells[0].Value).ToString();

            pnlEditProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlSearchProduct.Visible = false;

            if (prodNoSelected.Equals(""))
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                lblAddActualProductNo.Text = prodNoSelected.ToString();
                drProduct = dsSurefill.Tables["Product"].Rows.Find(lblAddActualProductNo.Text);

                lblEditActualProductNo.Text = drProduct["ProductNo"].ToString();
                txtEditProductDescription.Text = drProduct["ProductDescription"].ToString();
                txtEditProductPrice.Text = drProduct["ProductPrice"].ToString();
                txtEditProductQty.Text = drProduct["ProductQty"].ToString();
            }
        }

        private void btnEditProduct_MouseEnter(object sender, EventArgs e)
        {
            lblEditProduct.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnEditProduct_MouseLeave(object sender, EventArgs e)
        {
            lblEditProduct.ForeColor = Color.DimGray;
        }

        private void lblEditProduct_Click(object sender, EventArgs e)
        {
            pnlEditProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlSearchProduct.Visible = false;
        }

        private void btnDeleteProduct_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteProduct.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlDeleteProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlEditProduct.Visible = false;
            pnlSearchProduct.Visible = false;
        }

        private void lblDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlDeleteProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlEditProduct.Visible = false;
            pnlSearchProduct.Visible = false;
        }

        private void btnDeleteProduct_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteProduct.ForeColor = Color.DimGray;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            pnlSearchProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlEditProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
        }

        private void lblSearchProduct_Click(object sender, EventArgs e)
        {
            pnlSearchProduct.Visible = true;
            pnlAddProduct.Visible = false;
            pnlEditProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
        }

        private void btnSearchProduct_MouseEnter(object sender, EventArgs e)
        {
            lblSearchProduct.ForeColor = Color.FromArgb(237, 173, 72);
        }

        private void btnSearchProduct_MouseLeave(object sender, EventArgs e)
        {
            lblSearchProduct.ForeColor = Color.DimGray;
        }

        private void btnConfirmAddProduct_Click(object sender, EventArgs e)
        {
            MyProduct myProduct = new MyProduct();
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                myProduct.ProductNo = lblAddActualProductNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(lblAddActualProductNo, MyEx.toString());

            }

            try
            {
                myProduct.ProductDescription = txtAddProductDescription.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddProductDescription, MyEx.toString());
            }

            try
            {
                myProduct.ProductPrice = Convert.ToDouble (txtAddProductPrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddProductPrice, MyEx.toString());
            }

            try
            {
                myProduct.ProductQty = Convert.ToInt32 (txtAddProductQty.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errorProvider1.SetError(txtAddProductQty, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drProduct = dsSurefill.Tables["Product"].NewRow();

                    drProduct["ProductNo"] = myProduct.ProductNo;
                    drProduct["ProductDescription"] = myProduct.ProductDescription;
                    drProduct["ProductPrice"] = myProduct.ProductPrice;
                    drProduct["ProductQty"] = myProduct.ProductQty;

                    dsSurefill.Tables["Product"].Rows.Add(drProduct);
                    daProduct.Update(dsSurefill, "Product");

                    MessageBox.Show("Product Added");

                    if (MessageBox.Show("Do you want to add another Product?", "Add Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsSurefill.Tables["Product"].Rows.Count);
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        void clearAddForm()
        {
            txtAddProductDescription.Clear();
            txtAddProductPrice.Clear();
            txtAddProductQty.Clear();
        }

        private void getNumber(int noRows)
        {
            drProduct = dsSurefill.Tables["Product"].Rows[noRows - 1];
            lblAddActualProductNo.Text = ("P" + (int.Parse(drProduct["ProductNo"].ToString().Substring(1, 3)) + 1).ToString());
        }

        private void btnConfirmEditProduct_Click(object sender, EventArgs e)
        {
            if (btnConfirmEditProduct.Text == "Edit")
            {
                txtAddProductDescription.Enabled = true;
                txtEditProductPrice.Enabled = true;
                txtEditProductQty.Enabled = true;

                btnConfirmEditProduct.Text = "Save";

            }
            else
            {
                MyProduct myProduct = new MyProduct();
                bool ok = true;
                errorProvider1.Clear();

                try
                {
                    myProduct.ProductNo = lblEditActualProductNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(lblEditActualProductNo, MyEx.toString());

                }

                try
                {
                    myProduct.ProductDescription = txtEditProductDescription.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditProductDescription, MyEx.toString());
                }

                try
                {
                    myProduct.ProductPrice = Convert.ToDouble (txtEditProductPrice.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditProductPrice, MyEx.toString());
                }

                try
                {
                    myProduct.ProductQty = Convert.ToInt32 (txtEditProductQty.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errorProvider1.SetError(txtEditProductQty, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drProduct.BeginEdit();


                        drProduct["ProductNo"] = myProduct.ProductNo;
                        drProduct["ProductDescription"] = myProduct.ProductDescription;
                        drProduct["ProductPrice"] = myProduct.ProductPrice;
                        drProduct["ProductQty"] = myProduct.ProductQty;


                        drProduct.EndEdit();
                        daProduct.Update(dsSurefill, "Product");

                        MessageBox.Show("Product details updated", "Product");

                        txtEditProductDescription.Enabled = false;
                        txtEditProductPrice.Enabled = false;
                        txtEditProductQty.Enabled = false;

                        btnConfirmEditProduct.Text = "Edit";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Product from the list", "Select Product");
            }
            else
            {
                drProduct = dsSurefill.Tables["Product"].Rows.Find(dgvProduct.SelectedRows[0].Cells[0].Value);
                string tempName = drProduct["ProductDescription"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Product", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    drProduct.Delete();
                    daProduct.Update(dsSurefill, "Product");
                }
            }
        }

        private void btnCorfirmSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmCancelSearch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel Product?", "Product", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes);

            pnlSearchProduct.Visible = false;
        }

        private void txtSearchProductDescription_TextChanged(object sender, EventArgs e)
        {
            dsSurefill.Tables["ProdDets"].Clear();
            cmdProductDetails.Parameters["@Letter"].Value = txtSearchProductDescription.Text;
            daProdDetails.Fill(dsSurefill, "ProdDets");
            dgvProduct.DataSource = dsSurefill.Tables["ProdDets"];
        }

        private void btnDeleteProductCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the deletion of Product No: " + lblEditActualProductNo.Text + "?", "Delete Product", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes);
            pnlDeleteProduct.Visible = false;
        }

        private void btnConfirmCancelEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Product No: " + lblEditActualProductNo.Text + "?", "Edit Product", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes);
            pnlEditProduct.Visible = false;
        }

        private void btnConfirmCancelAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Product No: " + lblAddActualProductNo.Text + "?", "Add Product", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes);
            pnlAddProduct.Visible = false;
        }

    }
}
