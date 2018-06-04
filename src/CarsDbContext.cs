using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSQLite
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<Garage> Garages { get; set; }


    }
}
