using Teste01.Data;
using Teste01.Domain;

namespace Teste01.Services
{
    public class JogadorService
    {
        private readonly IJogadorRepository _repository;

        public JogadorService(IJogadorRepository repository)
        {
            _repository = repository;
        }

        public List<Jogador> GetJogadoresDaService()
        {
            var jogadores = _repository.GetJogadoresDaRepository()
                .Select(x => new Jogador(x.Codigo, x.Nome, x.Tipo))
                .ToList();

            return jogadores;
        }

        public List<Jogador> GetJogadoresDaService(Guid time)
        {
            var jogadores = _repository.GetJogadoresDaRepository(time)
                  .Select(x => new Jogador(x.Codigo, x.Nome, x.Tipo))
                  .ToList();

            return jogadores;
        }
    }
}