using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
    {
        public PromocaoProdutoMap() : base("tb_promocao_produto")
        {
        }
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
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
