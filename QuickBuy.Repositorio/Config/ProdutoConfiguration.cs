﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(produto => produto.Id);

            builder
               .Property(produto => produto.Nome)
               .IsRequired()
               .HasMaxLength(50);
            builder
                .Property(produto => produto.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(produto => produto.Preco)
                .IsRequired();

        }
    }
}
