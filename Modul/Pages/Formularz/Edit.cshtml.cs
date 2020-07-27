using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modul.Data;
using Modul.Models;

namespace Modul.Pages.Formularz
{
    public class EditModel : PageModel
    {
        private readonly Modul.Data.ApplicationDbContext _context;

        public EditModel(Modul.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ZalozeniaDlaOferty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZalozeniaDlaOfertyExists(ZalozeniaDlaOferty.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ZalozeniaDlaOfertyExists(int id)
        {
            return _context.ZolozeniaDlaOferty.Any(e => e.Id == id);
        }
    }
}
