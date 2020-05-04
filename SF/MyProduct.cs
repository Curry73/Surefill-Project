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
        private string productNo, productDescription, supplierNo;
        private double productPrice;

        public MyProduct()
        {
            this.productNo = "";
            this.productDescription = "";
            this.productPrice = 0.0;
            this.productQty = 0;
            this.supplierNo = "";
        }

        public MyProduct (String productNo, string productDescription, string supplierNo, double productPrice, int productQty)
        {
            this.productNo = productNo;
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.productQty = productQty;
            this.supplierNo = supplierNo;
        }

        public string ProductNo
        { get => productNo; set => productNo = value; }

        public int ProductQty
        { get => productQty; set => productQty = value; }

        //public int ProductQty
        //{
        //    get { return productQty; }
        //    set
        //    {
        //        if (MyValidation.validNumber(value) && MyValidation.validLetterWhitespace(value))
        //        {
        //            productQty = MyValidation.firstLetterEachWordToUpper(value);
        //        }
        //        else
        //            throw new MyException("County must be 2-20 letters");
        //    }
        //}


        public string ProductDescription
        {
            get { return productDescription; }
            set
            {
                if (MyValidation.validLength(value, 1, 20) && MyValidation.validLetterWhitespace(value))
                {
                    productDescription = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-20 letters");
            }
        }

        public double ProductPrice
        { get => productPrice; set => productPrice = value; }

        public string SupplierNo
        { get => supplierNo; set => supplierNo = value; }
    }
}
