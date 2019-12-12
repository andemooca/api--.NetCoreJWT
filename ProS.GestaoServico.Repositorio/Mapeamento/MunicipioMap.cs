using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProS.GestaoServico.Entidades;

namespace ProS.GestaoServico.Repositorio.Mapeamento
{
    public class MunicipioMap : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");
            builder.HasKey(e => e.IdMunicipio);
            builder.Property(e => e.IdMunicipio).ValueGeneratedOnAdd();
        }
    }
}
