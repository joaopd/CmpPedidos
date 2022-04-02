using Domain;
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
        }
    }
}
