using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {            
        public bool HasWheels { get; set; }
        public int NumOfWheels { get; set; }
        public double EngineSize { get; set; } 
        public string Model { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
    }
}
