using GameBRABO.Interface;

namespace GameBRABO
{
    public class JogoBRABO
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoBRABO(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());
            // 
            System.Console.Write("-= PRÓXIMO JOGADOR =-\n");
            // 
            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());
        }
    }
}