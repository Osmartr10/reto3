using EnrolamientoAPI.Models;
using EstudianteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnrolamientoAPI
{
    public class EnrolamientoContexto : DbContext, IEnrolamientoContext
    {
        public DbSet<Enrolamiento> Students { get; set; }

        void IEnrolamientoContext.SaveChanges()
        {
            base.SaveChanges();
        }
        public EnrolamientoContexto(DbContextOptions<EnrolamientoContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrolamiento>(enrol => { 
                enrol.ToTable(nameof(Enrolamiento));
                enrol.HasKey(x => x.Id);
                enrol.Property(x => x.FechaEnrolamiento).IsRequired();
                enrol.Property(x => x.FechaBaja).IsRequired();
                enrol.Property(x=> x.Estado).IsRequired();
                enrol.Property(x=> x.AsignaturaId).IsRequired();
                enrol.Property(x=> x.EstudianteId).IsRequired();
            });            

        }
    }
}
