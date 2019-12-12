using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProS.GestaoServico.Entidades;

namespace ProS.GestaoServico.Repositorio.Mapeamento
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("Perfil");
            builder.HasKey(e => e.IdPerfil);
            builder.Property(e => e.IdPerfil).ValueGeneratedOnAdd();
        }
    }
}
