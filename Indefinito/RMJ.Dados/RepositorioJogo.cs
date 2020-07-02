using RMJ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMJ.Dados
{
    public class RepositorioJogo:RepositorioBase<Jogo>
    {
        public IEnumerable<Jogo> ListarJogos()
        {
            return Contexto.
                   Jogo.
                   Where(f => f.idJogo != 0);
        }

        public int Max_idJogo()
        {
            return Contexto
                .Jogo
                .Max(f => f.idJogo);
        }

        public IEnumerable<Jogo> ListarJogo(int id_jogo)
        {
            return Contexto.
                    Jogo.
                    Where(f => f.idJogo == id_jogo);
        }
    }
}
