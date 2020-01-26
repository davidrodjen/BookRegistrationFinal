using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    public class Customer
    {

        /// <summary>
        /// Customer information standard in the DB
        /// </summary>
        //		CREATE TABLE Customer
        //(
        //	CustomerID  int PRIMARY KEY IDENTITY
        //	, DateOfBirth date    NOT NULL
        //	, FirstName varchar(30) NOT NULL
        //	, LastName   varchar(35) NOT NULL
        //	 , Title      varchar(30) NOT NULL
        //)
        public int CustomerID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }


        /// <summary>
        /// Customer ToString, This is the SURNAME of individual, not the title of a book
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title} {FirstName} {LastName}";
        }


    }
}
