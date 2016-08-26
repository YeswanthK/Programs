using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomerServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults =true)] //Override the web.config in C# code
    public class CustomerService : ICustomerService
    {
        private CustomerDetail customerDetail = null;
        private Customer customer = null;
        private List<Customer> customers = null;

        private string querystring = string.Empty;
        private string updateString = string.Empty;
        private int numRowsChanged = 0;

        public List<Customer> ListCustomers()
        {
            customers = new List<Customer>();

            using (var cnn = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                using (var cmd = new SqlCommand(
                    "SELECT CustomerId,FirstName " +
                    "FROM Tbl_Customers ORDER BY CustomerId", cnn))
                {
                    try
                    {
                        cnn.Open();
                    }
                    catch (Exception ex)
                    {
                        //throw new FaultException("Unable to connect to SQL Server");

                        //throw new Exception(ex.Message);
                        //throw new FaultException("Unable to connect to SQL Server", new FaultCode("DbConnection"));

                        //    var reasons = new List<FaultReasonText>();
                        //    reasons.Add(new FaultReasonText(
                        //        "Can't connect to database", new CultureInfo("en-US")));
                        //    reasons.Add(new FaultReasonText(
                        //        "No se puede conectar a la base de datos", new CultureInfo("es-ES")));
                        //    reasons.Add(new FaultReasonText(
                        //        "Impossible de se connecter a la base de donnees", new CultureInfo("fr-FR")));
                        //    reasons.Add(new FaultReasonText(
                        //        "Impossibile  connetersi al database", new CultureInfo("it-IT")));
                        //    throw new FaultException(new FaultReason(reasons), new FaultCode("DbConnection"));

                        var connectionFault = new ConnectionFault();
                        connectionFault.Operation = "ListCustomers";
                        connectionFault.Reason = "Can't connect to database";
                        connectionFault.details = ex.Message;
                        throw new FaultException<ConnectionFault>(connectionFault);
                    }
                    try
                    {
                        using (SqlDataReader CustomersReader = cmd.ExecuteReader())
                        {
                            while (CustomersReader.Read())
                            {
                                customer = new Customer();
                                customer.customerId = CustomersReader.GetInt32(20);//Error made to throw exception in this line
                                customer.FirstName = CustomersReader.GetString(1);
                                customers.Add(customer);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new FaultException("Error reading from the database");
                        //throw new Exception(ex.Message);
                        //throw new FaultException("Error reading from the database", new FaultCode("DbReader"));

                        var dataFault = new DataFault();
                        dataFault.Operation = "ListCustomers";
                        dataFault.Reason = "Error reading from the database";
                        dataFault.details = ex.Message;
                        throw new FaultException<DataFault>(dataFault);
                    }

                }

            }
            return customers;
        }

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
