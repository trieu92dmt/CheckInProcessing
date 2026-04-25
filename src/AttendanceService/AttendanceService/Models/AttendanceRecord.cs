namespace AttendanceService.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public DateTime CheckedAt { get; set; }
    }
}
