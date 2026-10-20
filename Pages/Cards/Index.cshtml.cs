using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Data;
using PokeCardCollection.Models;

namespace PokeCardCollection.Pages.Cards;

public class IndexModel : PageModel
{
    private readonly CardContext _context;

    public IndexModel(CardContext context)
    {
        _context = context;
    }

    public IList<PokemonCard> Cards { get; set; } = new List<PokemonCard>();

    public string? SearchString { get; set; }

    public async Task OnGetAsync(string? searchString)
    {
        SearchString = searchString;

        IQueryable<PokemonCard> cards = _context.PokemonCards;

        if (!string.IsNullOrWhiteSpace(searchString))
        {
            cards = cards.Where(card => card.Name.Contains(searchString));
        }

        Cards = await cards.OrderBy(card => card.Name).ToListAsync();
    }
}
