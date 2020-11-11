using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany
    {
        public int Year { get; set ; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool DriveAble { get ; set ; }
        public bool HasLogo { get; set; }
        bool FourWheelDrive { get; set; }
        int NumberOfDoors { get; set; }       
      
        public bool HasMotto { get; set; }      

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
    

}
