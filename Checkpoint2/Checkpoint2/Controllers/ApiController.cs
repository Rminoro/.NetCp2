using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Checkpoint2.Models;

namespace ReceitaController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaApiController : ControllerBase
    {
        private readonly Contexto _context;

        public ReceitaApiController(Contexto context)
        {
            _context = context;
        }

        // GET: api/ReceitaApi
        [HttpGet]
        public IEnumerable<Receita> Index()
        {
            return _context.Receita.ToList();
        }
    }
}
