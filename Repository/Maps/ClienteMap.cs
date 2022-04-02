using Domain;
using Microsoft.EntityFrameworkCore;
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

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(x => x.Cpf)
                .HasMaxLength(11)
                .HasColumnName("cpf")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();

            builder.Property(x => x.IdEndereco)
                .HasColumnName("id_endereco")
                .IsRequired();
        }
    }
}
