using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public double TrunkSpace {  get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"A {Year} {Make} {Model} has {TrunkSpace} inches cubed sized trunk to hold stuff!");
        }

        public Car(string year, string make, string model, double trunk, double mile) 
        {
            Year = year;
            Make = make;
            Model = model;
            TrunkSpace = trunk;
            Mileage = mile;
        }
    }
}
