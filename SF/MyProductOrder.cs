using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyProductOrder
    {
        private int orderNo, productNo, orderQty;

        public MyProductOrder()
        {
            this.orderNo = 0;
            this.productNo = 0;
            this.orderQty = 0;
        }

        public MyProductOrder(int orderNo, int productNo, int orderQty)
        {
            this.orderNo = orderNo;
            this.productNo = productNo;
            this.orderQty = orderQty;
        }

        public int OrderNo
        { get => orderNo; set => orderNo = value; }

        public int ProductNo
        { get => productNo; set => productNo = value; }

        public int OrderQty
        { get => orderQty; set => orderQty = value; }
    }
}
