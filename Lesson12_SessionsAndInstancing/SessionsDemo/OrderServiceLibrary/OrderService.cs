using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrderService : IOrderService
    {
        private Product product = null;
        private List<Product> products = null;
        private List<CartItem> cartItems = null;

        public void EmptyCart()
        {
            try
            {
                cartItems = new List<CartItem>();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void AddToCart(CartItem cartItem)
        {
            try
            {
                cartItems.Add(cartItem);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<CartItem> ListCart()
        {
            try
            {
                return cartItems;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<Product> ListProducts()
        {
            products = new List<Product>();
            try
            {
                using (var cnn = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
                {
                    using (var cmd = new SqlCommand(
                        "SELECT ProductId,MovieName,Price " +
                        "FROM Tbl_Movies ORDER BY ProductId", cnn))
                    {
                        cnn.Open();
                        using (SqlDataReader productsReader = cmd.ExecuteReader())
                        {
                            while (productsReader.Read())
                            {
                                product = new Product();
                                product.ProductId = productsReader.GetInt32(0);
                                product.ProductName = productsReader.GetString(1);
                                product.UnitPrice = productsReader.GetDecimal(2);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
