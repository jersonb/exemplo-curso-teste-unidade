using Moq;
using NSubstitute;
using Teste01.Data;

namespace Teste01.Services.Tests
{
    public class JogadorServiceTests
    {
        [Fact(DisplayName = "Obtem dos dados de jogadores")]
        public void GetJogadoresTestsMoq()
        {
            var repositoryMock = new Mock<IJogadorRepository>();

            repositoryMock
                .Setup(x => x.GetJogadoresDaRepository())
                .Returns(new List<Domain.JogadorDto>());

            var service = new JogadorService(repositoryMock.Object);

            service.GetJogadoresDaService();
            repositoryMock.Verify(repository => repository.GetJogadoresDaRepository(), Times.Once());
        }

        [Fact]
        public void GetJogadoresTestsNSubstitute()
        {
            var repositoryMock = Substitute.For<IJogadorRepository>();

            repositoryMock.GetJogadoresDaRepository().Returns(new List<Domain.JogadorDto>());

            var service = new JogadorService(repositoryMock);

            service.GetJogadoresDaService();
            repositoryMock.Received(1).GetJogadoresDaRepository();
        }


        [Fact]
        public void GetJogadoresPorTimeTestsNSubstitute()
        {
            var repositoryMock = Substitute.For<IJogadorRepository>();

            repositoryMock.GetJogadoresDaRepository(Arg.Any<Guid>()).Returns(new List<Domain.JogadorDto>());

            var service = new JogadorService(repositoryMock);
            var time = Guid.NewGuid();
            var dados =service.GetJogadoresDaService(time);

            var separado = dados.Chunk(5);

           
    
            repositoryMock.Received(1).GetJogadoresDaRepository(Arg.Is<Guid>(x => x == time));
        }
    }
}