using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public class RepositorioLogin:RepositorioBase<Login>
    {
        public IEnumerable<Login> ListarTodosOsLogins()
        {
            return Contexto.
                   Login
                   .Where(f => f.idLogin != 0);
        }

        public int Max_idLogin()
        {
            return Contexto
                .Login
                .Max(f => f.idLogin);
        }
    }
}
