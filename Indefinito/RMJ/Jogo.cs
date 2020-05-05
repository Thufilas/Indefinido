using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dominio
{
    class Jogo
    {
        public int idJogo { get; set; }
        public int idEstilo { get; set; }
        public int idImagens { get; set; }
        public int idDistribuidora { get; set; }
        public int idDesenvolvedora{ get; set; }
        public int idFornecedora { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
