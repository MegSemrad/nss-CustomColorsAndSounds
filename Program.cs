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
                CurrentChargePercentage = 43,
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 5.0,
                MainColor = "black",
                MaximumOccupancy = "four",
                CurrentChargePercentage = 21,
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



            List<IElectricVehcile> electricVehicles = new List<IElectricVehcile>()
            {
                fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehcile ev in electricVehicles)
            {
                Console.WriteLine($"Charge: {ev.CurrentChargePercentage}%");
            }

            foreach (IElectricVehcile ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehcile ev in electricVehicles)
            {
                Console.WriteLine($"After Charge: {ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            // Ram ram = new Ram();
            // Cessna cessna150 = new Cessna();

            // List <???> gasVehicles = new List<???> () 
            // {
            //     ram, cessna150
            // };

            // Console.WriteLine("Gas Vehicles");
            // foreach (??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach (??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach (??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        }
    }
}