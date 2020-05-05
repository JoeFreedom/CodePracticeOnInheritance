using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Cart : TransportMeans
    {
        public Cart() { }
        public Cart(int acceleration, CarType carType, FuelType fuel, int numberOfPassengers)
        {
            Acceleration = acceleration;
            CarBrand = carType;
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
