using System;

namespace EFCoreSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var garage = Garage.CreateNew("Michaels Garage", "Salina, Ks");

            var dbContext = new CarsDbContext();

            dbContext.Garages.Add(garage);
            dbContext.SaveChanges();

            var porsche = Car.CreateNew("911", "Porsche", garage.Id);
            var mercedes = Car.CreateNew("S-Class Coupe", "Mercedes", garage.Id);

            dbContext.Cars.Add(porsche);
            dbContext.Cars.Add(mercedes);

            dbContext.SaveChanges();
        }
    }
}
