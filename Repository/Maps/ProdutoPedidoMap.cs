using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
    {
        public ProdutoPedidoMap() : base("tb_produto_pedido")
        {
        }
        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Quantidade)
                .HasPrecision(2)
                .HasColumnName("quantidade")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasPrecision(17, 2)
                .HasColumnName("preco")
                .IsRequired();        
        }
    }
}
