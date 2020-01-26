using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    class DBHelper
    {
        /// <summary>
        /// Establish the connection to the Database, can be altered depending on server location
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string con = @"Data Source = (localdb)\MSSQLLocalDB; " +
                "Initial Catalog=BookRegistration;" +
                "Integrated Security=True;";
            return new SqlConnection(con);

        }//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True;
        //Server=;Database=tinyClothes;Trusted_Connection=True
    }
}
