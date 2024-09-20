using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class Order
    {
        public Dictionary<Product, int> Products { get; private set; } 
        public IPayment PaymentMethod { get; set; }
        public IDelivery DeliveryMethod { get; set; }
        public INotification NotificationMethod { get; set; }
        public IDiscount DiscountMethod { get; set; }
        public Order()
        {
            Products = new Dictionary<Product, int>();
            PaymentMethod = new CreditCardPayment();
            DeliveryMethod = new PostDelivery();
            NotificationMethod = new SmsNotification();
            DiscountMethod = new NoDiscount();
            NotificationMethod.SendNotification("Заказ создан.");
        }
        public Order(IPayment paymentMethod, IDelivery deliveryMethod, INotification notificationMethod, IDiscount discountMethod)
        {
            PaymentMethod = paymentMethod;
            DeliveryMethod = deliveryMethod;
            NotificationMethod = notificationMethod;
            DiscountMethod = discountMethod;
            Products = new Dictionary<Product, int>();
            NotificationMethod.SendNotification("Заказ создан.");
        }
        public void AddProduct(Product item, int count = 1)
        {
            if (Products.ContainsKey(item))
            {
                Products[item] += count;
            }
            else
            {
                Products.Add(item, count);
            }
        }
        public double CalculateTotalPrice()
        {
            int total = 0;
            foreach (var item in Products) 
            {
                total += item.Key.Price * item.Value;
            }
            return DiscountMethod.CalculateDiscount(total);
        }
    }
}
