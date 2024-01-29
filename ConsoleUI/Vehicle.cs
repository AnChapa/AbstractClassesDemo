using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage {  get; set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {Make} {Model} can get {Mileage} mpg.");
        }
        public virtual void DisplayInfo()
        {
            DriveAbstract();
            DriveVirtual();
            Console.WriteLine("---------------------------");
        }
    }
}
