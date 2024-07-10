using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Web.Models;

namespace Aplicacao_Web.Data
{
    public class Aplicacao_WebContext : DbContext
    {
        public Aplicacao_WebContext (DbContextOptions<Aplicacao_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Aplicacao_Web.Models.Department> Department { get; set; } = default!;
    }
}
