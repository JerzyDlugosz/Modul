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
    public class DetailsModel : PageModel
    {
        private readonly Modul.Data.ApplicationDbContext _context;

        public DetailsModel(Modul.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
