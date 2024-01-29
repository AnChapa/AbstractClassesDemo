using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public double PullWeight {  get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"A {Year} {Make} {Model} has can pull a {PullWeight} pound sidecar!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {Make} {Model} can get {Mileage} mpg with a sidecar.");
        }
        public Motorcycle(string year, string make, string model, double pull, double mile) 
        {
            Year = year;
            Make = make;
            Model = model;
            PullWeight = pull;
            Mileage = mile;
        }
    }
}
