﻿using System;

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
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine("-------------------------");
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine("-------------------------");
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine("-------------------------");
            trx1500.Drive();
            trx1500.Turn("right");
            trx1500.Stop();



            /***********************************************/



            List <???> electricVehicles = new List<???> () {
                fxs, modelS, mx410, trx1500
                          };

            Console.WriteLine("Electric Vehicles");
            foreach (??? ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (??? ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (??? ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List <???> gasVehicles = new List<???> () {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (??? gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}