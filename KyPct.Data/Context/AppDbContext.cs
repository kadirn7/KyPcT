using KyPcT.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace KyPct.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
