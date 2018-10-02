using BASE.Domain;
using Microsoft.EntityFrameworkCore;

namespace BASE.Data
{
    public class BaseContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public BaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}