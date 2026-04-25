using MassTransit;
using NotificationService.Data;
using NotificationService.Models;
using Shared.Contracts;

namespace NotificationService.Consumers
{
    public class EmployeeCheckedInConsumer(AppDbContext context) : IConsumer<EmployeeCheckedIn>
    {
        private readonly AppDbContext _context = context;

        public Task Consume(ConsumeContext<EmployeeCheckedIn> context)
        {
            var message = context.Message;

            Console.WriteLine("========== Notification ==========");
            Console.WriteLine($"Send mail to: {message.EmployeeName}");
            Console.WriteLine($"EmployeeId : {message.EmployeeId}");
            Console.WriteLine($"CheckedAt  : {message.CheckedAt}");
            Console.WriteLine("Mail sent successfully.");
            Console.WriteLine("==================================");

            // Here you can also save the notification record to the database if needed
            _context.NotificationLogs.Add(new NotificationLog
            {
                EmployeeId = message.EmployeeId,
                EmployeeName = message.EmployeeName,
                SentAt = DateTime.Now
            });

            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
