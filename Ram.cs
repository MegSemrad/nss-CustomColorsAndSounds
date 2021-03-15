using System;
using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public List<string> gasVehicles { get; } = new List<string>();
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {nameof(Ram)} growls by you. Rrrrruuuumbbllee!");
        }
    }
}