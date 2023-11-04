using Teste01.Domain;

namespace Teste01.Data
{
    public interface IJogadorRepository
    {
        List<JogadorDto> GetJogadoresDaRepository();

        List<JogadorDto> GetJogadoresDaRepository(Guid time);
    }
}