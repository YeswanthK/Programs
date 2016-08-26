using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomerServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> ListCustomers();

        [OperationContract]
        CustomerDetail GetCustomerDetails(int customerId);

        [OperationContract]
        bool SaveChanges(int customerId, string FirstName, string LastName, string Address);
    }
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int customerId { get; set; }

        [DataMember]
        public string FirstName { get; set; }
    }
    [DataContract]
    public class CustomerDetail
    {
        [DataMember]
        public int customerId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

    }
}
