using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dados.Configuracoes
{
    class ConfiguracaoAvaliacao:
        IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao"); 
        }
    }
}
