using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    ///  productionplan endpoint that provides all calculations.
    /// </summary>
    public class PowerCalculationController : BaseApiController
    {
		private readonly IPowerCalculationService _powerCalculationService;

        public PowerCalculationController(IPowerCalculationService powerCalculationService)
		{
			_powerCalculationService = powerCalculationService;
		}

        /// <summary>
        /// Calculates the power for the provided calculation inputs.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="calcInputDto">Inputs to be used for power calculation.</param>
        /// <returns></returns>
        [HttpPost("productionplan")]
        public ActionResult<IEnumerable<PerformanceOutputDto>> GetProductionPlanAsync(CalcInputDto calcInputDto)
        {
            if (calcInputDto.Fuels == null || calcInputDto.Powerplants == null)
            {
                return BadRequest("Invalid request data.");
            }

            var outputs = _powerCalculationService.GetProductionPlanAsync(calcInputDto);

            return Ok(outputs);
        }
    }
}