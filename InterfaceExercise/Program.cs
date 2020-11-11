using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each and every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            #endregion

            //Now, create objects of your 3 classes and give their members values;
            

            Car firstCar = new Car() { Year = 2012, Make = "Honda", Model = "accord", HasMotto = true, HasLogo = true, DriveAble = true };
            Truck firstTruck = new Truck() { Year = 2013, Make = "Chevrolet", Model = "1500", HasMotto = true, HasLogo = true, DriveAble = true };
            SUV firstSUV = new SUV() { Year = 2011, Make = "Toyota", Model = "Highlander", HasLogo = true, HasMotto = true, DriveAble = true };

            List<ICompany> iCompanies = new List<ICompany>();
            List<IVehicle> iVehicles = new List<IVehicle>();

            iCompanies.Add(firstTruck);
            iCompanies.Add(firstCar);
            iCompanies.Add(firstSUV);

            iVehicles.Add(firstTruck);
            iVehicles.Add(firstCar);
            iVehicles.Add(firstSUV);

            foreach (IVehicle vehicle in iVehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            }
            Console.WriteLine("======================");
            foreach (ICompany company in iCompanies)
            {
                Console.WriteLine($"{company.HasMotto} {company.HasLogo}");
            }
        }
    }
}
