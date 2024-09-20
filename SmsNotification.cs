using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class SmsNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Отправка уведомления на смс");
            Console.WriteLine(message);
            //Логика отправки уведомления
        }
    }
}
