using Bertotti.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bertotti.Data
{
    public class RecetaContext : DbContext
    {
        public DbSet<Receta> Recetas {  get; set; }

        public RecetaContext(DbContextOptions<RecetaContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        
    }
}
