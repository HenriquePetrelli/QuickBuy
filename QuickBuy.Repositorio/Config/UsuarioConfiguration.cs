﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(usuario => usuario.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
               .Property(usuario => usuario.Senha)
               .IsRequired()
               .HasMaxLength(400);
            builder
                .Property(usuario => usuario.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
               .Property(usuario => usuario.SobreNome)
               .IsRequired()
               .HasMaxLength(50);
            builder
               .HasMany(usuario => usuario.Pedidos)
               .WithOne(pedido => pedido.Usuario);
        }
    }
}
