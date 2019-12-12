using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProS.GestaoServico.Entidades;

namespace ProS.GestaoServico.Repositorio.Mapeamento
{
    public class UFMap : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> builder)
        {
            builder.ToTable("UF");
            builder.HasKey(e => e.IdUF);
            builder.Property(e => e.IdUF).ValueGeneratedOnAdd();
        }
    }
}
