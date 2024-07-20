using BasicPokedex_MinimalAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace BasicPokedex_MinimalAPI
{
    public class PokedexDbContext : DbContext
    {
        public PokedexDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
