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
    public class DetailsModel : PageModel
    {
        private readonly RazorApp.Models.RazorAppContext _context;

        public DetailsModel(RazorApp.Models.RazorAppContext context)
        {
            _context = context;
        }

        public Persona Persona { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Persona = await _context.Persona.FirstOrDefaultAsync(m => m.ID == id);

            if (Persona == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
