using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string Name;

        public Jogador1(string nome = "John")
        {
            Name = nome;
        }

        public string Chuta()
        {
            return $"{Name} está chutando";
        }

        public string Corre()
        {
            return $"{Name} está correndo";
        }

        public string Passe()
        {
            return $"{Name} está passando";
        }
    }
}