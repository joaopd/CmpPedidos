using Domain;
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
        }
    }
}
