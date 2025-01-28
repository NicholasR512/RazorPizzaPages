using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizza.Models;

namespace RazorPizzaPages.Data
{
    public class RazorPizzaPagesContext : DbContext
    {
        public RazorPizzaPagesContext (DbContextOptions<RazorPizzaPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPizza.Models.Pizza> Pizza { get; set; } = default!;
    }
}
