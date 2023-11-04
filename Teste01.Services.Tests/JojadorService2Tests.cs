using Bogus;
using Moq;
using Moq.EntityFrameworkCore;
using Teste01.Data;
using Teste01.Domain;

namespace Teste01.Services.Tests
{
    public class JojadorService2Tests
    {
        [Fact]
        public async Task Test01()
        {
            var jogadoresFake = new Faker<JogadorDto>("pt_BR")
              .RuleFor(j => j.Codigo, x => x.Random.Uuid())
              .RuleFor(j => j.Nome, x => x.Person.FullName)
              .RuleFor(x => x.Tipo, TipoJogador.LINHA)
              .Generate(11);

            jogadoresFake[0].Tipo = TipoJogador.GOLEIRO;

            var contextMock = new Mock<IJogadorContext>();

            contextMock
                .Setup(x => x.Jogadores)
                .ReturnsDbSet(jogadoresFake);

            var service = new JojadorService2(contextMock.Object);

            var result = await service.GetGoleiros();

            Assert.Single(result);
        }
    }
}