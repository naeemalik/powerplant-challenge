using API.DTOs;

namespace API.Interfaces
{
	public interface IPowerCalculationService
	{
        IEnumerable<PerformanceOutputDto> GetProductionPlanAsync(CalcInputDto calcInputsDto);
    }
}

