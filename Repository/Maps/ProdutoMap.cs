using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        public ProdutoMap() : base("tb_produto")
        {
        }
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(x => x.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasPrecision(17,2)               
                .HasColumnName("preco")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();
        }
    }
}
