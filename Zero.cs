using System;
using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public class Zero : Vehicle, IElectricVehcile  // Electric motorcycle
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
            Console.WriteLine($"The {MainColor} {nameof(Zero)} zips by you. Yeeeooooowwwww!");
        }
    }
}