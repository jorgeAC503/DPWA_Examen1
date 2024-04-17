using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimerExamen.Models;

namespace PrimerExamen.Data
{
    public class PrimerExamenContext : DbContext
    {
        public PrimerExamenContext (DbContextOptions<PrimerExamenContext> options)
            : base(options)
        {
        }

        public DbSet<PrimerExamen.Models.Category> Category { get; set; } = default!;
        public DbSet<PrimerExamen.Models.Product> Product { get; set; } = default!;
        public DbSet<PrimerExamen.Models.Supplier> Supplier { get; set; } = default!;
        public DbSet<PrimerExamen.Models.Login> Login { get; set; } = default!;
    }
}
