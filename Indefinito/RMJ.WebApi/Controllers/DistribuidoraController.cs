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
    public class DistribuidoraController : ControllerBase
    {
        private readonly DistribuidoraServico distribuidoraServico;

        public DistribuidoraController()
        {
            distribuidoraServico = new DistribuidoraServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Distribuidora> Ativos() => distribuidoraServico.ListarTodas();

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Distribuidora entidade)
        {
            return distribuidoraServico.Salvar(entidade);
        }
    }
}
