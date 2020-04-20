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
    public partial class frmPayments : Form
    {
        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daSuppliers, daPayments, daCustomers, daProductOrder, daOrders;
        DataSet dsSurefill = new DataSet();
        SqlConnection conn;
        SqlCommand cmdSupplierDetails, cmdProductDetails, cmdOrders;
        SqlCommandBuilder cmdBSupplier, cmdBOrders, cmdBProducts, cmdBProductOrders;


        DataRow drSupplier;

        String sqlNames, sqlSupplierDetails, sqlProduct, sqlProductDetails, sqlOrders, sqlProductOrder;
        String connStr;
        public frmPayments()
        {
            InitializeComponent();
        }
    }
}
