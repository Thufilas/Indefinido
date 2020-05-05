using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RMJ.Dominio;

namespace RMJ.Dados
{
    class Contexto : DbContext
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

        }



    }
}
