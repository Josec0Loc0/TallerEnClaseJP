using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TallerEnClaseJP.Data
{
    public class TallerEnClaseJPContext : DbContext
    {
        public TallerEnClaseJPContext (DbContextOptions<TallerEnClaseJPContext> options)
            : base(options)
        {
        }

        public DbSet<Jugador> Jugador { get; set; } = default!;
        public DbSet<Equipo> Equipo { get; set; } = default!;
        public DbSet<Estadio> Estadio { get; set; } = default!;
    }
}
