using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    public class ConfiguracaoEstiloDeJogo :
        IEntityTypeConfiguration<EstiloDeJogo>

    {
        public void Configure(EntityTypeBuilder<EstiloDeJogo> builder)
        {
            builder.HasKey("idEstilo");
            builder.Property(f => f.NomeEstilo).HasColumnName("NomeEstilo")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
