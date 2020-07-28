using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Modul.Models;

namespace Modul.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ZalozeniaDlaOferty> ZolozeniaDlaOferty { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<WycenaWarunkow> WycenaWarunkows { get; set; }
    }
}
