using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car:IVehicle, ICompany
    {
        public Car()
        { 
        }

        public bool HasWheels { get; set; } = true;
        public int NumOfWheels { get; set; } = 4;
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Optima";

        public string logo { get; set; } = "Circle with \"ford\" in the middle";
        public string CompanyName { get; set; } = "Kia";

        public bool hasTrunk { get; set; } = true;

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
        public void Trunk()
        {
           if (hasTrunk)
            { 
            Console.WriteLine($"{GetType().Name} has a full size trunk...");
            }
        }
    }

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
            Console.WriteLine($"{GetType().Name} has a {bedSize} bed size...");
        }
    }

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
                Console.WriteLine($"{GetType().Name} has a cargo area...");
            }
        }
    }


}
