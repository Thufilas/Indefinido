using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    public class ConfiguracaoImagens :
        IEntityTypeConfiguration<Imagens>
    {
        public void Configure(EntityTypeBuilder<Imagens> builder)
        {
            builder.ToTable("Imagens", "RankingJogo");
            builder.HasKey(f => f.idImagens);
            builder.Property(f => f.Nome).HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
        }
    }

}
