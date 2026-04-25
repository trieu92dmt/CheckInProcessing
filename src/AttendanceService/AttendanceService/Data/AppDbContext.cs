using AttendanceService.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<AttendanceRecord> AttendanceRecords => Set<AttendanceRecord>();
    }
}
