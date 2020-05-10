using RMJ.Dados;
using RMJ.Dominio;
using RMJ.Comum.NotificationPattern;
using System.Linq;
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

        public NotificationResult Salvar(Distribuidora entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                entidade.idDistribuidora = 1;

                if (!entidade.Nome.Validar())
                {
                    notificationResult.Add(new NotificationError("Nome Inválido", NotificationErrorType.BUSINESS_RULES));
                }

                if (!entidade.Site.Validar())
                {
                    notificationResult.Add(new NotificationError("Site Inválido", NotificationErrorType.BUSINESS_RULES));
                }

                if (NotificationResult.IsValid)
                {
                    _repositorioDistribuidora.Adicionar(entidade);

                    NotificationResult.Add("Produto cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;

            }

            catch(Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

    }
}
