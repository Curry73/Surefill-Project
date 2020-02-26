using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyOrders
    {
        private int orderNo;
        private DateTime orderDate;
        private string supplierNo;

        public MyOrders()
        {
            this.orderNo = 0;
            this.orderDate = new DateTime(2020, 01, 01);
            this.supplierNo = "";
        }

        public MyOrders (int orderNo, DateTime orderDate, string supplierNo)
        {
            this.orderNo = orderNo;
            this.orderDate = orderDate;
            this.supplierNo = supplierNo; 
        }

        public int OrderNo
        { get => orderNo; set => orderNo = value; }

        public DateTime OrderDate
        { get => orderDate; set => orderDate = value; }

        public string SupplierNo
        { get => supplierNo; set => supplierNo = value; }
    }
}
