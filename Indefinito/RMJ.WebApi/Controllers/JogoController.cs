using RMJ.Comum.NotificationPattern;
using RMJ.Dominio;
using RMJ.Servico;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RMJ.WebApi.Models;
using Microsoft.AspNetCore.Http;

namespace RMJ.WebApi.Controllers
{
        [Route("[controller]")]
        [ApiController]
        public class JogoController : ControllerBase
        {
            private readonly JogoServico jogoServico;

            public JogoController()
            {
                jogoServico = new JogoServico();
            }

            [HttpGet("todos")]
            public IEnumerable<Jogo> ListarJogos()
            {
                return jogoServico.ListarJogos();
            }

            [HttpPost("Adicionar")]
            public NotificationResult Salvar(Jogo entidade)
            {
                return jogoServico.Salvar(entidade);
            }
            
            [HttpPut("Atualizar")]
            public NotificationResult Atualizar(Jogo entidade)
            {
                return jogoServico.Atualizar(entidade);
            }

            [HttpDelete("Deletar")]
            public NotificationResult Excluir(Jogo entidade)
            {
                return jogoServico.Excluir(entidade);
            }
    }
}
