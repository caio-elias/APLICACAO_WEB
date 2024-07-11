using Microsoft.EntityFrameworkCore;

namespace Aplicacao_Web.Data
{
    public class Aplicacao_WebContext : DbContext
    {
        public Aplicacao_WebContext(DbContextOptions<Aplicacao_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Aplicacao_Web.Models.Department> Department { get; set; } = default!;
    }
}
