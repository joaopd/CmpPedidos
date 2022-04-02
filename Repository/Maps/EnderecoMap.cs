using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class EnderecoMap : BaseDomainMap<Endereco>
    {
        public EnderecoMap() : base("tb_endereco")
        {
        }
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Tipo)
                .HasColumnName("tipo")
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasMaxLength(100)
                .HasColumnName("logradouro")
                .IsRequired();

            builder.Property(x => x.Bairro)
                .HasMaxLength(100)
                .HasColumnName("bairro")
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero")
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasMaxLength(100)
                .HasColumnName("complemento");

            builder.Property(x => x.Cep)
                .HasMaxLength(8)
                .HasColumnName("cep")
                .IsRequired();
        }
    }
}
