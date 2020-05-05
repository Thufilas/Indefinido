using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    class ConfiguracaoUsuario :
        IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey("idusuario");
            builder.Property(f => f.Nome).HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
            builder.Property(f => f.CPF).HasColumnName("CPF")
                .IsRequired()
                .HasMaxLength(11);
            builder.Property(f => f.email).HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(f => f.idLogin).HasColumnName("idLogin");
        }
    }
}
