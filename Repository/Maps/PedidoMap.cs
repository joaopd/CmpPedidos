using Domain;
using Microsoft.EntityFrameworkCore;
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

            builder.Property(x => x.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero")
                .IsRequired();

            builder.Property(x => x.Entrega)
                .HasColumnName("entrega");

            builder.Property(x => x.ValorTotal)
                .HasPrecision(17, 2)
                .HasColumnName("valor_total")
                .IsRequired();
        }
    }
}
