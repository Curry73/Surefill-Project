using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyProduct
    {
        private int productNo, productQty;
        private string productDescription;
        private double productPrice;

        public MyProduct()
        {
            this.productNo = 0;
            this.productDescription = "";
            this.productPrice = 0.0;
            this.productQty = 0;
        }

        public MyProduct (int productNo, string productDescription, double productPrice, int productQty)
        {
            this.productNo = productNo;
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.productQty = productQty;
        }

        public int ProductNo
        { get => productNo; set => productNo = value; }

        public int ProductQty
        { get => productQty; set => productQty = value; }

        public string ProductDescription
        { get => productDescription; set => productDescription = value; }

        public double ProductPrice
        { get => productPrice; set => productPrice = value; }
    }
}
