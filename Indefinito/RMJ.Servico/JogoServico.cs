using RMJ.Dados;
using RMJ.Dominio;
using RMJ.Comum.NotificationPattern;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RMJ.Servico
{
    public class JogoServico
    {
        private readonly  RepositorioJogo _jogo;

        public JogoServico()
        {
            _jogo = new RepositorioJogo();
        }

        public NotificationResult Salvar(Jogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.idJogo == 0)
                {
                    if (entidade.idEstilo == 0)
                        NotificationResult.Add(new NotificationError("Jogo não é possível cadastrar!", NotificationErrorType.USER));
                    if (String.IsNullOrEmpty(entidade.Nome))
                        NotificationResult.Add(new NotificationError("Necessário inserir o nome do jogo!", NotificationErrorType.USER));
                    if (String.IsNullOrEmpty(entidade.Descricao))
                        NotificationResult.Add(new NotificationError("Necessário inserir a descricao do jogo!", NotificationErrorType.USER));

                    if (NotificationResult.IsValid)
                    {
                        _jogo.Adicionar(entidade);
                        NotificationResult.Add("Jogo cadastrado com Sucesso!");
                    }

                    return NotificationResult;
                }

                else
                {
                    _jogo.Atualizar(entidade);
                    return NotificationResult.Add(new NotificationError("Erro ao realizar cadastro!", NotificationErrorType.USER)); ;
                }
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public NotificationResult Atualizar(Jogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idJogo != 0)

                    entidade.idJogo = entidade.idJogo;

                if (NotificationResult.IsValid)
                {
                    _jogo.Atualizar(entidade);
                    NotificationResult.Add("Jogo Alterado com Sucesso!");

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

        public NotificationResult Excluir(Jogo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idJogo != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _jogo.Remover(entidade);
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

        public IEnumerable<Jogo> ListarJogos()
        {
            return _jogo.ListarJogos();
        }

        public IEnumerable<Jogo> ListarJogoUM(int id_jogo)
        {
            return _jogo.ListarJogo(id_jogo);
        }
    }
}
