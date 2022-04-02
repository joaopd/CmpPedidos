using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository
{
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        public ImagemMap() : base("tb_imagem")
        {
        }
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(x => x.NomeArquivo)
                .HasMaxLength(50)
                .HasColumnName("nome_arquvo")
                .IsRequired();

            builder.Property(x => x.Principal)
                .HasColumnName("ativo")
                .IsRequired();
        }
    }
}
