using System;

namespace EFCoreSQLite
{
    public class Car
    {
        public static Car CreateNew(string model, string make, Guid garageId)
        {
            return new Car()
            {
                Model = model,
                Make = make,
                GarageId = garageId
            };
        }

        public Guid Id { get; private set; }

        public string Make { get; private set; }

        public string Model { get; private set; }

        private Guid GarageId { get; set; }

        public Garage Garage {get; private set;}
    }
}
