using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2_1
{
    class SMSSender : INotificationSender
    {
        public void SendMessage(string to, string message)
        {
            // Симуляция отправки SMS
            Console.WriteLine($"SMS для {to}: {message}");
        }
    }
}
