using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using PatrimonioSenaiTaguatinga.EntityConfigurations;

namespace PatrimonioSenaiTaguatinga.Context
{
    public class PatrimonioSenaiTaguatingaContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public PatrimonioSenaiTaguatingaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Nivel> Nivels => Set<Nivel>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("PatrimonioSenaiTaguatinga"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NivelConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

    }
}