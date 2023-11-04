namespace Teste01.Domain
{
    public class Jogador 
    {
        public Jogador()
        {
        }

        public Jogador(Guid codigo, string nome, TipoJogador tipo)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new InvalidOperationException();
            }

            if (codigo == Guid.Empty)
            {
                throw new InvalidOperationException();
            }

            Codigo = codigo;
            Nome = nome;
            Tipo = tipo;
        }

        public TipoJogador Tipo { get; set; }
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
    }
}