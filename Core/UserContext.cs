using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<UserContext> User { get; set; }
    }
}