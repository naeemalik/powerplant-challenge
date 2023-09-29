using API.DTOs;
using API.Extensions;
using API.Helpers;
using API.Interfaces;

namespace API.Services
{
	public class PowerCalculationService : IPowerCalculationService
	{
        public IEnumerable<PerformanceOutputDto> GetProductionPlanAsync(CalcInputDto calcInputDto)
        {
            List<PerformanceOutputDto> outputs = new();

            var calcInput = calcInputDto.FromDto();

            var preferredPowerPlants = PowerplantServiceExtensions.OrderPowerplantsByRunningCost(calcInput.Fuels, calcInput.Powerplants);

            foreach (var preferredPowerPlant in preferredPowerPlants)
            {
                if (preferredPowerPlant != null)
                {
                    if (preferredPowerPlant.PMin > calcInput.Load || preferredPowerPlant.PMax == 0)
                    {
                        outputs.Add(new PerformanceOutputDto { Name = preferredPowerPlant.Name, Power = 0 });
                    }
                    else if (calcInput.Load >= preferredPowerPlant.PMin && calcInput.Load <= preferredPowerPlant.PMax)
                    {
                        outputs.Add(new PerformanceOutputDto { Name = preferredPowerPlant.Name, Power = calcInput.Load });
                    }
                    else
                    {
                        outputs.Add(new PerformanceOutputDto { Name = preferredPowerPlant.Name, Power = preferredPowerPlant.PMax });
                    }

                    calcInput.Load -= preferredPowerPlant.PMax;
                }
            }

            return outputs;
        }
    }
}

