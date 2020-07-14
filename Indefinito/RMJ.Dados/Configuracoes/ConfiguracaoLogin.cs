using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    public class ConfiguracaoLogin :
        IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login", "RankingJogo");
            builder.HasKey(f => f.idLogin);
            builder.Property(f => f.Nickname).HasColumnName("Nickname")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Senha).HasColumnName("Senha")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
