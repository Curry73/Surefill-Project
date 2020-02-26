using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class MyJobType
    {
        private string jobTypeID, jobTypeDescription;

        public MyJobType()
        {
            this.jobTypeID = "";
            this.jobTypeDescription = "";
        }

        public MyJobType (string jobTypeID, string jobTypeDescription)
        {
            this.jobTypeID = jobTypeID;
            this.jobTypeID = jobTypeDescription;
        }

        public string JobTypeID
        { get => jobTypeID; set => jobTypeID = value; }

        public string JobTypeDescription
        { get => jobTypeDescription; set => jobTypeDescription = value; }
    }
}
