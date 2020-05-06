using RMJ.Dados;
using RMJ.Dominio;
using RMJ.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Servico
{
    public class DistribuidoraServico
    {
        private readonly RepositorioDistribuidora _repositorioDistribuidora;

        public DistribuidoraServico()
        {
            _repositorioDistribuidora = new RepositorioDistribuidora();
        }
    }
}
