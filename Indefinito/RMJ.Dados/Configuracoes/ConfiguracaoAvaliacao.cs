using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    public class ConfiguracaoAvaliacao:
        IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");
            builder.HasKey("idAvaliacao");
            builder.Property(f => f.idAvaliacao).HasColumnName("idAvalicao");
            builder.Property(f => f.idUsuario).HasColumnName("idUsuario");
            builder.Property(f => f.idJogo).HasColumnName("idJogo");
            builder.Property(f => f.Nota).HasColumnName("Nota");
            builder.Property(f => f.NotaMedia).HasColumnName("NotaMedia");
            builder.Property(f => f.Comentario).HasColumnName("Comentario")
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(f => f.Indicacao).HasColumnName("Indicacao")
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
