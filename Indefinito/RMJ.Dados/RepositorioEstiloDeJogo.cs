using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public class RepositorioEstiloDeJogo:RepositorioBase<EstiloDeJogo>
    {
        public IEnumerable<EstiloDeJogo> ListarEstilodeJogos()
        {
            return Contexto.
                   EJogo.
                   Where(f => f.idEstilo != 0);
        }

        public IEnumerable<EstiloDeJogo> ListarEstilo(int id_ejogo)
        {
            return Contexto.
                   EJogo.
                   Where(f=> f.idEstilo == id_ejogo);
        }
    }
}
