using System;

namespace InterfaceExercise
{
 public class Suv : IVehicle, ICompany
    {
        public Suv()
        { 
        }
        public bool HasWheels { get; set; } = true;
        public int NumOfWheels { get; set; } = 4;
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Latitude";

        public string logo { get; set; } = "Words JEEP";
        public string CompanyName { get; set; } = "Jeep";

        public bool hasCargo { get; set; } = true;
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
        public void Cargo()
        {
            if (hasCargo)
            {
                Console.WriteLine($"The {Model} has a cargo area...");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The {CompanyName} has a logo of a {logo}, it boasts a engine size of {EngineSize}" +
                $".  The base model is an {Model}, it " + (HasWheels == true ? "has wheels" : "doesnt have wheels") +
                $", {NumOfWheels} wheels to be exact. \r\n");

            Cargo();
        }
    }
}
