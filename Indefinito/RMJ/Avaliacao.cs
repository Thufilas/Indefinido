using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Dominio
{
    public class Avaliacao
    {
        public int idAvaliacao { get; set; }
        public int idUsuario { get; set; }
        public int idJogo { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public string Indicacao { get; set; }
        public int NotaMedia { get; set; }
    }
}
