using System;

namespace GaryGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} comes to a stop.");
        }
    }
}