using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public interface IElectricVehicle
    {
        List<string> electricVehicles { get; }
        int CurrentChargePercentage { get; }
        void ChargeBattery();
    }
}