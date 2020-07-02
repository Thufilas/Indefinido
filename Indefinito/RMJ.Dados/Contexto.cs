using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RMJ.Dominio;
using RMJ.Dados.Configuracoes;

namespace RMJ.Dados
{
    public class Contexto : DbContext
    {
       //1.CLASSES - ENTIDADES - TABELAS
       //1. INICIO
        public DbSet<Avaliacao> Avaliacao { get; set;}
        public DbSet<Distribuidora> Distribuidora { get; set; }
        public DbSet<EstiloDeJogo> EJogo { get; set; }
        public DbSet<Fornecedora> Fornecedora { get; set; }
        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new ConfiguracaoAvaliacao());

            modelBuilder.ApplyConfiguration(new ConfiguracaoDistribuidora());

            modelBuilder.ApplyConfiguration(new ConfiguracaoEstiloDeJogo());

            modelBuilder.ApplyConfiguration(new ConfiguracaoJogo());

            modelBuilder.ApplyConfiguration(new ConfiguracaoUsuario());

            modelBuilder.ApplyConfiguration(new ConfiguracaoLogin());

            modelBuilder.ApplyConfiguration(new ConfiguracaoImagens());

            //2. FIM
        }


    }
}
