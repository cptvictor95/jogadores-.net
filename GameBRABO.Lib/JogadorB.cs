using GameBRABO.Interface;

namespace GameBRABO.Lib
{
    public class JogadorB : iJogador
    {
        public string Chutar()
        {
            return "Edmundo chutou a bola.\n";
        }
        public string Correr()
        {
            return "Edmundo está correndo.\n";
        }
        public string Passar()
        {
            return "Edmundo fez um passe.\n";
        }
    }
}