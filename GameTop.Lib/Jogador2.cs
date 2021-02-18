using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradora estás pateando";
        }

        public string Corre()
        {
            return "Maradora estás corriendo";
        }

        public string Passe()
        {
            return "Maradora estás pasando";
        }
    }
}