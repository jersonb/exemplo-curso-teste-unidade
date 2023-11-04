namespace Teste01.Domain
{
    public class JogadorDto
    {
        public TipoJogador Tipo { get; set; }
        public Guid Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Guid TimeId { get; set; }
    }
}