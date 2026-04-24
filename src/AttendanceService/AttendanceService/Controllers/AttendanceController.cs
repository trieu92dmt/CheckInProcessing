using AttendanceService.Models;
using AttendanceService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceAppService _service;

        public AttendanceController(AttendanceAppService service)
        {
            _service = service;
        }

        [HttpPost("checkin")]
        public IActionResult CheckIn(CheckInRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.EmployeeId))
                return BadRequest("EmployeeId is required.");

            if (string.IsNullOrWhiteSpace(request.EmployeeName))
                return BadRequest("EmployeeName is required.");

            var result = _service.CheckIn(request);

            return Ok(result);
        }
    }
}
