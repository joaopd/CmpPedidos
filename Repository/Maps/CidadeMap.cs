using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class CidadeMap : BaseDomainMap<Cidade>
    {
        public CidadeMap() : base("tb_cidade")
        {
        }
        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(x => x.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();
        }
    }
}
