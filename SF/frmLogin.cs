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
    public partial class frmLogin : Form
    {
        String connStr, sqlLogin;
        SqlDataAdapter daLogin;
        DataSet dsSurefill = new DataSet();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Surefill; Integrated Security = true";
            sqlLogin = "Select * from LoginTable Where username = '" + txtUsername.Text.Trim() + "' and pword = '" + txtPassword.Text.Trim() + "'";
            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            //cmdBLogin = new SqlCommandBuilder(daLogin);
            //daLogin.FillSchema(dsSurefill, SchemaType.Source, "LoginTable");
            //daLogin.Fill(dsSurefill, "LoginTable");
            DataTable LoginDT = new DataTable();
            daLogin.Fill(LoginDT);

            if(LoginDT.Rows.Count ==1)
            {
                frmMenu frmMenu = new frmMenu();
                this.Hide();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login details, click OK to retry","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
