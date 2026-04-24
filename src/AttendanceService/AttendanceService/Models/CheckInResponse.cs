namespace AttendanceService.Models
{
    public class CheckInResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CheckedAt { get; set; }
    }
}
