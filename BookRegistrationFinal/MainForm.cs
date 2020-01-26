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
    public partial class bookRegForm : Form
    {
        public bookRegForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Add a customer by bringing up the addCustomerForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            addCustomerForm addCustomer = new addCustomerForm();

            DialogResult result = addCustomer.ShowDialog();

            if(result == DialogResult.OK)
            {
                PopulateCustomerList();
            }
        }

        /// <summary>
        /// Populate the customer list, ordering the customer list will cause errors, adds customer object to the box
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> allCustomers = CustomerDB.GetAllCustomers();


            // Start with a blank list
            customerNameBx.Items.Clear();

            // Add the students to the list
            foreach (Customer c in allCustomers)
            {
                customerNameBx.Items.Add(c);
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            addBookForm addBook = new addBookForm();

            DialogResult result = addBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                PopulateBookList();
            }
        }

        /// <summary>
        /// Populates the book list and adds book object to the box
        /// </summary>
        private void PopulateBookList()
        {
            List<Book> allBooks = BookDB.GetAllBooks();

            //allBooks = allBooks.OrderByDescending(b => b.Title).ToList();

            // Start with a blank list
            bookNameBx.Items.Clear();

            // Add the books to the list
            foreach (Book b in allBooks)
            {
                bookNameBx.Items.Add(b);
            }
        }

        /// <summary>
        /// Windows Mainform load event, calling two methods that populate the objects into the boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateBookList();
            PopulateCustomerList();
            
        }

        //Don't forget to make the class public
        public Registration newReg { get; set; }

        /// <summary>
        /// RegisterBook, opens the register book form and adds adds information upon confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBookBtn_Click(object sender, EventArgs e)
        {
            Confirmation confirm = new Confirmation();

            DialogResult result = confirm.ShowDialog();

            if(result == DialogResult.OK)
            {

            //Get the customer
            Customer c = (Customer)customerNameBx.SelectedItem;

            Book b = (Book)bookNameBx.SelectedItem;

            Registration reggyBooky = new Registration()
            {
                CustomerID = c.CustomerID,

                ISBN = b.ISBN,

                RegDate = dateRegisterDtp.Value
            };

            newReg = reggyBooky;

            //Add the variable object to the database
            BookRegistrationDB.RegisterBook(reggyBooky);
            }

        }
    }
}
