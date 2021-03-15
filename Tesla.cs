using System;
using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public List<string> electricVehicles { get; } = new List<string>();
        public int CurrentChargePercentage { get; set; }


        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {nameof(Tesla)} blazes by you. Mmmmmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {nameof(Tesla)} squeals around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {nameof(Tesla)} silently stops as if it never moved.");
        }
    }
}