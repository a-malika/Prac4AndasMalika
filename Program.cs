using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProcessingOrder processingOrder = new ProcessingOrder();
            Order order0 = new Order();
            Product product = new Product("Laptop", 200300);
            order0.AddProduct(product);
            order0.AddProduct(product, 3);
            order0.AddProduct(new Product("Notebook", 340000));
            processingOrder.PlaceAnOrder(order0);
            
            Order order1 = new Order(new BankTransferPayment(), new CourierDelivery(), new EmailNotification(), new SilverDiscount());
            order1.AddProduct(new Product("Lipstick", 3000));
            order1.AddProduct(new Product("Crips", 1000), 5);
            order1.AddProduct(new Product("Juece", 300), 6);
            processingOrder.PlaceAnOrder(order1);
        }
    }
}