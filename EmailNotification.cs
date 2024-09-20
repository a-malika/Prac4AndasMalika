using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Отправка уведомления на почту");
            Console.WriteLine(message);
            //Логика отправки уведомления
        }
    }
}
