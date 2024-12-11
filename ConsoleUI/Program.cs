using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            
            

           

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var carOne = new Car() 
                {
                    Year = "2022",
                    Make = "Porsche",
                    Model = "918 spyder",
                    HasTrunk = true
                };

            var motoOne = new Moto()
            {
                Year = "2018",
                Make = "Harley",
                Model = "Cruiser",
                HasSideCart = true
            };

            Vehicle carTwo = new Car()
            {
                Year = "2021",
                Make = "Ferrari",
                Model = "599xx evolution",
                HasTrunk = true
            };
            
            Vehicle carThree = new Car()
            {
                Year = "2018",
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true
            };
            
            
            var vehicles = new List<Vehicle>() {carOne, carTwo, carThree, motoOne};
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (var ride in vehicles)
            {
                Console.WriteLine($"{ride.Make} {ride.Model} {ride.Year}");
                ride.DriveAbstract();
                ride.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
