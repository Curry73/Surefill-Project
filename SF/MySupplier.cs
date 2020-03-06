using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MySupplier
    {
        private string supplierNo, name, street, town, county, postcode, email, telephoneNo;


        public MySupplier()
        {
            this.supplierNo = "";
            this.name = "";
            this.street = "";
            this.town = "";
            this.postcode = "";
            this.county = "";
            this.email = "";
            this.telephoneNo = "";

        }

        public MySupplier(string supplierNo, string name, string street, string town, string county, string postcode, string email, string telephoneNo)

        {
            this.supplierNo = supplierNo;
            this.name = name;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.email = email;
            this.telephoneNo = telephoneNo;
        }

        public string SupplierNo
        { get => supplierNo; set => supplierNo = value; }

        public string Name
        { get => name; set => name = value; }

        public string Street
        { get => street; set => street = value; }

        public string Town
        { get => town; set => town = value; }

        public string County
        { get => county; set => county = value; }

        public string Postcode
        { get => postcode; set => postcode = value; }

        public string Email
        { get => email; set => email = value; }

        public string TelephoneNo
        { get => telephoneNo; set => telephoneNo = value; }

    }
}
