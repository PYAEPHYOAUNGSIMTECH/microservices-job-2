using Microsoft.EntityFrameworkCore;

namespace taxi_bookingAPI.Models
{
    public class bookingContext: DbContext
    {
        public bookingContext(DbContextOptions<bookingContext> options)
               : base(options)
        {
        }

        public DbSet<booking> bookings { get; set; } = null!;
    }
}
