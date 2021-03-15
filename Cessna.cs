using System;
using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public class Cessna : Vehicle, IGasVehicle
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
            Console.WriteLine($"The {MainColor} {nameof(Cessna)} flashes by you like a hurricane. Zzzzzzzoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {nameof(Cessna)} rolls down the runway for am ile and stops.");
        }
    }
}