using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_25.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
