using Microsoft.EntityFrameworkCore;
using ProS.GestaoServico.Entidades;
using ProS.GestaoServico.Repositorio.Mapeamento;

namespace ProS.GestaoServico.Repositorio
{
    public partial class ProSDbContext : DbContext
    {
        public ProSDbContext()
        {
            //this.ChangeTracker.LazyLoadingEnabled = false;
        }
        public ProSDbContext(DbContextOptions<ProSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new MunicipioMap());
            modelBuilder.ApplyConfiguration(new UFMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<UF> UF { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
