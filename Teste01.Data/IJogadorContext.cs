using Microsoft.EntityFrameworkCore;
using Teste01.Domain;

namespace Teste01.Data
{
    public interface IJogadorContext
    {
        DbSet<JogadorDto> Jogadores { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}