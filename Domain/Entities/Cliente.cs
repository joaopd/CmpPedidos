using System;

namespace Domain
{
    public class Cliente : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }

        public Guid IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
