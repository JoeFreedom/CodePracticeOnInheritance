using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Bicycle : TransportMeans
    {
        public Bicycle() { }
        public Bicycle(int acceleration, CarType carType, FuelType fuel, int numberOfPassengers)
        {
            Acceleration = acceleration;
            CarBrand = carType;
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
