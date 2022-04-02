using System;
using System.Collections.Generic;

namespace Domain
{
    public class Pedido : BaseDomain
    {
        public string Numero { get; set; }
        public decimal ValorTotal { get; set; }

        public Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<ProdutoPedido> ProdutosPedidos { get; set; }

        public TimeSpan Entrega { get; set; }
    }
}
