using Domain;
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
        }
    }
}
