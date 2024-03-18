using KyPcT.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


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

        protected override void OnModelCreating(ModelBuilder builder)
        {
           // builder.Entity<Article>().Property(x=>x.Title).HasMaxLength(150);
            // bu üstte yaptığımız da aynı mapping sınıfındaki gibi configure etmemizi sağlıyor
            // ama clean kod yapmak istedğimiz için pekte verimli değil.
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Mappingdeki bütün tanımlamaları tek bir seferde yapmak için kullanılıyor.
        }
    }
}
