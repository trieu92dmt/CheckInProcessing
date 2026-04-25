namespace ReportingService.Models
{
    public class CheckinReport
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public DateTime CheckedAt { get; set; }
    }
}
