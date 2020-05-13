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
                if(entidade.Nome == "")
                {
                    notificationResult.Add(new NotificationError("Nome inválido!", NotificationErrorType.USER));
                }

                if (entidade.Site == "")
                {
                    notificationResult.Add(new NotificationError("Nome inválido!", NotificationErrorType.USER));
                }

                if (notificationResult.IsValid)
                {
                    if (entidade.idDistribuidora == 0)
                        _repositorioDistribuidora.Adicionar(entidade);
                    else
                        _repositorioDistribuidora.Atualizar(entidade);

                    notificationResult.Add("Distribuidora cadastrada com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch(Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Distribuidora> ListarTodas()
        {
            return _repositorioDistribuidora.ListarTodasAsDistribuidoras();
        }
    }
}
