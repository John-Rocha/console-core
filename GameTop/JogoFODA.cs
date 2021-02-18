using System;
using GameTop.Interface;

namespace GameTop
{
    class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        private readonly iJogador _jogadorC;
        public JogoFODA(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }


        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Passe());

            System.Console.WriteLine("\nPRÓXIMO JOGADOR!\n");

            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Passe());

            System.Console.WriteLine("\nPRÓXIMO JOGADOR!\n");

            Console.WriteLine(_jogadorC.Chuta());
            Console.WriteLine(_jogadorC.Corre());
            Console.WriteLine(_jogadorC.Passe());
        }
    }
}