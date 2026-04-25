using AttendanceService.Data;
using AttendanceService.Models;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts;

namespace AttendanceService.Services
{
    public class AttendanceAppService
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly AppDbContext _context;

        public AttendanceAppService(IPublishEndpoint publishEndpoint, AppDbContext context)
        {
            _publishEndpoint = publishEndpoint;
            _context = context;
        }
        public async Task<CheckInResponse> CheckIn(CheckInRequest request)
        {
            var checkedAt = DateTime.UtcNow;

            await _publishEndpoint.Publish(
                new EmployeeCheckedIn(
                    request.EmployeeId,
                    request.EmployeeName,
            checkedAt
            ));

            _context.AttendanceRecords.Add(new AttendanceRecord
            {
                EmployeeId = request.EmployeeId,
                EmployeeName = request.EmployeeName,
                CheckedAt = checkedAt
            });

            await _context.SaveChangesAsync();

            return new CheckInResponse
            {
                Success = true,
                Message = "Checked in successfully.",
                CheckedAt = checkedAt
            };
        }
    }
}
