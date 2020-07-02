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
    public interface ILoginServico
    {
        Task<Login> Authenticate(string nickname, string password);
        Task<IEnumerable<Login>> GetAll();
    } 
    public class LoginServico : ILoginServico
    {
        private readonly RepositorioLogin _loginrepositorio;

        private List<Login> listalogins = new List<Login>
        {
            new Login {idLogin = 1, Nickname = "PopsTeste", Senha = "pops123" }
        };

        public async Task<Login> Authenticate(string nickname, string senha)
        {
            var login = await Task.Run(() => listalogins.SingleOrDefault(x => x.Nickname == nickname && x.Senha == senha));

            if (nickname == null)
                return null;

            login.Senha = null;
            return login;
        }
        public async Task<IEnumerable<Login>> GetAll()
        {
            return await Task.Run(() => listalogins.Select(x =>
            {
                x.Senha = null;
                return x;
            }));
        }

        public LoginServico()
        {
            _loginrepositorio = new RepositorioLogin();
        }

        public Login ListarLogin(int idLogin)
        {
            return _loginrepositorio.ListarUm(idLogin);
        }

        public NotificationResult Salvar(Login entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.idLogin == 0)
                {
                    entidade.idLogin = _loginrepositorio.Max_idLogin() + 1;

                    if (String.IsNullOrEmpty(entidade.Nickname))
                        NotificationResult.Add(new NotificationError("Necessário inserir o nick!", NotificationErrorType.USER));
                    if (String.IsNullOrEmpty(entidade.Senha))
                        NotificationResult.Add(new NotificationError("Necessário inserir a senha!", NotificationErrorType.USER));

                    if (NotificationResult.IsValid)
                    {
                        _loginrepositorio.Adicionar(entidade);
                        NotificationResult.Add("Login Cadastro com Sucesso!");
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

        public NotificationResult Excluir(Login entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idLogin != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _loginrepositorio.Remover(entidade);
                        NotificationResult.Add("Login excluido com Sucesso!");

                        return NotificationResult;
                    }

                    else
                        return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }

                else
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public NotificationResult Atualizar(Login entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idLogin != 0)

                    entidade.idLogin = entidade.idLogin;

                if (NotificationResult.IsValid)
                {
                    _loginrepositorio.Atualizar(entidade);
                    NotificationResult.Add("Login Alterado com Sucesso!");

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

        public IEnumerable<Login> ListarTodos()
        {
            return _loginrepositorio.ListarTodosOsLogins();
        }
    }
}
