using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class CalculatingTimeTransportFare : TransportMeans
    {
       public int Time { set; get; }
        public double Distance { set; get; }
        public double TransportFare { set; get; }

        public CalculatingTimeTransportFare() { }
        public CalculatingTimeTransportFare(int speed, int time, double distance, double transportFare, int numberOfPassengers, CarType carBrand, FuelType fuelType) 
        {
            Acceleration = speed;
            Time = time;
            Distance = distance;
            TransportFare = transportFare;
            CarBrand = carBrand;
            Fuel = fuelType;
            NumberOfPassengers = numberOfPassengers;
    }
        public static double CalculatingTime(int time, int distance, int speed)
        {
            time = distance / speed; 
            return time;
        }
        public static double CalculatingTransportFare(int numberOfPassengers, double transportFare, double totalTransportFare)
        {

            transportFare = totalTransportFare / numberOfPassengers;
            return transportFare;
        }

    }
}
