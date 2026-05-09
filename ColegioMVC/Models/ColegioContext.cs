using Microsoft.EntityFrameworkCore;

namespace ColegioMVC.Models
{
    public class ColegioContext : DbContext
    {
        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public DbSet<Alumno> Alumno { get; set; }

        public DbSet<Materia> Materia { get; set; }

        public DbSet<Expediente> Expediente { get; set; }
    }
}