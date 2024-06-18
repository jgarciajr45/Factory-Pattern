using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{

        public void Drive()
        {
            Console.WriteLine("Driving a car with four tires.");
        }
    }
}

