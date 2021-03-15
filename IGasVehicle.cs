using System.Collections.Generic;

namespace CustomColorsAndSounds
{
    public interface IGasVehicle
    {
        List<string> gasVehicles { get; }
        int CurrentTankPercentage { get; }
        void RefuelTank();
    }
}