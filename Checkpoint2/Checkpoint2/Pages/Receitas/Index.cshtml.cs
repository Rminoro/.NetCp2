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
    public class IndexModel : PageModel
    {
        private readonly Checkpoint2.Models.Contexto _context;

        public IndexModel(Checkpoint2.Models.Contexto context)
        {
            _context = context;
        }

        public IList<Receita> Receita { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Receita = await _context.Receita.ToListAsync();
        }
    }
}
