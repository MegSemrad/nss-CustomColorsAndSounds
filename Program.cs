using System;
using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 4.5,
                MainColor = "grey",
                MaximumOccupancy = "two",
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 5.0,
                MainColor = "black",
                MaximumOccupancy = "four",
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 22.5,
                MainColor = "dark blue",
                MaximumOccupancy = "six",
            };
            Ram trx1500 = new Ram()
            {
                FuelCapacity = 22.5,
                MainColor = "white",
                MaximumOccupancy = "four",
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            trx1500.Drive();
        }
    }
}