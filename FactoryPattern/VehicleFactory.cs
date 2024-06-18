using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public static IVehicle GetVehicle(string numberOfTires)
		{
			switch (numberOfTires)
			{
				case "2":
					return new Motorcycle();
				case "4":
					return new Car();
				case "6":
					return new Truck();
				default:
					throw new ArgumentException("Invalid entry. Looks like you'd rather use your legs to walk... BYEEEEEE");
			}
		}
		
	}
}

