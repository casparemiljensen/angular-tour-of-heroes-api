#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using angular_tour_of_heroes_api.Models;

namespace angular_tour_of_heroes_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<angular_tour_of_heroes_api.Models.Hero> Hero { get; set; }
    }
}
