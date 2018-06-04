using System;
using System.Collections.Generic;

namespace EFCoreSQLite
{
    public class Garage
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Location { get; private set; }

        public IEnumerable<Car> Cars {get; private set;} 
    }
}
