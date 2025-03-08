using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HalalDatingWebAPI.Entities.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
