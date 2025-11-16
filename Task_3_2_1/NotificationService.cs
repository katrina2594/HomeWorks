using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2_1
{
    class NotificationService
    {
        private readonly INotificationSender _sender;
        private readonly ILogger _logger;

        public NotificationService(INotificationSender sender, ILogger logger)
        {
            _sender = sender;
            _logger = logger;
        }



        public void SendNotification(string message, string recipient)
        {
            // Логика подготовки уведомления
            string formattedMessage = $"Уведомление: {message}";

            // Отправка email
            _sender.SendMessage(recipient, formattedMessage);

           
            _logger.Log($"Отправлено уведомление для {recipient}");
        }
    }
}
