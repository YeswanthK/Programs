using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using WindowsClient.OrderService;


namespace WindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Product product = null;
        private Product[] products = null;
        private CartItem cartItem = null;
        private CartItem[] cartItems = null;
        private OrderServiceClient proxy = null;
        private bool newCart = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new OrderServiceClient("OrderService_Tcp");
            products = proxy.ListProducts();
            productbindingSource.DataSource = products;
            proxy = null;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            product = (Product)productbindingSource.Current;
            if (newCart == true)
            {
                proxy = new OrderServiceClient("OrderService_Tcp");
                try
                {
                    proxy.EmptyCart();
                }
                catch (FaultException faultException)
                {
                    MessageBox.Show(faultException.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                newCart = false;
            }
            cartItem = new CartItem();
            cartItem.ProductId = product.ProductId;
            cartItem.ProductName = product.ProductName;
            cartItem.Quantity = Convert.ToInt32(quantityTextBox.Text);
            cartItem.UnitPrice = product.UnitPrice;
            try
            {
                proxy.AddToCart(cartItem);
                MessageBox.Show(String.Format("{0} {1}s at {2:C} were added to the cart", cartItem.Quantity, cartItem.ProductName, cartItem.UnitPrice));
            }
            catch (FaultException faultException)
            {
                MessageBox.Show(faultException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                cartItems = proxy.ListCart();
                cartListBox.Items.Clear();
                foreach (CartItem cartItem in cartItems)
                {
                    cartListBox.Items.Add(String.Format("{0} {1}s at {2:C} were added to the cart", cartItem.Quantity, cartItem.ProductName, cartItem.UnitPrice));
                }
            }
            catch (FaultException faulException)
            {
                MessageBox.Show(faulException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
