using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class ProcessingOrder
    {
        public void PlaceAnOrder(Order order)
        {
            Console.WriteLine($"Общая цена заказа с учетом скидки: {order.CalculateTotalPrice()}.");
            order.PaymentMethod.ProcessPayment(order.CalculateTotalPrice());
            order.DeliveryMethod.DeliverOrder(order);
            order.NotificationMethod.SendNotification("Заказ оплачен.");
        }
    }
}
