using System;

namespace CustomColorsAndSounds
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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