using GameBRABO.Interface;

namespace GameBRABO.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chutar()
        {
            return "Mbappé chutou a bola.\n";
        }

        public string Correr()
        {
            return "Mbappé está correndo.\n";
        }

        public string Passar()
        {
            return "Mbappé fez um passe.\n";
        }
    }
}