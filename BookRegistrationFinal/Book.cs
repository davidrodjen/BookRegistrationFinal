using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    public class Book
    {
        // No Arg Constructor
        public Book()
        {

        }
        // Database structure
        //   ISBN char (13)	PRIMARY KEY
        //   , Price  smallmoney NOT NULL
        //,Title varchar(100)    NOT NULL

        public String ISBN { get; set; }

        public decimal Price { get; set; }

        public String Title { get; set; }

        /// <summary>
        /// ToString method needed for passing to form as text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title}";
        }


    }
}
