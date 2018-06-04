using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSQLite
{
    public class CarsDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<Garage> Garages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./cars.sqlite");
        }
    }
}
