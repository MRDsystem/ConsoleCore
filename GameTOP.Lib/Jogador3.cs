using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Marcelo chuta\n";
        }

        public string Corre()
        {
           return "Marcelo corre\n";
        }

        public string Passe()
        {
           return "Marcelo passa\n";
        }
    }
}