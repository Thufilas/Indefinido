using RMJ.Servico;
using RMJ.Dominio;
using RMJ.Dados;
using System;
using System.Linq;

namespace RMJ.ConsoleApp2
{
    class Program
    {
        private static DistribuidoraServico _distribuidoraServico = new DistribuidoraServico();
        static void Main(string[] args)
        {
            Console.WriteLine("Listando Distribuidoras");

            var distribuidoras = _distribuidoraServico.ListarTodas();

            Console.WriteLine(Distribuidora.Cabecalho());
            foreach (Distribuidora item in distribuidoras)
                Console.WriteLine(item);

            var distri = new Distribuidora();
            Console.WriteLine(distri.Nome);

            var distribuidoraResultado = _distribuidoraServico.Salvar(distri);

            Console.WriteLine(distribuidoraResultado.Result.Nome);
            Console.WriteLine(distribuidoraResultado.Message);

            Console.WriteLine("Listagem completa");
            Console.ReadKey();
        }
    }
}
