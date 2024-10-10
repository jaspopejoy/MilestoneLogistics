using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
