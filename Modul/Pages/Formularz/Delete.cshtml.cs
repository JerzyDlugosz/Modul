using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Modul.Data;
using Modul.Models;

namespace Modul.Pages.Formularz
{
    public class DeleteModel : PageModel
    {
        private readonly Modul.Data.ApplicationDbContext _context;

        public DeleteModel(Modul.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ZalozeniaDlaOferty ZalozeniaDlaOferty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZalozeniaDlaOferty = await _context.ZolozeniaDlaOferty.FirstOrDefaultAsync(m => m.Id == id);

            if (ZalozeniaDlaOferty == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZalozeniaDlaOferty = await _context.ZolozeniaDlaOferty.FindAsync(id);

            if (ZalozeniaDlaOferty != null)
            {
                _context.ZolozeniaDlaOferty.Remove(ZalozeniaDlaOferty);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
