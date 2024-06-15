using System;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasWheels { get; set; } = true;
        public int NumOfWheels { get; set; } = 4;
        public double EngineSize { get; set; } = 8.0;
        public string Model { get; set; } = "F-150";

        public string logo { get; set; } = "Circle with \"ford\" in the middle";
        public string CompanyName { get; set; } = "Ford";
        public string bedSize { get; set; } = "Full";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now in drive...");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} now in park...");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} now in reverse...");
        }

        public void TruckBedSize()
        {
            Console.WriteLine($"The {Model} has a {bedSize} bed size...");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The {CompanyName} has a logo of a {logo}, it boasts a engine size of {EngineSize}" +
               $".  The base model is an {Model}, it " + (HasWheels == true ? "has wheels" : "doesnt have wheels") +
               $", {NumOfWheels} wheels to be exact. \r\n");

            TruckBedSize();
        }
    }
}
