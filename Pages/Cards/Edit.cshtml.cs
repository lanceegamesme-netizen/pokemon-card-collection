using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Data;
using PokeCardCollection.Models;

namespace PokeCardCollection.Pages.Cards;

public class EditModel : PageModel
{
    private readonly CardContext _context;

    public EditModel(CardContext context)
    {
        _context = context;
    }

    [BindProperty]
    public PokemonCard Card { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var card = await _context.PokemonCards.FindAsync(id);
        if (card == null)
        {
            return NotFound();
        }

        Card = card;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Card).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _context.PokemonCards.AnyAsync(card => card.Id == Card.Id))
            {
                return NotFound();
            }

            throw;
        }

        return RedirectToPage("./Index");
    }
}
