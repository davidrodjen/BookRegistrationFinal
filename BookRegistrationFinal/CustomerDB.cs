using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    class CustomerDB
    {
        /// <summary>
        /// Create a list for the customers named customer, using the SQl server connection
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetAllCustomers()
        {
            // Establish connection to the DB
            SqlConnection con = DBHelper.GetConnection();

            // Setup query
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT CustomerID, " +
                "DateOfBirth, FirstName, " +
                "LastName, Title " +
                "FROM Customer " +
                "ORDER BY LastName";

            // Open connection
            con.Open();

            // Send query to DB
            SqlDataReader reader = selectCmd.ExecuteReader();

            // Do something w results
            var customers = new List<Customer>();
            while (reader.Read())
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CustomerID = (int)reader["CustomerID"];
                tempCustomer.DateOfBirth = (DateTime)reader["DateOfBirth"];
                tempCustomer.FirstName = (string)reader["FirstName"];
                tempCustomer.LastName = (string)reader["LastName"];
                tempCustomer.Title = (string)reader["Title"];

                customers.Add(tempCustomer);
            }

            // Close DB connection
            con.Close();
            return customers;
        }
        /// <summary>
        /// Adds Customer To DB
        /// </summary>
        /// <param name="c"></param>
        public static void Add(Customer c)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText = "INSERT INTO Customer (DateOfBirth, FirstName, LastName, Title) " +
                "VALUES (@DateOfBirth, @FName, @LName, @Title)";
            addCommand.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);
            addCommand.Parameters.AddWithValue("@FName", c.FirstName);
            addCommand.Parameters.AddWithValue("@LName", c.LastName);
            addCommand.Parameters.AddWithValue("@Title", c.Title);

            try
            {
                con.Open();
                addCommand.ExecuteNonQuery();
            }
            catch
            {
                con.Dispose();
            }
        }






    }
}
