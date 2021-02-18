using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador2(), new Jogador3(), new Jogador1());
            jogo.IniciarJogo();
        }
    }
}
