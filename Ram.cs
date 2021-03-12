using System;

namespace CustomColorsAndSounds
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {nameof(Ram)} growls by you. Rrrrruuuumbbllee!");
        }
    }
}