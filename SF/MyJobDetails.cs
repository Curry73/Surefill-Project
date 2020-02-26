using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyJobDetails
    {
        private int jobNo, productNo, qty;

        public MyJobDetails()
        {
            this.jobNo = 0;
            this.productNo = 0;
            this.qty = 0;
        }

        public MyJobDetails(int jobNo, int productNo, int qty)
        {
            this.jobNo = jobNo;
            this.productNo = productNo;
            this.qty = qty;
        }

        public int JobNo
        { get => jobNo; set => jobNo = value; }

        public int ProductNo
        { get => productNo; set => productNo = value; }

        public int Qty
        { get => qty; set => qty = value; }
    }
}
