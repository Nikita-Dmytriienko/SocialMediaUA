using Microsoft.EntityFrameworkCore;

namespace SocialMediaUA.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}
