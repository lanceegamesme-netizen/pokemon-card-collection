using PokeCardCollection.Models;

namespace PokeCardCollection.Data;

public static class CardSeedData
{
    public static void AddSampleCards(CardContext db)
    {
        if (db.PokemonCards.Any())
        {
            return;
        }

        db.PokemonCards.AddRange(
            new PokemonCard
            {
                Name = "Pikachu",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Common",
                Condition = "Near Mint",
                EstimatedPrice = 2.50m,
                ImageUrl = "https://images.pokemontcg.io/base1/58.png"
            },
            new PokemonCard
            {
                Name = "Charizard",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Holo Rare",
                Condition = "Lightly Played",
                EstimatedPrice = 80.00m,
                ImageUrl = "https://images.pokemontcg.io/base1/4.png"
            },
            new PokemonCard
            {
                Name = "Blastoise",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Holo Rare",
                Condition = "Near Mint",
                EstimatedPrice = 35.00m,
                ImageUrl = "https://images.pokemontcg.io/base1/2.png"
            },
            new PokemonCard
            {
                Name = "Bulbasaur",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Common",
                Condition = "Near Mint",
                EstimatedPrice = 1.25m,
                ImageUrl = "https://images.pokemontcg.io/base1/44.png"
            },
            new PokemonCard
            {
                Name = "Mewtwo",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Holo Rare",
                Condition = "Good",
                EstimatedPrice = 12.00m,
                ImageUrl = "https://images.pokemontcg.io/base1/10.png"
            },
            new PokemonCard
            {
                Name = "Squirtle",
                SetName = "Base Set",
                Type = "Pokémon",
                Rarity = "Common",
                Condition = "Near Mint",
                EstimatedPrice = 1.50m,
                ImageUrl = "https://images.pokemontcg.io/base1/63.png"
            }
        );

        db.SaveChanges();
    }
}
