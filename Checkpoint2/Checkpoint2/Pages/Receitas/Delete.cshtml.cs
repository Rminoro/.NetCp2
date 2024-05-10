using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Checkpoint2.Models;

namespace Checkpoint2.Pages.Receitas
{
    public class DeleteModel : PageModel
    {
        private readonly Checkpoint2.Models.Contexto _context;

        public DeleteModel(Checkpoint2.Models.Contexto context)
        {
            _context = context;
        }

        [BindProperty]
        public Receita Receita { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receita.FirstOrDefaultAsync(m => m.Id == id);

            if (receita == null)
            {
                return NotFound();
            }
            else
            {
                Receita = receita;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receita.FindAsync(id);
            if (receita != null)
            {
                Receita = receita;
                _context.Receita.Remove(Receita);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
