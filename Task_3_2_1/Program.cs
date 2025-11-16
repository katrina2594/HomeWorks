using Microsoft.Extensions.DependencyInjection;

namespace Task_3_2_1
{
    internal class Program
    {
        static void Main()
        {
            string number = "";
            do
            {
                Console.WriteLine("Куда отправлять уведомление? Email(Нажмите 1), SMS(Нажмите 2)");
                number = Console.ReadLine();
            }
            while (!number.Equals("1") && !number.Equals("2"));
           
            

           ServiceCollection services = new ServiceCollection();
            if(number.Equals("1"))
                services.AddSingleton<INotificationSender, EmailSender>();

            else
                services.AddSingleton<INotificationSender, SMSSender>();
            services.AddSingleton<ILogger, FileLogger>();
            services.AddSingleton<NotificationService>();

            ServiceProvider provider = services.BuildServiceProvider();

            var service = provider.GetRequiredService<NotificationService>();
            
            service.SendNotification("Ваш заказ готов", "user@example.com");
        }
    }
}
