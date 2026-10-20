using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Data;
using PokeCardCollection.Models;

namespace PokeCardCollection.Pages.Cards;

public class DetailsModel : PageModel
{
    private readonly CardContext _context;

    public DetailsModel(CardContext context)
    {
        _context = context;
    }

    public PokemonCard? Card { get; set; }

    public async Task OnGetAsync(int id)
    {
        Card = await _context.PokemonCards.FirstOrDefaultAsync(card => card.Id == id);
    }
}
