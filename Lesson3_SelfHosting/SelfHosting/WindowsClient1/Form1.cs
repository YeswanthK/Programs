using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using CustomerServiceLibrary;

namespace WindowsClient1
{
    public partial class Form1 : Form
    {
        private Customer customer = null;
        private List<Customer> customers = null;
        private CustomerDetail customerDetail = null;
        private ICustomerService channel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var endPoint = new EndpointAddress("net.tcp://localhost:9000/CustomerService");
            channel = ChannelFactory<ICustomerService>.CreateChannel(new NetTcpBinding(), endPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers = channel.ListCustomers();
            CustomerbindingSource.DataSource = customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer = (Customer)CustomerbindingSource.Current;
            customerDetail = channel.GetCustomerDetails(customer.customerId);
            CustomerDetailbindingSource.DataSource = customerDetail;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (channel.SaveChanges(customerDetail.customerId, customerDetail.FirstName, customerDetail.LastName, customerDetail.Address))
            {
                MessageBox.Show("Changes saved successfully");
            }
            else
            {
                MessageBox.Show("This information was not saved");
            }
        }
    }
}
