using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationFinal
{
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Make a new book object
        /// </summary>
        public Book NewBook { get; set; }

        /// <summary>
        /// AddBook button on the addbook form, sets variables from boxes and creates a new book under conditions of not failing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBookFormBtn_Click(object sender, EventArgs e)
        {
            Book b = new Book()
            {

                ISBN = addBookIsbnTxt.Text,
                Price = Convert.ToDecimal(addBookPriceTxt.Text),
                Title = addBookTitleTxt.Text
                
            };

            NewBook = b;

            try
            {
                BookDB.Add(b);
                DialogResult = DialogResult.OK;
                MessageBox.Show("The book was added?");
            }
            catch
            {
                MessageBox.Show("There are currently server issues");
            }
        }
    }
}
