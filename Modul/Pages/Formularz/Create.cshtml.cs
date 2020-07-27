using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modul.Data;
using Modul.Models;

namespace Modul.Pages.Formularz
{
    public class CreateModel : PageModel
    {
        private readonly Modul.Data.ApplicationDbContext _context;

        public CreateModel(Modul.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ZalozeniaDlaOferty ZalozeniaDlaOferty { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ZolozeniaDlaOferty.Add(ZalozeniaDlaOferty);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
