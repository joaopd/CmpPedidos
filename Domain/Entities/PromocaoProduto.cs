using System;

namespace Domain
{
    public class PromocaoProduto : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Guid IdImagem { get; set; }
        public virtual Imagem Imagem { get; set; }

        public Guid IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public bool Ativo { get; set; }
    }
}
