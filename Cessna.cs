using System;

namespace GaryGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zooooooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} rolls to a stop after rolling a mile down the runway.");
        }


    }
}