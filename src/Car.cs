﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSQLite
{
    public class Car
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Make { get; private set; }

        public string Model { get; private set; }

        private Guid GarageId { get; set; }

        public Garage Location { get; private set; }
    }
}
