using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Car : TransportMeans
    {
        public Car() { }
        public Car(int acceleration, CarType carType, FuelType fuel, int numberOfPassengers) 
        {
            Acceleration = acceleration;
            CarBrand = carType;
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
