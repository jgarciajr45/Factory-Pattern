using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		
        public void Drive()
        {
            Console.WriteLine("Riding a motorcycle with two tires.");
        }
    }
}

