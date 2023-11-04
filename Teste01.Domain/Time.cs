namespace Teste01.Domain
{
    public class Time
    {
        public List<Jogador> Jogadores { get; }
        public bool EhValido { get; } = false;

        public Time(List<Jogador> jogadores)
        {
            if (jogadores.Count == 11)
            {
                EhValido = true;
            }
            Jogadores = jogadores;
        }
    }
}