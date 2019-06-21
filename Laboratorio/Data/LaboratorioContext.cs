using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio.Models
{
    public class LaboratorioContext : DbContext
    {
        public LaboratorioContext (DbContextOptions<LaboratorioContext> options)
            : base(options)
        {
        }

        public DbSet<Laboratorio.Models.Categoria> Categoria { get; set; }
    }
}
