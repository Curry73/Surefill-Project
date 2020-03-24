using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyProduct
    {
        private int productQty;
        private string productNo, productDescription;
        private double productPrice;

        public MyProduct()
        {
            this.productNo = "";
            this.productDescription = "";
            this.productPrice = 0.0;
            this.productQty = 0;
        }

        public MyProduct (String productNo, string productDescription, double productPrice, int productQty)
        {
            this.productNo = productNo;
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.productQty = productQty;
        }

        public string ProductNo
        { get => productNo; set => productNo = value; }

        public int ProductQty
        { get => productQty; set => productQty = value; }

        public string ProductDescription
        { get => productDescription; set => productDescription = value; }

        public double ProductPrice
        { get => productPrice; set => productPrice = value; }
    }
}
