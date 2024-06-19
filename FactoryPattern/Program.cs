namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires for the vehicle (2, 4, 6):");
            string numberOfTires = Console.ReadLine();

            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
                vehicle.Drive();
            }
            catch (ArgumentException e)        //tested try catch to catch errors. first time...
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
          