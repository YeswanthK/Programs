using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void EmptyCart();

        [OperationContract]
        void AddToCart(CartItem cartItem);

        [OperationContract]
        List<CartItem> ListCart();

        [OperationContract]
        List<Product> ListProducts();
    }
    
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }
    }

    [DataContract]
    public class CartItem
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }
    }
}
