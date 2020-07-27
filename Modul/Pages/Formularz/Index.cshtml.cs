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
    public class IndexModel : PageModel
    {
        private readonly Modul.Data.ApplicationDbContext _context;

        public IndexModel(Modul.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ZalozeniaDlaOferty> ZalozeniaDlaOferty { get;set; }

        public async Task OnGetAsync()
        {
            ZalozeniaDlaOferty = await _context.ZolozeniaDlaOferty.ToListAsync();
        }
    }
}
