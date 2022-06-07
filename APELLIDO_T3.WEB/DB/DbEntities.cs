using APELLIDO_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace APELLIDO_T3.WEB.DB
{
    public class DbEntities : DbContext
    {
        public DbEntities()
        {
            
        }
        public DbEntities(DbContextOptions<DbEntities> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }


        public virtual DbSet<HistoriaClinica> HistoriaClinicas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

    }
}
