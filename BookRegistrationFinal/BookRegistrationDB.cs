using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    static class BookRegistrationDB
    {   
        /// <summary>
        /// Confirmation bool for if the user want's to register
        /// </summary>
        /// <param name="regBook"></param>
        /// <returns></returns>
        public static bool RegisterBook(Registration regBook)
        {
            if(Add(regBook) == true)
            {
                System.Windows.Forms.MessageBox.Show("The registration was successful");
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("This did not work");
                return false;
            }
        }


        /// <summary>
        /// Add method for the Registration DB
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool Add(Registration r)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText = "INSERT INTO Registration (CustomerID, ISBN, RegDate)" +
                "VALUES (@CustomerID, @ISBN, @RegDate)";
            addCommand.Parameters.AddWithValue("@CustomerID", r.CustomerID);
            addCommand.Parameters.AddWithValue("@ISBN", r.ISBN);
            addCommand.Parameters.AddWithValue("@RegDate", r.RegDate);

            try
            {
                con.Open();
                addCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally 
            {
                con.Dispose();
            }
        }
        
    }
}
