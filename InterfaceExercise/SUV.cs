using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int Year { get; set; }
        public string Make { get;set; }
        public string Model { get; set; }
        public bool DriveAble { get; set; }        
        public bool HasMotto { get; set; }
        public bool HasLogo { get; set; }

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
