﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsClient.OrderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/EmptyCart", ReplyAction="http://tempuri.org/IOrderService/EmptyCartResponse")]
        void EmptyCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddToCart", ReplyAction="http://tempuri.org/IOrderService/AddToCartResponse")]
        void AddToCart(OrderServiceLibrary.CartItem cartItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ListCart", ReplyAction="http://tempuri.org/IOrderService/ListCartResponse")]
        OrderServiceLibrary.CartItem[] ListCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ListProducts", ReplyAction="http://tempuri.org/IOrderService/ListProductsResponse")]
        OrderServiceLibrary.Product[] ListProducts();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : WindowsClient.OrderService.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<WindowsClient.OrderService.IOrderService>, WindowsClient.OrderService.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void EmptyCart() {
            base.Channel.EmptyCart();
        }
        
        public void AddToCart(OrderServiceLibrary.CartItem cartItem) {
            base.Channel.AddToCart(cartItem);
        }
        
        public OrderServiceLibrary.CartItem[] ListCart() {
            return base.Channel.ListCart();
        }
        
        public OrderServiceLibrary.Product[] ListProducts() {
            return base.Channel.ListProducts();
        }
    }
}