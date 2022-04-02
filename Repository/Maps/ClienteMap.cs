using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base("tb_cliente")
        {
        }
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
        }
    }
}
