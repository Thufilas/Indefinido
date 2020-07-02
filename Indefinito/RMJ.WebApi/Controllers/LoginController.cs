using RMJ.Comum.NotificationPattern;
using RMJ.Dominio;
using RMJ.Servico;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using RMJ.WebApi.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RMJ.WebApi.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginServico _loginServico;

        public LoginController()
        {
            _loginServico = new LoginServico();
        }



        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]Login userParam)
        {
            var login = await _loginServico.Authenticate(userParam.Nickname, userParam.Senha);

            if (login == null)
                return BadRequest(new { message = "Nick ou senha incorretos" });

            return Ok(login);
        }


        [HttpGet("ListarLogins")]
        public IEnumerable<Login> ListarTodos()
        {
            return _loginServico.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Login entidade)
        {
            return _loginServico.Salvar(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Login entidade)
        {
            return _loginServico.Atualizar(entidade);
        }
    }
}
