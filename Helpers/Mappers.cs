using API.DTOs;
using API.Entities;

namespace API.Helpers
{
	public static class Mappers
	{
        public static CalcInput FromDto(this CalcInputDto src)
        {
            return src == null ? null : new CalcInput()
            {
                Load = src.Load,
                Fuels = src.Fuels.FromDto(),
                Powerplants = src.Powerplants?.FromDto(),
            };
        }

        public static Variable FromDto(this VariableDto src)
        {
            return src == null ? null : new Variable()
            {
                Name = src.Name,
                Type = src.Type,
                Efficiency = src.Efficiency,
                PMax = src.PMax,
                PMin = src.PMin,
            };
        }

        public static List<Variable> FromDto(this List<VariableDto> src)
        {
            return src == null ? null : new List<Variable>(src?.Select(f => f.FromDto()));
        }

        public static ExternalFactor FromDto(this ExternalFactorDto src)
        {
            return src == null ? null : new ExternalFactor()
            {
                Gas = src.Gas,
                Kerosine = src.Kerosine,
                Co2 = src.Co2,
                Wind = src.Wind,
            };
        }
    }
}

