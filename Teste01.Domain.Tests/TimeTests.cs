using Bogus;
using FluentAssertions;

namespace Teste01.Domain.Tests
{
    public class TimeTests
    {
        [Fact]
        public void CriarTimeDeveFalharComMenosde11Jogadores()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => new Time(new List<Jogador>()));
            Assert.Equal("Time deve ter 11 jogadores", ex.Message);
        }

        [Theory]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        public void CriarTimeDeveFucnionarCom11Jogadores(int quantidade, bool esperado)
        {
            var jogadoresFake = new Faker<Jogador>("pt_BR")
                .RuleFor(j => j.Codigo, x => x.Random.Uuid())
                .RuleFor(j => j.Nome, x => x.Person.FullName)
                .RuleFor(x => x.Tipo, TipoJogador.LINHA)
                .Generate(quantidade);
            var time = new Time(jogadoresFake);
            Assert.Equal(esperado, time.EhValido);
        }

        [Fact]
        public void CriarTimeDeveFucnionarCom11Jogadores2()
        {
            var jogadoresFake = new Faker<Jogador>("pt_BR")
                .RuleFor(j => j.Codigo, x => x.Random.Uuid())
                .RuleFor(j => j.Nome, x => x.Person.FullName)
                .RuleFor(x => x.Tipo, TipoJogador.LINHA)
                .Generate(11);
            var time = new Time(jogadoresFake);

            jogadoresFake.Should().BeInAscendingOrder(x => x.Codigo);

            time.EhValido.Should().BeTrue();
        }
    }
}