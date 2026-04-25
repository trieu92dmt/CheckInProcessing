namespace NotificationService.Models
{
    public class NotificationLog
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public DateTime SentAt { get; set; }
    }
}
