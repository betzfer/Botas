using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Botas.Models;

namespace Botas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Botas.Models.Bota> Bota { get; set; } = default!;
        public DbSet<Botas.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<Botas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Botas.Models.Venda> Venda { get; set; } = default!;
    }
}
