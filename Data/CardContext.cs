using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Models;

namespace PokeCardCollection.Data;

public class CardContext : DbContext
{
    public CardContext(DbContextOptions<CardContext> options) : base(options)
    {
    }

    public DbSet<PokemonCard> PokemonCards => Set<PokemonCard>();
}
