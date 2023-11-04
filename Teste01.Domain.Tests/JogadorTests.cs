namespace Teste01.Domain.Tests
{
    public class JogadorTests
    {
        [Fact]
        public void CriarJogador()
        {
            var jogador = new Jogador(Guid.NewGuid(), Guid.NewGuid().ToString(), TipoJogador.LINHA);

            Assert.NotNull(jogador);
        }

        [Fact(DisplayName = "Deve gerar operac�o inv�lida com nome vazio ou nulo")]
        public void ValidarNome()
        {
            Assert.Throws<InvalidOperationException>(() => new Jogador(Guid.NewGuid(), string.Empty, TipoJogador.LINHA));
        }

        [Fact(DisplayName = "Deve gerar operac�o inv�lida com c�digo default")]
        public void ValidaCodigo()
        {
            Assert.Throws<InvalidOperationException>(() => new Jogador(Guid.Empty, Guid.NewGuid().ToString(), TipoJogador.LINHA));
        }


    }
}