using Microsoft.EntityFrameworkCore;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Banner> Banner { get; set; }

    }
}
