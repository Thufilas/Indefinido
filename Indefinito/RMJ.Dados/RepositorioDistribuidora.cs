using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public class RepositorioDistribuidora:RepositorioBase<Distribuidora>
    {
        public IEnumerable<Distribuidora> ListarTodasAsDistribuidoras()
        {
            return Contexto.
                Distribuidora
                .Where(f => f.idDistribuidora >= 0);
        }

        public Distribuidora ListarDistribuidoraUm(int idDistri)
        {
            return Contexto.
                Distribuidora
                .SingleOrDefault(f => f.idDistribuidora == idDistri);
        }

    }
}
