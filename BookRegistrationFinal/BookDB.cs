using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationFinal
{
    class BookDB
    {
        /// <summary>
        /// Get a collection of books as a list that currently are in the DB
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetAllBooks()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText =
                "SELECT ISBN, Price, Title " +
                "FROM Book ";// +
                //"ORDER BY Title";

            con.Open();

            SqlDataReader rdr = selCmd.ExecuteReader();

            var Book = new List<Book>();
            while (rdr.Read())
            {
                Book tempBook = new Book();
                tempBook.ISBN = (String)rdr["ISBN"];
                tempBook.Price = (Decimal)rdr["Price"];
                tempBook.Title = (String)rdr["Title"];

                Book.Add(tempBook);

            }

            con.Close();
            return Book;

        }

        /// <summary>
        /// Adds a book to DB
        /// </summary>
        /// <param name="b"></param>
        public static void Add(Book b)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText =
                 "INSERT INTO Book (ISBN, Price, Title) " +
                "VALUES (@ISBN, @Price, @Title)";
            addCommand.Parameters.AddWithValue("@ISBN", b.ISBN);
            addCommand.Parameters.AddWithValue("@Price", b.Price);
            addCommand.Parameters.AddWithValue("@Title", b.Title);

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
