using System;

namespace RMJ.Dominio
{
    public class Usuario 
    {
        public int idUsuario { get; set; }
        public int idLogin { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string CPF { get; set; }
    }
}
