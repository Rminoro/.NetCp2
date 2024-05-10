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
    public class DetailsModel : PageModel
    {
        private readonly Checkpoint2.Models.Contexto _context;

        public DetailsModel(Checkpoint2.Models.Contexto context)
        {
            _context = context;
        }

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
    }
}
