using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyCustomer
    {
        private string customerNo, forename, surname, street, town, postcode, email, telephoneNo, county;


        public MyCustomer()
        {
            this.customerNo = "";
            this.forename = "";
            this.surname = "";
            this.street = "";
            this.town = "";
            this.postcode = "";
            this.email = "";
            this.telephoneNo = "";
            this.county = "";
        }

        public MyCustomer(string customerNo, string forename, string surname, string street, string town, string postcode, string email, string telephoneNo, string county)

        {
            this.customerNo = customerNo;
            this.forename = forename;
            this.surname = surname;
            this.street = street;
            this.town = town;
            this.postcode = postcode;
            this.email = email;
            this.telephoneNo = telephoneNo;
            this.county = county;
        }

        public string CustomerNo
        { get => customerNo; set => customerNo = value; }

        public string Forename
        { get => forename; set => forename = value; }

        public string Surname
        { get => surname; set => surname = value; }

        public string Street
        { get => street; set => street = value; }

        public string Town
        { get => town; set => town = value; }

        public string Postcode
        { get => postcode; set => postcode = value; }

        public string Email
        { get => email; set => email = value; }

        public string TelephoneNo
        { get => telephoneNo; set => telephoneNo = value; }

        public string County
        { get => county; set => county = value; }
    }
}
