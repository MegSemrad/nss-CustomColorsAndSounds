using System;

namespace CustomColorsAndSounds
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
            Console.WriteLine($"The {MainColor} {nameof(Cessna)} flashes by you like a hurricane. Zzzzzzzoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {nameof(Cessna)} rolls down the runway for am ile and stops.");
        }
    }
}