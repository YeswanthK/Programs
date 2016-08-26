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
            proxy = new CustomerServiceClient("WSHttpBinding_ICustomerService");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Retrieve the list of customers
                customers = proxy.ListCustomers();

                CustomerbindingSource.DataSource = customers;
            }
            catch (FaultException<ConnectionFault> connectionException)
            {
                MessageBox.Show(String.Format("{0}\n\n" +
                    "The following error occured in the {1}:\n{2}",
                    connectionException.Detail.Reason,
                    connectionException.Detail.Operation,
                    connectionException.Detail.details));
            }
            catch (FaultException<DataFault> dataException)
            {
                MessageBox.Show(String.Format("{0}\n\n" +
                    "The following error occured in the {1}:\n{2}",
                    dataException.Detail.Reason,
                    dataException.Detail.Operation,
                    dataException.Detail.details));
            }
            //catch(FaultException faultException)
            //{
            //    switch (faultException.Code.Name)
            //    {
            //        case "DbConnection":
            //            MessageBox.Show(faultException.Message + "\n\n" + "Try again later.", "Connection problem");
            //            break;
            //        case "DbReader":
            //            MessageBox.Show(faultException.Message + "\n\n" + "Contact the administrator", "Reading problem");
            //            break;
            //        default:
            //            MessageBox.Show(faultException.Message + "\n\n" + "Contact the administrator", "Unknown problem");
            //            break;
            //    }
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

        private void button3_Click(object sender, EventArgs e)
        {
            customer = (Customer)CustomerbindingSource.Current;
            customerDetail = proxy.GetCustomerDetails(customer.customerId);
            CustomerDetailbindingSource.DataSource = customerDetail;
        }


    }
}

