using RMJ.Dados;
using RMJ.Dominio;
using RMJ.Comum.NotificationPattern;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Servico
{
    public class EstiloDeJogoServico
    {
        private readonly RepositorioEstiloDeJogo _estiloDeJogo;

        public EstiloDeJogoServico()
        {
            _estiloDeJogo = new RepositorioEstiloDeJogo();
        }

        public NotificationResult Salvar(EstiloDeJogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.idEstilo == 0)
                {
                    if (entidade.idEstilo == 0)
                        NotificationResult.Add(new NotificationError("Estilo não é possível cadastrar!", NotificationErrorType.USER));
                    if (String.IsNullOrEmpty(entidade.NomeEstilo))
                        NotificationResult.Add(new NotificationError("Necessário inserir o nome do estilo!", NotificationErrorType.USER));

                    if (NotificationResult.IsValid)
                    {
                        _estiloDeJogo.Adicionar(entidade);
                        NotificationResult.Add("Estilo Cadastro com Sucesso!");
                    }

                    return NotificationResult;
                }

                else
                    return NotificationResult.Add(new NotificationError("Erro ao realizar cadastro!", NotificationErrorType.USER)); ;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public NotificationResult Atualizar(EstiloDeJogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idEstilo != 0)

                    entidade.idEstilo = entidade.idEstilo;

                if (NotificationResult.IsValid)
                {
                    _estiloDeJogo.Atualizar(entidade);
                    NotificationResult.Add("Estilo Alterado com Sucesso!");

                    return NotificationResult;
                }

                else
                {
                    return NotificationResult.Add(new NotificationError("O id informado não existe!", NotificationErrorType.USER));

                }
            }
            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError("O id informado não existe!", NotificationErrorType.USER));
            }

        }

        public NotificationResult Excluir(EstiloDeJogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idEstilo != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _estiloDeJogo.Remover(entidade);
                        NotificationResult.Add("Estilo excluido com Sucesso!");

                        return NotificationResult;
                    }

                    else
                        return NotificationResult.Add(new NotificationError("O id informado não existe!", NotificationErrorType.USER));
                }

                else
                    return NotificationResult.Add(new NotificationError("O id informado não existe!", NotificationErrorType.USER));
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<EstiloDeJogo> ListarEstilos()
        {
            return _estiloDeJogo.ListarEstilodeJogos();
        }

        public IEnumerable<EstiloDeJogo> ListarEstiloJ(int id_estilo)
        {
            return _estiloDeJogo.ListarEstilo(id_estilo);
        }
    }

}
