using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public bool HasMotto { get; set; }
        public bool HasLogo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool DriveAble { get; set; }
        public int Year { get; set; }
        bool HasTrunk { get; set; }
        bool RoofRack { get; set; }

        public void Drive()
        {
        }

        public void Park()
        {
            
        }

        public void Reverse()
        {
            
        }
       
    }
}   
