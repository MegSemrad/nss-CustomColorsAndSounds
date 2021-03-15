using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public interface IElectricVehcile
    {
        List<string> electricVehicles { get; }
        void CurrentChargePercentage();
    }
}