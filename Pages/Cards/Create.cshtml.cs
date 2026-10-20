using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeCardCollection.Data;
using PokeCardCollection.Models;

namespace PokeCardCollection.Pages.Cards;

public class CreateModel : PageModel
{
    private readonly CardContext _context;

    public CreateModel(CardContext context)
    {
        _context = context;
    }

    [BindProperty]
    public PokemonCard Card { get; set; } = new();

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.PokemonCards.Add(Card);
        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}
