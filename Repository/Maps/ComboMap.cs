using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class ComboMap : BaseDomainMap<Combo>
    {
        public ComboMap() : base("tb_combo")
        {
        }
        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasPrecision(17,2)
                .HasColumnName("preco")
                .IsRequired();        

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();
        }
    }
}
