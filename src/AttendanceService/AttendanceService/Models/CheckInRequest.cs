using System.ComponentModel.DataAnnotations;

namespace AttendanceService.Models
{
    public class CheckInRequest
    {
        [Required]
        public string EmployeeId { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
    }
}
