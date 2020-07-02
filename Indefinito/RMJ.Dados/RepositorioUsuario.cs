using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public class RepositorioUsuario:RepositorioBase<Usuario>
    {
        public IEnumerable<Usuario> ListarUsuarios()
        {
            return Contexto.
                   Usuario.
                   Where(f => f.idUsuario != 0);
        }

        public IEnumerable<Usuario> ListarumUsuario(int id_usuario)
        {
            return Contexto.
                   Usuario.
                   Where(f => f.idUsuario == id_usuario);
        }


    }
}
