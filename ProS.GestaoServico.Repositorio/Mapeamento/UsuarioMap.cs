using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProS.GestaoServico.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ProS.GestaoServico.Repositorio.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(e => e.IdUsuario);
            builder.Property(e => e.IdUsuario).ValueGeneratedOnAdd();

            builder
                .HasOne(e => e.Perfil)
                .WithMany(c => c.Usuarios)
            .HasForeignKey(c => c.IdPerfil);
        }
    }
}
