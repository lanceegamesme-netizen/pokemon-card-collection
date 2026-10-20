using System.ComponentModel.DataAnnotations;

namespace PokeCardCollection.Models;

public class PokemonCard
{
    public int Id { get; set; }

    [Required]
    [StringLength(80)]
    [Display(Name = "Card name")]
    public string Name { get; set; } = "";

    [Required]
    [Display(Name = "Set name")]
    public string SetName { get; set; } = "";

    [Required]
    public string Type { get; set; } = "Pokémon";

    public string Rarity { get; set; } = "Common";

    [Display(Name = "Card condition")]
    public string Condition { get; set; } = "Near Mint";

    [Range(0, 100000)]
    [Display(Name = "Estimated price (QAR)")]
    public decimal EstimatedPrice { get; set; }

    [Display(Name = "Card image URL")]
    [Url]
    public string? ImageUrl { get; set; }
}
