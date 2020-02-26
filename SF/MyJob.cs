using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyJob
    {
        private int jobNo;
        private DateTime jobDate;
        private string customerNo, jobCompletion, jobTypeID;

        public MyJob()
        {
            this.jobNo = 0;
            this.jobDate = new DateTime(2020, 01, 01);
            this.customerNo = "";
            this.jobCompletion = "";
            this.jobTypeID = "";
        }

        public MyJob (int jobNo, DateTime jobDate, string customerNo, string jobCompletion, string jobTypeID)
        {
            this.jobNo = jobNo;
            this.jobDate = jobDate;
            this.customerNo = customerNo;
            this.jobCompletion = jobCompletion;
            this.jobTypeID = jobTypeID;
        }

        public int JobNo
        { get => jobNo; set => jobNo = value; }


        public DateTime JobDate
        { get => jobDate; set => jobDate = value; }


        public string CustomerNo
        { get => customerNo; set => customerNo = value; }


        public string JobCompletion
        { get => jobCompletion; set => jobCompletion = value; }


        public string JobTypeID
        { get => jobTypeID; set => jobTypeID = value; }
    }
}
