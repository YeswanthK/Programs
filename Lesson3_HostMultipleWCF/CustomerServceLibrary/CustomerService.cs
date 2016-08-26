using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomerServceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        private CustomerDetail customerDetail = null;
        private Customer customer = null;
        private List<Customer> customers = null;

        private string querystring = string.Empty;
        private string updateString = string.Empty;
        private int numRowsChanged = 0;

        public CustomerDetail GetCustomerDetails(int customerId)
        {
            customerDetail = new CustomerDetail();
            using (var cnn = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                using (var cmd = new SqlCommand(
                    "SELECT CustomerId,FirstName,LastName,Address FROM Tbl_Customers " +
                    "WHERE CustomerId=@customerId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@customerId", customerId));
                    cnn.Open();
                    using (SqlDataReader CustomersReader = cmd.ExecuteReader())
                    {
                        while (CustomersReader.Read())
                        {
                            customerDetail.customerId = CustomersReader.GetInt32(0);
                            customerDetail.FirstName = CustomersReader.GetString(1);
                            customerDetail.LastName = CustomersReader.GetString(2);
                            customerDetail.Address = CustomersReader.GetString(3);
                        }
                    }
                }
            }
            return customerDetail;
        }

        public List<Customer> ListCustomers()
        {
            customers = new List<Customer>();

            using (var cnn = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                using (var cmd = new SqlCommand(
                    "SELECT CustomerId,FirstName " +
                    "FROM Tbl_Customers ORDER BY CustomerId", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader CustomersReader = cmd.ExecuteReader())
                    {
                        while (CustomersReader.Read())
                        {
                            customer = new Customer();
                            customer.customerId = CustomersReader.GetInt32(0);
                            customer.FirstName = CustomersReader.GetString(1);
                            customers.Add(customer);
                        }
                    }
                }

            }
            return customers;
        }

        public bool SaveChanges(int customerId, string FirstName, string LastName, string Address)
        {
            using (var cnn = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                using (var cmd = new SqlCommand(
                    "UPDATE Tbl_Customers " +
                    "SET FirstName=@FirstName, " +
                    "LastName=@LastName, " +
                    "Address=@Address " +
                    "WHERE CustomerId=@customerId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", LastName));
                    cmd.Parameters.Add(new SqlParameter("@Address", Address));
                    cmd.Parameters.Add(new SqlParameter("@customerId", customerId));
                    cnn.Open();
                    numRowsChanged = (int)cmd.ExecuteNonQuery();
                }
            }
            return (numRowsChanged != 0);
        }
    }
}
