using API.Entities;
using API.Helpers;

namespace API.Extensions
{
	public static class PowerplantServiceExtensions
	{
        public static IEnumerable<Variable> OrderPowerplantsByRunningCost(ExternalFactor fuels, List<Variable> powerplants)
        {
            var orderedPowerplants = new List<Variable>();

            foreach (var powerplant in powerplants)
            {
                switch (powerplant.Type)
                {
                    case PowerplantType.gasfired:
                        powerplant.RunningCost = fuels.Gas / powerplant.Efficiency;
                        break;
                    case PowerplantType.turbojet:
                        powerplant.RunningCost = fuels.Kerosine / powerplant.Efficiency;
                        break;
                    case PowerplantType.windturbine:
                        powerplant.RunningCost = 0.0M;
                        break;
                    default:
                        break;
                }

                powerplant.PMax = powerplant.Type == PowerplantType.windturbine ? powerplant.PMax / 100.0M * fuels.Wind : powerplant.PMax;

                orderedPowerplants.Add(powerplant);
            }

            return orderedPowerplants.OrderBy(c => c.RunningCost);
        }
    }
}