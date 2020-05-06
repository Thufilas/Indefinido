using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
	class ConfiguracaoJogo :
		IEntityTypeConfiguration<Jogo>
	{
		public void Configure(EntityTypeBuilder<Jogo> builder)
		{
			builder.ToTable("Jogo");
			builder.HasKey("idJogo");
			builder.Property(f => f.Nome).HasColumnName("Nome")
                .IsRequired()
				.HasMaxLength(50);
			builder.Property(f => f.DataLancamento).HasColumnName("Datalancamento");
			builder.Property(f => f.Descricao).HasColumnName("Descricao")
				.IsRequired()
				.HasMaxLength(100);
			builder.Property(f => f.idImagens).HasColumnName("idImagens");
			builder.Property(f => f.idDistribuidora).HasColumnName("idDistribuidora");
			builder.Property(f => f.idEstilo).HasColumnName("idEstilo");
			builder.Property(f => f.idFornecedora).HasColumnName("idFornecedora");
			builder.Property(f => f.idDesenvolvedora).HasColumnName("idDesenvolvedora");
		}
	}
}
