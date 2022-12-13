using DovizBank.Entity;
using Microsoft.EntityFrameworkCore;

namespace DovizBank.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<UserCurrency> UserCurrencies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initilializer.Build();
            optionsBuilder.UseSqlServer(Initilializer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}
