using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProS.GestaoServico.Entidades;

namespace ProS.GestaoServico.Repositorio.Mapeamento
{
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(e => e.IdEndereco);
            builder.Property(e => e.IdEndereco).ValueGeneratedOnAdd();

            builder
                .HasOne(e => e.Municipio)
                .WithMany(c => c.Enderecos)
            .HasForeignKey(c => c.IdMunicipio);

            builder
                .HasOne(e => e.UF)
                .WithMany(c => c.Enderecos)
            .HasForeignKey(c => c.IdUF);
        }
    }
}
