using System;
namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck with six tires.");
        }
    }
}

