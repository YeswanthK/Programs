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

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private Customer customer = null;
        private List<Customer> customers = null;
        private CustomerDetail customerDetail = null;

        private ICustomerService basicHttpchannel = null;
        private ICustomerService wsHttpchannel = null;
        private ICustomerService tcpchannel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basicHttpchannel = new ChannelFactory<CustomerServiceLibrary.ICustomerService>("CustomerService_Http").CreateChannel();
            wsHttpchannel = new ChannelFactory<CustomerServiceLibrary.ICustomerService>("CustomerService_WsHttp").CreateChannel();
            tcpchannel = new ChannelFactory<CustomerServiceLibrary.ICustomerService>("CustomerService_Tcp").CreateChannel();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers = basicHttpchannel.ListCustomers();
            CustomerbindingSource.DataSource = customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer = (Customer)CustomerbindingSource.Current;
            customerDetail = wsHttpchannel.GetCustomerDetails(customer.customerId);
            CustomerDetailbindingSource.DataSource = customerDetail;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tcpchannel.SaveChanges(customerDetail.customerId,
                customerDetail.FirstName,
                customerDetail.LastName,
                customerDetail.Address))
            {
                MessageBox.Show("Changes saved");
            }
            else
            {
                MessageBox.Show("This information is not saved");
            }
        }
    }
}
