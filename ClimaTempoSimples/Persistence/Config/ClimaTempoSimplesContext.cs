using ClimaTempoSimples.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClimaTempoSimples.Persistence.Config
{
    public class ClimaTempoSimplesContext : DbContext
    {
        public ClimaTempoSimplesContext() : base("CTSimples")
        {
        }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<PrevisaoClima> PrevisoesClima { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Cidade>()
                .HasMany(e => e.PrevisaoClima)
                .WithRequired(e => e.Cidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Cidade)
                .WithRequired(e => e.Estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrevisaoClima>()
                .Property(e => e.TemperaturaMinima)
                .HasPrecision(3, 1);

            modelBuilder.Entity<PrevisaoClima>()
                .Property(e => e.TemperaturaMaxima)
                .HasPrecision(3, 1);
        }
    }
}