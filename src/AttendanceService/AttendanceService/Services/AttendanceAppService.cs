using AttendanceService.Models;

namespace AttendanceService.Services
{
    public class AttendanceAppService
    {
        public CheckInResponse CheckIn(CheckInRequest request)
        {
            return new CheckInResponse
            {
                Success = true,
                Message = $"Employee {request.EmployeeName} checked in successfully.",
                CheckedAt = DateTime.UtcNow
            };
        }
    }
}
