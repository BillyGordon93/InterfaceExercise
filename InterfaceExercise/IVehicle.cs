using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        int Year { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        bool DriveAble { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
    }
}
