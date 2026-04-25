using MassTransit;
using ReportingService.Data;
using Shared.Contracts;

namespace ReportingService.Consumers
{
    public class EmployeeCheckedInConsumer(AppDbContext context) : IConsumer<EmployeeCheckedIn>
    {
        private readonly AppDbContext _context = context;

        public Task Consume(ConsumeContext<EmployeeCheckedIn> context)
        {
            var message = context.Message;

            Console.WriteLine("========== Reporting ==========");
            Console.WriteLine($"EmployeeId : {message.EmployeeId}");
            Console.WriteLine($"Name       : {message.EmployeeName}");
            Console.WriteLine($"CheckedAt  : {message.CheckedAt}");
            Console.WriteLine("Saved statistics successfully.");
            Console.WriteLine("================================");

            // Save the check-in report to the database
            _context.CheckinReports.Add(new Models.CheckinReport
            {
                EmployeeId = message.EmployeeId,
                EmployeeName = message.EmployeeName,
                CheckedAt = message.CheckedAt
            });

            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
