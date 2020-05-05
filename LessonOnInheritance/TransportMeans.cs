using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    public enum CarType { BMW, MBenz, Lada, Ferrari, Volkswagen}
    public enum FuelType { Petrol, Diesel, Gasoline, JetFuel, Electricity, Pedalling}
    public abstract class TransportMeans
    {
        public int Acceleration { set; get; }
        public CarType CarBrand { set; get; }
        public FuelType Fuel { set; get; }
        public int NumberOfPassengers {set; get;}

    }
}
