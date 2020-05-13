using System;
using System.Collections.Generic;
using System.Text;
using RMJ.Comum;

namespace RMJ.Dominio
{
    public class Distribuidora
    {
        public int idDistribuidora { get; set; }
        public string Nome { get; set; }
        public string Site { get; set; }

        public static string Cabecalho()
        {
            return "ID\t\tNome\t\tSite";
        }

        public override string ToString()
        {
            return $"{idDistribuidora}\t\t{Nome}\t\t{Site}";
        }

    }


}
