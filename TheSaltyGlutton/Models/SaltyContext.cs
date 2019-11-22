using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSaltyGlutton.Models;

namespace TheSaltyGlutton.Models
{
    public class SaltyContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
