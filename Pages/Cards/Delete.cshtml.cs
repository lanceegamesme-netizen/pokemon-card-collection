using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Data;
using PokeCardCollection.Models;

namespace PokeCardCollection.Pages.Cards;

public class DeleteModel : PageModel
{
    private readonly CardContext _context;

    public DeleteModel(CardContext context)
    {
        _context = context;
    }

    [BindProperty]
    public PokemonCard? Card { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Card = await _context.PokemonCards.FirstOrDefaultAsync(card => card.Id == id);
        if (Card == null)
        {
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        var card = await _context.PokemonCards.FindAsync(id);
        if (card != null)
        {
            _context.PokemonCards.Remove(card);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
