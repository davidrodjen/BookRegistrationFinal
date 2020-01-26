using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    public class Registration
    {

        /// <summary>
        /// Structure of Registration table in Database
        /// </summary>
        //CustomerID int REFERENCES Customer(CustomerID)
        //,ISBN char (13) REFERENCES Book(ISBN)
        //,RegDate smalldatetime   NOT NULL
        //, PRIMARY KEY(CustomerID, ISBN)


        public int CustomerID { get; set; }

        public string ISBN { get; set; }

        public DateTime RegDate { get; set; }

    }
}
