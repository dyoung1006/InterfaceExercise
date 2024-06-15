using System;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasWheels { get; set; } = true;
        public int NumOfWheels { get; set; } = 4;
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Optima";
        public string logo { get; set; } = "Reminds of the lexus logo";
        public string CompanyName { get; set; } = "Kia";
        public bool hasTrunk { get; set; } = true;

        public void Drive() => Console.WriteLine($"{GetType().Name} now in drive...");

        public void Park() => Console.WriteLine($"{GetType().Name} now in park...");
        
        public void Reverse() => Console.WriteLine($"{GetType().Name} now in reverse...");

        public void Trunk()
        {
            if (!hasTrunk)
            {
                return;
            }
            Console.WriteLine($"The {Model} has a full size trunk...");
        }

        public void DisplayDetails() 
        {
            Console.WriteLine($"The {CompanyName} has a logo of a {logo}, it boasts a engine size of {EngineSize}" +
                $".  The base model is an {Model}, it " + (HasWheels == true ? "has wheels" : "doesnt have wheels") +
                $", {NumOfWheels} wheels to be exact. \r\n");

            Trunk();
        }
    }
}
