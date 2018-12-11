using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorApp.Models;

namespace RazorApp.Pages.Personas
{
    public class IndexModel : PageModel
    {
        private readonly RazorApp.Models.RazorAppContext _context;

        public IndexModel(RazorApp.Models.RazorAppContext context)
        {
            _context = context;
        }

        public IList<Persona> Persona { get;set; }

        public async Task OnGetAsync()
        {
            Persona = await _context.Persona.ToListAsync();
        }
    }
}
