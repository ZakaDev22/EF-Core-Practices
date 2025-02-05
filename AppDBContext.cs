using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace EF_Core_Practices
{
    public class AppDBContext : DbContext
    {
        public DbSet<Students> students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            var config = new ConfigurationBuilder()
                       .AddJsonFile("appSettings.json")
                       .Build();
            var ConnectionString = config.GetSection("ConnectionStrings").Value;

            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
