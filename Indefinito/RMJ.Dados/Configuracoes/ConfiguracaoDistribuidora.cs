using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    public class ConfiguracaoDistribuidora :
        IEntityTypeConfiguration<Distribuidora>

    {
        public void Configure(EntityTypeBuilder<Distribuidora> builder)
        {
            builder.ToTable("Distribuidora");
            builder.HasKey("idDistribuidora");
            builder.Property(f => f.Nome).HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(f => f.Site).HasColumnName("Site")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
