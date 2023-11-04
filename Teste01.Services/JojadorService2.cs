using Microsoft.EntityFrameworkCore;
using Teste01.Data;
using Teste01.Domain;

namespace Teste01.Services
{
    public class JojadorService2
    {
        public readonly IJogadorContext _context;

        public JojadorService2(IJogadorContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Jogador>> GetGoleiros()
        {
            var jogadores = await _context.Jogadores
                .Select(x => new Jogador(x.Codigo, x.Nome, x.Tipo))
                .ToListAsync();

            return jogadores.Where(x => x.Tipo == TipoJogador.GOLEIRO);
        }
    }
}