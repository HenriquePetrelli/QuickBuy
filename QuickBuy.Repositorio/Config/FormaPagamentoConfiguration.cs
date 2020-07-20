using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(forma => forma.Id);

            builder.Property(forma => forma.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(forma => forma.Descricao)
               .IsRequired()
               .HasMaxLength(100);
        }
    }
}
