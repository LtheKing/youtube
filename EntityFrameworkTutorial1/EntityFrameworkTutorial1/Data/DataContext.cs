using EntityFrameworkTutorial1.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTutorial1.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=M21-010B;Database=EFTutorialYoutube;User Id=xtremax_sa;Password=th3ZetaLion!;" +
                "Trusted_Connection=false;TrustServerCertificate=true;MultipleActiveResultSets=true;");
        }
    }
}
