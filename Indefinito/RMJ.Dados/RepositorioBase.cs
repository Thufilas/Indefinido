using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public abstract class RepositorioBase<T> where T : class
    {
        protected Contexto Contexto {get;}
        private DbSet<T> Entidade { get; }

        public RepositorioBase()
        {
            Contexto = new Contexto();
            Entidade = Contexto.Set<T>();
        }

        public T ListarUm(params object[] keys)
        {
            return Entidade.Find(keys);
        }

        public List<T> ListarTodos()
        {
            return Contexto
                .Set<T>()
                .ToList();
        }

        public void Adicionar(T entidade)
        {
            Entidade.Add(entidade);
            Contexto.SaveChanges();
        }

        public void Remover(T entidade)
        {
            Entidade.Remove(entidade);
            Contexto.SaveChanges();
        }

        public void Atualizar(T entidade)
        {
            Entidade.Update(entidade);
            Contexto.SaveChanges();
        }
    }
}
