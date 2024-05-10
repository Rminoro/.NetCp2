using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Checkpoint2.Models;

namespace Checkpoint2.Pages.Receitas
{
    public class CreateModel : PageModel
    {
        private readonly Checkpoint2.Models.Contexto _context;

        public CreateModel(Checkpoint2.Models.Contexto context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Receita Receita { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Receita.Add(Receita);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
