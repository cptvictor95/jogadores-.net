using GameBRABO.Interface;

namespace GameBRABO.Lib
{
    public class JogadorA : iJogador
    {
        public readonly string _Nome;
        public JogadorA(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        // Chutar
        public string Chutar()
        {
            return $"{_Nome} chutou a bola.\n";
        }
        // Correr
        public string Correr()
        {
            return $"{_Nome} está correndo.\n";
        }
        // Passar
        public string Passar()
        {
            return $"{_Nome} fez um passe.\n";
        }
    }
}