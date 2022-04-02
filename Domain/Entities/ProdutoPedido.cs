using System;

namespace Domain
{
    public class ProdutoPedido : BaseDomain
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Guid IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public Guid IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
