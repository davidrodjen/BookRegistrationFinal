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
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        public Customer NewCustomer { get; set; }

        
        /// <summary>
        /// This sets the new customer and attempts to add the object, failure prompts message 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerFormBtn(object sender, EventArgs e)
        {
            Customer c = new Customer()
            {

                FirstName = custFirstNameTxt.Text,
                LastName = custLastNameTxt.Text,
                Title = addCustTitle.Text,
                DateOfBirth = addCustDOBDTP.Value

            };


            NewCustomer = c;

            try
            {
                CustomerDB.Add(c);
                DialogResult = DialogResult.OK;
                MessageBox.Show("The customer was added!");
            }
            catch
            {
                MessageBox.Show("There are currently server issues");
            }

        }
    }
}
