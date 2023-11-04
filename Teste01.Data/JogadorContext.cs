using Microsoft.EntityFrameworkCore;
using Teste01.Domain;

namespace Teste01.Data
{
    public class JogadorContext : DbContext, IJogadorContext
    {
        public JogadorContext(DbContextOptions<JogadorContext> options) : base(options)
        {
        }

        public DbSet<JogadorDto> Jogadores { get; set; } = default!;
    }
}