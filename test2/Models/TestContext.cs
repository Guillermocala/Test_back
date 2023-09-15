using Microsoft.EntityFrameworkCore;

namespace CreateDb.Models
{
    public class TestContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UserServices> UserServices { get; set; }

        public TestContext(DbContextOptions options) : base(options)
        {
        }
    }
}