using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerServiceLibrary;
using WindowsClient.CustomerService;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private Customer customer = null;
        private Customer[] customers = null;
        private CustomerDetail customerDetail = null;
        private CustomerServiceClient proxy = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (proxy.SaveChanges(customerDetail.customerId, customerDetail.FirstName, customerDetail.LastName, customerDetail.Address))
            {
                MessageBox.Show("These details are saved");
            }
            else
            {
                MessageBox.Show("This information was not saved");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Retrieve the list of customers
            customers = proxy.ListCustomers();

            CustomerbindingSource.DataSource = customers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer = (Customer)CustomerbindingSource.Current;
            customerDetail = proxy.GetCustomerDetails(customer.customerId);
            CustomerDetailbindingSource.DataSource = customerDetail;
        }


    }
}
