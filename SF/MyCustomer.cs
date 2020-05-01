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
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 letters");
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }
        }

        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-20 letters");
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Postcode must be 7-8 letters and alphanumeric only");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validEmail(value))
                {
                    email = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Email must be 2-30 letters");
            }
        }

        public string TelephoneNo
        {
            get { return telephoneNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telephoneNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }
        }
    }
}
