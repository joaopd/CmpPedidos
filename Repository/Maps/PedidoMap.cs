using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class PedidoMap : BaseDomainMap<Pedido>
    {
        public PedidoMap() : base("tb_pedido")
        {
        }
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
        }
    }
}
