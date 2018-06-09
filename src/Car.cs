using System;

namespace EFCoreSQLite
{
    public class Car
    {
        public static Car CreateNew(string model, string make, int garageId)
        {
            return new Car()
            {
                Model = model,
                Make = make,
                GarageId = garageId
            };
        }

        public int Id { get; private set; }

        public string Make { get; private set; }

        public string Model { get; private set; }

        public int GarageId { get; private set; }

        public Garage Garage {get; private set;}
    }
}
