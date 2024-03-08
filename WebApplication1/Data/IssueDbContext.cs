using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; 

namespace WebApplication1.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }

    }
}
